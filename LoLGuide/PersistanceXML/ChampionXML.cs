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
        public IChampion champion { get; }
        [DataMember]
        public int id
        {
            get { return champion.Id; }
            private set { }
        }
        [DataMember]
        public string Nom
        {
            get { return champion.Nom; }
            private set { }
        }
        [DataMember]
        public string Histoire
        {
            get { return champion.Histoire; }
            private set { }
        }
        [DataMember]
        public IReadOnlyCollection<Sort> sorts
        {
            get { return champion.Sorts; }
            private set { }
        }
        public ChampionXML(IChampion champion)
        {
            this.champion = champion;
        }

    }
}
