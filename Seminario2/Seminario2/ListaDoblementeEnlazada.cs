using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seminario2
{

    public class ListaDoblementeEnlazada
    {
        private Nodo cabeza;



        public void AgregarAlFinal()
        {
            int valor = 0;
            Nodo nuevoNodo = new Nodo(valor);

            Console.WriteLine("Ingrese el valor del nuevo nodo");
            nuevoNodo.Valor = int.Parse(Console.ReadLine());


            if (cabeza == null)
            {
                cabeza = nuevoNodo;
            }
            else
            {
                Nodo actual = cabeza;
                while (actual.Siguiente != null)
                {
                    actual = actual.Siguiente;
                }

                actual.Siguiente = nuevoNodo;
                nuevoNodo.Anterior = actual;
            }
        }

        public void AgregarAlPrincipio()

        {
            int valor = 0;
            Nodo nuevoNodo = new Nodo(valor);

            Console.WriteLine("Ingrese el valor del nuevo nodo");
            nuevoNodo.Valor = int.Parse(Console.ReadLine());

            if (cabeza != null)
            {
                cabeza.Anterior = nuevoNodo;
                nuevoNodo.Siguiente = cabeza;
            }

            cabeza = nuevoNodo;
        }
        public void InsertarEnPosicion(int valor, int posicion)
        {
            if (posicion < 0)
            {
                Console.WriteLine("La posición debe ser un número no negativo.");
                return;
            }

            Nodo nuevoNodo = new Nodo(valor);



            Nodo actual = cabeza;
            int indice = 0;

            while (actual != null && indice < posicion - 1)
            {
                actual = actual.Siguiente;
                indice++;
            }

            if (actual == null)
            {
                Console.WriteLine("La posición especificada excede la longitud de la lista.");
                return;
            }

            nuevoNodo.Siguiente = actual.Siguiente;
            nuevoNodo.Anterior = actual;
            actual.Siguiente = nuevoNodo;

            if (nuevoNodo.Siguiente != null)
            {
                nuevoNodo.Siguiente.Anterior = nuevoNodo;
            }
        }
        public Nodo Buscar(int valor)
        {
            Nodo actual = cabeza;

            while (actual != null)
            {
                if (actual.Valor == valor)
                {
                    return actual; // Se encontró el valor, devuelve el nodo
                }

                actual = actual.Siguiente;
            }

            return null; // El valor no se encontró en la lista
        }
        public void RecorrerHaciaAdelante()
        {
            Nodo actual = cabeza;
            while (actual != null)
            {
                Console.Write(actual.Valor + " ");
                actual = actual.Siguiente;
            }
            Console.WriteLine();
        }
        public void RecorrerHaciaAtras()
        {
            Nodo actual = cabeza;
            while (actual != null && actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }

            while (actual != null)
            {
                Console.Write(actual.Valor + " ");
                actual = actual.Anterior;
            }
            Console.WriteLine();
        }
        public void EliminarAlPrincipio()
        {
            if (cabeza != null)
            {
                Nodo segundoNodo = cabeza.Siguiente;

                if (segundoNodo != null)
                {
                    segundoNodo.Anterior = null;
                }

                cabeza = segundoNodo;
            }
        }
        public void EliminarAlFinal()
        {
          

            if (cabeza.Siguiente == null)
            {
                // Solo hay un nodo en la lista
                cabeza = null;
                return;
            }

            Nodo actual = cabeza;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }

            actual.Anterior.Siguiente = null;
        }
        public void EliminarEnPosicion(int posicion)
        {


            if (posicion == 0)
            {
                EliminarAlPrincipio();
                return;
            }

            Nodo actual = cabeza;
            int indice = 0;

            while (actual != null && indice < posicion)
            {
                actual = actual.Siguiente;
                indice++;
            }

            if (actual.Anterior != null)
            {
                actual.Anterior.Siguiente = actual.Siguiente;
            }

            if (actual.Siguiente != null)
            {
                actual.Siguiente.Anterior = actual.Anterior;
            }
        }
        public int ContarElementos()
        {
            Nodo actual = cabeza;
            int contador = 0;

            while (actual != null)
            {
                contador++;
                actual = actual.Siguiente;
            }

            return contador;
        }
        public void InvertirLista()
        {
            Nodo actual = cabeza;
            Nodo temp = null;

            while (actual != null)
            {
                temp = actual.Anterior;
                actual.Anterior = actual.Siguiente;
                actual.Siguiente = temp;

                actual = actual.Anterior; // Mover al siguiente nodo
            }

            if (temp != null)
            {
                cabeza = temp.Anterior; // Actualizar la cabeza al último nodo (nuevo primero)
            }
        }
    }

}

