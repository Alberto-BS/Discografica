using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Discografica
{
    public class ValidadorKorea : IValidador1
    {
        public bool IsValid(IReproducible reproducible)
        {
            return reproducible.Duracion > new TimeSpan(0, 7, 0) && reproducible.Duracion < new TimeSpan(0, 15, 0);
        }
    }
}