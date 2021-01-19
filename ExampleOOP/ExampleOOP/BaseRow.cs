﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleOOP
{
    public abstract class BaseRow
    {
        private string name;
        private int id;
        private int categoryID;

        public int CategoryID
        {
            get { return categoryID; }
            set { categoryID = value; }
        }


        public int ID
        {
            get { return id; }
            set { id = value; }
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /*public string Name { get; set; }

        public int ID { get; set; }
        public int CategoryID { get; set; }
*/
        protected BaseRow()
        {

        }

        protected BaseRow(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }

        protected BaseRow(int id, string name, int cateid)
        {
            this.ID = id;
            this.Name = name;
            this.CategoryID = cateid;
        }
    }
}
