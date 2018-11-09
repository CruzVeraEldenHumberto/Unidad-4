using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4_1.Cruz_Vera_Elden_Humberto
{
    public class ArbolBinarioOrdenado
    {

        private Nodo raiz;
        private int cant;
        private int altura;
        public ArbolBinarioOrdenado()
        {
            raiz = null;
        }
        private void ImprimirPre(Nodo reco) //Metodo para ordenar el arbol en Preorden
        {
            if (reco != null)
            {
                Console.Write(reco.info + " ");
                ImprimirPre(reco.izq);
                ImprimirPre(reco.der);
            }
        }
        public void ImprimirPre() //Metodo para ordenar el arbol en Preorden con la raiz como primer elemento
        {
            ImprimirPre(raiz);
            Console.WriteLine();
        }
        private void ImprimirPost(Nodo reco) //recibe el valor de la raiz
        {
            if (reco != null)
            {
                ImprimirPost(reco.izq);
                ImprimirPost(reco.der);
                Console.Write(reco.info + " ");
            }
        }
        public void ImprimirPost()
        {
            ImprimirPost(raiz); //Envia como parametro el valor de la raiz
            Console.WriteLine();
        }
        public void Insertar(int info) //Recibe el valor del nodo actual
        {
            if (!Existe(info)) //Si en caso de que ya exista uno igual, crea otro
            {
                Nodo nuevo;
                nuevo = new Nodo();
                nuevo.info = info;
                nuevo.izq = null;
                nuevo.der = null;
                if (raiz == null)
                    raiz = nuevo;
                else
                {
                    Nodo anterior = null, reco;
                    reco = raiz;
                    while (reco != null)
                    {
                        anterior = reco;
                        if (info < reco.info)
                            reco = reco.izq;
                        else
                            reco = reco.der;
                    }
                    if (info < anterior.info)
                        anterior.izq = nuevo;
                    else
                        anterior.der = nuevo;
                }
            }
        }

        public bool Existe(int info)
        {
            Nodo reco = raiz;
            while (reco != null)
            {
                if (info == reco.info)
                    return true;
                else
                    if (info > reco.info)
                    reco = reco.der;
                else
                    reco = reco.izq;
            }
            return false;
        }

        private void ImprimirEntre(Nodo reco) //Metodo para imprimir en preorden los nodos
        {
            if (reco != null)
            {
                ImprimirEntre(reco.izq);
                Console.Write(reco.info + " ");
                ImprimirEntre(reco.der);
            }
        }

        public void ImprimirEntre()
        {
            ImprimirEntre(raiz);
            Console.WriteLine();
        }


        private void Cantidad(Nodo reco)
        {
            if (reco != null)
            {
                cant++;
                Cantidad(reco.izq);
                Cantidad(reco.der);
            }
        }

        public int Cantidad() //Metodo para obtener la catidad total de nodos
        {
            cant = 0;
            Cantidad(raiz);
            return cant;
        }

        private void CantidadNodosHoja(Nodo reco) //Metodo para obtener la cantidad de hojas del arbol
        {
            if (reco != null)
            {
                if (reco.izq == null && reco.der == null)
                    cant++;
                CantidadNodosHoja(reco.izq);
                CantidadNodosHoja(reco.der);
            }
        }

        public int CantidadNodosHoja()
        {
            cant = 0;
            CantidadNodosHoja(raiz);
            return cant;
        }

        private void ImprimirEntreConNivel(Nodo reco, int nivel) //Imprime los nodos junto con la cantidad del nivel que le corresponde
        {
            if (reco != null)
            {
                ImprimirEntreConNivel(reco.izq, nivel + 1);
                Console.Write(reco.info + " (" + nivel + ") - ");
                ImprimirEntreConNivel(reco.der, nivel + 1);
            }
        }

        public void ImprimirEntreConNivel()
        {
            ImprimirEntreConNivel(raiz, 1);
            Console.WriteLine();
        }

        private void RetornarAltura(Nodo reco, int nivel) //Imprime la altura de el arbol
        {
            if (reco != null)
            {
                RetornarAltura(reco.izq, nivel + 1);
                if (nivel > altura)
                    altura = nivel;
                RetornarAltura(reco.der, nivel + 1);
            }
        }

        public int RetornarAltura()
        {
            altura = 0;
            RetornarAltura(raiz, 1);
            return altura;
        }

        public void MayorValorl() //Obtiene el valor del nodo mayor de todo el arbol
        {
            if (raiz != null)
            {
                Nodo reco = raiz;
                while (reco.der != null)
                    reco = reco.der;
                Console.WriteLine("Mayor valor del árbol:" + reco.info);
            }
        }
    }
}