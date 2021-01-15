using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleOOP
{
    public abstract class BaseRow
    {
        public string Name { get; set; }

        public int ID { get; set; }
        public int CategoryID { get; set; }

        public BaseRow()
        {

        }

        public BaseRow(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }

        public BaseRow(int id, string name, int cateid)
        {
            this.ID = id;
            this.Name = name;
            this.CategoryID = cateid;
        }
    }
}
