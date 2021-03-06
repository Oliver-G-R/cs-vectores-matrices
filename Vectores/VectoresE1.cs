using System;

namespace Vectores1
{
    class RegistroAlumnos
    {
        private int cantidadRegistro = 0;
        private string[] nombre, apellido;
        private string[] correo;
        public void Registro()
        {
            Console.Clear();

            Console.Write("\nIngresa la cantidad de personas a registrar: ");
            cantidadRegistro = int.Parse(Console.ReadLine());

            nombre = new string[cantidadRegistro];
            apellido = new string[cantidadRegistro];
            correo = new string[cantidadRegistro];

            for (var i = 0; i < nombre.Length; i++)
            {
                Console.Write("\n Nombre: ");
                nombre[i] = Console.ReadLine();

                Console.Write("\n Apellido: ");
                apellido[i] = Console.ReadLine();

                Console.Write("\n Correo: ");
                correo[i] = Console.ReadLine();

                Console.WriteLine("\n----");
            }
        }

        public void mostrarRegistro()
        {
            Console.WriteLine("------- El registro se a guardado correctamente -------");
            for (var i = 0; i < nombre.Length; i++)
            {
                Console.WriteLine($"\n Registro No. ({i + 1})");

                Console.Write("\n Nombre: " + nombre[i]);

                Console.Write("\n Apellido: " + apellido[i]);

                Console.Write("\n Correo: " + correo[i]);

                Console.WriteLine("\n----");

            }
        }
    }
}
