using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E4_1.Cruz_Vera_Elden_Humberto
{
    public class BTree
    {
        private BNode _root;
        private int _count;
        private IComparer<int> _comparer = Comparer<int>.Default; //Metodo para comparar 2 objetos


        public BTree() //Inicializa la raiz como nula y el contador en 0
        {
            _root = null;
            _count = 0;
        }


        public bool Add(int Item) //Entra el primer elemento añadido
        {
            if (_root == null) //si la raiz es nula, este elemento se convierte en la raiz y suma 1 al contador
            {
                _root = new BNode(Item); //si la raiz es nula entonces se inicializa como un objeto junto con el nuevo valor del elemento
                _count++;
                return true;
            }
            else //si la raiz ya existe entonces ejecuta el metodo para añadir nodos y envia como parametros los valores de la raiz y el nuevo elemento
            {
                return Add_Sub(_root, Item);
            }
        }

        private bool Add_Sub(BNode Node, int Item)
        {
            if (_comparer.Compare(Node.item, Item) < 0) //compara los 2 objetos y regresa el valor indicando cual es menor, igual o mayor que el otro
            {   //Si el valor retornado es menor que 0 sera el nuevo nodo derecho
                if (Node.right == null)
                {
                    Node.right = new BNode(Item); //Si el nodo derecho es nulo, se inicializa como objeto junto con su nuevo valor
                    _count++; //Suma 1 al contador
                    return true;
                }
                else
                {
                    return Add_Sub(Node.right, Item); //Si no es nulo, ejecuta el metodo para obtener el valor del nodo izquierdo
                }
            }
            else if (_comparer.Compare(Node.item, Item) > 0)
            {   //si el valor retornado es mayor a 0 sera el nuevo nodo izquierdo
                if (Node.left == null) //Si el nodo izquierdo es nulo entonces se le asigna un nuevo valor
                {
                    Node.left = new BNode(Item);
                    _count++; //Suma uno al contador
                    return true;
                }
                else
                {
                    return Add_Sub(Node.left, Item);
                }
            }
            else
            {
                return false;
            }
        }

        public void Print()
        {
            _root.PrintPretty("", true); //Vaya al metodo para mas informacion* xd
        }

    }
}

