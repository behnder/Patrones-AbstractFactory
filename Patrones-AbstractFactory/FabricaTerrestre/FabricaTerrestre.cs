
using Patrones_AbstractFactory;
using System;
using System.Collections.Generic;
using System.Text;


namespace Patrones_AbstractFactory
{
    class FabricaTerrestre : FabricaAbstracta
    {
        public IArma GetArma(string tipoDeArma)
        {
            return tipoDeArma switch
            {
                "Cañon Simple" => new CanonSimple(),
                "Cañon Triple" => new CanonTriple(),
                "Cañon Rafaga" => new CanonRafaga(),
                _ => null,
            };
        }

        public IEnemigo GetEnemigo(string tipoEnemigo)
        {
            return tipoEnemigo switch
            {
                "Bestia" => new Bestia(),
                "Insecto" => new Insecto(),
                "Humano" => new Humano(),
                _ => null,
            };
        }
    }
}
