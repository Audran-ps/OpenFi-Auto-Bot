using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    public class Livre
    {
        private string titre;
        private string auteur;
        private string editeur;
        private string genre;
        private int nbExemplaires;

        // Constructeur sans genre
        public Livre(string titre, string auteur, string editeur)
        {
            this.titre = titre;
            this.auteur = auteur;
            this.editeur = editeur;
            this.genre = "Non spécifié";
            this.nbExemplaires = 0;
        }

        // Constructeur avec genre
        public Livre(string titre, string auteur, string editeur, string genre, int nbExemplaires = 0)
        {
            this.titre = titre;
            this.auteur = auteur;
            this.editeur = editeur;
            this.genre = genre;
            this.nbExemplaires = nbExemplaires >= 0 ? nbExemplaires : 0;
        }

        // Accesseurs (lecture seule pour titre, auteur, éditeur)
        public string Titre => titre;
        public string Auteur => auteur;
        public string Editeur => editeur;

        public string Genre
        {
            get => genre;
            set => genre = value;
        }

        public int NbExemplaires => nbExemplaires;
        public void NouvelExemplaire()
        {
            nbExemplaires++;
        }

        // Ajoute plusieurs exemplaires
        public void NouvelExemplaire(int nb)
        {
            if (nb > 0)
                nbExemplaires += nb;
        }

        // Perte d’un exemplaire
        public void PerteExemplaire()
        {
            if (nbExemplaires > 0)
                nbExemplaires--;
        }
    }
}