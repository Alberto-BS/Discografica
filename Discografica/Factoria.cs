using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Discografica
{
    public class Factoria : IFactoria
    {
        public IReproducible dameIreproducible(int minutos, int Segundos)
        {
            return new Cancion(minutos, Segundos);   
        }
    }
}