using System;
namespace Vectores3
{
    class FinDeSemana
    {
        private string[] semana = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };

        public int recorrerSemana()
        {
            int f = 0;
            foreach (string item in semana)
            {
                if (item == "Sabado" || item == "Domingo") f++;

            }

            return f;
        }

        public void verificaFinSemana()
        {
            if (this.recorrerSemana() > 0)
            {
                Console.WriteLine("Si hay fin de semana");
            }
            else
            {
                Console.WriteLine("No hay fin de semana");

            }
        }

    }
}