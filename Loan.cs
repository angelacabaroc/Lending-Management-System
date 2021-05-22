
using System;
using System.Collections.Generic;
namespace Lending_Systems
{
    class Loan
    {

             public static List<int> Loans = new List<int> { };

        public void SavingsLoan()
        {


            Loans.Add(10000);
            Loans.Add(20000);
            Loans.Add(30000);
            Loans.Add(40000);
            Console.WriteLine("=======================================================");
            Console.WriteLine("List of Available Savings Loan!");
            Loans.ForEach(Console.WriteLine);


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

