using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4_3.Cruz_Vera_Elden_Humberto
{
    public class Graph
    {
        // Contiene los nodos hijos de cada vertice del grafo
        // Asumiendo que los vertices comienzan del 0
        private List<int>[] nodosHijos;

        // Construye un grafo de x tamañao
        // Tamaño representa el numero de vertices
        public Graph(int Tamaño)
        {
            this.nodosHijos = new List<int>[Tamaño];
            for (int i = 0; i < Tamaño; i++)
            {
                // asigna una lista vacia de vertices adjacentes
                this.nodosHijos[i] = new List<int>();
            }
        }

        //onstruye un grafo basado en las listas que se generan de los nodos sucesores/adyacentes de cada nodo
        public Graph(List<int>[] nodosHijos)
        {
            this.nodosHijos = nodosHijos;
        }

        // Regresa el tamaño del grafo, osea la cantidad de nodos
        public int Tamaño
        {
            get { return this.nodosHijos.Length; }
        }


        // Este metodo checa si hay conexion entre dos nodos, recibe dos parametros, un para el primer nodo
        // y el otro para el segundo nodo, si tienen conexion regresa True, de lo contrario False
        public bool TieneConexion(int u, int v)
        {
            bool TieneConexion = nodosHijos[u].Contains(v);
            return TieneConexion;
        }

        // Regresa los sucesores/hijos del nodo deseado
        public IList<int> ObtenerNodos(int v) 
        {
            return nodosHijos[v];
        }

        // los ultimos metodos no son necesarios, pero me parecieron utiles para entender el codigo
    
    }
}
