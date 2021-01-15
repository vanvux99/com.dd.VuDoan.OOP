using System;
using System.Collections.Generic;
using System.Text;

using ExampleOOP.Entity;

namespace ExampleOOP.DAO
{
    class ProductDAO : BaseDAO
    {
        Database database = new Database();
        const string PRODUCT = "product";

        public ProductDAO() : base()
        {

        }

        public Product FindByName(string name)
        {
            Product result = null;

            foreach (Product item in database.SelectTable(PRODUCT))
            {
                if (item.Name == name)
                {
                    result = item;
                }
            }

            return result;
        }

        public Product FindById( int id)
        {
            Product result = new Product();

            foreach (Product item in database.SelectTable(PRODUCT))
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
