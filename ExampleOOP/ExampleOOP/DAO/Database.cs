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


        public bool InsertTable(string name, dynamic row)
        {
            bool result = true;

            try
            {
                if (row != null)
                {
                    switch (name)
                    {
                        case "productTable":
                            Product tmp = (Product) row;
                            int id = tmp.CategoryId;
                            if (tmp.ID.ToString() == null)
                            {
                                result = false;
                            }
                            productTable.Add(tmp);
                            break;

                        case "categoryTable":
                            Category parseCategory = (Category) row;
                            if (parseCategory.ID.ToString() == null)
                            {
                                result = false;
                            }
                            categoryTable.Add(parseCategory);
                            break;

                        case "accessoryTable":
                            Accessotion parseAsscessory = (Accessotion) row;
                            if (parseAsscessory.ID.ToString() == null)
                            {
                                result = false;
                            }
                            accessoryTable.Add(parseAsscessory);
                            break;

                        default:
                            result = false;
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                error = ex.Message.ToString();
                result = false;
            }

            return result;
        }

        public List<object> SelectTable(string name) 
        {
            List<object> list = new List<object>();
            try
            {
                switch (name)
                {
                    case "productTable":
                        foreach (var itemPro in productTable)
                        {
                            list.Add(itemPro);
                        }
                        break;

                    case "categoryTable":
                        foreach (var itemCate in categoryTable)
                        {
                            list.Add(itemCate);
                        }
                        break;

                    case "accessoryTable":
                        foreach (var itemAcces in accessoryTable)
                        {
                            list.Add(itemAcces);
                        }
                        break;
                    default:
                        error = "Truyền sai tên object";
                        break;
                }
            }
            catch (Exception ex)
            {
                error = ex.Message.ToString();
            }

            return list;
        }

        public bool UpdateTable(object name, object row)
        {
            bool result = true;

            try
            {
                if (row != null)
                {
                    switch (name)
                    {
                        case "productTable":
                            foreach (var item in productTable)
                            {
                                Product tmp = (Product) row;
                                if (item.ID == tmp.ID)
                                {
                                    item.Name = tmp.Name;
                                    item.CategoryId = tmp.CategoryId;
                                }
                            }
                            break;

                        case "categoryTable":
                            foreach (var item in categoryTable)
                            {
                                Category tmp = (Category) row;
                                if (item.ID == tmp.ID)
                                {
                                    item.Name = tmp.Name;
                                }
                            }
                            break;

                        case "accessoryTable":
                            foreach (var item in accessoryTable)
                            {
                                Accessotion tmp = (Accessotion) row;
                                if (item.ID == tmp.ID)
                                {
                                    item.Name = tmp.Name;
                                }
                            }
                            break;

                        default:
                            result = false;
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                error = ex.Message.ToString();
                result = false;
            }

            return result;
        }

        public bool DeleteTable(object name, object row)
        {
            bool result = true;

            try
            {
                if (row != null)
                {
                    switch (name)
                    {
                        case "productTable":
                            foreach (var item in productTable.ToList())
                            {
                                Product tmp = (Product) row;
                                if (item.ID == tmp.ID)
                                {
                                    productTable.Remove(item);
                                }
                            }
                            break;

                        case "categoryTable":
                            foreach (var item in categoryTable.ToList())
                            {
                                Category tmp = (Category) row;
                                if (item.ID == tmp.ID)
                                {
                                    categoryTable.Remove(item);
                                }
                            }
                            break;

                        case "accessoryTable":
                            foreach (var item in accessoryTable.ToList())
                            {
                                Accessotion tmp = (Accessotion) row;
                                if (item.ID == tmp.ID)
                                {
                                    accessoryTable.Remove(item);
                                }
                            }
                            break;
                        default:
                            result = false;
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                error = ex.Message.ToString();
                result = false;
            }

            return result;
        }

        public bool TruncateTable(object name)
        {
            bool result = true;

            try
            {
                switch (name)
                {
                    case "productTable":
                        foreach (var listProduct in productTable.ToList())
                        {
                            productTable.Remove(listProduct);
                        }
                        break;

                    case "categoryTable":
                        foreach (var listCategory in categoryTable.ToList())
                        {
                            categoryTable.Remove(listCategory);
                        }
                        break;

                    case "accessoryTable":
                        foreach (var listAccessory in accessoryTable.ToList())
                        {
                            accessoryTable.Remove(listAccessory);
                        }
                        break;

                    default:
                        break;
                }
            }
            catch (Exception ex)
            {
                error = ex.Message.ToString();
                result = false;
            }

            return result;
        }

        public bool UpdateTable(int id, string name, object row)
        {
            bool result = true;

            try
            {
                if (row != null && name != null)
                {
                    switch (name)
                    {
                        case "productTable":
                            foreach (var item in productTable)
                            {
                                Product tmp = (Product) row;
                                if (id == tmp.ID && id == item.ID)
                                {
                                    item.Name = tmp.Name;
                                    item.CategoryId = tmp.CategoryId;
                                }
                            }
                            break;

                        case "categoryTable":
                            foreach (var item in categoryTable)
                            {
                                Category tmp = (Category) row;
                                if (id == tmp.ID && id == item.ID)
                                {
                                    item.Name = tmp.Name;
                                }
                            }
                            break;

                        case "accessoryTable":
                            foreach (var item in accessoryTable)
                            {
                                Accessotion tmp = (Accessotion) row;
                                if (id == tmp.ID && id == item.ID)
                                {
                                    item.Name = tmp.Name;
                                }
                            }
                            break;

                        default:
                            result = false;
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                error = ex.Message.ToString();
                result = false;
            }

            return result;
        }
    }
}
