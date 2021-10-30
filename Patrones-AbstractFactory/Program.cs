using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            FabricaAbstracta fabricaArmas = new FabricaDeArmas();
            IArma arma1 = fabricaArmas.GetArma("Cañon Simple");
            IArma arma2 = fabricaArmas.GetArma("Cañon Triple");

            FabricaAbstracta fabricaEnemigos = new FabricaDeEnemigos();
            IEnemigo enemigo1 = fabricaEnemigos.GetEnemigo("Insecto");
            IEnemigo enemigo2 = fabricaEnemigos.GetEnemigo("Bestia");

            arma1.Descripcion();
            arma2.Descripcion();
            Console.WriteLine("=================");

            enemigo1.Descripcion();
            enemigo1.Ataque();
            enemigo2.Descripcion();
            enemigo2.Ataque();
                      
            Console.ReadKey();

          

        }
    }
}
