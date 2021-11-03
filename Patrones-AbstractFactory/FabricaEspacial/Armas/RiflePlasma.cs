using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_AbstractFactory
{
    class RiflePlasma : IArma
    {

        public string Nombre { get; private set; }
        public string Categoria { get; private set; }

        public RiflePlasma()
        {
            Nombre = "Rifle de Plasma";
            Categoria = "Pesado";
        }

        public void Descripcion()
        {
            Console.Write($"nombre: {Nombre}\n Categoria: {Categoria}\n Disparo!: ");
            TipoDisparo();
        }

        public void TipoDisparo()
        {
            Console.WriteLine("disparando un rifle de Plasma");
        }
    }
}
