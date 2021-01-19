using System;
using MonCatalogueProduit.Service;

namespace TestBaseDeDonner
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new CatalogueDbContext())
            {
              /* juste pour la premiere fois puis garder les categories 
               * et laisser que le produit qu'on peut l'ajouter
                
                db.Database.EnsureDeleted();
                db.Database.EnsureCreated();
            
                //ajout quelque categorie
                /**/
               /* db.Categories.Add(
                    new Categorie { NomCategorie="Bricolage"}
                    );
                db.Categories.Add(
                    new Categorie { NomCategorie = "Courses" }
                    );
                db.Categories.Add(
                    new Categorie { NomCategorie = "Menages" }
                    );
                db.Categories.Add(
                    new Categorie { NomCategorie = "Achat" }
                    );
                */
                //Ajout qlq produit
                //En deuxiéme lancement garder que les produits pour ajouter
                db.Produits.Add(new Demande {
                Designation = "Construction",
                    Lieu="Paris",
                    Description="Bonjour, j'ai besoin des personnes pour construire un mini house",
                    CategorieID=1
                });

                db.Produits.Add(new Demande
                {
                    Designation = "Achat/Vente",
                    Lieu = "Caen",
                    Description = "J'ai besoin d'une voiture rouge type Hondai budget 3000 milles euros",
                    CategorieID = 4
                });
                db.Produits.Add(new Demande
                {
                    Designation = "Prduits alimentaires",
                    Lieu = "Dinard",
                    Description = "J'ai besoin de quelq'un qui fait mes courses chaque jeudi",
                    CategorieID = 2
                });

                db.Produits.Add(new Demande
                {
                    Designation = "Ménage suite une grossesse",
                    Lieu = "Saint Malo",
                    Description = "J'ai besoin d'une personne motivé pour m'aider à faire le ménage chaque mardi dans apparetement 25 m2",
                    CategorieID = 3
                });
                db.SaveChanges();
            }
        }
    }
}