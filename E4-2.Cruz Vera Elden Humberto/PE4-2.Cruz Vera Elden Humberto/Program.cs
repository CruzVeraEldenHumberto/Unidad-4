using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE4_2.Cruz_Vera_Elden_Humberto
{
    class Program
    {
        static void Main(string[] args)
        {
            Arbol Arbol = new Arbol();//Se crea un objeto de tipo Arbol llamado Arbol
            Arbol.ImprimirArbolA();//se llama al metodo ImprimirArbolA de la clase Arbol
            Console.Clear();//Se limpia la consola
            Arbol.ImprimirArbolB();//se llama al metodo ImprimirArbolB de la clase Arbol
            Console.Clear();//Se limpia la consola
            Arbol.ImprimirArbolC();//se llama al metodo ImprimirArbolC de la clase Arbol
        }
    }
}
