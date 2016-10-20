﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    /// <summary>
    /// Facade immuable de champion
    /// </summary>
   public  interface IChampion
    {
        string Nom { get; }

        int Id { get; }

        string Histoire { get; }

        IReadOnlyList<Sort> Sorts { get;}

    }
}
