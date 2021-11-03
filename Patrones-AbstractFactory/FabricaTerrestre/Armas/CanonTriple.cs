using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_AbstractFactory

{
    class CanonTriple: IArma
    {
        public string Nombre { get; private set; }
        public string Categoria { get; private set; }

        public CanonTriple()
        {
            Nombre = "Arma de cañon triple";
            Categoria = "Grande";
        }

        public void Descripcion()
        {
            Console.Write($"nombre: {Nombre}\n Categoria: {Categoria}\n Disparo!: ");
            TipoDisparo();
        }

        public void TipoDisparo()
        {
            Console.WriteLine("disparando 3 balas a la vez");
        }
    }
}
