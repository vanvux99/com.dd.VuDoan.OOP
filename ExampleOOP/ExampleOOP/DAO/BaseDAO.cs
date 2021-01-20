using ExampleOOP.DAO;

using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleOOP
{
    public abstract class BaseDAO : IDAO
    {
        public const string CATEGORY = "category";
        public const string PRODUCT = "product";
        public const string ACCESSORY = "accessory";

        protected BaseDAO()
        {

        }

        public bool Insert(string nameObject, BaseRow row)
        {
            return Database.Instance.InsertTable(nameObject, row);
        }

        public bool Update(string nameObject, BaseRow row)
        {
            return Database.Instance.UpdateTable(nameObject, row);
        }

        public bool Delete(string nameObject, BaseRow row)
        {
            return Database.Instance.DeleteTable(nameObject, row);
        }

        /// <summary>
        /// select data in the BaseRow
        /// </summary>
        /// <param name="nameObject"></param>
        /// <returns> Data in select table</returns>
        public List<BaseRow> FindAll(string nameObject)
        {
            return Database.Instance.SelectTable(nameObject);
        }

        /// <summary> Find data by name
        /// 
        /// </summary>
        /// <param name="name"></param>
        /// <param name="nameObject"> </param>
        /// <returns> object in  the baseRow, data in select table </returns>
        public BaseRow FindByName(string name, string nameObject)
        {
            return null;
        }

        public BaseRow FindById(int id, string nameObject)
        {
            foreach (BaseRow item in Database.Instance.SelectTable(nameObject))
            {
                if (item.GetID() == id)
                {
                    return item;
                }
            }

            return null;
        }
    }
}
