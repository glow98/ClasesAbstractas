using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeresVivos
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se crean objetos para los distintos animales
            Humano oHumano = new Humano();
            Ballena oBallena = new Ballena();
            Caballo oCaballo = new Caballo();
            Gorila oGorila = new Gorila();
            Lagartija oLagartija = new Lagartija();
            //Con ayuda de los objetos se mandan llamar los metodos que le corresponden a cada animal
            

            oHumano.getNombre("JUAN y soy un HUMANO");
            oHumano.MostrarNombre("JUAN y soy un HUMANO");
            oHumano.Respirar();
            oHumano.Pensar();
            oHumano.CuidarCrias();
            oHumano.Raciocinio();
            oHumano.NumPatas();
            Console.WriteLine();

            oBallena.getNombre("WILLY y soy una BALLENA");
            oBallena.MostrarNombre("WILLY y soy una BALLENA");
            oBallena.Respirar();
            oBallena.Pensar();
            oBallena.CuidarCrias();
            oBallena.Nadar();
            Console.WriteLine();

            oCaballo.getNombre("PANCHO y soy un CABALLO");
            oCaballo.MostrarNombre("PANCHO y soy un CABALLO");
            oCaballo.Respirar();
            oCaballo.Pensar();
            oCaballo.CuidarCrias();
            oCaballo.Galopar();
            oCaballo.NumPatas();
            Console.WriteLine();

            oGorila.getNombre("ROSA y soy una GORILA");
            oGorila.MostrarNombre("ROSA y soy una GORILA");
            oGorila.Respirar();
            oGorila.Pensar();
            oGorila.CuidarCrias();
            oGorila.Trepar();
            oGorila.NumPatas();
            Console.WriteLine();

            oLagartija.getNombre("PEDRO y soy una LAGARTIJA");
            oLagartija.MostrarNombre("PEDRO y soy una LAGARTIJA");
            oLagartija.Respirar();
            oLagartija.NumPatas();
            Console.WriteLine();




            Console.ReadKey();
        }
    }
}
