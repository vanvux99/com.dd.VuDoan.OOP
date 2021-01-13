using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleOOP.Entity
{
    class Category
    {
        public string Name { get; set; }

        public int ID { get; set; }

        public Category()
        {

        }

        public Category(int _id, string _name)
        {
            ID = _id;
            Name = _name;
        }
    }
}
