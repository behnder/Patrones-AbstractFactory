using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_AbstractFactory
{
    class Humano : IEnemigo
    {
        public void Ataque()
        {
            Console.WriteLine("Lanzando Puñetazo");
        }

        public void Descripcion()
        {
            Console.WriteLine("Enemigo tipo Humano");
        }
    }
}
