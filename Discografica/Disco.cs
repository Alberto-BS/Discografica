using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Discografica
{
    public class Disco : IMusicable
    {
        public TimeSpan DuracionTotal {get; set;}
        public int NumeroCanciones {get; set;}

        public void AddCanciones(IReproducible Cancion)
        {
            throw new NotImplementedException();
        }
    }
}