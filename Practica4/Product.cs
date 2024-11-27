using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practica4;

namespace Practica4
{
    internal class Product
    {
        private string[,] productos = new string[0, 3];
        private int cantidadProductos = 0;
        public void Redimensionar(int nuevoTamano)
        {
            string[,] nuevoArreglo = new string[nuevoTamano, 3];
            for (int i = 0; i < cantidadProductos; i++)
            {
                for (int j = 0; j < productos.GetLength(1); j++)
                {
                    nuevoArreglo[i, j] = productos[i, j];
                }
            }
            productos = nuevoArreglo;
        }
        public void Registrar()
        {
            Redimensionar(cantidadProductos + 1);
            Console.Write("\nIngrese el nombre del producto: ");
            productos[cantidadProductos, 0] = Console.ReadLine();
            Console.Write("Ingrese el precio del producto: ");
            productos[cantidadProductos, 1] = Console.ReadLine();
            Console.Write("Ingrese el stock del producto: ");
            productos[cantidadProductos, 2] = Console.ReadLine();
            cantidadProductos++;
            Console.WriteLine("\nProducto registrado exitosamente.");
        }
        public void Mostrar()
        {
            if (cantidadProductos == 0)
            {
                Console.WriteLine("\nNo hay productos registrados.");
                return;
            }
            Console.WriteLine("\nProductos registrados:\n");
            for (int i = 0; i < cantidadProductos; i++)
            {
                Console.WriteLine($"Producto {i + 1}:");
                Console.WriteLine($"Nombre: {productos[i, 0]}");
                Console.WriteLine($"Precio: {productos[i, 1]}");
                Console.WriteLine($"Stock: {productos[i, 2]}");
                Console.WriteLine();
            }
        }
        public void Modificar()
        {
            Mostrar();
            Console.Write("\nIngrese el número del producto a modificar: ");
            int indice = int.Parse(Console.ReadLine()) - 1;
            if (indice < 0 || indice >= cantidadProductos)
            {
                Console.WriteLine("\nNúmero de producto no válido.");
                return;
            }
            Console.Write("\nIngrese el nuevo nombre del producto: ");
            productos[indice, 0] = Console.ReadLine();
            Console.Write("Ingrese el nuevo precio del producto: ");
            productos[indice, 1] = Console.ReadLine();
            Console.Write("Ingrese el nuevo stock del producto: ");
            productos[indice, 2] = Console.ReadLine();
            Console.WriteLine("\nProducto modificado exitosamente.");
        }

    }
}
