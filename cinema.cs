using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM_PATHE
{
    internal class cinema
    {
        private List<film> films;
        private List<acteur> acteurs;

        public cinema(List<film> films, List<acteur> acteurs)
        {
            this.films = new List<film>();
            this.acteurs = new List<acteur>();
        }

        public List<film> Films
        {
            get { return films; }
            set { films = value; }
        }
        public List<acteur> Acteurs
        {
            get { return acteurs; }
            set { acteurs = value; }
        }
        public  cinema getInstance()
        {
            return new cinema(films,acteurs);
        }
        public void addFilm(film film)
        {
            films.Add(film);
        }
        public void addActeur(acteur acteur1)
        {
            acteurs.Add(acteur1);
        }
        public int nombreFilm()
        {
            return films.Count;
        }
        public int nombreActeur()
        {
            return acteurs.Count;
        }
        




    }
}
