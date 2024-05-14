using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Discografica
{
    public class ValidadorNormal : IValidador1
    {
        public bool IsValid(IReproducible reproducible)
        {
            return reproducible.Duracion > new TimeSpan(0, 0, 0) && reproducible.Duracion < new TimeSpan(0, 10, 0);
        }
    }
}