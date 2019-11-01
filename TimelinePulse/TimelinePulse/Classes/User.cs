using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace TimelinePulse.Classes
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Phono { get; set; }
        public string Photo { get; set; }
    }
}
