using System;

namespace Jeux
{
    public class Jeux_nim
    {
        // Attributs du jeu
        public int nombre_batonnets;
        public bool tour; // Aussi appelé drapeau ou flag. Permettra de continuer ou non le jeu
        public string choix = "";
        public bool tour_utilisateur = true;
        public bool tour_robot = true;
        public string gagnant = "";

        public Jeux_nim()
        {
            // Initialisation des paramètres du jeu
            Jeux();
        }

        public void Setup()
        {
            nombre_batonnets = 20;
            tour = true;
            Affichage_batonnets();
        }

        public void Affichage_batonnets()
        {
        string affichage_batonnets = string.Concat(Enumerable.Repeat("# ", nombre_batonnets)); // Permet d'afficher x éléments
        Console.Write(affichage_batonnets);
        Console.Write("\n" + affichage_batonnets);
        Console.Write("\n" + affichage_batonnets);
        }

        public void Choix_utilisateur()
        {
            tour_utilisateur = true;
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
                tour_utilisateur = false;
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
            int choix_robot = aleatoire.Next(1, 4); //4 non inclus
            nombre_batonnets -= choix_robot;
            Console.WriteLine("\n\nChoix du robot : \n");
            Affichage_batonnets();
        }
        public void Jeux()
        {
            // Appel des méthodes essentiel
            Setup();
            
            // Lancement du jeu
            while (tour)
            {
                //Vérification du nombre de batonnets & tour utilisateur
                if (nombre_batonnets > 0)
                {
                    Choix_utilisateur();
                    // Vérification de la validité du choix
                    if (!(tour_utilisateur))
                    {
                        Console.WriteLine("Entrez un nombre valable entre 1 et 3.");
                    }

                 // Vérification du nombre de batonnets & tour du robot
                    else if (nombre_batonnets <= 0)
                    {
                        tour = false;
                        Console.WriteLine("Fin 1");
                        break;
                    }
                    Console.WriteLine(nombre_batonnets);
                    // Vérification de la validité du choix & tour utilisateur
                    if (nombre_batonnets > 0)
                    {
                        try
                        {
                            Choix_robot();
                        }
                        catch (System.ArgumentOutOfRangeException)
                        {
                            Console.WriteLine("Fin 2");
                            break;
                        }
                    }

                    else if (nombre_batonnets <= 0)
                    {
                        tour = false;
                        Console.WriteLine("Fin 2");
                        break;
                    }
                }
            }
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