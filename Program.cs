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
            Choix_utilisateurs();
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

        public void Choix_utilisateurs()
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