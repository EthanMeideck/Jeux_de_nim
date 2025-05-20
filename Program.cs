using System;

namespace Jeux
{
    public class Jeux_nim
    {
        // Attributs du jeu
        public int nombre_batonnets;
        public bool tour; // Aussi appelé drapeau ou flag. Permettra de continuer ou non le jeu
        public string choix = "";
        public int choix_robot;
        public bool tour_utilisateur = true; // Permet à l'utilisateur de jouer
        public bool erreur_utilisateur = true; // Empêche le robot de jouer en cas d'erreur de l'utilisateur
        public bool tour_robot = false; // Permet au robot de jouer

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
            // Affichage des batonnets s'il reste au moins 1 batonnets
            if (nombre_batonnets >= 1)
            {
                string affichage_batonnets = string.Concat(Enumerable.Repeat("# ", nombre_batonnets)); // Permet d'afficher x éléments
                Console.Write(affichage_batonnets);
                Console.Write("\n" + affichage_batonnets);
                Console.Write("\n" + affichage_batonnets + "\n");
            }
        }

        public void Choix_utilisateur()
        {
            // Initialisation des variables de tour
            tour_utilisateur = erreur_utilisateur = true;
            int choix_int;
            Console.Write("\nSéléctionner un nombre de bâtonnets : ");
            string choix = Console.ReadLine();

            // Conversion du choix en nombre entier + gestion erreur de types
            try
            {
                choix_int = int.Parse(choix); // Conversion du choix de l'utilisateur
            }

            catch (System.FormatException) // Erreur si le choix est une chaine de caractère
            {
                erreur_utilisateur = false;
                return;
            }

            // Vérification du nombre choisi et retrait du nombre de batonnet choisit
            if (choix_int < 1 || choix_int > 3)
            {
                Console.WriteLine("\nEntrez un nombre entre 1 et 3.\n");
                tour_utilisateur = false;
            }

            else if (choix_int > nombre_batonnets)
            {
                Console.WriteLine("\nVous ne pouvez pas prendre plus de bâtonnets qu'il en reste !\n");
                tour_utilisateur = false;
            }

            else
            {
                // Réduction du nombre de batonnets en fonction du choix de l'utilisateur
                nombre_batonnets -= choix_int;
                Console.WriteLine("\nVous avez pris " + choix_int + " bâtonnets.\n");
            }
            Affichage_batonnets();
        }
        public void Choix_robot()
        {
            // Génération d'un nombre aléatoire entre 1 et 3
            Random aleatoire = new Random();

            if (nombre_batonnets > 3)
            {
                choix_robot = aleatoire.Next(1, 4); //4 non inclus
            }

            // Choix d'un nombre pour pas que le robot perde tout seul
            else if (nombre_batonnets == 3)
            {
                choix_robot = 2;
            }
            else if (nombre_batonnets == 2)
            {
                choix_robot = 1;
            }
            else
            {
                choix_robot = 1;
            }

            nombre_batonnets -= choix_robot;
            Console.WriteLine("\nChoix du robot : ");
            Console.WriteLine("\nLe robot a pris " + choix_robot + " bâtonnets\n");
            Affichage_batonnets();
        }
        public void Jeux()
        {
            // Appel de la méthode essentiel
            Setup();

            // Lancement du jeu
            while (tour)
            {
                tour_robot = false;
                //Vérification du nombre de batonnets & tour utilisateur
                if (nombre_batonnets > 0)
                {
                    Choix_utilisateur();
                    // Vérification de la validité du choix depuis la méthode "Choix_utilisateur"
                    if (!(erreur_utilisateur))
                    {
                        Console.WriteLine("\nEntrez un nombre valable entre 1 et 3.\n");
                        Affichage_batonnets();
                    }
                    else if (tour_utilisateur)
                    {
                        tour_robot = true;
                    }
                }
                // Vérification du nombre de batonnets pour le tour du robot
                else if (nombre_batonnets <= 0)
                {
                    // Fermeture du jeu s'il n'y a plus de batonnets.
                    tour = false;
                    Console.WriteLine("Vous avez gagné !");
                    break;
                }

                // Vérification du nombre de batonnets pour le tour de l'utilisateur
                if (nombre_batonnets > 0 && tour_robot)
                {

                    Choix_robot();
                }

                else if (nombre_batonnets <= 0)
                {
                    // Fermeture du jeu s'il n'y a plus de batonnets
                    tour = false;
                    Console.WriteLine("Vous avez perdu...");
                    break;
                }
            }
            // Option rejouer si le jeu est terminé
            if (!(tour))
            {
                Rejouer();
            }
        }

        public void Rejouer()
        {
            bool rejouer = true;

            while (rejouer)
            {
                Console.WriteLine("\nSouhaitez-vous rejouer ? (o/n) : ");
                string choix_rejouer = Console.ReadLine();
                choix_rejouer = choix_rejouer.ToUpper();

                if (choix_rejouer == "O" || choix_rejouer.ToUpper() == "OUI")
                {
                    Console.WriteLine("\nLancement d'une nouvelle partie !\n");
                    Jeux();
                    break;
                }

                else if (choix_rejouer == "N" || choix_rejouer.ToUpper() == "NON")
                {
                    Console.WriteLine("À bientôt !");
                    break;
                }
                else
                {
                    Console.WriteLine("Veuillez choisir une option valable !");
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