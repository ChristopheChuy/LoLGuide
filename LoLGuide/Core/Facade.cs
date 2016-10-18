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
        async public Task<List<IChampion>> GetListChampion()
        {

            return await ChargerChampion.LoadChampion(); 
        }
        public Champion GetChampion(int id)
        {
            return null;
        }
        public List<Champion> GetListChampion(bool favoris,bool gratuit)
        {
            return null;
        }
        public Facade(ChargerChampion chargerChampion)
        {
            this.ChargerChampion = chargerChampion;
        }
    }
}
