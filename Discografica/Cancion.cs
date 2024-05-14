using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Discografica
{
    public class Cancion : IReproducible
    {
        public TimeSpan Duracion { get; set; }
        public Cancion(int minutos, int segundos) 
        {Duracion = new TimeSpan(0, minutos, segundos); }
    }
}