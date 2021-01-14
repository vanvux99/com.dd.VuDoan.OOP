using System;
using System.Collections.Generic;
using System.Text;

using ExampleOOP.Entity;

namespace ExampleOOP.DAO
{
    class CategoryDAO : BaseDAO
    {
        string error;
        Database database = new Database();

        public override bool Insert(Category row)
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
                    //Database.categoryTable.Add(row);
                    database.categoryTable.Add(row);
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

        public bool Update(Category row)
        {
            bool result = true;

            try
            {
                if (row != null)
                {
                    foreach (var item in database.categoryTable)
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

        public bool Delete(Category row)
        {
            bool result = true;

            try
            {
                if (row != null)
                {
                    foreach (var item in database.categoryTable)
                    {
                        if (item.ID == row.ID)
                        {
                            database.categoryTable.Remove(item);
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

        public List<Category> FillAll()
        {
            List<Category> list = new List<Category>();

            try
            {
                if (database.categoryTable.Count > 0)
                {
                    foreach (var itemCate in database.categoryTable)
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

        public object FillById(string name)
        {
            object result = null;

            return result;
        }
    }
}
