using System;
using System.Collections.Generic;
using System.Text;

namespace Patrones_AbstractFactory

{
    class CanonSimple : IArma
    {
        public string Nombre { get ; private set ; }
        public string Categoria { get ; private set ; }

        public CanonSimple()
        {
            Nombre = "Arma de cañon simple";
            Categoria = "Pequeña";
        }

        public void Descripcion()
        {
            Console.Write($"nombre: {Nombre}\n Categoria: {Categoria}\n Disparo!: ");
            TipoDisparo();
        }

        public void TipoDisparo()
        {
            Console.WriteLine("disparando 1 bala a la vez");
        }
    }


        
}
