using ExampleOOP.Entity;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ExampleOOP.DAO
{
    class Database
    {
        public static List<Product> productTable = new List<Product>();
        public static List<Category> categoryTable = new List<Category>();
        public static List<Accessotion> accessoryTable = new List<Accessotion>();
        public Database instants;

        string error;
        const string CATEGORY = "category";
        const string PRODUCT = "product";
        const string ACCESSORY = "accessory";
        const string DELETE = "delete";
        const string TRUNCATE = "truncate";
        

        // Add data to the database
        public bool InsertTable(string name, BaseRow row)
        {
            bool result = true;
            int countTable = 0;
            int countTableLaterInsert = 0;

            try
            {
                if (row != null && name != null)
                {
                    if (name == PRODUCT)
                    {
                        countTable = productTable.Count;
                        Product parseProduct = (Product) row;

                        if (CheckId(parseProduct) == true)
                        {
                            productTable.Add(parseProduct);
                            countTableLaterInsert = productTable.Count;

                            if (CheckCountDatabase(countTable, countTableLaterInsert) == false)
                                return false;
                        }   
                        else
                            return false;
                    }
                    else if (name == CATEGORY)
                    {
                        countTable = categoryTable.Count;
                        Category parseCategory = (Category) row;

                        if (CheckId(parseCategory) == true)
                        {
                            categoryTable.Add(parseCategory);
                            countTableLaterInsert = categoryTable.Count;

                            if (CheckCountDatabase(countTable, countTableLaterInsert) == false)
                                return false;
                        }     
                        else
                            return false;
                    }
                    else if (name == ACCESSORY)
                    {
                        countTable = accessoryTable.Count;
                        Accessotion parseAsscessory = (Accessotion) row;

                        if (CheckId(parseAsscessory) == true)
                        {
                            accessoryTable.Add(parseAsscessory);
                            countTableLaterInsert = accessoryTable.Count;

                            if (CheckCountDatabase(countTable, countTableLaterInsert) == false)
                                return false;
                        }    
                        else
                            return false;
                    }
                    else
                        return false;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                error = ex.Message.ToString();
                return false;
            }

            return result;
        }

        // get the data out of the database
        public List<object> SelectTable(string name)
        {
            List<object> list = new List<object>();

            try
            {
                if (name != null)
                {
                    if (name == PRODUCT)
                    {
                        list = AddDataToList(list, productTable);
                    }
                    else if (name == CATEGORY)
                    {
                        list = AddDataToList(list, categoryTable);
                    }
                    else if (name == ACCESSORY)
                    {
                        list = AddDataToList(list, accessoryTable);
                    }
                }
            }
            catch (Exception ex)
            {
                error = ex.Message.ToString();
            }

            return list;
        }

        // update data into the database
        public bool UpdateTable(string name, BaseRow row)
        {
            bool result = true;

            try
            {
                if (row != null && name != null)
                {
                    if (name == PRODUCT)
                    {
                        if (UpdateTableAuto(name, row, productTable) == false)
                            return false;
                    }
                    else if (name == CATEGORY)
                    {
                        if (UpdateTableAuto(name, row, categoryTable) == false)
                            return false;
                    }
                    else if (name == ACCESSORY)
                    {
                        if (UpdateTableAuto(name, row, accessoryTable) == false)
                            return false;
                    }
                    else
                        return false;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                error = ex.Message.ToString();
                return false;
            }

            return result;
        }

        // delete data 
        public bool DeleteTable(string name, BaseRow row)
        {
            bool result = true;

            try
            {
                if (row != null && row != null)
                {
                    if (name == PRODUCT)
                    {
                        Product product = (Product) row;
                        DeleteTableById(productTable, product, DELETE);
                    }
                    else if (name == CATEGORY)
                    {
                        Category product = (Category) row;
                        DeleteTableById(categoryTable, product, DELETE);
                    }
                    else if (name == ACCESSORY)
                    {
                        Accessotion product = (Accessotion) row;
                        DeleteTableById(accessoryTable, product, DELETE);
                    }
                    else
                        return false;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                error = ex.Message.ToString();
                return false;
            }

            return result;
        }

        // delete all data 
        public bool TruncateTable(string name)
        {
            bool result = true;

            try
            {
                if (name != null)
                {
                    if (name == PRODUCT)
                    {
                        DeleteTableById(productTable, productTable, TRUNCATE);
                    }
                    else if (name == CATEGORY)
                    {
                        DeleteTableById(categoryTable, categoryTable, TRUNCATE);
                    }
                    else if (name == ACCESSORY)
                    {
                        DeleteTableById(accessoryTable, accessoryTable, TRUNCATE);
                    }
                    else
                        return false;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                error = ex.Message.ToString();
                return false;
            }

            return result;
        }

        // update database by id
        public bool UpdateTable(int id, string name, BaseRow row)
        {
            bool result = true;

            try
            {
                if (row != null && name != null && id.ToString() != null)
                {
                    if (name == PRODUCT)
                    {
                        if (UpdateTableById(name, row, productTable, id) == false)
                            return false;
                    }
                    else if (name == CATEGORY)
                    {
                        if (UpdateTableById(name, row, productTable, id) == false)
                            return false;
                    }
                    else if (name == ACCESSORY)
                    {
                        if (UpdateTableById(name, row, productTable, id) == false)
                            return false;
                    }
                    else
                        return false;
                }
                else
                    return false;
            }
            catch (Exception ex)
            {
                error = ex.Message.ToString();
                return false;
            }

            return result;
        }

        // check id input
        bool CheckId(dynamic value)
        {
            bool check = true;

            if (value.ID.ToString() == null)
                return false;

            return check;
        }

        // add data into the list
        List<Object> AddDataToList(List<Object> listReturn, dynamic table)
        {
            List<Object> list = new List<Object>();

            foreach (var itemPro in table)
            {
                listReturn.Add(itemPro);
            }

            return list;
        }

        // update data
        bool UpdateTableAuto(string name, BaseRow row, dynamic table)
        {
            bool check = true;

            if (name == PRODUCT)
            {
                foreach (var itemTable in table)
                {
                    Product tmp = (Product) row;

                    if (itemTable.ID == tmp.ID)
                    {
                        itemTable.Name = tmp.Name;
                        itemTable.CategoryId = tmp.CategoryID;
                        return true;
                    }
                }
            }
            else if (name == CATEGORY || name == ACCESSORY)
            {
                foreach (var itemTable in table)
                {
                    dynamic tmp = (dynamic) row;

                    if (itemTable.ID == tmp.ID)
                    {
                        itemTable.Name = tmp.Name;
                        return true;
                    }
                }
            }
            else
                return false;

            return check;
        }

        // update data by id
        bool UpdateTableById(string name, BaseRow row, dynamic table, int id)
        {
            bool check = true;

            if (name == PRODUCT)
            {
                foreach (var itemTable in table)
                {
                    Product tmp = (Product) row;

                    if (id == tmp.ID && id == itemTable.ID)
                    {
                        itemTable.Name = tmp.Name;
                        itemTable.CategoryId = tmp.CategoryID;
                        return true;
                    }
                }
            }
            else if (name == CATEGORY || name == ACCESSORY)
            {
                foreach (var itemTable in table)
                {
                    dynamic tmp = (dynamic) row;

                    if (id == tmp.ID && id == itemTable.ID)
                    {
                        itemTable.Name = tmp.Name;
                        return true;
                    }
                }
            }
            else
                return false;

            return check;
        }

        // delete data, use with method Delete and method Truncate
        bool DeleteTableById(dynamic table, dynamic row, string switchMethod)
        {
            bool check = true;

            if (switchMethod == DELETE)
            {
                foreach (var itemTable in table.ToList())
                {
                    if (itemTable.ID == row.ID)
                    {
                        table.Remove(itemTable);
                    }
                    else
                        return false;
                }
            }
            else if (switchMethod == TRUNCATE)
            {
                table.Clear();
            }
            else
                return false;

            return check;
        }

        // checks the count of the table, returns false if the count of the inserted table has not changed
        bool CheckCountDatabase(int countTable, int countTableLater)
        {
            bool check = true;

            if (countTableLater <= countTable)
                return false;

            return check;
        }
    }
}
