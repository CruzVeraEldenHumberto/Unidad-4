using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4_1.Cruz_Vera_Elden_Humberto
{
    public class BNode
    {
        public int item;
        public BNode right; //Variables para la posicion de los nodos (derecha o izquierda)
        public BNode left;

        public BNode(int item)
        {
            this.item = item;
        }
        //Metodo para imprimir las aristas de los nodos para poder visualizarlas
        public void PrintPretty(string indent, bool last) //recibe la cadena y el bool
        {

            Console.Write(indent); //Imprime la cadena ("") esto nos ayudara a poder visualizar el arbol de tal manera que parezca que va decendiendo los niveles del arbol 
            //(solo es para darle figura al arbol y mejor apreciacion)
            if (last)
            {
                Console.Write("└─");
                indent += "  ";
            }
            else
            {
                Console.Write("├─");
                indent += "| ";
            }
            Console.WriteLine(item); //Imprime el valor del nodo actual

            var children = new List<BNode>();
            if (this.left != null)
                children.Add(this.left);
            if (this.right != null)
                children.Add(this.right);

            for (int i = 0; i < children.Count; i++)
                children[i].PrintPretty(indent, i == children.Count - 1);

        }

    }
}
