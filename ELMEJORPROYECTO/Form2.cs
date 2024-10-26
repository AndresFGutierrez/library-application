using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELMEJORPROYECTO
{
    public partial class Form2 : Form
    {
        string n_usuario;
        save guar = new save();
        public Form2()
        {
            InitializeComponent();

            n_usuario = guar.Leerusuario();

            string rutaArchivo = @"C:\andres_roland\G51.txt";

            if (!Directory.Exists(@"C:\andres_roland"))
            {
                Directory.CreateDirectory(@"C:\andres_roland");

            }

            string contenidoArchivo = System.IO.File.ReadAllText(@"C:\andres_roland\G51.txt");

            if (string.IsNullOrEmpty(contenidoArchivo))
            {
                // El archivo está vacío o no existe, se limpia
                System.IO.File.WriteAllText(rutaArchivo, string.Empty);
                MessageBox.Show("ESTA VACIO");
            }

            List<string> nombres = guar.Leer(); // obtener la lista de nombres desde el archivo

            // Ordenar la lista alfabéticamente por el primer nombre
            nombres = nombres.OrderBy(nombre => nombre.Split('\t')[0].Trim()).ToList();

            // Imprimir los nombres ordenados
            foreach (string nombreLinea in nombres)
            {
                lista.Text += nombreLinea + Environment.NewLine; // Imprimir en una línea diferente cada uno
            }

            string resultado = guar.Leer_listadeudores(n_usuario);
            if(resultado != null)
            {
                label10.Visible = true;
                button5.Visible = true;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {

            MessageBox.Show($"La fecha seleccionada es:" + monthCalendar1.SelectionEnd);
        }

        private void monthCalendar2_DateSelected(object sender, DateRangeEventArgs e)
        {
            MessageBox.Show($"La fecha seleccionada es:" + monthCalendar2.SelectionEnd);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide(); //oculta el form
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
            this.Hide(); //oculta el form
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string resultado = guar.Leer_listadeudores(n_usuario);
            string resultadito = guar.Leer_listaprestados(n_usuario);

            if(resultadito == null)
            { 
                if (resultado == null)
                {
                    if (textBox1.Text != "" && textBox3.Text != "")
                    {
                        string nombrelibro = textBox1.Text; // Obtener el nombre del cuadro de texto
                        string nombreautor = textBox3.Text; // Obtener el nombre del cuadro de texto
                        string resultad = guar.Leerunlibro(nombrelibro, nombreautor); // Llamar al método Leeruno con el nombre a buscar
                        textBox1.Text = "";
                        textBox3.Text = "";
                        if (resultad != null)
                        {
                            DateTime fechaInicio = monthCalendar1.SelectionEnd;
                            DateTime fechaFin = monthCalendar2.SelectionEnd;

                            // Verificar que la fecha de fin sea mayor o igual a la fecha de inicio
                            if (fechaFin >= fechaInicio)
                            {
                                MessageBox.Show("Prestamo Exitoso");
                                guar.Eliminar_un_libro(nombrelibro, nombreautor);
                                // devuelve una cadena que representa la fecha en un formato corto y legible para los usuarios, sin incluir la información detallada de la hora
                                guar.libro_prestado(n_usuario + "-" + nombrelibro + "-" + nombreautor + "-" + fechaInicio.ToShortDateString() + "-" + fechaFin.ToShortDateString());
                            }
                            else
                            {
                                MessageBox.Show("La fecha de devolucion debe ser mayor o igual a la fecha de prestamo");
                            }
                        }
                        else
                        {
                            MessageBox.Show("No se encuentra disponible el libro");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Rellena el campo");
                    }
                }
                else
                {
                    MessageBox.Show("Usted no puede hacer prestamo de libros\nTiene una deuda");
                    if (resultado != null)
                    {
                        label10.Visible = true;
                        button5.Visible = true;
                    }
                }
            }
            else
            {
                MessageBox.Show("Usted no puede prestar dos libros");
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "" && textBox4.Text != "")
            {
                string nombrelibro = textBox2.Text; // Obtener el nombre del cuadro de texto
                string nombreautor = textBox4.Text; // Obtener el nombre del cuadro de texto
                string fecha_entrega = monthCalendar4.SelectionEnd.ToString("dd/MM/yyyy");
                DateTime fecha_entregaa = DateTime.ParseExact(fecha_entrega, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                string resultado = guar.entregalibro(n_usuario, nombrelibro, nombreautor); // Llamar al método Leeruno con el nombre a buscar
                textBox2.Text = "";
                textBox4.Text = "";
                if (resultado != null)
                {
                    DateTime fecha_estimada = DateTime.ParseExact(guar.ObtenerFechaEstimada(n_usuario), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                    MessageBox.Show(Convert.ToString(fecha_estimada));

                    if (fecha_entregaa > fecha_estimada)
                    {
                        // obtener la cantidad de días de retraso utilizando la resta de fechas.
                        TimeSpan retraso = fecha_entregaa - fecha_estimada;
                        int diasDeRetraso = retraso.Days;
                        MessageBox.Show(Convert.ToString( diasDeRetraso));

                        int recargo = diasDeRetraso * 20000;
                        MessageBox.Show("Se retraso en la entrega del libro\nTiene una deuda de "+ recargo);
                        guar.listadeudores(n_usuario + " " + recargo);
                        guar.Eliminar_prestamo(n_usuario, nombrelibro, nombreautor);
                        guar.agregar_libro(nombrelibro + " " + nombreautor);
                    }
                    else
                    {
                        MessageBox.Show("Entrega exitosa");
                        guar.Eliminar_prestamo(n_usuario, nombrelibro, nombreautor);
                        guar.agregar_libro(nombrelibro + " " + nombreautor);
                    }

                }
                else
                {
                    MessageBox.Show("No se encuentra la informacion");
                }
            }
            else
            {
                MessageBox.Show("Rellena el campo");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            guar.Eliminar_deudor(n_usuario);
            MessageBox.Show("Deuda Resuelta\nYa puedes prestar libros");
            label10.Visible = false;
            button5.Visible = false;
        }

        private void monthCalendar4_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateTime fecha_estimad = DateTime.ParseExact(guar.ObtenerFechaEstimada(n_usuario), "dd/MM/yyyy", CultureInfo.InvariantCulture);

            if (monthCalendar4.SelectionEnd < fecha_estimad)
            {
                // Si la fecha seleccionada es menor que la fecha estimada, restablecer la fecha a la fecha estimada
                monthCalendar4.SelectionEnd = fecha_estimad;
            }
        }
    }
}