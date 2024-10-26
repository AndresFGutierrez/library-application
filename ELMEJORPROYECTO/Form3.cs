using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ELMEJORPROYECTO
{
    public partial class Form3 : Form
    {
        string n_usuario;

        save guar = new save();

        public Form3()
        {
            InitializeComponent();
            n_usuario = guar.Leerusuario();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide(); //oculta el form
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.Show();
            this.Hide(); //oculta el form
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox4.Text != "" && textBox2.Text != "")
            {
                string nombreABuscar = textBox4.Text; // Obtener el nombre del cuadro de texto
                string nombreAutor = textBox2.Text;
                string resultado = guar.Leerunlibro(nombreABuscar, nombreAutor); // Llamar al método Leeruno con el nombre a buscar
                textBox4.Text = "";
                textBox2.Text = "";
                if (resultado != null)
                {
                    Form2 f2 = new Form2();
                    MessageBox.Show("El libro esta disponible\nSe redigira a formulario de prestamo");
                    f2.Show();
                    this.Hide(); //oculta el form
                }
                else
                {
                    MessageBox.Show("El libro no esta disponible");
                }
            }
            else
            {
                MessageBox.Show("Rellena el campo");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox3.Text != "")
            {
                guar.agregar_libro(textBox1.Text + " " + textBox3.Text);
                textBox1.Text = "";
                textBox3.Text = "";
                MessageBox.Show("Libro agregado exitosamente");
            }
            else
            {
                MessageBox.Show("Rellene el campo");
            }
        }
    }
}
