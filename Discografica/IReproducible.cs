﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Discografica
{
    public interface IReproducible
    {
        public TimeSpan Duracion { get; set; }
    }
}