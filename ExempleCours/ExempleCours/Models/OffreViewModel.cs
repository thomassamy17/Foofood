using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExempleCours.Models
{
    public class Offre
    {
        private string titre;
        private string description;
        private string url;
        private int prix;

        public Offre(int id, string titre,string description, string url, int prix)
        {
            this.Id = id;
            this.titre = titre;
            this.description = description;
            this.url = url;
            this.prix = prix;
        }
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

        public int Id { get; set; }
        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException("Description trop courte");
                }
                description = value;
            }
        }

        public string Url
        {
            get
            {
                return url;
            }
            set
            {
                url = value;
            }
        }
        public int Prix
        {
            get
            {
                return prix;
            }
            set
            {
                prix = value;
            }
        }

    }
}
