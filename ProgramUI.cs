using System;
using Cafe;

namespace Cafe
{
    public class ProgramUI : MenuRepository
    {
        public void Programy()
        {

            Data();

            Console.WriteLine("Greetings, Manager!");

            bool continueToRun = true;
            while (continueToRun)
            {
                Console.WriteLine("Please select one of the options below:\n");
                Console.WriteLine("1)..........View Menu\n" +
                    "2)..........Add to Menu\n" +
                    "3)..........Remove from Menu\n");
                string userinput = Console.ReadLine();

                switch (userinput)
                {
                    case "1":
                        {
                            ViewMenu();
                            Console.ReadKey();
                            break;
                        }

                    case "2":

                        {
                            Menu x = CreateFood();
                            AddToMenu(x);
                            break;

                        }

                    case "3":

                        {
                            Menu x = KillFood();
                            DeleteFromMenu(x);
                            break;
                        }

                }
            }
        }
    }
}
