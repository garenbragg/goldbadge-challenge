using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Cafe;

namespace Cafe
{
    class CafeTest
    {
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethod]
        public void MyTestMethod()
        {
            Menu Coffee = new Menu();
            Coffee.Name = "Coffee";
            Coffee.Description = "A delicious hot sandwhich";
            Coffee.Ingredients = "Bread, Meat";
            Coffee.Price = 2.99m;
            Coffee.ItemNumber = 3;
            AddToMenu(Coffee);
            Menu Pizza = new Menu();
            Pizza.Name = "Komodo Soup";
            Pizza.Description = "A delicious hot soup";
            Pizza.Ingredients = "Soup, Bowl";
            Pizza.Price = 4.99m;
            Pizza.ItemNumber = 4;
            AddToMenu(Soup);

        }
    }
}
