using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM_PATHE
{
    internal class film
    {
        private string genre;
        private string resume;
        private string titre;
        private int idFilm;
        private int annee;
        private acteur acteur1;

        public film(string genre, string resume, string titre, int idFilm, int annee, acteur acteur1)
        {
            this.genre = genre;
            this.resume = resume;
            this.titre = titre;
            this.idFilm = idFilm;
            this.annee = annee;
            this.acteur1 = acteur1;
        }

        public string Genre
        {
            get { return genre; }
            set { genre = value; }
        }
        public string Titre
        {
            get { return titre; }
            set { titre = value; }
        }
        public string Resume
        {
            get { return resume; }
            set { resume = value; }
        }
        public int Annee
        {
            get { return annee; }
            set { annee = value; }
        }

        public film getInstance(string genre, string resume, string titre, int idFilm, int annee, acteur acteur1)
        {
            return new film(genre, resume, titre, idFilm, annee, acteur1);
        }

        public acteur GetActeurPrincipal()
        {
            return acteur1;
        }

        public override string ToString()
        {
            return $"Titre : {titre} Annee : {annee} Genre : {genre} Resume : {resume}";
        }

    }
}
