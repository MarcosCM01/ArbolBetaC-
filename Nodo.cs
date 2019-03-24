using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBeta
{
    public  class Nodo<T>
    {
        public int m = asignarOrden();
        public Nodo<T>[] arrayNodos = new Nodo<T>[10]; //Vector de nodos
        public Nodo<T>[] arrayPointers = new Nodo<T>[10]; //Vector de apuntadores
        public int posicion; 

        public int asignarOrden()
        {
            int k;
            Console.WriteLine("Digite el orden");
            Console.ReadLine(k);
            return k;
        }

        bool nodoLleno(Nodo<T> tmp)
        { if (tmp.posicion == m - 1) return true; return false; }

        bool nodoSemiVacio(Nodo<T> tmp)
        { if (tmp.posicion < m / 2) { return true; } return false; }
    }
    
}
