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
        string Nom { get; set; }

        int Id { get; }

        string Histoire { get; }
        Dictionary<BarreDeForce, Int32> BarresDeForce { get; }
        List<string> Tags { get; }
        string Image { get; }
        string Titre { get; }
        List<Sort> Sorts { get;}
        bool Favoris { get; set; }

    }
}
