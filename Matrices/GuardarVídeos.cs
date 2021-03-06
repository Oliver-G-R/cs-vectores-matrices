using System;

namespace Matrices2
{
    class GuardarVideos
    {
        private string[] tituloUrl;
        private string[][] url; //Matriz irregular
        private string[] autor;
        private int cantidadDeUrl = 0, cantidadAutor = 0;

        public void agregarVideo()
        {
            Console.Clear();

            Console.Write("\nCantidad de autores a registrar: ");
            cantidadAutor = int.Parse(Console.ReadLine());

            //Se especifica la cantidad de filas. dejando la cantidad de columnas incompleta
            url = new string[cantidadAutor][];

            autor = new string[cantidadAutor];
            tituloUrl = new string[cantidadAutor];

            for (int j = 0; j < autor.Length; j++)
            {
                Console.Write($"\nCantidad de enlaces a agregar para el autor autor ({j + 1}): ");
                cantidadDeUrl = int.Parse(Console.ReadLine());

                /* 
                    url[j] establce la posición de la fila, new string[cantidadDeUrl] 
                    establcec la cantidad de elementos por fila
                */
                url[j] = new string[cantidadDeUrl];

                Console.Write($"Agregar un título para guardar este video: ");
                tituloUrl[j] = Console.ReadLine();

                Console.Write("Agrega el autor de este vídeo: ");
                autor[j] = Console.ReadLine();

                /* 
                    Para poder agregar elementos se tiene que tener en cuenta la posición
                    de la fila url[j], y sacar su cantidad de espacios url[j].Length, para poder 
                    recorrerlos y llenarlos con la información correspondiente.

                    Se crea un segundo for para agregar esos datos a cada espacio de la fila.
                    for (int k = 0; k < url[j].Length; k++)
                 */
                for (int k = 0; k < url[j].Length; k++)
                {
                    Console.Write("Url: ");

                    /*
                        Al llenarla se toman en cuenta la posición [j] de su fila
                        y su posicón [k] de los esapcios a llenar => url[j][k]
                     */
                    url[j][k] = Console.ReadLine();

                }
            }

        }

        public void mostrarVídeosGuardardos()
        {
            for (int j = 0; j < autor.Length; j++)
            {
                Console.Write($"\n----Tus vídeos son los sigueintes---- ({j + 1})");
                Console.Write("\nTítulo: " + tituloUrl[j]);

                Console.Write("\nAutor: " + autor[j]);

                /* Para mostrar se ocupa otro bucle para poder recorrer estos espacios
                únicos de cada fila, así co,o se hizo para llenarlos */

                for (int k = 0; k < url[j].Length; k++)
                {
                    Console.Write("\nUrl: " + url[j][k]);

                }
            }
        }
    }
}
