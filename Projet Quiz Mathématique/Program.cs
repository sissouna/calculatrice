using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Permet d'utiliser Console, Random, Math, etc.
using System;

// Namespace = “dossier” qui regroupe tout le projet
namespace QuizMath
{
    // Enum = liste de choix pour le niveau
    enum Niveau
    {
        Facile = 0,   // 0 correspond à Facile
        Moyen = 1,    // 1 correspond à Moyen
        Difficile = 2 // 2 correspond à Difficile
    }

    // Enum = liste de choix pour l'opération
    enum Operation
    {
        Addition = 0,       // 0 = addition
        Soustraction = 1,   // 1 = soustraction
        Multiplication = 2, // 2 = multiplication
        Division = 3,       // 3 = division
        Mixte = 4           // 4 = mixte (opération au hasard)
    }

    // Classe principale du programme
    class Program
    {
        // Point d'entrée du programme
        static void Main(string[] args)
        {
            // Permet de rejouer tant que c'est vrai
            bool rejouer = true;

            // Boucle principale : tant que rejouer est vrai, on relance une partie
            while (rejouer)
            {
                // Nettoie l'écran
                Console.Clear();

                // Titre
                Console.WriteLine(" QUIZ MATHEMATIQUE ");

                // Demande le nombre de questions (entre 1 et 10) en vérifiant l'entrée
                int nbQuestions = LireEntier("A Combien de Questions Souhaitez vous Répondre ?   ( de 1 à 10 ) : ", 1, 10);

                // Demande le niveau (0 à 2) puis conversion en enum Niveau
                Niveau niveau = (Niveau)LireEntier(
                    "\nChoisissez le Niveau des Questions :\n0-Facile\n1-Moyen\n2-Difficile\n> ", 0, 2);

                // Demande l'opération (0 à 4) puis conversion en enum Operation
                Operation operation = (Operation)LireEntier(
                    "\nLe type de calcule :\n0-Addition\n1-Soustraction\n2-Multiplication\n3-Division\n4-Mixte\n> ", 0, 4);

                // Compteurs
                int bonnes = 0;
                int mauvaises = 0;

                // Générateur de nombres aléatoires
                Random rnd = new Random();

                // Boucle : on pose nbQuestions questions
                for (int i = 1; i <= nbQuestions; i++)
                {
                    // Nettoie l'écran
                    Console.Clear();

                    // Affiche le numéro de question
                    Console.WriteLine("Question " + i + "/" + nbQuestions);

                    // max = limite des nombres selon le niveau
                    int max;
                    if (niveau == Niveau.Facile) max = 10;
                    else if (niveau == Niveau.Moyen) max = 50;
                    else max = 100;

                    // Deux nombres aléatoires
                    int a = rnd.Next(1, max);
                    int b = rnd.Next(1, max);

                    // Opération réelle utilisée dans cette question
                    Operation op;
                    if (operation == Operation.Mixte)
                        op = (Operation)rnd.Next(1, 5); // 1 à 4 (pas 5)
                    else
                        op = operation;

                    // Calcul de la bonne réponse
                    double bonneRep = Calculer(a, b, op);

                    // Affiche la question
                    Console.Write(a + " " + Symbole(op) + " " + b + " = ");

                    // Réponse utilisateur
                    double repUser;

                    // Tant que l’utilisateur n’a pas entré un nombre valide, on recommence
                    while (!double.TryParse(Console.ReadLine(), out repUser))
                    {
                        Console.Write("Entrée invalide. Réessayez : ");
                    }

                    // Vérifie la réponse (avec petite tolérance)
                    if (Math.Abs(repUser - bonneRep) < 0.0001)
                  
                    {
                        Console.WriteLine("Félicitation, c'était la bonne réponse !");
                        bonnes++;
                    }
                    else
                    {
                        Console.WriteLine("Vous étes nul. La bonne réponse était : " + bonneRep);
                        mauvaises++;
                    }

                    // Pause
                    Console.WriteLine("Appuyez sur une touche...");
                    Console.ReadKey();
                }

                // Résultats finaux
                Console.Clear();
                Console.WriteLine(" RESULTATS ");
                Console.WriteLine("Bonnes réponses : " + bonnes);
                Console.WriteLine("Mauvaises réponses : " + mauvaises);

                // Score en pourcentage
                double score = (double)bonnes / nbQuestions * 100.0;
                Console.WriteLine("Score final : " + score.ToString("0.0") + "%");

                // Verdict
                if (score >= 50) Console.WriteLine(" Réussite !");
                else Console.WriteLine(" Vous étes NUL ...");

                // Demande si on rejoue
                Console.Write("\nRejouer ? (O/N) : ");
                string c = Console.ReadLine().ToUpper();
                rejouer = (c == "O");
            }

            // Fin du programme
            Console.WriteLine("Merci à vous d'avoir joué !");
        }

        // Calcule le résultat selon l'opération
        static double Calculer(int a, int b, Operation op)
        {
            switch (op)
            {
                case Operation.Addition: return a + b;
                case Operation.Soustraction: return a - b;
                case Operation.Multiplication: return a * b;
                case Operation.Division: return Math.Round((double)a / b, 2);
            }
            return 0;
        }

        // Donne le symbole à afficher
        static string Symbole(Operation op)
        {
            switch (op)
            {
                case Operation.Addition: return "+";
                case Operation.Soustraction: return "-";
                case Operation.Multiplication: return "×";
                case Operation.Division: return "÷";
            }
            return "+";
        }

        // Demande un entier et vérifie qu'il est entre min et max
        static int LireEntier(string msg, int min, int max)
        {
            int n;
            Console.Write(msg);

            while (!int.TryParse(Console.ReadLine(), out n) || n < min || n > max)
            {
                Console.Write("Veuillez entrer un nombre entre " + min + " et " + max + " : ");
            }

            return n;
        }
    }
}
