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
              
    