using System;
using System.Collections.Generic;
using System.Text;
using Patrones_AbstractFactory;


namespace Patrones_AbstractFactory
{
    public interface FabricaAbstracta
    {
        IArma GetArma(string tipoDeArma);
        IEnemigo GetEnemigo(string tipoDeEnemigo);

    }
}
