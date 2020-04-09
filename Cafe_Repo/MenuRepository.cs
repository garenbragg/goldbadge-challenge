using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe
{
    public class MenuRepository : Menu
    {
        protected readonly List<Menu> _contentMenu = new List<Menu>();
        public void ViewMenu()
        {
            foreach (Menu food in _contentMenu)
            {
                Console.WriteLine($"{food.ItemNumber}...{food.Name}...{food.Price}");
            }
        }


        public bool AddToMenu(Menu item)

        {
            int startingCount = _contentMenu.Count;
            _contentMenu.Add(item);
            bool wasAdded = (_contentMenu.Count > startingCount) ? true : false;
            return wasAdded;
        }

        public Menu CreateFood()
        {
            Console.Clear();
            Menu item = new Menu();
            Console.WriteLine("Please enter the price (format $$.cc)");
            item.Price = decimal.Parse(Console.ReadLine());
            item.ItemNumber = _contentMenu.Count + 1;
            Console.WriteLine("Please Enter the Name of Food.");
            item.Name = Console.ReadLine();
            Console.WriteLine("Select what the food is:");
            Console.WriteLine("1) Breakfast \n" +
                "2) Lunch \n" +
                "3) Dinner \n" +
                "4) Appetizer \n" +
                "5) Drink \n" +
                "6) Dessert \n");
            int typeId = int.Parse(Console.ReadLine());
            item.ItemType = (Course)typeId;
            Console.WriteLine("Please enter a brief description");
            item.Description = Console.ReadLine();
            Console.WriteLine("Please enter ingredients. Seperate each ingredient with a , please");
            string inputlist = Console.ReadLine();
            item.Ingredients = inputlist;
            return item;
            
        }

        public List<Menu> GetItem() => _contentMenu;

        public Menu GetItemByNum(int num)

        {
            foreach (Menu thing in _contentMenu)
            {
                if (thing.ItemNumber == num)
                {
                    return thing;
                }
            }
            return null;
        }

        public bool DeleteFromMenu(Menu item)

        {
            int startingCount = _contentMenu.Count;
            _contentMenu.Remove(item);
            bool wasRemoved = (_contentMenu.Count < startingCount) ? true : false;
            return wasRemoved;
        }

        public Menu KillFood() 
        {
            Console.WriteLine("Which item would you like to remove?...");
            ViewMenu();
            //List<Menu> things = _contentMenu.GetItem();
            int input = int.Parse(Console.ReadLine());
            Menu condemned = GetItemByNum(input);
            return condemned;
        }

        public void Data()
        {
            Menu Sandwhich = new Menu();
            Sandwhich.Name = "Deluxe Sandwhich";
            Sandwhich.Description = "A delicious hot sandwhich";
            Sandwhich.Ingredients = "Bread, Meat";
            Sandwhich.Price = 5.99m;
            Sandwhich.ItemNumber = 1;
            AddToMenu(Sandwhich);
            Menu Soup = new Menu();
            Soup.Name = "Komodo Soup";
            Soup.Description = "A delicious hot soup";
            Soup.Ingredients = "Soup, Bowl";
            Soup.Price = 4.99m;
            Soup.ItemNumber = 2;
            AddToMenu(Soup);
        }


    }
}
