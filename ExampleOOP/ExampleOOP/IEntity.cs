using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleOOP
{
    interface IEntity
    {
        public void SetID(int id);
        public int GetID();

        public void SetName(string name);
        public string GetName();

        public void SetCategoryID(int cateid);
        public int GetCategoryID();
    }
}
