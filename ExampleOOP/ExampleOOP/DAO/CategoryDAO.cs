using System;
using System.Collections.Generic;
using System.Text;

using ExampleOOP.Entity;

namespace ExampleOOP.DAO
{
    class CategoryDAO : BaseDAO
    {
        Database database = new Database();
        const string ACCESSORY = "accessory";
        public CategoryDAO() : base()
        {

        }

        public Category FindById(int id)
        {
            Category result = new Category();

            foreach (Category item in database.SelectTable(ACCESSORY))
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
