### Jeux de nim ###

__**Description**__
- Projet réalisé en 1ère année de BTS SIO et uniquement en cours. Ce projet est de type portfolio et à comme but de nous faire apprendre la programmation en C# de façon ludique.
- Date de la lancement du projet : Mai 2025.
- Date de la fin du projet : Mai 2025.

__**📖 Règles du jeux :**__

  1. Le jeux démarre avec 20 bâtonnets.
  2. Le jeu se joue uniquement contre un ordinateur.
  3. Chaque joueur peut prendre entre 1 et 3 bâtonnets inclus.
  4. Le joueur prenant le dernier bâtonnet perd la partie.
  5. À la fin de la partie, le joueur aura le choix de rejouer ou non.
  6. Si le choix d'un joueur est supérieur au nombre de bâtonnets restant, ce dernier devra rejouer.
  7. Si le choix du joueur est invalide (lettres, caractères spéciaux, chiffre strictement inférieur à 1 ou strictement supérieur à 3), le joueur devra rejouer.
  
  Bon jeu 😁

🛠️ ####Caractéristique technique :

__**⚙️ Technologie utilisé :**__
- Langage : C#
- Environnement : Console .NET

__**📂 Organisation du code :**__
- Class ***Jeux_nim***
- Méthode *Setup* (Initialisation des paramètres du jeu)
- Méthode *Affichage_batonnets* (Affiche les bâtonnets dans la console)
- Méthode *Choix_utilisateur* (Permet à l'utilisateur de choisir le nombre de bâtonnets à retirer)
- Méthode *Choix_robot* (Permet au robot de choisir le nombre de bâtonnets à retirer)
- Méthode *Jeux* (Déroulement complet du jeu)
- Méthode *Rejouer* (Permet de rejouer une fois la partie terminé)

__**🎮 Lancement du jeu**__
1. Ouvrir le répertoire du projet dans une console.
2. Une fois dans le répertoire du projet, effectuer la commande **dotnet run**

__**🔎 Comment je m'y suis pris ?**__
1. J'ai commencé par réalisé les **algorigrammes de chaque fonctionnalité** sur *Draw.io*
2. J'ai ensuite commencé à développer les fonctionnalité de bases tels que l'affichage des bâtonnets, les choix de l'utilisateur et du robot... Celà sans gestion d'erreur.
3. Après ça, j'ai conçu la méthode **jeu**. La toute première version est déjà prête !
4. Par la suite, j'ai développé la première version de la méthode **rejouer**.
5. Enfin, j'ai réglé tous les bugs étant crée par l'utilisateur (mauvais type d'entrée, nombre invalide...)
