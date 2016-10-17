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

        public List<string> JouerAvec { get; private set; }

        public List<string> JouerContre { get; private set; }

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
            JouerAvec = new List<string>();
            JouerContre = new List<string>();
        }

        public void addSort(List<Sort> sorts)
        {
            Sorts.AddRange(sorts);
        }

        public void addJouerAvec(List<string> conseils)
        {
            JouerAvec.AddRange(conseils);
        }

        public void addJouerContre(List<string> conseils)
        {
            JouerContre.AddRange(conseils);
        }

        public override string ToString()
        {
            return $"Id champion : {Id} // Nom champion : {Nom} // Sorts : \n{Sorts.Aggregate(String.Empty, (chaine, s) => chaine+$"{s.Nom} : {s.Description}\n")}";
        }

    }
}
