using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace PersistanceXML
{
    [DataContract(Name = "champion")]
    class ChampionXML
    {
        /// <summary>
        /// facade immuable de champion 
        /// </summary>
        public IChampion champion { get; }

        /// <summary>
        /// id du champion a sauvegarde et a charger
        ///
        /// </summary>
        [DataMember]
        public int id
        {
            get { return champion.Id; }
            private set { }
        }

        /// <summary>
        /// nom du champion a sauvegarder
        /// </summary>
        [DataMember]
        public string Nom
        {
            get { return champion.Nom; }
            private set { }
        }

        /// <summary>
        /// histoire du champion a sauvegarder
        /// </summary>
        [DataMember]
        public string Histoire
        {
            get { return champion.Histoire; }
            private set { }
        }

        /// <summary>
        /// sorts des champion a sauvegarder
        /// </summary>
        [DataMember]
        public IReadOnlyCollection<Sort> sorts
        {
            get { return champion.Sorts; }
            private set { }
        }

        /// <summary>
        ///  constructeur de championXML
        /// </summary>
        /// <param name="champion"></param>
        public ChampionXML(IChampion champion)
        {
            this.champion = champion;
        }

    }
}
