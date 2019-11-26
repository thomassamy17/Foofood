using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExempleCours.Models
{
    public class Photo
    {
        private string titre;
        private string url;
        private int vues;

        public Photo()
        {
            titre = url = String.Empty;
            vues = 0;
        }

        public Photo(string titre, string url)
        {
            this.titre = titre;
            this.url = url;
            this.vues = 0;
        }

        public void AugmenterLesVues()
        {
            vues++;
        }

        //Synthaxe facile pour écrire le corps d'une méthode n'ayant pas beaucoups d'éléments
        public string GetTitre2() => titre;

        /// <summary>
        /// Méthode contenant les propriétés get et set
        /// </summary>
        public string Titre
        {
            get
            {
                return titre;
            }
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("Titre trop court");
                }
                titre = value;
            }
        }

        public int Vues => vues;


    }
}