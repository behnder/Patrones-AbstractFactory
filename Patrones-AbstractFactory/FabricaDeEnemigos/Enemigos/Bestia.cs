using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_AbstractFactory
{
    class Bestia : IEnemigo
    {
        public void Ataque()
        {
            Console.WriteLine("Atacando con una mordida");
        }

        public void Descripcion()
        {
            Console.WriteLine("Enemigo tipo Bestia");
        }
    }
}
