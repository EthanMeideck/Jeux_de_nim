using System;
using System.Linq;

namespace Jeux
{
    public class Jeux_nim
    {
        // Attributs du jeu
        public int nombre_batonnets = 20;
        public bool tour = true;

        public void Setup()
            {
            string affichage_batonnets = string.Concat(Enumerable.Repeat("# ", nombre_batonnets));
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
            t.Setup();
        }

    }
}