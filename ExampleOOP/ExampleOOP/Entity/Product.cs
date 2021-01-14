using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleOOP.Entity
{
    class Product : BaseRow
    {
        public int CategoryId { get; set; }

        public override int ID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Product()
        {

        }

        public Product(int id, string name, int cateid)
        {
            ID = id;
            Name = name;
            CategoryId = cateid;
        }
    }
}
