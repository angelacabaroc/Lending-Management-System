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

            accountNames.Add("Angela");
            accountNames.Add("Michael");
            accountNames.Add("Leni");
            accountNames.Add("Royette");
            Console.WriteLine();
            Console.WriteLine("=======================================================");
            Console.WriteLine("New Client Added!");
            accountNames.ForEach(Console.WriteLine);



        }

        public static List<int> Loans = new List<int> { };
        public void SavingsLoan()
        {

            Loans.Add(10000);
            Loans.Add(20000);
            Loans.Add(30000);
            Loans.Add(40000);
            Console.WriteLine("=======================================================");
            Console.WriteLine("Savings Loan!");
            Loans.ForEach(Console.WriteLine);

            static void client()
            {
                //code want to view the Client();

                foreach (var item in accountNames)
                {
                    Console.WriteLine(item);
                }

                static void Loan()
                {
                    //code want to view the Savings Loan();

                    foreach (var lists in Loans)
                    {
                        Console.WriteLine();
                    }

                }
            }
        }
    }
}
            
    