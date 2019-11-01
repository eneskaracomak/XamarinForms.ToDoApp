using SQLite;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace TimelinePulse.Classes
{
   public class Item
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string Status { get; set; }

        public string Color { get; set; }
        public string dateTime { get; set; }
        public string time { get; set; }
        public string Photo { get; set; }
    }
}
