using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Ferreteria
{
    public class Controlador
    {
        public void Testear()
        {
            Alumnos alumnoTrucho = new Alumnos(); //<--- CANCER!! mal no va aca

            var newAlumno = Factoria.CrearAlumno();
            var newAlumno2 = Factoria.CrearAlumno();
            var newAlumno3 = Factoria.CrearAlumno();

            var autor1 = Factoria.CrearAutor();


            var libro1 = Factoria.CrearLibro();
            var libro2 = Factoria.CrearLibro(autor1);

            newAlumno.DecirSuNombre();

        }
    }
    public class Autor
    {
        public int ID { get; set; }
        public int nombre { get; set; }
    }
    public class Alumnos
    {
        public string Nombre { get; set; }

        internal void DecirSuNombre()
        {
            Console.WriteLine("Hola soy juan perez");
        }
    }
    public class Libro
    {
        public Libro(Autor a)
        {
            Autor = a;
        }

        public string Nombre { get; set; }
        public Autor Autor { get; set; }
    }

    /// <summary>
    /// EL CREA TODAS LAS CLASES DEL SISTEMA NADIE MAS!
    /// </summary>
    public class Factoria
    {
        public static Alumnos CrearAlumno()
        {
            return new Alumnos();
        }
        public static Autor CrearAutor()
        {
            return new Autor();
        }
        /// <summary>
        /// Crea Libro
        /// </summary>
        /// <param name="a">Autor como parametro OPCIONAL</param>
        /// <returns></returns>
        public static Libro CrearLibro(Autor a = null)
        {
            if (a != null)
            {
                return new Libro(a);
            }
            return new Libro(CrearAutor());

        }

    }
}
