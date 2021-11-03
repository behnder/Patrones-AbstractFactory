using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_AbstractFactory
{
    class RifleLaser : IArma
    {

        public string Nombre { get; private set; }
        public string Categoria { get; private set; }

        public RifleLaser()
        {
            Nombre = "Rifle Laser";
            Categoria = "Media";
        }

        public void Descripcion()
        {
            Console.Write($"nombre: {Nombre}\n Categoria: {Categoria}\n Disparo!: ");
            TipoDisparo();
        }

        public void TipoDisparo()
        {
            Console.WriteLine("disparando un rifle laser");
        }
    }
}
