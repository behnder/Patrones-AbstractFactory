using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_AbstractFactory
{
    class CanonRayos : IArma
    {

        public string Nombre { get; private set; }
        public string Categoria { get; private set; }

        public CanonRayos()
        {
            Nombre = "Cañón de Rayos";
            Categoria = "Pesada";
        }

        public void Descripcion()
        {
            Console.Write($"nombre: {Nombre}\n Categoria: {Categoria}\n Disparo!: ");
            TipoDisparo();
        }

        public void TipoDisparo()
        {
            Console.WriteLine("disparando un Cañón de rayos");
        }
    }
}
