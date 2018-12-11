using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace DemoXamarinSQLite.Model
{
  public class Student
    { 
        [PrimaryKey,AutoIncrement]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
