using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SeresVivos
{
    //Se crea la clase "Mamiferos"
    class Caballo : Mamiferos
    {
        //Se crean metodos propios y se le dan valores a los metodos heredados
        public void Galopar()
        {
            Console.WriteLine("Soy un CABALLO y estoy galopando");
        }
        public void NumPatas()
        {
            Console.WriteLine("Tengo 4 patas");
        }

        public void MostrarNombre(string nombre)
        {
            Console.WriteLine("Me llamo " + nombre);


        }
    }

}
