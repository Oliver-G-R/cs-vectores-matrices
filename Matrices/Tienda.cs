using System;

namespace Matrices3
{
    class Tienda
    {
        private int cantidadProductos = 0, cantidadClientes = 0;
        private string[][] nombreProducto;
        private int[][] costo;

        private int[] total;

        public void agregarProductos()
        {
            Console.Write("Cantidad de clientes: ");
            cantidadClientes = int.Parse(Console.ReadLine());

            nombreProducto = new string[cantidadClientes][];
            costo = new int[cantidadClientes][];
            total = new int[cantidadClientes];


            for (int i = 0; i < cantidadClientes; i++)
            {
                Console.Write($"Cantidad de prodcutos del cliente ({i + 1}): ");
                cantidadProductos = int.Parse(Console.ReadLine());

                nombreProducto[i] = new string[cantidadProductos];
                costo[i] = new int[cantidadProductos];

                for (int f = 0; f < nombreProducto[i].Length; f++)
                {
                    Console.Write("Nombre del producto: ");
                    nombreProducto[i][f] = Console.ReadLine();

                    Console.Write("Precio: ");
                    costo[i][f] = int.Parse(Console.ReadLine());
                    total[i] += costo[i][f];
                }
            }
        }

        public void mostrarCompras()
        {
            for (int i = 0; i < cantidadClientes; i++)
            {
                Console.WriteLine($"\nCompra del cliente ({i + 1})");

                Console.WriteLine("---- Su compra ----");
                for (int f = 0; f < nombreProducto[i].Length; f++)
                {
                    Console.Write("\nNombre del prodcuto: " + nombreProducto[i][f]);
                    Console.Write("\nPrecio: " + costo[i][f]);
                }
                Console.WriteLine("\nTotal: " + total[i]);
            }
        }

    }
}
