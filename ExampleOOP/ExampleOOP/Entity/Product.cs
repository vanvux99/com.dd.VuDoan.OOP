using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleOOP.Entity
{
    class Product
    {
        public int CategoryId { get; set; }

        public string Name { get; set; }

        public int ID { get; set; }

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
