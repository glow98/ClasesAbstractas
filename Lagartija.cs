using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeresVivos
{
    class Lagartija : Animales
    {
        //Se crean metodos propios y se le dan valores a los metodos heredados
        public override void getNombre(string nombre)
        {
        }

        public void MostrarNombre(string nombre)
        {
            Console.WriteLine("Me llamo " + nombre);
        }
        public void NumPatas()
        {
            Console.WriteLine("Tengo 4 patas");

        }
    }
}
