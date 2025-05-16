using System;
using System.Linq;

namespace Jeux
{
    public class Jeux_nim
    {
        // Attributs du jeu
        public int nombre_batonnets;
        public bool tour; // Aussi appelé drapeau ou flag. Permettra de continuer ou non le jeu
        public string choix = "";

        public Jeux_nim()
        {
            // Initialisation des paramètres du jeu
            Setup();
            Affichage_batonnets();
            Choix_utilisateur();
            Choix_robot();
        }

        public void Setup()
        {
            nombre_batonnets = 20;
            tour = true;
        }

        public void Affichage_batonnets()
        {
            // Affichage de tous les batonnets
            string affichage_batonnets = string.Concat(Enumerable.Repeat("# ", nombre_batonnets)); // Permet d'afficher x éléments
            Console.Write(affichage_batonnets);
            Console.Write("\n" + affichage_batonnets);
            Console.Write("\n" + affichage_batonnets);
        }

        public void Choix_utilisateur()
        {
            int choix_int;
            Console.Write("\nSéléctionner un nombre de bâtonnets : ");
            string choix = Console.ReadLine();

            // Conversion du choix en nombre entier + gestion erreur de types
            try
            {
                choix_int = int.Parse(choix);
            }

            catch (System.FormatException)
            {
                Console.WriteLine("Entrez un nombre valable entre 1 et 3.");
                return;
            }

            // Vérification du nombre choisi et retrait du nombre de batonnet choisit
            if (choix_int < 1 || choix_int > 3)
            {
                Console.WriteLine("Entrez un nombre entre 1 et 3.");
            }
            else
            {
                nombre_batonnets -= choix_int;
                Console.WriteLine("");
                Affichage_batonnets();
            }
        }
        public void Choix_robot()
        {
            // Génération d'un nombre aléatoire entre 1 et 3
            Random aleatoire = new Random();
            int choix_robot = aleatoire.Next(1, 4);
            nombre_batonnets -= choix_robot;
            Console.WriteLine("\n\nChoix du robot : \n");
            Affichage_batonnets();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Jeux_nim t = new Jeux_nim();
        }

    }
}