using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Champion
    {

        public int Id { get; private set; }

        public string Nom { get; private set; }

        public int PrixRiotPoint { get; private set; }

        public int PrixPointInfluence { get; private set; }

        public List<string> Avantages { get; private set; }

        public List<string> Inconvenients { get; private set; }

        public string Histoire { get; private set; }

        public float TauxVictoire { get; private set; }

        public float TauxJoue { get; private set; }

        public float TauxBan { get; private set; }

        public bool Favoris { get; private set; }

        public List<Sort> Sorts { get; private set; }

        public List<Voie> Voies { get; private set; }

        public Dictionary<BarreDeForce, Int16> BarresDeForce { get; private set; }

        public Champion(int Id, string Nom, string Histoire)
        {
            this.Id = Id;
            this.Nom = Nom;
            this.Histoire = Histoire;
            Sorts = new List<Sort>();
        }

        public void addSort(List<Sort> sorts)
        {
            Sorts.AddRange(sorts);
        }

        public override string ToString()
        {
            return $"{Id} : {Nom} et {Sorts}";
        }

    }
}
