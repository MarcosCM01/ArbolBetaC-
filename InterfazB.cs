using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBeta
{
     public interface InterfazB<T>
    {
        void CrearArbol();
        void PedirOrden(int n);
        Nodo<T> buscar(Nodo<T> actual, string cl, int k);
        void insertar(Nodo<T> actual, int[]array);
        void eliminar(Nodo<T> actual, int[] array);

        Nodo<T> BuscarNodo(Nodo<T> actual, string cl, int k);
        void Empujar(Nodo<T> actual, int[]array, int a, int b, Nodo<T> nuevo);
        void InsertarHoja(Nodo<T> actual, int[]array, Nodo<T> derecha, int k);
        void DividirNodo(Nodo<T> actual, int[] array, Nodo<T> derecha, int k, int[]mediana, Nodo<T>nuevo);
        void EliminarRegistro(Nodo<T> actual, int []array, int encontrado);
        void Remover(Nodo<T> actual, int k);
        void Hijo(Nodo<T> actual, int k);
        void Reestablecer(Nodo<T> actual, int k);
        void MoverADerecha(Nodo<T> actual, int k);
        void MoverAIzquierda(Nodo<T> actual, int k);
        void Combinar(Nodo<T> actual, int k);
    }
}
