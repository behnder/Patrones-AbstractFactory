using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_AbstractFactory
{
    class Quarian : IEnemigo
    {
        public void Ataque()
        {
            Console.WriteLine("Atacando con desde el aire");
        }

        public void Descripcion()
        {
            Console.WriteLine("Enemigo tipo Quarian");
        }
    }
}
