using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Discografica
{
    public class Coleccion02 : IWrapper
    {
        public List<IReproducible> reproducibles = new List<IReproducible>();

        public void Add()
        {
            throw new NotImplementedException();
        }

        public void DuracionTotal()
        {
            throw new NotImplementedException();
        }
    }
}