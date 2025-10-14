using Projet;
using System;

public abstract class Media
{
    private string titre;
    private string auteur;
    protected int nombreExemplaires;
    protected Bibliobus bibliobusAppartenance;

    public Media(string titre, string auteur, int nombreExemplaires = 1)
    {
        this.titre = titre.ToUpper();
        this.auteur = auteur.ToUpper();
        this.nombreExemplaires = nombreExemplaires;
        this.bibliobusAppartenance = null;
    }

    public string Titre
    {
        get { return titre; }
        set { titre = value.ToUpper(); }
    }

    public string Auteur
    {
        get { return auteur; }
        set { auteur = value.ToUpper(); }
    }

    public int NombreExemplaires
    {
        get { return nombreExemplaires; }
        set { nombreExemplaires = value; }
    }

    public Bibliobus BibliobusAppartenance
    {
        get { return bibliobusAppartenance; }
        set { bibliobusAppartenance = value; }
    }

    public abstract string AfficherInfos();
    public abstract string AfficherGenre();
}
