using ExampleOOP.Entity;

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace ExampleOOP.DAO
{
    class Database : BaseDAO
    {
        public List<Product> productTable = new List<Product>();
        public List<Category> categoryTable = new List<Category>();
        public List<Accessotion> accessoryTable = new List<Accessotion>();
        public Database instants;

        string error;
        public const string _category = "category";
        public const string _product = "product";
        public const string _accessory = "accessory";
        const string _delete = "delete";
        const string _truncate = "truncate";

        // Add data to the database
        public bool InsertTable(string name, BaseRow row)
        {
            bool result = true;

            try
            {
                if (row != null && name != null)
                {
                    if (name == _product)
                    {
                        Product parseProduct = (Product) row;
                        if (CheckId(parseProduct) == true)
                            productTable.Add(parseProduct);
                        else
                            result = false;
                    }
                    else if (name == _category)
                    {
                        Category parseCategory = (Category) row;
                        if (CheckId(parseCategory) == true)
                            categoryTable.Add(parseCategory);
                        else
                            result = false;
                    }
                    else if (name == _accessory)
                    {
                        Accessotion parseAsscessory = (Accessotion) row;
                        if (CheckId(parseAsscessory) == true)
                            accessoryTable.Add(parseAsscessory);
                        else
                            result = false;
                    }
                    else
                        result = false;
                }
                else
                    result = false;
            }
            catch (Exception ex)
            {
                error = ex.Message.ToString();
                result = false;
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
                    if (name == _product)
                    {
                        AddList(list, productTable);
                    }
                    else if (name == _category)
                    {
                        AddList(list, categoryTable);
                    }
                    else if (name == _accessory)
                    {
                        AddList(list, accessoryTable);
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
                    if (name == _product)
                    {
                        if (UpdateTableAuto(name, row, productTable) == false)
                            result = false;
                    }
                    else if (name == _category)
                    {
                        if (UpdateTableAuto(name, row, categoryTable) == false)
                            result = false;
                    }
                    else if (name == _accessory)
                    {
                        if (UpdateTableAuto(name, row, accessoryTable) == false)
                            result = false;
                    }
                    else
                        result = false;
                }
                else
                    result = false;
            }
            catch (Exception ex)
            {
                error = ex.Message.ToString();
                result = false;
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
                    if (name == _product)
                    {
                        Product product = (Product) row;
                        DeleteTableById(productTable, product, _delete);
                    }
                    else if (name == _category)
                    {
                        Category product = (Category) row;
                        DeleteTableById(categoryTable, product, _delete);
                    }
                    else if (name == _accessory)
                    {
                        Accessotion product = (Accessotion) row;
                        DeleteTableById(accessoryTable, product, _delete);
                    }
                    else
                        result = false;
                }
                else
                {
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

        // delete all data 
        public bool TruncateTable(string name)
        {
            bool result = true;

            try
            {
                if (name != null)
                {
                    if (name == _product)
                    {
                        DeleteTableById(productTable, productTable, _truncate);
                    }
                    else if (name == _category)
                    {
                        DeleteTableById(categoryTable, categoryTable, _truncate);
                    }
                    else if (name == _accessory)
                    {
                        DeleteTableById(accessoryTable, accessoryTable, _truncate);
                    }
                    else
                        result = false;
                }
                else
                {
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

        // update database by id
        public bool UpdateTable(int id, string name, BaseRow row)
        {
            bool result = true;

            try
            {
                if (row != null && name != null && id.ToString() != null)
                {
                    if (name == _product)
                    {
                        if (UpdateTableById(name, row, productTable, id) == false)
                            result = false;
                    }
                    else if (name == _category)
                    {
                        if (UpdateTableById(name, row, productTable, id) == false)
                            result = false;
                    }
                    else if (name == _accessory)
                    {
                        if (UpdateTableById(name, row, productTable, id) == false)
                            result = false;
                    }
                    else
                        result = false;
                }
                else
                {
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

        // check id input
        bool CheckId(dynamic value)
        {
            bool check = true;

            if (value.ID.ToString() == null)
            {
                check = false;
            }

            return check;
        }

        // add data into the list
        List<object> AddList(List<object> listReturn, dynamic table)
        {
            List<object> list = new List<object>();

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

            switch (name)
            {
                case _product:
                    foreach (var itemTable in table)
                    {
                        Product tmp = (Product) row;
                        if (itemTable.ID == tmp.ID)
                        {
                            itemTable.Name = tmp.Name;
                            itemTable.CategoryId = tmp.CategoryId;
                        }
                    }
                    break;
                case _accessory:
                case _category:
                    foreach (var itemTable in table)
                    {
                        dynamic tmp = (dynamic) row;
                        if (itemTable.ID == tmp.ID)
                        {
                            itemTable.Name = tmp.Name;
                        }
                    }
                    break;
                default:
                    check = false;
                    break;
            }

            return check;
        }

        // update data by id
        bool UpdateTableById(string name, BaseRow row, dynamic table, int id)
        {
            bool check = true;

            switch (name)
            {
                case _product:
                    foreach (var itemTable in table)
                    {
                        Product tmp = (Product) row;
                        if (id == tmp.ID && id == itemTable.ID)
                        {
                            itemTable.Name = tmp.Name;
                            itemTable.CategoryId = tmp.CategoryId;
                        }
                    }
                    break;
                case _accessory:
                case _category:
                    foreach (var itemTable in table)
                    {
                        dynamic tmp = (dynamic) row;
                        if (id == tmp.ID && id == itemTable.ID)
                        {
                            itemTable.Name = tmp.Name;
                        }
                    }
                    break;
                default:
                    check = false;
                    break;
            }

            return check;
        }

        // delete data, use with method Delete and method Truncate
        bool DeleteTableById(dynamic table, dynamic row, string switchMethod)
        {
            bool check = true;

            foreach (var itemTable in table.ToList())
            {
                if (switchMethod == "delete")
                {
                    if (itemTable.ID == row.ID)
                    {
                        table.Remove(itemTable);
                    }
                    else
                        check = false;
                }
                else if (switchMethod == "truncate")
                {
                    table.Remove(itemTable);
                }
                else
                    check = false;
            }
            return check;
        }
    }
}
