using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Discografica
{
    public class ListaReproduccion : IMusicable
    {
        public TimeSpan DuracionTotal { get; set; }
        public int NumeroCanciones { get; set; }

        public List<IReproducible> reproducibles = new List<IReproducible>();

        public void AddCanciones(IReproducible Cancion)
        {
            reproducibles.Add(Cancion);
            DuracionTotal += Cancion.Duracion;
            NumeroCanciones++;
        }
    }
}