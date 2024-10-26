using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ELMEJORPROYECTO
{
    internal class save
    {
        public string usuario(string Dato)
        {
            StreamWriter W1 = new StreamWriter(@"C:\andres_roland\usuario.txt", true);
            W1.WriteLine(Dato);
            W1.Close();
            return Dato;
        }

        public string Leerusuario()
        {
            string nombreusuario;

            using (StreamReader reader = new StreamReader(@"C:\andres_roland\usuario.txt"))
            {
                string linea;
                while ((linea = reader.ReadLine()) != null)
                {
                    nombreusuario = linea.Trim();
                    return nombreusuario;
                }
            }
            return null;
        }

        public void Escribir(string Dato)
        {
            StreamWriter W1 = new StreamWriter(@"C:\andres_roland\G51.txt", true);
            W1.WriteLine(Dato);
            W1.Close();
        }
        public List<string> Leer()
        {
            List<string> nombres = new List<string>(); //Almacenara la linea con los nombres
            StreamReader R1 = new StreamReader(@"C:\andres_roland\G51.txt");

            string linea; //para leer cada linea
            while ((linea = R1.ReadLine()) != null) //para leer hasta la ultima linea
            {
                nombres.Add(linea); //agrega cada linea a la lista de nombres
            }

            R1.Close();
            return nombres;
        }
        public string Leerunlibro(string nomblibro, string nombautor)
        {
            using (StreamReader reader = new StreamReader(@"C:\andres_roland\G51.txt"))
            {
                string linea;
                while ((linea = reader.ReadLine()) != null)
                {
                    if(linea.Contains(nomblibro) && linea.Contains(nombautor))
                    {
                        return linea;
                    }
                }
            }
            return null; // Si no se encuentra ninguna coincidencia, devolver null
        }

        public void Registrar_usuario(string Dato)
        {
            StreamWriter W1 = new StreamWriter(@"C:\andres_roland\users.txt", true);
            W1.WriteLine(Dato);
            W1.Close();
        }

        public void libro_prestado(string Dato)
        {
            StreamWriter W1 = new StreamWriter(@"C:\andres_roland\listaprestados.txt", true);
            W1.WriteLine(Dato);
            W1.Close();
        }

        public void agregar_libro(string Dato)
        {
            StreamWriter W1 = new StreamWriter(@"C:\andres_roland\G51.txt", true);
            W1.WriteLine(Dato);
            W1.Close();
        }

        public void listadeudores(string Dato)
        {
            StreamWriter W1 = new StreamWriter(@"C:\andres_roland\deudores.txt", true);
            W1.WriteLine(Dato);
            W1.Close();
        }

        public string Leer_listadeudores(string usuario)
        {
            using (StreamReader reader = new StreamReader(@"C:\andres_roland\deudores.txt"))
            {
                string linea;
                while ((linea = reader.ReadLine()) != null)
                {
                    if (linea.Contains(usuario))
                    {
                        return linea;
                    }
                }
            }
            return null; // Si no se encuentra ninguna coincidencia, devolver null
        }

        public string Leer_un_usuario(string usuario, string contraseña)
        {
            using (StreamReader reader = new StreamReader(@"C:\andres_roland\users.txt"))
            {
                string linea;
                while ((linea = reader.ReadLine()) != null)
                {
                    if (linea.Contains(usuario) && linea.Contains(contraseña))
                    {
                        return linea;
                    }
                }
            }
            return null; // Si no se encuentra ninguna coincidencia, devolver null
        }

        public void Eliminar_un_libro(string nombrelibro, string nombreautor)
        {
            string rutaArchivo = @"C:\andres_roland\G51.txt";
            string[] lineas = File.ReadAllLines(rutaArchivo);

            for (int i = 0; i < lineas.Length; i++)
            {
                if (lineas[i].Contains(nombrelibro) && lineas[i].Contains(nombreautor))
                {
                    // Eliminar la línea correspondiente
                    lineas[i] = "";
                    break; // Salir del bucle una vez que se ha encontrado la coincidencia
                }
            }
            

            // Escribir las líneas actualizadas de vuelta al archivo
            File.WriteAllLines(rutaArchivo, lineas);
        }

        public string entregalibro(string usuario, string nomblibro, string nombautor)
        {
            using (StreamReader reader = new StreamReader(@"C:\andres_roland\listaprestados.txt"))
            {
                string linea;
                while ((linea = reader.ReadLine()) != null)
                {
                    if (linea.Contains(usuario) && linea.Contains(nomblibro) && linea.Contains(nombautor))
                    {
                        return linea;
                    }
                }
            }
            return null; // Si no se encuentra ninguna coincidencia, devolver null
        }

        public string ObtenerFechaEstimada(string nombre_u)
        {
            string fechaEstimada = null;

            using (StreamReader reader = new StreamReader(@"C:\andres_roland\listaprestados.txt"))
            {
                string linea;
                while ((linea = reader.ReadLine()) != null)
                {
                    // Eliminar espacios adicionales y dividir por guiones
                    string[] elementos = linea.Trim().Split('-');

                    // Verificar si el usuario está en la línea
                    if (linea.Contains(nombre_u))
                    {
                        // Asegurarse de que hay al menos 5 elementos
                        if (elementos.Length >= 5)
                        {
                            fechaEstimada = elementos[4].Trim(); // Obtener el último elemento después de dividir por '-'
                            break; // Salir del bucle si se encuentra la información
                        }
                    }
                }
            }

            return fechaEstimada;
        }

        public void Eliminar_prestamo(string nombre, string nombrelibro, string nombreautor)
        {
            string rutaArchivo = @"C:\andres_roland\listaprestados.txt";
            string[] lineas = File.ReadAllLines(rutaArchivo);

            for (int i = 0; i < lineas.Length; i++)
            {
                if (lineas[i].Contains(nombre) && lineas[i].Contains(nombrelibro) && lineas[i].Contains(nombreautor))
                {
                    // Eliminar la línea correspondiente
                    lineas[i] = "";
                    break; // Salir del bucle una vez que se ha encontrado la coincidencia
                }
            }


            // Escribir las líneas actualizadas de vuelta al archivo
            File.WriteAllLines(rutaArchivo, lineas);
        }

        public string Leer_listaprestados(string usuario)
        {
            using (StreamReader reader = new StreamReader(@"C:\andres_roland\listaprestados.txt"))
            {
                string linea;
                while ((linea = reader.ReadLine()) != null)
                {
                    if (linea.Contains(usuario))
                    {
                        return linea;
                    }
                }
            }
            return null; // Si no se encuentra ninguna coincidencia, devolver null
        }

        public void Eliminar_deudor(string nombre)
        {
            string rutaArchivo = @"C:\andres_roland\deudores.txt";
            string[] lineas = File.ReadAllLines(rutaArchivo);

            for (int i = 0; i < lineas.Length; i++)
            {
                if (lineas[i].Contains(nombre))
                {
                    // Eliminar la línea correspondiente
                    lineas[i] = "";
                    break; // Salir del bucle una vez que se ha encontrado la coincidencia
                }
            }
            // Escribir las líneas actualizadas de vuelta al archivo
            File.WriteAllLines(rutaArchivo, lineas);
        }
    }
}
