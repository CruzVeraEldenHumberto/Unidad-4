using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE4_2.Cruz_Vera_Elden_Humberto
{ // Profe aqui la neta no pude imprimir la ruta al ultimo elemento, investigare más sobre esto
    class Arbol
    {
        int CoordX = 0, CoordY = 2;//Coordenadas para posicionar el Arbol 
        public void AgregarVinculo(Nodo Nodo, string name, string[] names)//Metodo llamado AgregarVinculo, crea las relaciones en cada nodo
        {
            if (Nodo.vinculo != null)//Si el atributo vinculo de Nodo es diferente de null
            {
                foreach (Nodo item in Nodo.vinculo)//por cada item de la clase Nodo en vinculo 
                {
                    AgregarVinculo(item, name, names);//Se llama al metodo AgregarVinculo
                }
            }
            else// si no
            {
                if (Nodo.nombre == name)//si el atributo nombre de la clase Nodo es igual al parametro name 
                {
                    Nodo.vinculo = new Nodo[names.Length];//se crea un nuevo arreglo Nodo que se le asigna al atributo vinculo 
                    for (int i = 0; i < names.Length; i++)//for que va desde 0 hasta el tamaño del arreglo names - 1 
                    {
                        Nodo.vinculo[i] = new Nodo(names[i]);//se crea un nuevo arreglo de Nodo con parametro names en i, y se iguala al atributo vinculo en la posicion i 
                    }
                }
            }
        }
        int Altura = 0, Nivel = 0;// se crean las variables Altura y Nivel del arbol 
        public void Imprimir(Nodo Nodo)//Creacion del metodo de impresion al que se le manda un parametro de tipo Nodo
        {

            if (Nodo.vinculo != null)// si el atributo vinculo de Nodo es diferente a null
            {
                Console.SetCursorPosition(CoordX, CoordY);//se usa SetCursorPosition con parametros CoordX y CoordY para que se escriba en cierta parte de la consola 
                Console.Write(Nodo.nombre);//Se imprime el atributo nombre 
                CoordX += 5;// se le suma a la coordenada x 5 
                CoordY++;//incremento de la coordenada y
                for (int i = 0; i < Nodo.vinculo.Length; i++)// for desde 0 hasta el tamaño del arreglo vinculo 
                {
                    Imprimir(Nodo.vinculo[i]);//se llama el metodo impresion con parametro vinculo en la posicion i 
                }
                CoordX += 5;// se le suma a la coordenada x 5 
            }
            else// si no 
            {
                Console.SetCursorPosition(CoordX, CoordY);// el cursor se posiciona en las coordenadas 
                Console.Write(Nodo.nombre);// se imprime el atributo nombre 
                CoordY++;// se incrementa la coordenada y 
            }

            Altura = ((CoordY - 1) / 2);// altura se iguala a ((CoordY - 1) /2) - 1
            Nivel = Altura-1;// Nivel se iguala a Altura 
        }
        public void AlturaNivel()//Metodo que imprime Altura y Nivel 
        {
            Console.WriteLine("\n\nAltura: {0}", Altura);//se imprime en consola Altura
            Console.WriteLine("Nivel: {0}", Nivel);//se imprime en consola Nivel
                                                   
        }

        public void ImprimirArbolA()//Metodo que imprime el arbol A 
        {
            Console.WriteLine("Arbol A");//Escribe lo que esta entre comillas
            Nodo NodoRaiz = new Nodo("E");//se crea un objeto de tipo Nodo dandole de parametro la letra E que es la raiz 
            Arbol Arbol = new Arbol();//se crea un objeto de tipo Arbol llamado Arbol
            Arbol.AgregarVinculo(NodoRaiz, "E", new string[] { "F", "A" });//se llama el metodo AgregarVinculo dandole distintos parametros
            Arbol.AgregarVinculo(NodoRaiz, "A", new string[] { "B", "C", "D" });//se llama el metodo AgregarVinculo dandole distintos parametros
            Arbol.Imprimir(NodoRaiz);//Se llama el metodo que imprimira al arbol llamado Impresion 
            Arbol.AlturaNivel();//Se llama al metodo AlturaNivel que imprime la altura y el nivel 
            
            Console.ReadKey();
        }

        public void ImprimirArbolB()
        {
            Console.WriteLine("Arbol B");//Escribe lo que esta entre comillas
            Nodo NodoRaiz = new Nodo("C");//se crea un objeto de tipo Nodo dandole de parametro la letra C que es la raiz
            Arbol Arbol = new Arbol();//se crea un objeto de tipo Arbol llamado Arbol
            Arbol.AgregarVinculo(NodoRaiz, "C", new string[] { "D", "F", "G", "A" });//se llama el metodo AgregarVinculo dandole distintos parametros
            Arbol.AgregarVinculo(NodoRaiz, "A", new string[] { "B" });//se llama el metodo AgregarVinculo dandole distintos parametros
            Arbol.AgregarVinculo(NodoRaiz, "B", new string[] { "E" });//se llama el metodo AgregarVinculo dandole distintos parametros
            Arbol.Imprimir(NodoRaiz);//Se llama el metodo que imprimira al arbol llamado Impresion 
            Arbol.AlturaNivel();//Se llama al metodo AlturaNivel que imprime la altura y el nivel 
            
            Console.ReadKey();
        }

        public void ImprimirArbolC()
        {
            Console.WriteLine("Arbol C");//Escribe lo que esta entre comillas
            Nodo NodoRaiz = new Nodo("K");//se crea un objeto de tipo Nodo dandole de parametro la letra K que es la raiz
            Arbol Arbolito = new Arbol();//se crea un objeto de tipo Arbol llamado Arbol
            Arbolito.AgregarVinculo(NodoRaiz, "K", new string[] { "A", "C", "B", "D" });//se llama el metodo AgregarVinculo dandole distintos parametros
            Arbolito.AgregarVinculo(NodoRaiz, "D", new string[] { "I    J", "E" });//se llama el metodo AgregarVinculo dandole distintos parametros //No pude hacer que I tuviera al hijo J 
            Arbolito.AgregarVinculo(NodoRaiz, "E", new string[] { "F", "G" });//se llama el metodo AgregarVinculo dandole distintos parametros
            Arbolito.AgregarVinculo(NodoRaiz, "G", new string[] { "H" });//se llama el metodo AgregarVinculo dandole distintos parametros
            Arbolito.Imprimir(NodoRaiz);//Se llama el metodo que imprimira al arbol llamado Impresion 
            Arbolito.AlturaNivel();//Se llama al metodo AlturaNivel que imprime la altura y el nivel 
            
            Console.ReadKey();
        }

    }
}

