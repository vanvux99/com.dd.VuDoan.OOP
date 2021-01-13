using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleOOP.Entity
{
    class Accessotion
    {
        public string Name { get; set; }

        public int ID { get; set; }

        public Accessotion()
        {

        }

        public Accessotion(int _id, string _name)
        {
            ID = _id;
            Name = _name;
        }
    }
}
