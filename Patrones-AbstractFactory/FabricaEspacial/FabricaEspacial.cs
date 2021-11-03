
using Patrones_AbstractFactory;
using System;
using System.Collections.Generic;
using System.Text;



namespace Patrones_AbstractFactory
{
    class FabricaEspacial : FabricaAbstracta
    {
        public IArma GetArma(string tipoDisparo)
        {
            return tipoDisparo switch
            {
                "Cañon de Rayos" => new CanonRayos(),
                "Rifle Laser" => new RifleLaser(),
                "Rifle de Plasma" => new RiflePlasma(),
                _ => null,
            };
        }

        public IEnemigo GetEnemigo(string tipoDeEnemigo)
        {
            return tipoDeEnemigo switch
            {
                "Krogan" => new Krogan(),
                "Quarian" => new Quarian(),
                "Turian" => new Turian(),
                _ => null,
            };
        }
    }
}
