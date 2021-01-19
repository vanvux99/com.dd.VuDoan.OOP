using ExampleOOP.DAO;

using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleOOP
{
    public abstract class BaseDAO
    {
        public const string CATEGORY = "category";
        public const string PRODUCT = "product";
        public const string ACCESSORY = "accessory";

        protected BaseDAO()
        {

        }

        public bool Insert(string nameObject, BaseRow row)
        {
            bool result = true;

            if (Database.Instance.InsertTable(nameObject, row) == false)
                return false;

            return result;
        }

        public bool Update(string nameObject, BaseRow row)
        {
            bool result = true;

            if (Database.Instance.UpdateTable(nameObject, row) == false)
                return false;

            return result;
        }

        public bool Delete(string nameObject, BaseRow row)
        {
            bool result = true;

            if (Database.Instance.DeleteTable(nameObject, row) == false)
                return false;

            return result;
        }


        public List<Object> FindAll(string nameObject)
        {
            List<Object> list = new List<Object>();

            foreach (Object item in Database.Instance.SelectTable(nameObject))
            {
                list.Add(item);
            }

            return list;
        }

        public BaseRow FindByName(string name, string nameObject)
        {
            BaseRow result = null;

            foreach (BaseRow item in Database.Instance.SelectTable(nameObject))
            {
                if (item.Name == name)
                {
                    result = item;
                }
            }

            return result;
        }

        public BaseRow FindById(int id, string nameObject)
        {
            BaseRow result = null;

            foreach (BaseRow item in Database.Instance.SelectTable(nameObject))
            {
                if (item.ID == id)
                {
                    result = item;
                }
            }

            return result;
        }
    }
}
