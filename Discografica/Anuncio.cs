using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Discografica
{
    public class Anuncio : IReproducible
    {
        public int Coste
        {
            get => default;
            set
            {
            }
        }

        public int Duracion { get; set; }
        TimeSpan IReproducible.Duracion { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}