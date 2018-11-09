using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace E4_1.Cruz_Vera_Elden_Humberto
{
    class Program
    {
        static void Main(string[] args)
        {
            BTree btr = new BTree();
            btr.Add(6);    //Se añaden el valor de los nodos al arbol para poder visualizarlo en consola
            btr.Add(2);
            btr.Add(3);
            btr.Add(11);
            btr.Add(30);
            btr.Add(9);
            btr.Add(13);
            btr.Add(18);
            btr.Print();
            ArbolBinarioOrdenado abo = new ArbolBinarioOrdenado();
            abo.Insertar(6);   //Se añaden el valor de los nodos al arbol para ejecutar las distintas operaciones 
            abo.Insertar(2);
            abo.Insertar(3);
            abo.Insertar(11);
            abo.Insertar(30);
            abo.Insertar(9);
            abo.Insertar(13);
            abo.Insertar(18);
            Console.WriteLine("\nCantidad de nodos del árbol:" + abo.Cantidad());  //Muestra la cantidad de nodos en total en el arbol
            Console.WriteLine("Cantidad de nodos hoja:" + abo.CantidadNodosHoja()); //Ejecuta el metodo para mostrar la cantidad de hojas en el arbol
            Console.WriteLine("Impresion en entre orden junto al nivel del nodo.");
            abo.ImprimirEntreConNivel(); //Ejecuta el metodo para imprimir los nodos con su respectivo nivel en el arbol
            Console.Write("Artura del arbol:");
            Console.WriteLine(abo.RetornarAltura());
            abo.MayorValorl(); //Ejecuta el metodo para mostrar la altura del arbol
            Console.WriteLine("Impresion preorden: ");
            abo.ImprimirPre(); //Imprime los nodos en preorden
            Console.WriteLine("Impresion entreorden: ");
            abo.ImprimirEntre(); //IMprime los nodos en entreorden
            Console.WriteLine("Impresion postorden: ");
            abo.ImprimirPost();  //Imprime los nodos en postorden
            Console.ReadKey();
        }
    }
}
