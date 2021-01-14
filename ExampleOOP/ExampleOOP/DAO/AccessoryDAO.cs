using System;
using System.Collections.Generic;
using System.Text;

using ExampleOOP.Entity;

namespace ExampleOOP.DAO
{
    class AccessoryDAO : BaseDAO
    {
        string error;
        Database database = new Database();

        public AccessoryDAO()
        { }

        public override bool Insert(Accessotion row)
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
                    database.accessoryTable.Add(row);
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

        public bool Update(Accessotion row)
        {
            bool result = true;

            try
            {
                if (row != null)
                {
                    foreach (var item in database.accessoryTable)
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

        public bool Delete(Accessotion row)
        {
            bool result = true;

            try
            {
                if (row != null)
                {
                    foreach (var item in database.accessoryTable)
                    {
                        if (item.ID == row.ID)
                        {
                            database.instants.accessoryTable.Remove(item);
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

        public List<Accessotion> FillAll()
        {
            List<Accessotion> list = new List<Accessotion>();

            try
            {
                if (database.instants.accessoryTable.Count > 0)
                {
                    foreach (var itemCate in database.accessoryTable)
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

        public Accessotion FillById(string name)
        {
            Accessotion result = null;

            return result;
        }

        public Accessotion FillByName(string name)
        {
            Accessotion result = null;

            return result;
        }

        public Accessotion[] Search(string name)
        {
            Accessotion[] result = null;

            return result;
        }
    }
}
