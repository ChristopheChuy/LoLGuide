using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Facade
    {
        /// <summary>
        /// Sert à la persistance
        /// </summary>
        public ChargerChampion ChargerChampion { get; private set; }
        /// <summary>
        /// Sert à la persistane
        /// </summary>
        public SauvegarderChampion SauvegarderChampion { get; private set; }

        /// <summary>
        /// Récupère la liste des champions à partir de LoadChampion() 
        /// </summary>
        /// <returns> Task liste de IChampion </returns>
        async public Task<List<IChampion>> GetListChampion()
        {

            return await ChargerChampion.LoadChampion(); 
        }

        /// <summary>
        /// Appel la méthode de sauvegarde des données
        /// </summary>
        /// <param name="champions"></param>
        public void SauvergarderChampion(List<IChampion> champions)
        {
            SauvegarderChampion.sauvegarderChampion(champions);
        }

        //public Champion GetChampion(int id)
        //{
        //    return null;
        //}
        //public List<Champion> GetListChampion(bool favoris,bool gratuit)
        //{
        //    return null;
        //}

        /// <summary>
        /// Constructeur de la Facade
        /// </summary>
        /// <param name="chargerChampion"></param>
        /// <param name="sauvegarderChampion"></param>
        public Facade(ChargerChampion chargerChampion,SauvegarderChampion sauvegarderChampion)
        {
            this.SauvegarderChampion = sauvegarderChampion;
            this.ChargerChampion = chargerChampion;
        }
    }
}
