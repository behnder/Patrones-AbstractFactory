using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_AbstractFactory
{
    class Turian : IEnemigo
    {
        public void Ataque()
        {
            Console.WriteLine("Atacando con velocidad aumentada");
        }

        public void Descripcion()
        {
            Console.WriteLine("Enemigo tipo Turian");
        }
    }
}
