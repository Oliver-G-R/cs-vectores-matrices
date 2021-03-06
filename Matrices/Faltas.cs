using System;
namespace Matrices4
{
    class Faltas
    {
        private string[][] semana;
        private string[] nombre, faltaD;
        private int cantidadR = 0, cantidadDías = 0;

        public void Registrar()
        {
            Console.Clear();
            Console.Write("Cantidad de empleados a registrar: ");
            cantidadR = int.Parse(Console.ReadLine());

            nombre = new string[cantidadR];
            semana = new string[cantidadR][];

            for (int i = 0; i < cantidadR; i++)
            {
                Console.Write($"\nNombre del empelado ({i + 1}): ");
                nombre[i] = Console.ReadLine();

                Console.Write("\nCantidad de días que falto: ");
                cantidadDías = int.Parse(Console.ReadLine());
                semana[i] = new string[cantidadDías];

                for (int x = 0; x < semana[i].Length; x++)
                {
                    Console.Write("Día que falto: ");
                    semana[i][x] = Console.ReadLine().ToLower().Trim();
                }
            }
        }

        public void personasConFaltaEspe()
        {
            faltaD = new string[nombre.Length];
            for (int i = 0; i < nombre.Length; i++)
            {
                for (int k = 0; k < semana[i].Length; k++)
                {
                    if (semana[i][k] == "jueves" || semana[i][k] == "viernes")
                    {
                        faltaD[i] = nombre[i];
                    }

                }
            }

            Console.WriteLine("\nNombres de personas que faltaron el jueves o viernes");

            foreach (string item in faltaD)
                Console.WriteLine(item);

        }

    }
}