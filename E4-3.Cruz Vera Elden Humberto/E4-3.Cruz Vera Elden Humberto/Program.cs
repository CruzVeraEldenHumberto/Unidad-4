using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4_3.Cruz_Vera_Elden_Humberto
{
    class GraphComponents
    {  // Aqui genera el grafo con la primer ruta, ya despues de eso profe le intente pero
        // no me salian bien las otras trayectorias simples, quizas debi usar un metodo BFS
        static Graph graph = new Graph(new List<int>[] {
        new List<int>() {0, 1},     // Nodos adyacentes del  vertice 0
        new List<int>() {0, 2, 6}, // Nodos adyacentes del  vertice 1
        new List<int>() {1,3,6},    // Nodos adyacentes del  vertice 2
        new List<int>() {2,4,5},     // Nodos adyacentes del  vertice 3
        new List<int>() {3,5},     // Nodos adyacentes del  vertice 4
        new List<int>() {3,4,6},      // Nodos adyacentes del  vertice 5
        new List<int>() {1, 2, 5}  // Nodos adyacentes del  vertice 6
    });

        static Graph graph1 = new Graph(new List<int>[] { 
        new List<int>() {0, 1},     // Nodos adyacentes del  vertice 0
        new List<int>() {3,5},     // Nodos adyacentes del  vertice 4  
        new List<int>() {0, 2, 6}, // Nodos adyacentes del  vertice 1
        new List<int>() {1,3,6},    // Nodos adyacentes del  vertice 2
        new List<int>() {2,4,5},     // Nodos adyacentes del  vertice 3
        new List<int>() {3,4,6},      // Nodos adyacentes del  vertice 5
        new List<int>() {1, 2, 5},  // Nodos adyacentes del  vertice 6
        
    });


        static bool[] visited = new bool[graph.Tamaño]; // Arreglo que contiene valores True/False si se ha visitado el nodo
        // contiene el tamaño de nuestro grafo

        static bool[] visited1 = new bool[graph1.Tamaño];


        static void TraverseDFS(int v) // Aqui se usa un metodo DFS para poder imprimir la conexion entre los nodos
        {
            if (!visited[v]) // Si no se ha visitado el nodo visited se hace verdadero porque ya paso por ese nodo
            {
                Console.Write(v + " ");
                visited[v] = true;
                foreach (int child in graph.ObtenerNodos(v)) // Dentro de un ciclo ponemos un metodo recursivo para que se
                    // se visiten los demas nodos
                {
                    TraverseDFS(child);
                }
            }
        }

        static void TraverseDFS1(int v) // lo mismo que el mismo metodo anterior, excepto que aqui no me salio xd
        {
            if (!visited1[v])
            {
                Console.Write(v + " ");
                visited1[v] = true;
                foreach (int child in graph1.ObtenerNodos(v))
                {
                    TraverseDFS1(child);
                }
            }
        }

  

        static void Main(string[] args)
        { 
            Console.WriteLine("0 = A");
            Console.WriteLine("1 = B");
            Console.WriteLine("2 = C");
            Console.WriteLine("3 = D");
            Console.WriteLine("4 = E");
            Console.WriteLine("5 = F");
            Console.WriteLine("6 = G");
            Console.WriteLine("Nodos conectados del grafo y primer trayectoria: ");

            // En este metodo del main mandamos como parametro la v para que el metodo TravserseDFS pueda ser recursivo
            for (int v = 0; v < graph.Tamaño; v++)
            {
                if (!visited[v])
                {
                    TraverseDFS(v);
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
            Console.WriteLine("Segunda trayectoria");
            for (int v = 0; v < graph1.Tamaño; v++)
            {
                if (!visited1[v])
                {
                    TraverseDFS1(v);
                    Console.WriteLine();
                }
            }

            Console.Write("Presione una tecla para continuar ");
            Console.ReadKey();
        }
    }
}
