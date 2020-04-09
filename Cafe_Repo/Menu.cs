using System;
using System.Collections.Generic;
using System.Text;

namespace Cafe
{
    public enum Course { Breakfast, Lunch, Dinner, Appetizer, Drink, Dessert}
    public class Menu
    {
        public decimal Price { get; set; }
        public int ItemNumber { get; set; }
        public string Name { get; set; }
        public Course ItemType { get; set; }

        public string Description { get; set; }
        public string Ingredients { get; set; }
        public Menu() { }
      
        public Menu(decimal price, int itemnumber, string name, Course itemtype, string ingredients)
        {
            Price = price;
            ItemNumber = itemnumber;
            Name = name;
            ItemType = itemtype;
            Ingredients = ingredients;
        }
    }
}
