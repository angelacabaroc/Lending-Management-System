using System;
using System.Collections.Generic;
using System.Text;

namespace Lending_Systems
{
    class Loan
    {

        public static List<string> Loans = new List<string> { };

        public void loans()
        {
            //Sa class po nato makikita mo sya kapag tinype mo sya sa given choices na "x" sa main program . At dito makikita mo po yung loan status mo ba

            //dito po nakalagay yung mga variable ko para maspecify sila
            var loanAmount = 50000;
            var interest = 0.08; // (8.0) kaya ganito po hindi naka percentage hindi ko pa po kase alam pano sya ilalagay kaya naka decimal form po sya
            var numberMonths = 12;
            var accountType = "Savings Account";


            string clientName, gender, occupation; ;
            int id, number;

            //dito po ikaw yung magtatype ng mismong info mo
            Console.WriteLine("Client Name: ");
            clientName = Console.ReadLine();
            Console.WriteLine("Transaction ID: ");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Occupation: ");
            occupation = Console.ReadLine();
            Console.WriteLine("Gender: ");
            gender = Console.ReadLine();
            Console.WriteLine("Phone Number: ");
            number = Convert.ToInt32(Console.ReadLine());


            // para makuha yung interest per month
            var monthlyInterest = loanAmount * interest;

            // para makuha ang overall interest ng loan per year
            var overallInterest = monthlyInterest * numberMonths;

            //para makuha ang total loan payment
            var totalloanpayment = overallInterest + loanAmount;

            //para makuha ang payment per months o hulog sa kada buwan
            var paymentperMonth = totalloanpayment / numberMonths;


            //dito naman sya na yung nagpapalabas ng buong details ng loan mo
            Console.WriteLine("==================================Loan Status=======================");
            Console.WriteLine();
            Console.WriteLine("Client Name: " + clientName);
            Console.WriteLine("Account Type: " + accountType);
            Console.WriteLine("Transaction ID: " + id);
            Console.WriteLine("Occupation: " + occupation);
            Console.WriteLine("Gender: " + gender);
            Console.WriteLine("Phone Number: " + number);
            Console.WriteLine("Amount of Loan: " + loanAmount);
            Console.WriteLine("Interest Rate: " + interest);
            Console.WriteLine("Number of Months: " + numberMonths);
            Console.WriteLine("Payment per Month: " + paymentperMonth);
            Console.WriteLine("Payment Amount: " + totalloanpayment);
            Console.WriteLine();
            Console.WriteLine("Thank you!");




        }

        static void loan()
        {
            //code want to view the loan();

            foreach (var item in Loans)
            {
                Console.WriteLine(item);
            }

        }
    }


}

