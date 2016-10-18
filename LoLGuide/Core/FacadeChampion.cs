using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
   public  interface FacadeChampion
    {
        string Nom { get; }
        int Id { get; }
        List<Sort> Sorts { get;}
    }
}
