using System;

using Vectores1;
using Vectores2;
using Vectores3;

using Matrices1;
using Matrices2;
using Matrices3;
using Matrices4;


namespace Vectores_y_matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vectores
            RegistroAlumnos registroAlumnos = new RegistroAlumnos();
            BonoEmpleado bonoEmpleado = new BonoEmpleado();
            FinDeSemana finDeSemana = new FinDeSemana();

            //Matrices
            MayorSueldo mayorSueldo = new MayorSueldo();
            GuardarVideos guardarVideos = new GuardarVideos();
            Tienda tienda = new Tienda();
            Faltas faltas = new Faltas();

            Console.ReadKey();

        }
    }
}
