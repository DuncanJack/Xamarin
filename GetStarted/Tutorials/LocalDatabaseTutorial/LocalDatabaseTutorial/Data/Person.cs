using System;
using SQLite;

namespace LocalDatabaseTutorial.Data
{
    public class Person
    {
        [PrimaryKey, AutoIncrement]
        public int PersonId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
