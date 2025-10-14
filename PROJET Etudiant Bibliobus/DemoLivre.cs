using Projet;
using System;

namespace BiblioBus
{
    public class DemoLivre
    {
        public static void Main(string[] args)
        {
            Livre livre1 = new Livre("Les Misérables", "Victor Hugo", "Gallimard");
            Livre livre2 = new Livre("Harry Potter", "J.K. Rowling", "Gallimard", "Littérature jeunesse", 5);

            Console.WriteLine("=== Livre 1 ===");
            Console.WriteLine($"Titre : {livre1.Titre}, Auteur : {livre1.Auteur}, Éditeur : {livre1.Editeur}, Genre : {livre1.Genre}");

            Console.WriteLine("\n=== Livre 2 ===");
            Console.WriteLine($"Titre : {livre2.Titre}, Auteur : {livre2.Auteur}, Éditeur : {livre2.Editeur}, Genre : {livre2.Genre}, Exemplaires : {livre2.NbExemplaires}");
        }
    }
}