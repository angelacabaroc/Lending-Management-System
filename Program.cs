using System;

namespace Lending_Management_System1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("WELCOME TO LENDING MANAGEMENT SYSTEM");
            Console.WriteLine();
            Console.WriteLine("************LOG IN***********");
            Console.Write("Fullname: ");
            String name = Console.ReadLine();
            Console.Write("Address: ");
            String add = Console.ReadLine();
            Console.Write("Account Type: ");
            String type = Console.ReadLine();
            Console.Write("Withdrawal: ");
            String withdraw = Console.ReadLine();
            Console.Write("Deposit : ");
            String deposit = Console.ReadLine();
            Console.Write("Number of Months: ");
            int nummonth = int.Parse(Console.ReadLine());
            Console.Write("Amount of Loan: ");
            int amloan = int.Parse(Console.ReadLine());
            Console.Write("Interest Rate: ");
            int rate = int.Parse(Console.ReadLine());

            int a, b, c, d;
            a = amloan * rate;
            b = a * nummonth;
            c = b + amloan;
            d = c / nummonth;
            Console.WriteLine();
            Console.WriteLine("Per Month Interest: " + a);
            Console.WriteLine("Overall Interest Rate of Loan: " + b);
            Console.WriteLine("Total Loan Payment: " + c);
            Console.WriteLine("Monthly Payment: " + d);
            Console.WriteLine();


            Console.WriteLine();
            Console.WriteLine("*****************RESULTS*********************");
            Console.WriteLine();
            Console.WriteLine("Customer's Name: " + name);
            Console.WriteLine("Address: " + add);
            Console.WriteLine("Account Type: " + type);
            Console.WriteLine("Interest Rate: " + rate);
            Console.WriteLine("Amount of Loan: " + amloan);
            Console.WriteLine("Number of Months: " + nummonth);
            Console.WriteLine("Per Month Interest: " + a);
            Console.WriteLine("Overall Interest Rate of Loan: " + b);
            Console.WriteLine("Monthly Payment : " + d);
            Console.WriteLine("Total Loan Payment: " + c);
          



            Console.WriteLine();
            Console.WriteLine("*******************THANKYOU******************");

            




        }
    }
}
