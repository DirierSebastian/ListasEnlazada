using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    public class Nodo
    {
        private int _dato;
        private Nodo _siguiente;

        public Nodo(int dato)
        {
            _dato = dato;
            _siguiente = null;
        }

        public Nodo(int dato, Nodo siguiente)
        {
            _dato = dato;
            _siguiente = siguiente;
        }

        public Nodo getSiguiente
        {
            get { return _siguiente; }
            set { _siguiente = value; }
        }

        public int getDato
        {
            get { return _dato; }
        }
    }
}
