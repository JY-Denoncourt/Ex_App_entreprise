using System;

namespace Ex_A_Aff_nom_
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.Faites un programme qui affiche votre nom qui est stocké dans une variable.
            //    a.Faites un commit avec le commentaire « Exercice X complété »

            /*
            string nom;

            Console.WriteLine("Entrer votre nom : ");
            nom = Console.ReadLine();
            Console.WriteLine(nom);
            */

            //-------------------------------------------------------------------------------------------------

            //3.Faites un programme qui attend l’entrée de deux nombres, qui demande à l’utilisateur
            //  quelle opération arithmétique qu’il veut effectuer et le programme affiche le résultat.
            //      a.La méthode « Console.ReadLine() » permet de lire ce que l’utilisateur entre au clavier.
            //      b.Faites un commit avec le commentaire « Exercice X complété »

            /*
            int tot = 0;
            string choix;

            Console.WriteLine("Entrer votre nombre A : ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Entrer votre nombre B : ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("Entrer votre operation : ");
            choix = Console.ReadLine();

           
            if (choix[0] == '/') 
                tot = a / b;
            else if (choix[0] == '*') 
                tot = a * b;
            else if (choix[0] == '+') 
                tot = a + b;
            else if (choix[0] == '-')
                tot = a - b;
            else
                Console.WriteLine("Erreur ");

            Console.WriteLine($"Votre operation : {tot}");
            */

            //--------------------------------------------------------------------------------------------------

            //4.Faites une fonction qui effectue la somme des X premiers nombres premiers.Vous devez faire une fonction.

            Console.WriteLine("Some of the first x prime numbers. x = ");
            int x = int.Parse(Console.ReadLine());

            long sum = 0;
            int n = 2;
            int ctr = 0;
            
            while (ctr < x)
            {
                if (isPrime(n))
                {
                    sum += n;
                    ctr++;
                }
                n++;
            }

            Console.WriteLine(sum.ToString());






        }



        static bool isPrime(int n)
        {
            int x = (int)Math.Floor(Math.Sqrt(n));

            if (n == 1)
                return false;
            
            if (n == 2)
                return true;

            int i = 2;
            while (i <= x)
            {
                if ((n % i) == 0)
                {
                    return false;
                }
                else
                    i++;
            }
           
            return true;
        }
    }



}
