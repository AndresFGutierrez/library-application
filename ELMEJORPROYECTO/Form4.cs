using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ELMEJORPROYECTO
{
    public partial class Form4 : Form
    {
        save guar = new save();

        public Form4()
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
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != "" && textBox2.Text != "")
            {
                string nombreABuscar = textBox4.Text; // Obtener el nombre del cuadro de texto
                string contraseñaABuscar = textBox2.Text; // Obtener el nombre del cuadro de texto
                string resultado = guar.Leer_un_usuario(nombreABuscar, contraseñaABuscar); // Llamar al método Leeruno con el nombre a buscar
                if (resultado != null)
                {
                    MessageBox.Show("El usuario ya esta registrado");
                    Form1 f1 = new Form1();
                    f1.Show();
                    this.Hide(); //oculta el form
                }
                else
                {
                    MessageBox.Show("Usuario registrado exitosamente");
                    guar.Registrar_usuario(textBox4.Text + " " + textBox2.Text);

                    Form1 f1 = new Form1();
                    f1.Show();
                    this.Hide(); //oculta el form
                }
            }
            else
            {
                MessageBox.Show("Rellene el campo");
            }
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
