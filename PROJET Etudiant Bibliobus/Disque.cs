using System;
using System.Collections.Generic;

namespace Projet
{
    public enum GenreDisque
    {
        CLASSIQUE,
        JAZZ,
        MUSIQUE_DU_MONDE,
        ROCK,
        POP,
        CHANSON_FRANCAISE,
        NON_SPECIFIE
    }

    public class Disque : Media
    {
        public GenreDisque Genre { get; private set; }
        public List<string> Pistes { get; private set; }

        public Disque(string titre, string auteur, GenreDisque genre,
                      List<string> pistes, int nbExemplaires = 1)
            : base(titre, auteur, nbExemplaires)
        {
            Genre = genre;
            Pistes = pistes ?? new List<string>();
        }

        public override string AfficherDetails()
        {
            return $"[DISQUE] {Titre} - {Auteur} | Genre : {Genre} | Pistes : {Pistes.Count} | Exemplaires : {NbExemplaires}";
        }
    }
}

