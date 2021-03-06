using System;
namespace Vectores2
{
    class BonoEmpleado
    {
        private int cantidadARegistrar = 0;
        private string[] nombreEmpleado;
        private int[] tiempoTrabajando;
        public void registroEmpleado()
        {
            Console.Clear();

            Console.Write("Cantidad de empleados: ");
            cantidadARegistrar = int.Parse(Console.ReadLine());

            nombreEmpleado = new string[cantidadARegistrar];
            tiempoTrabajando = new int[cantidadARegistrar];

            for (int i = 0; i < nombreEmpleado.Length; i++)
            {
                Console.WriteLine("Nombre del empleado: ");
                nombreEmpleado[i] = Console.ReadLine();

                Console.WriteLine("Cantidad de años trabajando: ");
                tiempoTrabajando[i] = int.Parse(Console.ReadLine());

            }
        }
        public void calcularBono()
        {
            int cantidadTM = tiempoTrabajando[0];
            string nombre = nombreEmpleado[0];


            for (int i = 0; i < tiempoTrabajando.Length; i++)
            {
                if (tiempoTrabajando[i] >= 5)
                {
                    cantidadTM = tiempoTrabajando[i];
                    nombre = nombreEmpleado[i];
                }

            }

            Console.WriteLine("El empleado con acceso al bono es: " + nombre + "\n Por sus años trabajando de: " + cantidadTM);
        }
    }
}
