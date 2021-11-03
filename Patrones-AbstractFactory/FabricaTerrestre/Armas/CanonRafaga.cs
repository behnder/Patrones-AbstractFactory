using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_AbstractFactory

{
    class CanonRafaga : IArma
    {
        public string Nombre { get; private set; }
        public string Categoria { get; private set; }

        public CanonRafaga()
        {
            Nombre = "Arma de rafagas";
            Categoria = "Media";
        }

        public void Descripcion()
        {
            Console.Write($"nombre: {Nombre}\n Categoria: {Categoria}\n Disparo!: ");
            TipoDisparo();
        }

        public void TipoDisparo()
        {
            Console.WriteLine("disparando una rafaga de balas");
        }

    }
}
