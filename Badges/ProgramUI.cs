using System;
using System.Collections.Generic;
using System.Text;

namespace Badges
{
    class ProgramUI : BadgeRepository
    {
        public void Programy()
        {
            Data();
            LoadDoors();
            LoadKeys();
            Console.WriteLine("Greetings, Security Admin!");

            bool continueToRun = true;
            while (continueToRun)
            {
                Console.WriteLine("Please select one of:\n");
                Console.WriteLine("1)..........See all badges\n" +
                    "2)..........Add a badge\n" +
                    "3)..........Update a badge\n");
                string userinput = Console.ReadLine();

                switch (userinput)
                {
                    case "1":
                        {
                            ViewBadges();
                            Console.ReadKey();
                            break;
                        }

                    case "2":

                        {
                            CreateBadge();
                            break;

                        }

                    case "3":

                        {
                            UpdateBadge();                         
                            break;
                        }

                }
            }
        }
    }
}
