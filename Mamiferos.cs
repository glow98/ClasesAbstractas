using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeresVivos
{
    //Se crea la clase Mamiferos la cual tiene dos metodos propios y dos metodos que son heredados de la clase animales
    class Mamiferos : Animales
    {
        //Se crean metodos propios y se le dan valores a los metodos heredados
        public void Pensar()
        {
            Console.WriteLine("Todos los MAMIFEROS tenemos la capacidad de PENSAR");
        }
        public void CuidarCrias()
        {
            Console.WriteLine(" Todos los MAMIFEROS tenemos la capacidad de Cuidar a nuestras crias");

        }
        public override void getNombre(string nombre)
        {

        }
    }
}
