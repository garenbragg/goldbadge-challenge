using System;
using System.Collections.Generic;
using System.Text;

namespace Badges
{
    class Badge
    {
        public int BadgeID { get; set; }
        public List<string> DoorAccess = new List<string>();

        public Badge() { }

        public Badge(int badgeid, List<string> dooraccess)
        {
            BadgeID = badgeid;
            DoorAccess = dooraccess;
        }
    }
}
