using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet
{
    public class Bibliobus
    {
        private string nom;
        private Livre[] livres;
        private int nbLivres;
        private int capaciteMax;

        // Constructeur
        public Bibliobus(string nom, int capaciteMax)
        {
            this.nom = nom;
            this.capaciteMax = capaciteMax;
            this.livres = new Livre[capaciteMax];
            this.nbLivres = 0;
        }

        // Accesseurs
        public string Nom => nom;
        public int NbLivres => nbLivres;
        public int CapaciteMax => capaciteMax;

        // Retourne les caractéristiques d'un livre dont on connaît l'identifiant
        public Livre GetLivre(int id)
        {
            if (id >= 0 && id < nbLivres)
                return livres[id];
            return null;
        }

        // MÉTHODES GET : Accès aux caractéristiques d'un livre par identifiant
        public string GetTitre(int identifiant)
        {
            Livre livre = GetLivre(identifiant);
            if (livre != null)
                return livre.Titre;
            return "Non trouvé";
        }

        public string GetAuteur(int identifiant)
        {
            Livre livre = GetLivre(identifiant);
            if (livre != null)
                return livre.Auteur;
            return "Non trouvé";
        }

        public string GetEditeur(int identifiant)
        {
            Livre livre = GetLivre(identifiant);
            if (livre != null)
                return livre.Editeur;
            return "Non trouvé";
        }

        public string GetGenre(int identifiant)
        {
            Livre livre = GetLivre(identifiant);
            if (livre != null)
                return livre.Genre;
            return "Non trouvé";
        }

        public int GetNbExemplaires(int identifiant)
        {
            Livre livre = GetLivre(identifiant);
            if (livre != null)
                return livre.NbExemplaires;
            return 0;
        }

        // MÉTHODES DE MODIFICATION : Modifier les caractéristiques d'un livre
        public bool ModifierTitre(int identifiant, string nouveauTitre)
        {
            Livre livre = GetLivre(identifiant);
            if (livre == null)
            {
                Console.WriteLine($"Erreur : Aucun livre trouvé avec l'identifiant {identifiant}");
                return false;
            }
            livre.Titre = nouveauTitre;
            Console.WriteLine($"Titre du livre ID {identifiant} modifié en : {nouveauTitre}");
            return true;
        }

        public bool ModifierAuteur(int identifiant, string nouvelAuteur)
        {
            Livre livre = GetLivre(identifiant);
            if (livre == null)
            {
                Console.WriteLine($"Erreur : Aucun livre trouvé avec l'identifiant {identifiant}");
                return false;
            }
            livre.Auteur = nouvelAuteur;
            Console.WriteLine($"Auteur du livre ID {identifiant} modifié en : {nouvelAuteur}");
            return true;
        }

        public bool ModifierEditeur(int identifiant, string nouvelEditeur)
        {
            Livre livre = GetLivre(identifiant);
            if (livre == null)
            {
                Console.WriteLine($"Erreur : Aucun livre trouvé avec l'identifiant {identifiant}");
                return false;
            }
            livre.Editeur = nouvelEditeur;
            Console.WriteLine($"Éditeur du livre ID {identifiant} modifié en : {nouvelEditeur}");
            return true;
        }

        public bool ModifierGenre(int identifiant, string nouveauGenre)
        {
            Livre livre = GetLivre(identifiant);
            if (livre == null)
            {
                Console.WriteLine($"Erreur : Aucun livre trouvé avec l'identifiant {identifiant}");
                return false;
            }
            livre.Genre = nouveauGenre;
            Console.WriteLine($"Genre du livre ID {identifiant} modifié en : {nouveauGenre}");
            return true;
        }

        public bool ModifierNbExemplaires(int identifiant, int newNbExemplaires)
        {
            Livre livre = GetLivre(identifiant);
            if (livre == null)
            {
                Console.WriteLine($"Erreur : Aucun livre trouvé avec l'identifiant {identifiant}");
                return false;
            }
            if (newNbExemplaires < 0)
            {
                Console.WriteLine("Erreur : Le nombre d'exemplaires ne peut pas être négatif");
                return false;
            }
            livre.NbExemplaires = newNbExemplaires;
            Console.WriteLine($"Nombre d'exemplaires du livre ID {identifiant} modifié en : {newNbExemplaires}");
            return true;
        }

        // MÉTHODES DE RECHERCHE ET DE FILTRAGE
        public int RechercherLivreParTitre(string titre)
        {
            for (int i = 0; i < nbLivres; i++)
            {
                if (livres[i].Titre.Equals(titre, StringComparison.OrdinalIgnoreCase))
                    return i;
            }
            return -1;
        }

        public void AfficherLivresParAuteur(string auteur)
        {
            Console.WriteLine($"=== Livres de l'auteur '{auteur}' ===");
            bool trouve = false;

            for (int i = 0; i < nbLivres; i++)
            {
                if (livres[i].Auteur.Equals(auteur, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"\n[ID {i}]");
                    Console.WriteLine(livres[i].ToString());
                    trouve = true;
                }
            }

            if (!trouve)
            {
                Console.WriteLine($"Aucun livre de l'auteur '{auteur}' n'a été trouvé.");
            }
        }

        public void AfficherLivresParEditeur(string editeur)
        {
            Console.WriteLine($"=== Livres de l'éditeur '{editeur}' ===");
            bool trouve = false;

            for (int i = 0; i < nbLivres; i++)
            {
                if (livres[i].Editeur.Equals(editeur, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"\n[ID {i}]");
                    Console.WriteLine(livres[i].ToString());
                    trouve = true;
                }
            }

            if (!trouve)
            {
                Console.WriteLine($"Aucun livre de l'éditeur '{editeur}' n'a été trouvé.");
            }
        }

        // MÉTHODES DE STATISTIQUES
        public int CompterLivresParGenre(string genre)
        {
            int count = 0;
            for (int i = 0; i < nbLivres; i++)
            {
                if (livres[i].Genre.Equals(genre, StringComparison.OrdinalIgnoreCase))
                    count++;
            }
            return count;
        }

        public int CompterLivresParAuteur(string auteur)
        {
            int count = 0;
            for (int i = 0; i < nbLivres; i++)
            {
                if (livres[i].Auteur.Equals(auteur, StringComparison.OrdinalIgnoreCase))
                    count++;
            }
            return count;
        }

        public int CapaciteDisponible()
        {
            return capaciteMax - nbLivres;
        }

        public bool EstPlein()
        {
            return nbLivres >= capaciteMax;
        }

        public bool EstVide()
        {
            return nbLivres == 0;
        }

        public int NombreTotalExemplaires()
        {
            int total = 0;
            for (int i = 0; i < nbLivres; i++)
            {
                total += livres[i].NbExemplaires;
            }
            return total;
        }

        // MÉTHODES D'AFFICHAGE
        public void AfficheLivre(int identifiant)
        {
            Livre livre = GetLivre(identifiant);

            if (livre == null)
            {
                Console.WriteLine($"Erreur : Aucun livre trouvé avec l'identifiant {identifiant}");
                return;
            }

            Console.WriteLine("========================================");
            Console.WriteLine($"Identifiant            : {identifiant}");
            Console.WriteLine($"Titre                  : {GetTitre(identifiant)}");
            Console.WriteLine($"Auteur                 : {GetAuteur(identifiant)}");
            Console.WriteLine($"Éditeur                : {GetEditeur(identifiant)}");
            Console.WriteLine($"Genre                  : {GetGenre(identifiant)}");
            Console.WriteLine($"Nombre d'exemplaires   : {GetNbExemplaires(identifiant)}");
            Console.WriteLine("========================================");
        }

        public void AfficheCatalogue()
        {
            Console.WriteLine($"Bibliobus : {nom}");
            Console.WriteLine($"Capacité : {nbLivres}/{capaciteMax}");
            Console.WriteLine("========================================");

            if (nbLivres == 0)
            {
                Console.WriteLine("Le catalogue est vide.");
                return;
            }

            for (int i = 0; i < nbLivres; i++)
            {
                Console.WriteLine($"\nIdentifiant : {i}");
                Console.WriteLine(livres[i].ToString());
                Console.WriteLine("----------------------------------------");
            }
        }

        public void AfficherStatistiques()
        {
            Console.WriteLine("\n========== STATISTIQUES DU BIBLIOBUS ==========");
            Console.WriteLine($"Nom du bibliobus      : {nom}");
            Console.WriteLine($"Nombre de titres      : {nbLivres}");
            Console.WriteLine($"Capacité              : {nbLivres}/{capaciteMax}");
            Console.WriteLine($"Capacité disponible   : {CapaciteDisponible()}");
            Console.WriteLine($"Total d'exemplaires   : {NombreTotalExemplaires()}");
            Console.WriteLine($"Bibliobus plein       : {(EstPlein() ? "Oui" : "Non")}");
            Console.WriteLine($"Bibliobus vide        : {(EstVide() ? "Oui" : "Non")}");
            Console.WriteLine("===============================================");
        }

        public void AfficherLivresPresents()
        {
            Console.WriteLine($"=== Livres présents dans le Bibliobus '{nom}' ===");
            bool auMoinsUn = false;

            for (int i = 0; i < nbLivres; i++)
            {
                if (livres[i].EstPresent())
                {
                    Console.WriteLine($"\n[ID {i}]");
                    Console.WriteLine(livres[i].ToString());
                    auMoinsUn = true;
                }
            }

            if (!auMoinsUn)
            {
                Console.WriteLine("Aucun livre n'est actuellement présent.");
            }
        }

        public void AfficherLivresParGenre(string genre)
        {
            Console.WriteLine($"=== Livres du genre '{genre}' dans le Bibliobus '{nom}' ===");
            bool trouve = false;

            for (int i = 0; i < nbLivres; i++)
            {
                if (livres[i].Genre.Equals(genre, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"\n[ID {i}]");
                    Console.WriteLine(livres[i].ToString());
                    trouve = true;
                }
            }

            if (!trouve)
            {
                Console.WriteLine($"Aucun livre du genre '{genre}' n'a été trouvé.");
            }
        }

        public void AfficherLivre(int id)
        {
            Livre livre = GetLivre(id);
            if (livre != null)
            {
                Console.WriteLine($"Livre ID {id} :");
                Console.WriteLine(livre.ToString());
            }
            else
            {
                Console.WriteLine($"Aucun livre trouvé avec l'ID {id}");
            }
        }

        // MÉTHODES DE GESTION : Ajouter et retirer des livres
        public bool EstConnu(Livre livre)
        {
            if (livre == null)
                return false;

            for (int i = 0; i < nbLivres; i++)
            {
                if (livres[i].Equals(livre))
                    return true;
            }
            return false;
        }

        public bool EstConnu(int id)
        {
            return id >= 0 && id < nbLivres;
        }

        public bool EstPresent(int id)
        {
            if (EstConnu(id))
                return livres[id].EstPresent();
            return false;
        }

        public bool EstPresent(Livre livre)
        {
            if (livre == null)
                return false;

            for (int i = 0; i < nbLivres; i++)
            {
                if (livres[i].Equals(livre) && livres[i].EstPresent())
                    return true;
            }
            return false;
        }

        public int NombreExemplaires(int id)
        {
            if (EstConnu(id))
                return livres[id].NbExemplaires;
            return 0;
        }

        public int NombreExemplaires(Livre livre)
        {
            if (livre == null)
                return 0;

            for (int i = 0; i < nbLivres; i++)
            {
                if (livres[i].Equals(livre))
                    return livres[i].NbExemplaires;
            }
            return 0;
        }

        public bool RetirerLivre(int id)
        {
            if (!EstConnu(id))
            {
                Console.WriteLine($"Impossible de retirer : livre ID {id} non trouvé.");
                return false;
            }

            livres[id] = livres[nbLivres - 1];
            livres[nbLivres - 1] = null;
            nbLivres--;

            Console.WriteLine($"Livre ID {id} retiré du catalogue.");
            return true;
        }

        public bool AjouterLivre(Livre livre)
        {
            if (livre == null)
            {
                Console.WriteLine("Impossible d'ajouter un livre null.");
                return false;
            }

            if (nbLivres >= capaciteMax)
            {
                Console.WriteLine($"Impossible d'ajouter le livre : le bibliobus '{nom}' est plein.");
                return false;
            }

            livres[nbLivres] = livre;
            nbLivres++;
            Console.WriteLine($"Livre '{livre.Titre}' ajouté au bibliobus (ID {nbLivres - 1}).");
            return true;
        }

        public bool AjoutLivre(string titre, string auteur, string editeur)
        {
            if (nbLivres >= capaciteMax)
            {
                Console.WriteLine($"Impossible d'ajouter le livre : le bibliobus '{nom}' est plein.");
                return false;
            }

            Livre nouveauLivre = new Livre(titre, auteur, editeur);
            livres[nbLivres] = nouveauLivre;
            nbLivres++;
            Console.WriteLine($"Livre '{titre}' ajouté au bibliobus (ID {nbLivres - 1}).");
            return true;
        }
    }
}