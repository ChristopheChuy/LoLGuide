using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Facade
    {
        public ChargerChampion ChargerChampion { get; private set; }
        public List<Champion> GetListChampion()
        {
            ChargerChampion.LoadChampion();
            return null;
        }
        public Champion GetChampion(int id)
        {
            return null;
        }
        public List<Champion> GetListChampion(bool favoris,bool gratuit)
        {
            return null;
        }
        public Facade()
        {
            ChargerChampion = new ChargerChampionAPI();
        }
    }
}
