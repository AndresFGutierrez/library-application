using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

//2.Creación de estructura para almacenar la información de los libros de una biblioteca,
//prestamos, entregas, recargos de entregas y multas para los usuarios. Un usuario multado
//no podrá volver a prestar libros.
// Libros Iniciales
// Usuarios Iniciales
// Agregar Usuarios y Libros
// Prestar solo si hay disponibles
// Multar si se pasa de los días especificados para préstamo.

namespace ELMEJORPROYECTO
{
    public partial class Form1 : Form
    {
        save guar = new save();

        public Form1()
        {
            InitializeComponent();
            string rutaArchivo = @"C:\andres_roland\users.txt";

            if (!Directory.Exists(@"C:\andres_roland"))
            {
                Directory.CreateDirectory(@"C:\andres_roland");
            }

            string contenidoArchivo = System.IO.File.ReadAllText(@"C:\andres_roland\users.txt");

            if (string.IsNullOrEmpty(contenidoArchivo))
            {
                // El archivo está vacío o no existe, se limpia
                System.IO.File.WriteAllText(rutaArchivo, string.Empty);
            }

            System.IO.File.WriteAllText(@"C:\andres_roland\usuario.txt", string.Empty);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btinicio_Click(object sender, EventArgs e)
        {
            if (txinicio.Text != "" && txregis.Text != "")
            {
                string nombreABuscar = txinicio.Text; // Obtener el nombre del cuadro de texto
                string contraseñaABuscar = txregis.Text; // Obtener el nombre del cuadro de texto
                string resultado = guar.Leer_un_usuario(nombreABuscar, contraseñaABuscar); // Llamar al método Leeruno con el nombre a buscar
                if (resultado != null)
                {
                    guar.usuario(txinicio.Text);
                    Form2 f2 = new Form2();
                    f2.Show();
                    this.Hide(); //oculta el form
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña incorrecta");
                }
            }
            else
            {
                MessageBox.Show("Rellena el campo");
            }
        }

        private void btregis_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
            this.Hide(); //oculta el form
        }

    }
}
