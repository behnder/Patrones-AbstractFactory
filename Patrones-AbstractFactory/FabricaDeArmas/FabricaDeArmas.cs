
using Patrones_AbstractFactory;
using System;
using System.Collections.Generic;
using System.Text;



namespace Patrones_AbstractFactory
{
    class FabricaDeArmas : FabricaAbstracta
    {
        public IArma GetArma(string tipoDisparo)
        {
            return tipoDisparo switch
            {
                "Cañon Simple" => new CanonSimple(),
                "Cañon Triple" => new CanonTriple(),
                "Cañon Rafaga" => new CanonRafaga(),
                _ => null,
            };
        }

        public IEnemigo GetEnemigo(string tipoDeEnemigo)
        {
            throw null;
        }
    }
}
