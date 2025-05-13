using System;
using System.Linq;

namespace Jeux
{
    public class Jeux_nim
    {
        // Attributs du jeu
        public int nombre_batonnets;
        public bool tour; // Aussi appelé drapeau ou flag. Permettra de continuer ou non le jeu

        public Jeux_nim()
        {
            // Initialisation des paramètres du jeu
            Setup();
        }

        public void Setup()
        {
            nombre_batonnets = 20;
            tour = true;
            // Affichage de tous les batonnets
            string affichage_batonnets = string.Concat(Enumerable.Repeat("# ", nombre_batonnets)); // Permet d'afficher x éléments
            Console.Write(affichage_batonnets);
            Console.Write("\n" + affichage_batonnets);
            Console.Write("\n" + affichage_batonnets);
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