using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeresVivos
{
    //Se crea la clase "Gorila"
    class Gorila : Mamiferos //Se van a heredar metodos de la clase abstracta "Mamiferos", es por ello que se colocan dos puntos y asi pueda existir la herencia
    {
        //Se crean metodos propios de la clase como lo es "Trepar" y se heredan los metodos "NumPatas" y "MostrarNombre"
        //a las cuales se les dan valores por el sentido de la clase
        public void Trepar()
        {
            Console.WriteLine("Soy un GORILA y estoy trepando");
        }
        public void  NumPatas()
        {
            Console.WriteLine("Tengo 2 patas");
        }

        public void MostrarNombre(string nombre)
        {
            Console.WriteLine("Me llamo " + nombre);
        }
    }
}
