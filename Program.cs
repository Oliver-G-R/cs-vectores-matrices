using System;
using Vectores1;
using Vectores2;

using Matrices1;
using Matrices2;
using Matrices3;

namespace Vectores_y_matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vectores
            RegistroAlumnos registroAlumnos = new RegistroAlumnos();
            BonoEmpleado bonoEmpleado = new BonoEmpleado();

            //Matrices
            MayorSueldo mayorSueldo = new MayorSueldo();
            GuardarVideos guardarVideos = new GuardarVideos();
            Tienda tienda = new Tienda();

            tienda.agregarProductos();
            tienda.mostrarCompras();

            Console.ReadKey();

        }
    }
}
