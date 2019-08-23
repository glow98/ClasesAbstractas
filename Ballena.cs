using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeresVivos
{
    class Ballena : Mamiferos
    {
        //Se crean metodos propios y se le dan valores a los metodos heredados
        public void Nadar()
        {
            Console.WriteLine("Soy una BALLENA y estoy nadando");
        }

        public void MostrarNombre(string nombre)
        {
            Console.WriteLine("Me llamo " + nombre);
        }
    }
}
