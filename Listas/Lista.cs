using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    public class Lista
    {
        private Nodo _primero;
        private Nodo _ultimo;
        private int _dato;

        public Lista(int Dato)
        {
            _dato = Dato;
            _primero = _ultimo = null;
        }

        public Lista()
        {
        }

        public bool IsNull()
        {
            return _primero == null;
        }

        public void InsertarPrincipio(int dato)
        {
            if (IsNull())
            {
                _primero = _ultimo = new Nodo(dato);
            }
            else
            {
                _primero = new Nodo(dato, _primero);
            }
        }

        public void InsertarFinal(int dato)
        {
            if (IsNull())
            {
                _primero = _ultimo = new Nodo(dato);
            }
            else
            {
                _ultimo = _ultimo.getSiguiente = new Nodo(dato);
            }
        }

        public int EliminarPrincipio()
        {
            if (IsNull())
            {
                Console.WriteLine("La lista esta vacia");
                return 0;
            }
            int Borrar = _primero.getDato;
            if (_primero == _ultimo)
            {
                _primero = _ultimo = null;
            }
            else
            {
                _primero = _primero.getSiguiente;
            }
            Console.WriteLine($"El numero eliminado es: {Borrar}");
            return Borrar;
        }

        public int EliminarFinal()
        {
            if (IsNull())
            {
                Console.WriteLine("La lista esta vacia");
                return 0;
            }
            int Borrar = _ultimo.getDato;
            if (_primero == _ultimo)
            {
                _primero = _ultimo = null;
            }
            else
            {
                int cont = 0;
                Nodo actual = _primero;
                while (actual != _ultimo)
                {
                    ++cont;
                    actual = actual.getSiguiente;
                }
                actual = _primero;
                for (int i = 0; i < cont - 1; ++i)
                {
                    actual = actual.getSiguiente;
                }
                _ultimo = actual;
                Console.WriteLine($"El numero eliminado es: {Borrar}");
                actual.getSiguiente = null;

            }
            return Borrar;
        }

        public void InsertarMedio(int dato)
        {
            Nodo medio = new Nodo(dato);
            if (IsNull())
            {
                _primero = _ultimo = new Nodo(dato);
                
            }
            else
            {
                Nodo actual = _primero;
                Nodo anterior = null;
                Nodo buscar = _primero;

                while (buscar != null && buscar.getSiguiente != null)
                {
                    buscar = buscar.getSiguiente.getSiguiente;
                    anterior = actual;
                    actual = actual.getSiguiente;
                }
                medio.getSiguiente = actual;
                anterior.getSiguiente = medio;
            }
            
        }

        public void EliminarMedio()
        {
            if (IsNull())
            {
                Console.WriteLine("La lista esta vacia");
                return;
            }
            Nodo actual = _primero;
            Nodo anterior = null;
            Nodo buscar = _primero;
            while (buscar != null && buscar.getSiguiente != null)
            {
                buscar = buscar.getSiguiente.getSiguiente;
                anterior = actual;
                actual = actual.getSiguiente;
            }
            Console.WriteLine($"El numero eliminado es: {actual.getDato}");
            anterior.getSiguiente = actual.getSiguiente;

        }
        public void ImprimirLista()
        {
            if (IsNull())
            {
                Console.WriteLine("La lista esta vacia");
                return;
            }
            Console.WriteLine($"La lista es: ");
            Nodo actual = _primero;
            while (actual != null)
            {
                Console.Write(actual.getDato + " ");
                actual = actual.getSiguiente;
            }
            Console.WriteLine("\n");

        }
    }
}
