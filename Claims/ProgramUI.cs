using System;
using System.Collections.Generic;
using System.Text;

namespace Claims
{
    class ProgramUI : ClaimsRepository
    {
        public void Programy()
        {

            Data();

            Console.WriteLine("Greetings, claims adjuster!"); //Is this scenario for an adjuster or an agent? Doesn't matter - nobody cares.

            bool continueToRun = true;
            while (continueToRun)
            {
                Console.WriteLine("Please select one of the options below:\n");
                Console.WriteLine("1)..........See all claims\n" +
                    "2)..........Take care of next claim\n" +
                    "3)..........Enter a new claim\n");
                string userinput = Console.ReadLine();

                switch (userinput)
                {
                    case "1":
                        {
                            ViewAll();
                            Console.ReadKey();
                            break;
                        }

                    case "2":

                        {
                            Claim x = NextClaim();
                            DealNow(x);
                            break;

                        }

                    case "3":

                        {
                            Claim x = CreateClaim();
                            AddClaim(x);
                            break;
                        }

                }
            }
        }
    }
}
