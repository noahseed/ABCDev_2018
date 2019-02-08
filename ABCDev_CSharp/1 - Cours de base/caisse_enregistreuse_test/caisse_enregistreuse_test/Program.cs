using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace caisse_enregistreuse_test
{
    class Program
    {

        static void AfficherListeProduit(string[] listeProduits, double[] prixProduits)
        {
            Console.WriteLine("LISTE DES PRODUITS");
            Console.WriteLine("NOM PRIX");
            for (int i = 0; i < listeProduits.Length; i++)
            {
                Console.WriteLine("{0} {1} euros", listeProduits[i], prixProduits[i]);
            }
        }

        static bool NomProduitEstReconnu(string nomProduit, string[] listeProduits, out int indicePrix)
        {
            bool produitExiste = false;
            indicePrix = 0;
            for (int i = 0; i < listeProduits.Length; i++)
            {
                if (nomProduit == listeProduits[i])
                {
                    produitExiste = true;
                    indicePrix = i;
                }
            }
            return produitExiste;
        }

        static void AfficherLigneAchat(string nomProduit, int quantite, double prix)
        {
            double sousTotal = quantite * prix;
            Console.WriteLine("Produit : " + nomProduit + "  Quantite : " + quantite + "  Sous-total : " + sousTotal + " euros");


        }

        static void AjouterUnAchat(ref string[,] listeAchats, string[] listeProduits, double[] prixProduits, ref int nbAchats)
        {
            string nomProduit;
            string quantite;
            Console.Write("Entrez nom produit :");
            nomProduit = Console.ReadLine();

            int indicePrix;
            if (NomProduitEstReconnu(nomProduit, listeProduits, out indicePrix))
            { // le nom du produit est reconnu 
                Console.Write("Entrez quantité produit :");
                quantite = Console.ReadLine();
                try
                {
                    int intQ = int.Parse(quantite);

                    // on enregistre la ligne d'achat
                    listeAchats[nbAchats, 0] = nomProduit;
                    listeAchats[nbAchats, 1] = quantite;
                    Console.WriteLine("*********** Ligne d'achat enregistrée ***********");
                    AfficherLigneAchat(nomProduit, intQ, prixProduits[indicePrix]);
                    nbAchats++;
                }
                catch
                {
                    // le quantite du produit n'est pas valide - Entrer un nombre entier 
                    Console.WriteLine("Quantite invalide - La ligne n'est pas enregistrée");
                }
            }
            else
            {
                // le nom du produit n'est pas reconnu
                Console.WriteLine("Nom de produit inconnu - La ligne n'est pas enregistrée");
            }


        }

        static void AfficherListeAchats(string[,] listeAchats, string[] listeProduits, double[] prixProduits, int nbAchats, out double sommeTotale)
        {
            Console.WriteLine("\n\n Liste des achats clients");
            sommeTotale = 0.0;
            for (int i = 0; i < nbAchats; i++)
            {
                string nomProduit = listeAchats[i, 0];
                int quantite = int.Parse(listeAchats[i, 1]);
                int indicePrix;
                NomProduitEstReconnu(nomProduit, listeProduits, out indicePrix);
                double prix = prixProduits[indicePrix];
                AfficherLigneAchat(nomProduit, quantite, prix);
                double sousTotal = prix * quantite;
                sommeTotale += sousTotal;
            }

            Console.WriteLine("Somme totale due par le client : " + sommeTotale + " euros");

        }

        static void CalculerRenduMonnaie(double sommeDue)
        {
            Console.WriteLine("Quelle est la somme remise par le client : ");
            double sommeRemise = double.Parse(Console.ReadLine());

            double monnaieARendre = Math.Round((sommeRemise - sommeDue),2);

            Console.WriteLine("Somme a rendre au client :" + monnaieARendre);

        }

        static void Main(string[] args)
        {
            // produits proposés par la boulangerie
            string[] listeProduits = new string[4] { "pain", "baguette", "eclair", "croissant" };

            // prix des produits
            double[] prixProduits = new double[4] { 0.8, 0.5, 0.4, 0.45 };

            // listes des achats fait par le client
            string[,] listeAchats = new string[60, 60];
            // nombre de lignes enregistrées dans la liste des achats (indice dernier achat)
            int nbAchats = 0;
            int nbAchatMax = 60;


            string achatTermine = "n";

            do
            {
                AfficherListeProduit(listeProduits, prixProduits);

                // enregistre une ligne d'achat
                AjouterUnAchat(ref listeAchats, listeProduits, prixProduits, ref nbAchats);

                Console.Write("Achat client terminé ? (o/n):");
                achatTermine = Console.ReadLine();
            }
            while (achatTermine != "o" && nbAchats < nbAchatMax);

            // Afficher la liste des achats et le total
            double sommeTotale;
            AfficherListeAchats(listeAchats, listeProduits, prixProduits, nbAchats, out sommeTotale);

            // Calcul du rendu 
            CalculerRenduMonnaie(sommeTotale);

            Console.ReadLine();

        }
    }
}
