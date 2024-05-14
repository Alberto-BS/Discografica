using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Discografica
{
    public interface IFactoria
    {
        public IReproducible dameIreproducible(int minutos, int segundos);
    }
}