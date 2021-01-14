using System;
using System.Collections.Generic;
using System.Text;

using ExampleOOP.Entity;

namespace ExampleOOP.DAO
{
    class ProductDAO : BaseDAO
    {
        string error;
        Database database = new Database();

        
        public override bool Insert(Product row)
        {
            bool result = true;

            try
            {
                if (row != null)
                {
                    if (row.ID.ToString() == null)
                    {
                        result = false;
                    }
                    database.instants.productTable.Add(row);
                }
                else
                {
                    error = "Object not references";
                    result = false;
                }
            }
            catch (Exception ex)
            {
                error = ex.Message.ToString();
                result = false;
            }

            return result;
        }

        public bool Update(Product row)
        {
            bool result = true;

            try
            {
                if (row != null)
                {
                    foreach (var item in database.instants.productTable)
                    {
                        if (item.ID == row.ID)
                        {
                            item.Name = row.Name;
                        }
                    }
                }
                else
                {
                    error = "Object not references";
                    result = false;
                }
            }
            catch (Exception ex)
            {
                error = ex.Message.ToString();
                result = false;
            }

            return result;
        }

        public bool Delete(Product row)
        {
            bool result = true;

            try
            {
                if (row != null)
                {
                    foreach (var item in database.instants.productTable)
                    {
                        if (item.ID == row.ID)
                        {
                            database.instants.productTable.Remove(item);
                        }
                    }
                }
                else
                {
                    error = "Object not references";
                    result = false;
                }
            }
            catch (Exception ex)
            {
                error = ex.Message.ToString();
                result = false;
            }

            return result;
        }

        public List<Product> FillAll()
        {
            List<Product> list = new List<Product>();

            try
            {
                if (database.instants.productTable.Count > 0)
                {
                    foreach (var itemCate in database.instants.productTable)
                    {
                        list.Add(itemCate);
                    }
                }
                else
                {
                    error = "Table null";
                }
            }
            catch (Exception ex)
            {
                error = ex.Message;
            }

            return list;
        }

        public Product FillById(string name)
        {
            Product result = null;

            return result;
        }

        public Product FillByName(string name)
        {
            Product result = null;

            return result;
        }

        public Product[] Search(string name)
        {
            Product[] result = null;

            return result;
        }
    }
}
