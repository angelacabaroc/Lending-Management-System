using System;
using System.Collections.Generic;

namespace Lending_Systems
{
    class Program
    {

        static void Main(string[] args)
        {
            borrower borrow = new Borrower();
            Loan loan = new Loan();

            string username = "angelacabaroc";
            string name = "Angela Cabaroc";
            string sex = "Female";
            string address = "San Jose , Binan Laguna";
            string accounttype = "Savings Account";
            int savingsbalance = 50000;
            int withdraw = 500;
            int deposit = 1000;


            string optionSelected;

            Console.WriteLine("========================= Welcome to Lending Management System===============================");
            Console.WriteLine();
            Console.WriteLine("Know more about your Savings: ");
            Console.WriteLine();
            Console.WriteLine("Account Type: " + accounttype);
            Console.WriteLine();
            Console.WriteLine("Type\'a\' To view your savings ");
            Console.WriteLine();
            Console.WriteLine("Type\'b\' To withdraw.");
            Console.WriteLine();
            Console.WriteLine("Type\'d\' To deposit.");
            Console.WriteLine();
            Console.WriteLine("Type\'i\' To view the information of the Client. ");
            Console.WriteLine();
            Console.WriteLine("Type\'l\' To view Loan Status.");
            Console.WriteLine();
            Console.WriteLine("Type\'x'\' To add a New Client. ");
            Console.WriteLine();
            Console.WriteLine("Type\'e\' To exit the program.");
            Console.WriteLine();

            Console.Write("Input: ");



            optionSelected = Console.ReadLine().ToLower();
            if (optionSelected.Equals("a"))
            {

            }
            else if (optionSelected.Equals("b"))
            {
                Console.WriteLine("How much would you withdraw? ");
                int savings = Convert.ToInt32(Console.ReadLine());
                savingsbalance -= withdraw;

                //savingsbalance = savingsbalance - withdraw
            }

            Console.WriteLine();
            for (; optionSelected != "e";)
            {
                if (optionSelected.Equals("a"))
                {
                    Console.WriteLine(" Available Savings: " + savingsbalance);
                    Console.WriteLine("========================================================");

                }
                else if (optionSelected.Equals("b"))
                {
                    Console.Write("How much would you withdraw?: ");
                    int wdraw = Convert.ToInt32(Console.ReadLine());
                    savingsbalance -= withdraw;
                    Console.WriteLine("====================================================");

                    //savingsbalance = savingsbalance - withdraw

                }
                else if (optionSelected.Equals("i"))
                {
                    Console.WriteLine("=============================LENDING MANAGEMENT SYSTEM==========================");
                    Console.WriteLine("Fullname: " + name);
                    Console.WriteLine("Username: " + username);
                    Console.WriteLine("Address: " + address);
                    Console.WriteLine("Sex: " + sex);
                    Console.WriteLine("Account Type: " + accounttype);
                    Console.WriteLine("Savings: " + savingsbalance);
                    Console.WriteLine("=============================================================================");
                }
                else if (optionSelected.Equals("d"))
                {
                    Console.Write("How much do will you deposit?: ");
                    int dep = Convert.ToInt32(Console.ReadLine());
                    savingsbalance += deposit;
                    Console.WriteLine("=============================================================================");

                    //savingsaccount = savingsaccount + deposit;
                }
                else if (optionSelected.Equals("x"))
                {
                    borrow.AddClient();


                }

                else if (optionSelected.Equals("l"))
                {
                    loan.loans();
                }
                else

                {
                    Console.WriteLine("Error: Invalid Selection.");
                    Console.WriteLine("==============================================================================");


                }
                Console.WriteLine();
                Console.WriteLine("Type\'a\' To view your savings ");
                Console.WriteLine();
                Console.WriteLine("Type\'b\' To withdraw.");
                Console.WriteLine();
                Console.WriteLine("Type\'d\' To deposit.");
                Console.WriteLine();
                Console.WriteLine("Type\'i\' To view the information of the Client. ");
                Console.WriteLine();
                Console.WriteLine("Type\'l\' To view Loan Status.");
                Console.WriteLine();
                Console.WriteLine("Type\'x\' To add a New Client.");
                Console.WriteLine();
                Console.WriteLine("Type\'e\' To exit the program.");
                Console.WriteLine();

                Console.Write("Input: ");

                optionSelected = Console.ReadLine().ToLower();
                Console.WriteLine();
            }
            Console.WriteLine("Program Exiting..");

        }



    }

    internal class Borrower : borrower
    {
    }
}

