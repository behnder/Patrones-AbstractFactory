using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            FabricaAbstracta fabricaEspacial = new FabricaEspacial();
            IArma armaEspacial1 = fabricaEspacial.GetArma("Cañon de Rayos");
            IArma armaEspacial2 = fabricaEspacial.GetArma("Rifle Laser");
            IArma armaEspacial3 = fabricaEspacial.GetArma("Rifle de Plasma");

            IEnemigo enemigoEspacial1 = fabricaEspacial.GetEnemigo("Krogan");
            IEnemigo enemigoEspacial2 = fabricaEspacial.GetEnemigo("Quarian");
            IEnemigo enemigoEspacial3 = fabricaEspacial.GetEnemigo("Turian");

            FabricaAbstracta fabricaTerrestre = new FabricaTerrestre();
            IArma armaTerrestre1 = fabricaTerrestre.GetArma("Cañon Simple");
            IArma armaTerrestre2 = fabricaTerrestre.GetArma("Cañon Triple");
            IArma armaTerrestre3 = fabricaTerrestre.GetArma("Cañon Rafaga");

            IEnemigo enemigoTerrestre1 = fabricaTerrestre.GetEnemigo("Bestia");
            IEnemigo enemigoTerrestre2 = fabricaTerrestre.GetEnemigo("Insecto");
            IEnemigo enemigoTerrestre3 = fabricaTerrestre.GetEnemigo("Humano");

            Console.WriteLine("========================");

            armaEspacial1.Descripcion();
            armaEspacial2.Descripcion();
            armaEspacial3.Descripcion();
            enemigoEspacial1.Descripcion();
            enemigoEspacial2.Descripcion();
            enemigoEspacial3.Descripcion();

            Console.WriteLine("========================");

            armaTerrestre1.Descripcion();
            armaTerrestre2.Descripcion();
            armaTerrestre3.Descripcion();
            enemigoTerrestre1.Descripcion();
            enemigoTerrestre2.Descripcion();
            enemigoTerrestre3.Descripcion();




            Console.ReadKey();




        }
    }
}
