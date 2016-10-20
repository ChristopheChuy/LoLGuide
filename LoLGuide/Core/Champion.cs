using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    public class Champion : IChampion
    {
        /// <summary>
        /// Id du champion
        /// </summary>
        public int Id { get; private set; }

        /// <summary>
        /// Nom du champion
        /// </summary>
        public string Nom { get; private set; }

        /// <summary>
        /// Prix du champion en monnaie virtuel du jeu (alimenté en monnaie réelle)
        /// </summary>
        public int PrixRiotPoint { get; private set; }

        /// <summary>
        /// Prix du champion en monnaie acquise durant les parties de jeu
        /// </summary>
        public int PrixPointInfluence { get; private set; }

        /// <summary>
        /// Conseils pour jouer le champion
        /// </summary>
        public IReadOnlyList<string> JouerAvec => jouerAvec.AsReadOnly();
        private List<string> jouerAvec = new List<string>();

        /// <summary>
        /// Conseils pour jouer contre le champion
        /// </summary>
        public IReadOnlyList<string> JouerContre=> jouerContre.AsReadOnly();
        private List<string> jouerContre = new List<string>();

        /// <summary>
        /// Histoire du champion dans l'univers du jeu
        /// </summary>
        public string Histoire { get; private set; }

        /// <summary>
        /// Taux de victoire du champion quand il est joué
        /// </summary>
        public float TauxVictoire { get; private set; }

        /// <summary>
        /// Taux de selection du champion par les joueurs
        /// </summary>
        public float TauxJoue { get; private set; }

        /// <summary>
        /// Taux d'interdiction du champion 
        /// (Chaque équipe interdit le choix de 3 champions pour une partie)
        /// </summary>
        public float TauxBan { get; private set; }

        /// <summary>
        /// Indique si l'utilisateur a mis ce champion en favoris
        /// </summary>
        public bool Favoris { get; private set; }

        /// <summary>
        /// Liste des sorst du champion
        /// </summary>
        public IReadOnlyList<Sort> Sorts => sorts.AsReadOnly();
        private List<Sort> sorts = new List<Sort>();

        /// <summary>
        /// Liste des voies où le champion peut aller (sur la carte du jeu)
        /// </summary>
        public IReadOnlyList<Voie> Voies => voies.AsReadOnly();
        private List<Voie> voies = new List<Voie>();

        /// <summary>
        /// Barres de force du champion 
        /// (1 valeur pour chaque barre représentée par un entier de 0 à 10) 
        /// </summary>
        public Dictionary<BarreDeForce, Int16> BarresDeForce { get; private set; }

        /// <summary>
        /// Constructeur du champion
        /// </summary>
        /// <param name="Id"></param>
        /// <param name="Nom"></param>
        /// <param name="Histoire"></param>
        public Champion(int Id, string Nom, string Histoire)
        {
            this.Id = Id;
            this.Nom = Nom;
            this.Histoire = Histoire;
        }

        /// <summary>
        /// Ajoute des sorts dans la liste de sorts
        /// </summary>
        /// <param name="sorts"></param>
        public void addSort(List<Sort> sorts)
        {
            sorts.AddRange(sorts);
        }

        /// <summary>
        /// Réécriture de la méthode ToString()
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"Id champion : {Id} // Nom champion : {Nom} // Sorts : \n{Sorts.Aggregate(String.Empty, (chaine, s) => chaine+$"{s.Nom} : {s.Description}\n")}";
        }

    }
}
