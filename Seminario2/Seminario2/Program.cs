using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminario2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ListaDoblementeEnlazada lista = new ListaDoblementeEnlazada();
            Console.WriteLine("Agregar un nuevo nodo al principio de la lista:");
            lista.AgregarAlPrincipio();
            lista.AgregarAlPrincipio();
            lista.AgregarAlPrincipio();
            lista.AgregarAlPrincipio();
            lista.AgregarAlPrincipio();
            Console.WriteLine("Lista:");
            lista.RecorrerHaciaAdelante();
            Console.ReadKey();

            Console.WriteLine("Agregar un nuevo nodo al final de la lista:");
            lista.AgregarAlFinal();
            lista.AgregarAlFinal();
            Console.WriteLine("Lista:");
            lista.RecorrerHaciaAdelante();



            Console.ReadKey();
            Console.Write("Agregar un nuevo nodo en una posición específica de la lista:\n ");
            Console.Write("Ingrese el valor a insertar: ");
            int valor = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la posición de inserción: ");
            int posicion = int.Parse(Console.ReadLine());

            lista.InsertarEnPosicion(valor, posicion);

            Console.WriteLine("Después de insertar en la posición " + posicion + ":");
            lista.RecorrerHaciaAdelante();


            Console.ReadKey();
            Console.WriteLine("Eliminando el primer nodo:");
            lista.EliminarAlPrincipio();
            lista.RecorrerHaciaAdelante();

            Console.ReadKey();
            Console.WriteLine("Eliminando el último nodo:");
            lista.EliminarAlFinal();
            lista.RecorrerHaciaAdelante();

            Console.Write("Ingrese la posición del nodo a eliminar: ");
             posicion = int.Parse(Console.ReadLine());

            lista.EliminarEnPosicion(posicion);

            Console.WriteLine("Lista después de eliminar el nodo en la posición " + posicion + ":");
            lista.RecorrerHaciaAdelante();

            Console.Write("Ingrese el valor a buscar: ");
            int valorBuscado = int.Parse(Console.ReadLine());

            Nodo nodoEncontrado = lista.Buscar(valorBuscado);
            if (nodoEncontrado != null)
            {
                Console.WriteLine("El valor " + valorBuscado + " se encontró en la lista.");
            }
            else
            {
                Console.WriteLine("El valor " + valorBuscado + " no se encontró en la lista.");
            }
            Console.ReadKey();
            Console.WriteLine("Lista ordenada Hacia Adelante:");
            lista.RecorrerHaciaAdelante();
            Console.WriteLine("Lista ordenada Hacia Atras:");
            lista.RecorrerHaciaAtras();


            Console.ReadKey();
            Console.WriteLine(" el número de elementos en la lista doblemente enlazada:");
            int cantidadElementos = lista.ContarElementos();
            Console.WriteLine("Número de elementos en la lista: " + cantidadElementos);

            Console.ReadKey();
            Console.WriteLine("Lista:");
            lista.RecorrerHaciaAdelante();
            Console.ReadKey();
            Console.WriteLine("Invertir lista:");
            lista.InvertirLista();
            lista.RecorrerHaciaAdelante();





        }
    }
}
