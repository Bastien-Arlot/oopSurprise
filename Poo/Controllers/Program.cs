using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


namespace Poo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<Inventaire> items = File.ReadAllLines("./inventaires.tsv")
                .Skip(1)
                .Select(line => Inventaire.FromTsv(line))
                .ToList();

            if (welcome())
            {
                foreach (Inventaire obj in items)
                {
                    Console.WriteLine(obj.Prettify());
                }
            }
            
        }

        public static bool welcome()
        {
            Console.WriteLine("Bonjour Madame l'entrepreneuse voulez-vous accéder à la liste des items ?");
            Console.WriteLine("Oui / Non ?");
            string userInput = Console.ReadLine();
            userInput = userInput.ToLower();

            if (userInput == "oui")
            {
                return true;
            }else if (userInput == "non")
            {
                Console.WriteLine("Très bien c'est noté, au revoir!");
                return false;
            }
            else
            {
                Console.WriteLine("Ce choix n'est pas disponible, au revoir");
                return false;
            }


        }
    }

}