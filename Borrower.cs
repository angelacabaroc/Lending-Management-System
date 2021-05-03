using System;
using System.Collections.Generic;
using System.Text;

namespace Lending_Systems
{
    class Borrower
    {
        public static List<string> accountNames = new List<string> { };
    
        public void AddClient()
        {
            Console.WriteLine("Enter Client Name: ");
            accountNames.Add(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("=======================================================");
            Console.WriteLine("Client Added Successfully!");
            accountNames.ForEach(Console.WriteLine);


        }
        static void MyMethod()
        {
            //code want to view the Client();

            foreach (var item in accountNames)
            {
                Console.WriteLine(item);
            }
        }
    }
}
 