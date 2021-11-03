using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_AbstractFactory
{
    class Insecto : IEnemigo
    {
        public void Ataque()
        {
            Console.WriteLine("Lanzando Veneno!");
        }

        public void Descripcion()
        {
            Console.WriteLine("Enemigo tipo insecto");
        }
    }
}
