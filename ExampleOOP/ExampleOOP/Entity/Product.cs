using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleOOP.Entity
{
    class Product : BaseRow
    {
        public Product() : base ()
        {

        }

        public Product(int id, string name, int cateid) : base(id, name, cateid)
        {

        }
    }
}
