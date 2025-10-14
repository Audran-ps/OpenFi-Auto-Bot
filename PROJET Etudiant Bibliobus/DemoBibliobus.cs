using System;
using Projet;

namespace BiblioBus
{
    public class DemoBibliobus
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("=== DÉMONSTRATION DU PROJET BIBLIOBUS ===\n");

            // Création d’un bibliobus
            Bibliobus bus1 = new Bibliobus("Bibliobus Centre-Ville", 6);

            // TEST 1 : Catalogue vide
            Console.WriteLine("\n=== TEST 1 : Catalogue vide ===");
            bus1.AfficheCatalogue();

            // TEST 2 : Ajout de livres simples
            Console.WriteLine("\n=== TEST 2 : Ajout de livres ===");
            bus1.AjoutLivre("Les Misérables", "Victor Hugo", "Gallimard");
            bus1.AjoutLivre("Harry Potter", "J.K. Rowling", "Gallimard");
            bus1.AjoutLivre("1984", "George Orwell", "Gallimard");

            // TEST 3 : Ajout de livres complets
            Console.WriteLine("\n=== TEST 3 : Ajout d'instances complètes ===");
            Livre livre4 = new Livre("Le Petit Prince", "Antoine de Saint-Exupéry", "Gallimard", "Jeunesse", 3);
            Livre livre5 = new Livre("L'Étranger", "Albert Camus", "Gallimard", "Roman", 1);
            Livre livre6 = new Livre("Le Seigneur des Anneaux", "J.R.R. Tolkien", "Christian Bourgois", "Fantasy", 2);
            bus1.AjouterLivre(livre4);
            bus1.AjouterLivre(livre5);
            bus1.AjouterLivre(livre6);

            // TEST 4 : Affichage complet
            Console.WriteLine("\n=== TEST 4 : Catalogue complet ===");
            bus1.AfficheCatalogue();

            // TEST 5 : Livres présents
            Console.WriteLine("\n=== TEST 5 : Livres présents ===");
            bus1.AfficherLivresPresents();

            // TEST 6 : Afficher un livre spécifique
            Console.WriteLine("\n=== TEST 6 : Affichage d’un livre (ID=1) ===");
            bus1.AfficheLivre(1);

            // TEST 7 : Livres par genre
            Console.WriteLine("\n=== TEST 7 : Livres du genre 'Roman' ===");
            bus1.AfficherLivresParGenre("Roman");

            // TEST 8 : Retrait d’un livre
            Console.WriteLine("\n=== TEST 8 : Retrait du livre ID=2 ===");
            bus1.RetirerLivre(2);
            Console.WriteLine("\nCatalogue après retrait :");
            bus1.AfficheCatalogue();

            // TEST 9 : Second bibliobus
            Console.WriteLine("\n=== TEST 9 : Second bibliobus ===");
            Bibliobus bus2 = new Bibliobus("Bibliobus Quartier Nord", 3);
            bus2.AjoutLivre("Germinal", "Émile Zola", "Pocket");
            bus2.AjoutLivre("Notre-Dame de Paris", "Victor Hugo", "Livre de Poche");
            Console.WriteLine("\nCatalogue du second bibliobus :");
            bus2.AfficheCatalogue();

            // TEST 10 : Informations générales
            Console.WriteLine("\n=== TEST 10 : Informations globales ===");
            Console.WriteLine($"Bus 1 - Nom : {bus1.Nom} | Livres : {bus1.NbLivres}/{bus1.CapaciteMax}");
            Console.WriteLine($"Bus 2 - Nom : {bus2.Nom} | Livres : {bus2.NbLivres}/{bus2.CapaciteMax}");

            // TEST 11 : Accès via getters
            Console.WriteLine("\n=== TEST 11 : Accès par méthodes Get ===");
            Console.WriteLine($"ID 0 : {bus1.GetTitre(0)} par {bus1.GetAuteur(0)} ({bus1.GetEditeur(0)})");
            Console.WriteLine($"ID 3 : {bus1.GetTitre(3)} [{bus1.GetGenre(3)}] - {bus1.GetNbExemplaires(3)} exemplaires");

            // TEST 12 : Statistiques
            Console.WriteLine("\n=== TEST 12 : Statistiques ===");
            bus1.AfficherStatistiques();

            // TEST 13 : Test de modification directe
            Console.WriteLine("\n=== TEST 13 : Modification de données ===");
            bus1.ModifierTitre(1, "Harry Potter à l'école des sorciers");
            bus1.ModifierNbExemplaires(1, 5);
            bus1.AfficheLivre(1);

            // TEST 14 : Test de genre inexistant
            Console.WriteLine("\n=== TEST 14 : Genre inexistant ===");
            bus1.AfficherLivresParGenre("Policier");

            // TEST 15 : Test ID invalide
            Console.WriteLine("\n=== TEST 15 : ID invalide ===");
            bus1.AfficheLivre(99);

            Console.WriteLine("\n=== FIN DE LA DÉMONSTRATION ===");
        }
    }
}
