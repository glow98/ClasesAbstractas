using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using SeresVivos;

namespace SeresVivos
{
    //Se crea la clase "Humano"
    class Humano : Mamiferos
    {
        //Se crean metodos propios y se le dan valores a los metodos heredados
        public void Raciocinio()
        {
            Console.WriteLine("Soy un humano y tengo la capacidad de Razonar");
        }
        public void NumPatas()
        {
            Console.WriteLine("Tengo 2 patas");
        }

        public void MostrarNombre(string nombre)
        {
            Console.WriteLine("Me llamo " + nombre);


        }
    }
}
