using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Champion : IChampion
    {

        public int Id { get; private set; }

        public string Nom { get; private set; }

        public int PrixRiotPoint { get; private set; }

        public int PrixPointInfluence { get; private set; }

        public IReadOnlyList<string> JouerAvec => jouerAvec.AsReadOnly();
        private List<string> jouerAvec = new List<string>();

        public IReadOnlyList<string> JouerContre=> jouerContre.AsReadOnly();
        private List<string> jouerContre = new List<string>();

        public string Histoire { get; private set; }

        public float TauxVictoire { get; private set; }

        public float TauxJoue { get; private set; }

        public float TauxBan { get; private set; }

        public bool Favoris { get; private set; }

        public IReadOnlyList<Sort> Sorts => sorts.AsReadOnly();
        private List<Sort> sorts = new List<Sort>();

        public IReadOnlyList<Voie> Voies => voies.AsReadOnly();
        private List<Voie> voies = new List<Voie>();

        public Dictionary<BarreDeForce, Int16> BarresDeForce { get; private set; }

        public Champion(int Id, string Nom, string Histoire)
        {
            this.Id = Id;
            this.Nom = Nom;
            this.Histoire = Histoire;
        }

        public void addSort(List<Sort> sorts)
        {
            sorts.AddRange(sorts);
        }

        public override string ToString()
        {
            return $"Id champion : {Id} // Nom champion : {Nom} // Sorts : \n{Sorts.Aggregate(String.Empty, (chaine, s) => chaine+$"{s.Nom} : {s.Description}\n")}";
        }

    }
}
