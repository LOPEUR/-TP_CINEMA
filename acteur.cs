using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DM_PATHE
{
    internal class acteur
    {
        private string nom;
        private string prenom;
        private int id;
        private int annneeNaiss;

        public acteur(string nom, string prenom, int id, int anneeNaiss)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.id = id;
            this.annneeNaiss = anneeNaiss;
        }

        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int AnneeNaiss
        {
            get { return annneeNaiss; }
            set {  annneeNaiss = value; }
        }
        
        public static acteur getinstance (string nom, string prenom, int id, int anneeNaiss)
        {
            return new acteur ( nom,prenom,id,anneeNaiss);
        }

        public override string ToString()
        {
            return $"Nom : {nom} Prenom : {prenom} Année de naissance : {annneeNaiss}";
        }
    }
}
