//using Patrones_AbstractFactory.FabricaDeEnemigos.Enemigos;
using Patrones_AbstractFactory
;
using System;
using System.Collections.Generic;
using System.Text;


namespace Patrones_AbstractFactory
{ 
    class FabricaDeEnemigos : FabricaAbstracta
    {
        public IArma GetArma(string tipoDeArma)
        {
            return null;
        }

        public IEnemigo GetEnemigo(string tipoEnemigo) 
        {
            return tipoEnemigo switch
            {
                "Bestia" => new Bestia(),
                "Insecto" => new Insecto(),
                "Robot" => new Robot(),
                _ => null,
            };
        }
    }
}
