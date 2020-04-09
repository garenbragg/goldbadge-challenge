using System;
using System.Collections.Generic;
using System.Text;

namespace Badges
{
    class BadgeRepository
    {
        Dictionary<int, List<string>> keys = new Dictionary<int, List<string>>();   //I now see that this is not needed, but it works for the instructional purposes for which it was intended
        protected readonly List<Badge> _allBadges = new List<Badge>();

        public List<string> AllDoors = new List<string>();
        public void LoadDoors()
        {
            AllDoors.Add("A1");
            AllDoors.Add("A2");
            AllDoors.Add("A3");
            AllDoors.Add("A4");
            AllDoors.Add("A5");
            AllDoors.Add("A6");
            AllDoors.Add("A7");
            AllDoors.Add("B1");
            AllDoors.Add("B2");
            AllDoors.Add("B3");
            AllDoors.Add("B4");
            AllDoors.Add("B5");
            AllDoors.Add("B6");
            AllDoors.Add("B7");
            return;
        }

        public void Data()
        {
            Badge badge1 = new Badge();
            badge1.BadgeID = 12345;
            badge1.DoorAccess.Add("A1");
            badge1.DoorAccess.Add("A2");
            badge1.DoorAccess.Add("A3");
            badge1.DoorAccess.Add("A4");
            AddBadge(badge1);
            Badge badge2 = new Badge();
            badge2.BadgeID = 67890;
            badge2.DoorAccess.Add("A5");
            badge2.DoorAccess.Add("A6");
            badge2.DoorAccess.Add("A7");
            badge2.DoorAccess.Add("B1");
            AddBadge(badge2);
            Badge badge3 = new Badge();
            badge3.BadgeID = 55555;
            badge3.DoorAccess.Add("B2");
            badge3.DoorAccess.Add("B3");
            badge3.DoorAccess.Add("B4");
            badge3.DoorAccess.Add("B5");
            AddBadge(badge3);

        }

        public bool AddBadge(Badge card)

        {
            int startingCount = _allBadges.Count;
            _allBadges.Add(card);
            bool wasAdded = (_allBadges.Count > startingCount) ? true : false;
            return wasAdded;
        }

        public void LoadKeys()
        {
            foreach (Badge card in _allBadges)
            {
                keys.Add(card.BadgeID, card.DoorAccess);
            }
        }

        public void LoadNewKey(Badge card)
        {
                keys.Add(card.BadgeID, card.DoorAccess);
        }

        public void ViewBadges()
        {
            Console.WriteLine("Badge #.......Door Access");
            
            foreach (KeyValuePair<int, List<string>> card in keys)
            {
                foreach (string door in card.Value)
                {
                    string doorname = door;

                    Console.WriteLine($"{card.Key}...{doorname}");
                }
            }
        }

        public void AddAccess(Badge card)
        {
            Console.WriteLine("Select a door this user should be able to access.");
            Console.WriteLine("All doors:");
            foreach (string door in AllDoors)
            {
                Console.WriteLine($"{door}");
            }
            string inputlist = Console.ReadLine();
            card.DoorAccess.Add(inputlist);

            Console.WriteLine("Any other doors? (y/n)");
            string yesno = Console.ReadLine();
            if (yesno == "y")
            {
                AddAccess(card);
            }
            else if (yesno == "n")
            {
                return;
            }
            else
            {
                Console.WriteLine("Invalid input, returning to home screen.");
                return;
            }
        }

        public void AddDoor_ToKeys(int enteredbadge)
        {
            List<string> doors = keys[enteredbadge];
            Console.WriteLine("Select a door this user should be able to access.");
            Console.WriteLine("All doors:");
            foreach (string door in AllDoors)
            {
                Console.WriteLine($"{door}");
            }
            string inputlist = Console.ReadLine();
            doors.Add(inputlist);

            Console.WriteLine("Any other doors? (y/n)");
            string yesno = Console.ReadLine();
            if (yesno == "y")
            {
                AddDoor_ToKeys(enteredbadge);
            }
            else if (yesno == "n")
            {
                return;
            }
            else
            {
                Console.WriteLine("Invalid input, returning to home screen.");
                return;
            }
        }

        public Badge CreateBadge()
        {
            Console.Clear();
            Badge card = new Badge();
            Console.WriteLine("Please enter the 5 digit badge number");
            card.BadgeID = int.Parse(Console.ReadLine());
            AddAccess(card);
            LoadNewKey(card);
           // keys.Add(card);
           // keys.Clear();
           // LoadKeys();
            return card;
        }

       
        public void UpdateBadge()
        {
            Console.WriteLine("What is the badge number to update?");
            int enteredbadge = int.Parse(Console.ReadLine());
            if (keys.ContainsKey(enteredbadge))
            {
                List <string> doors = keys[enteredbadge];
                foreach (string door in doors)
                {
                    Console.WriteLine($" Badge {enteredbadge} has access to {door}");
                }
            }
            Console.WriteLine("What would you like to do?\n");
            Console.WriteLine("1) Remove door \n 2) Add door");
            string userchoice = Console.ReadLine();
            switch (userchoice)
            {
                case "1":
                    {
                        RemoveDoor(enteredbadge);
                        break;
                    }
                case "2":
                    {
                        AddDoor_ToKeys(enteredbadge);
                        break;
                    }
            }
        }

        public void RemoveDoor(int enteredbadge)
        {
            List<string> doors = keys[enteredbadge];
            Console.WriteLine("Which door are we removing?");
            string deddoor = Console.ReadLine();
            if (doors.Contains(deddoor))
            {
                doors.Remove(deddoor);
            }
            foreach (string door in doors)
            {
                Console.WriteLine($"Badge {enteredbadge} has access to {door}");
            }
            Console.WriteLine("Any other doors? (y/n)");
            string yesno = Console.ReadLine();
            if (yesno == "y")
            {
                RemoveDoor(enteredbadge);
            }
            else if (yesno == "n")
            {
                return;
            }
            else
            {
                Console.WriteLine("Invalid input, returning to home screen.");
                return;
            }
        }
    }
}
