using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBeta
{
    public class ArbolB<T> : InterfazB<T>
    {
        public Nodo<T> raiz { get; set; }
        public void CrearArbol()
        {
            raiz = null;
        }

        public Nodo<T> buscar(Nodo<T> actual, string cl, int k)
        {
            if (raiz == null)
            {
                return null;
            }
            else
            {
                var Aux = new Nodo<T>();
                Aux = BuscarNodo(actual, cl, k);
                if (Aux == actual)
                {
                    return actual;
                }
                else
                {
                    return buscar(actual.arrayPointers[k], cl, k);
                }
            }
        }

        public Nodo<T> BuscarNodo(Nodo<T> actual, string cl, int k)
        {
            var Aux2 = new Nodo<T>();
            if (cl < actual.arrayNodos[1])
            {

            }
        }

        public void Combinar(Nodo<T> actual, int k)
        {
            throw new NotImplementedException();
        }

        public void DividirNodo(Nodo<T> actual, int[] array, Nodo<T> derecha, int k, int[] mediana, Nodo<T> nuevo)
        {
            throw new NotImplementedException();
        }

        public void eliminar(Nodo<T> actual, int[] array)
        {
            throw new NotImplementedException();
        }

        public void EliminarRegistro(Nodo<T> actual, int[] array, int encontrado)
        {
            throw new NotImplementedException();
        }

        public void Empujar(Nodo<T> actual, int[] array, int a, int b, Nodo<T> nuevo)
        {
            throw new NotImplementedException();
        }

        public void Hijo(Nodo<T> actual, int k)
        {
            throw new NotImplementedException();
        }

        public void insertar(Nodo<T> actual, int[] array)
        {
            throw new NotImplementedException();
        }

        public void InsertarHoja(Nodo<T> actual, int[] array, Nodo<T> derecha, int k)
        {
            throw new NotImplementedException();
        }

        public void MoverADerecha(Nodo<T> actual, int k)
        {
            throw new NotImplementedException();
        }

        public void MoverAIzquierda(Nodo<T> actual, int k)
        {
            throw new NotImplementedException();
        }

        public void PedirOrden(int n)
        {
            throw new NotImplementedException();
        }

        public void Reestablecer(Nodo<T> actual, int k)
        {
            throw new NotImplementedException();
        }

        public void Remover(Nodo<T> actual, int k)
        {
            throw new NotImplementedException();
        }
    }
}
