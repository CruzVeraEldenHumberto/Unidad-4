using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PE4_2.Cruz_Vera_Elden_Humberto
{
    class Nodo
    {
        public string nombre;//Variable de tipo string 
        public Nodo[] vinculo;//Arreglo de tipo Nodo llamado vinculo
        public Nodo() { }//Constructor 
        public Nodo(string name)//Construcutor sobrecargado
        {
            nombre = name;//Se iguala la variable nombre al parametro name
        }
    }
}
