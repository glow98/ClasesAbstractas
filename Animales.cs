using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeresVivos
{
    //Se crea una clase abstracta para que esta pueda heredar a las clases hijas sus metodos
    public abstract class Animales
    {
        public abstract void getNombre(string nombre);
        public void Respirar()
        {
            Console.WriteLine("Estoy respirando");
        }
    }
}
