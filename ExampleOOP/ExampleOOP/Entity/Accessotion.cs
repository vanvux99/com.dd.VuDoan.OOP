using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleOOP.Entity
{
    class Accessotion : BaseRow
    {
        public override string Name { get; set; }

        public override int ID { get; set; }

        public Accessotion()
        {

        }

        //override
        public Accessotion(int _id, string _name)
        {
            ID = _id;
            Name = _name;
        }
    }
}
