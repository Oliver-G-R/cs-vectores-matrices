using System;
namespace Matrices1
{
    class MayorSueldo
    {
        private int cantidadDeMeses = 0, cantidadEmpleados = 0;
        private int[,] salarioPorMes;
        private string[,] mesPagado;
        private string[] nombre;
        private int[] sueldoTotal;

        public void cargarEmpleados()
        {
            Console.Clear();
            Console.Write("Cantidad de empleados: ");
            cantidadEmpleados = int.Parse(Console.ReadLine());

            Console.Write("Cantidad de Meses a evaular: ");
            cantidadDeMeses = int.Parse(Console.ReadLine());

            nombre = new string[cantidadEmpleados];
            salarioPorMes = new int[cantidadEmpleados, cantidadDeMeses];
            mesPagado = new string[cantidadEmpleados, cantidadDeMeses];

            for (int i = 0; i < cantidadEmpleados; i++)
            {
                Console.Write($"\nNombre del operario ({i + 1}): ");
                nombre[i] = Console.ReadLine();

                for (int j = 0; j < salarioPorMes.GetLength(1); j++)
                {
                    Console.Write("Mes pagado: ");
                    mesPagado[i, j] = Console.ReadLine();

                    Console.Write("Cantidad pagada: ");
                    salarioPorMes[i, j] = int.Parse(Console.ReadLine());
                }
            }

        }

        public void CalculaSalario()
        {
            sueldoTotal = new int[cantidadEmpleados];
            for (int f = 0; f < salarioPorMes.GetLength(0); f++)
            {
                int sum = 0;
                for (int c = 0; c < salarioPorMes.GetLength(1); c++)
                {
                    sum += salarioPorMes[f, c];
                }
                sueldoTotal[f] = sum;
            }
        }

        public void totalPagado()
        {
            for (int q = 0; q < sueldoTotal.Length; q++)
            {

                Console.Write($"\nNombre del empleado: {nombre[q]}");
                Console.Write($"\nSalario total por cada {cantidadDeMeses} meses: {sueldoTotal[q]}");
                Console.Write($"\nMeses cubiertos");
                for (int c = 0; c < mesPagado.GetLength(1); c++)
                {
                    Console.WriteLine($"\n{q + 1}.- {mesPagado[q, c]}");

                }
            }
        }

    }
}