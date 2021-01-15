using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleOOP.Entity
{
    class Category : BaseRow
    {
        public Category() : base()
        {

        }

        public Category(int id, string name) : base(id, name)
        {

        }
    }
}
