using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleOOP
{
    public abstract class BaseRow : IEntity
    {
        private string name;
        private int id;
        private int categoryID;

        public void SetID(int id)
        {
            this.id = id;
        }

        public int GetID()
        {
            return id;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }

        public void SetCategoryID(int cateid)
        {
            this.categoryID = id;
        }

        public int GetCategoryID()
        {
            return categoryID;
        }

        protected BaseRow()
        {

        }

        protected BaseRow(int id, string name)
        {
            this.id = id;
            this.name = name;
        }

        protected BaseRow(int id, string name, int cateid)
        {
            this.id = id;
            this.name = name;
            this.categoryID = cateid;
        }
    }
}
