using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_AbstractFactory

{
    class Krogan : IEnemigo
    {
        public void Ataque()
        {
            Console.WriteLine("Atacando con Energia");
        }

        public void Descripcion()
        {
            Console.WriteLine("Enemigo tipo Krogan");
        }
    }
}
