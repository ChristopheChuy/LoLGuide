using System;
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


        string Image { get; }
        string Titre { get; }
        List<Sort> Sorts { get;}

    }
}
