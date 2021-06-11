using System;

using System.Collections.Generic;

namespace Lending_Systems
{
    class borrower
    {
        public static List<string> accountNames = new List<string> { };

        public void AddClient()
        {
            // Ang ginagawa po ng class nato ay nag aadd po sya ng client sa list at makikita mo sya pag tinype mo yung "x" sa choices.

            Console.WriteLine("Enter Client Name: ");
            accountNames.Add(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("========================================================================");
            Console.WriteLine();
            Console.WriteLine("Client Added Successfully!");
            accountNames.ForEach(Console.WriteLine);



        }

        static void client()
        {
            //code want to view the Client();

            foreach (var item in accountNames)
            {
                Console.WriteLine(item);
            }



        }
    }




}