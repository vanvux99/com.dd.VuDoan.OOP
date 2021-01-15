using ExampleOOP.DAO;

using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleOOP
{
    public abstract class BaseDAO
    {
        Database database = new Database();

        public BaseDAO()
        {

        }

        public bool Insert(string nameObject, BaseRow row)
        {
            bool result = true;

            if (database.InsertTable(nameObject, row) == false)
                return false;

            return result;
        }

        public bool Update(string nameObject, BaseRow row)
        {
            bool result = true;

            if (database.UpdateTable(nameObject, row) == false)
                return false;

            return result;
        }

        public bool Delete(string nameObject, BaseRow row)
        {
            bool result = true;

            if (database.DeleteTable(nameObject, row) == false)
                return false;

            return result;
        }


        public List<Object> FindAll(string nameObject)
        {
            List<Object> list = new List<Object>();

            foreach (Object item in database.SelectTable(nameObject))
            {
                list.Add(item);
            }

            return list;
        }
    }
}
