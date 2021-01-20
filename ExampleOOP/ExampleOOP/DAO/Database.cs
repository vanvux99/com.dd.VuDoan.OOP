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
        private List<Product> productTable = new List<Product>();
        private List<Category> categoryTable = new List<Category>();
        private List<Accessotion> accessoryTable = new List<Accessotion>();
        private static Database instants = null;
        private string error;
        private const string CATEGORY = "category";
        private const string PRODUCT = "product";
        private const string ACCESSORY = "accessory";
        private const string DELETE = "delete";
        private const string TRUNCATE = "truncate";

        public static Database Instance
        {
            get
            {
                if (instants == null)
                    instants = new Database();
                return instants;
            }
            set { instants = value; }
        }

        private Database()
        {

        }

        /// <summary>
        /// insert data into the database
        /// </summary>
        /// <param name="name"></param>
        /// <param name="row"></param>
        /// <returns> true or false </returns>
        public bool InsertTable(string name, BaseRow row)
        {
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

                        return InsertData(countTable, countTableLaterInsert, parseProduct);
                    }
                    else if (name == CATEGORY)
                    {
                        countTable = categoryTable.Count;
                        Category parseCategory = (Category) row;

                        return InsertData(countTable, countTableLaterInsert, parseCategory);
                    }
                    else if (name == ACCESSORY)
                    {
                        countTable = accessoryTable.Count;
                        Accessotion parseAsscessory = (Accessotion) row;

                        return InsertData(countTable, countTableLaterInsert, parseAsscessory);
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
        }

        /// <summary>
        /// return the list data of database
        /// </summary>
        /// <param name="name"></param>
        /// <returns> list data </returns>
        public List<BaseRow> SelectTable(string name)
        {
            try
            {
                if (name != null)
                {
                    if (name == PRODUCT)
                    {
                        return AddDataToList(productTable);
                    }
                    else if (name == CATEGORY)
                    {
                        return AddDataToList(categoryTable);
                    }
                    else if (name == ACCESSORY)
                    {
                        return AddDataToList(accessoryTable);
                    }
                }
            }
            catch (Exception ex)
            {
                error = ex.Message.ToString();
            }
            return null;
        }

        /// <summary>
        /// update data into the database
        /// </summary>
        /// <param name="name"></param>
        /// <param name="row"></param>
        /// <returns> boolean </returns>
        public bool UpdateTable(string name, BaseRow row)
        {
            try
            {
                if (row != null && name != null)
                {
                    if (name == PRODUCT)
                    {
                        return UpdateTableAuto(name, row, productTable);
                    }
                    else if (name == CATEGORY)
                    {
                        return UpdateTableAuto(name, row, categoryTable);
                    }
                    else if (name == ACCESSORY)
                    {
                        return UpdateTableAuto(name, row, accessoryTable);
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
        }

        /// <summary>
        /// delete data into the database
        /// </summary>
        /// <param name="name"></param>
        /// <param name="row"></param>
        /// <returns> variable boolean </returns>
        public bool DeleteTable(string name, BaseRow row)
        {
            try
            {
                if (row != null && row != null)
                {
                    if (name == PRODUCT)
                    {
                        Product product = (Product) row;
                        return DeleteTableById(productTable, product, DELETE);
                    }
                    else if (name == CATEGORY)
                    {
                        Category product = (Category) row;
                        return DeleteTableById(categoryTable, product, DELETE);
                    }
                    else if (name == ACCESSORY)
                    {
                        Accessotion product = (Accessotion) row;
                        return DeleteTableById(accessoryTable, product, DELETE);
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
        }

        /// <summary>
        /// clean data in the database
        /// </summary>
        /// <param name="name"></param>
        /// <returns> var boolean </returns>
        public bool TruncateTable(string name)
        {
            try
            {
                if (name != null)
                {
                    if (name == PRODUCT)
                    {
                        return DeleteTableById(productTable, productTable, TRUNCATE);
                    }
                    else if (name == CATEGORY)
                    {
                        return DeleteTableById(categoryTable, categoryTable, TRUNCATE);
                    }
                    else if (name == ACCESSORY)
                    {
                        return DeleteTableById(accessoryTable, accessoryTable, TRUNCATE);
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
        }

        /// <summary>
        /// update database by id
        /// </summary>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="row"></param>
        /// <returns></returns>
        public bool UpdateTable(int id, string name, BaseRow row)
        {
            try
            {
                if (row != null && name != null && id.ToString() != null)
                {
                    if (name == PRODUCT)
                    {
                        return UpdateTableById(name, row, productTable, id);
                    }
                    else if (name == CATEGORY)
                    {
                        return UpdateTableById(name, row, productTable, id);
                    }
                    else if (name == ACCESSORY)
                    {
                        return UpdateTableById(name, row, productTable, id);
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
        }

        #region SubMethod 

        /// <summary>
        /// check id input
        /// </summary>
        /// <param name="value"> id</param>
        /// <returns></returns>
        bool CheckId(dynamic value)
        {
            bool check = true;

            if (value.ID.ToString() == null)
                return false;

            return check;
        }

        /// <summary>
        /// add data into the list
        /// </summary>
        /// <param name="table"></param>
        /// <returns></returns>
        List<BaseRow> AddDataToList(dynamic table)
        {
            List<BaseRow> list = new List<BaseRow>();

            foreach (var itemPro in table)
            {
                list.Add(itemPro);
            }

            return list;
        }

        /// <summary>
        /// update data
        /// </summary>
        /// <param name="name"> object of baserow</param>
        /// <param name="row"> data input</param>
        /// <param name="table"> database</param>
        /// <returns></returns>
        bool UpdateTableAuto(string name, BaseRow row, dynamic table)
        {
            bool check = true;

            if (name == PRODUCT)
            {
                foreach (var itemTable in table)
                {
                    Product tmp = (Product) row;

                    if (itemTable.ID == tmp.GetID())
                    {
                        itemTable.Name = tmp.GetName();
                        itemTable.CategoryId = tmp.GetCategoryID();
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

        /// <summary>
        /// update data by id
        /// </summary>
        /// <param name="name"> object of baserow</param>
        /// <param name="row"> data input</param>
        /// <param name="table"> database</param>
        /// <param name="id"> id input</param>
        /// <returns></returns>
        bool UpdateTableById(string name, BaseRow row, dynamic table, int id)
        {
            bool check = true;

            if (name == PRODUCT)
            {
                foreach (var itemTable in table)
                {
                    Product tmp = (Product) row;

                    if (id == tmp.GetID() && id == itemTable.ID)
                    {
                        itemTable.Name = tmp.GetName();
                        itemTable.CategoryId = tmp.GetCategoryID();
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

        /// <summary>
        /// delete data, use with method Delete and method Truncate
        /// </summary>
        /// <param name="table"> of BaseRow</param>
        /// <param name="row"> database </param>
        /// <param name="switchMethod"> delete or truncate </param>
        /// <returns></returns>
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

        /// <summary>
        /// checks the count of the table, returns false if the count of the inserted table has not changed
        /// </summary>
        /// <param name="countTable"> count of row of database</param>
        /// <param name="countTableLater"> count of row of database later compare </param>
        /// <returns></returns>
        bool CheckCountDatabase(int countTable, int countTableLater)
        {
            bool check = true;

            if (countTableLater <= countTable)
                return false;

            return check;
        }


        /// <summary>
        /// insert data into database
        /// </summary>
        /// <param name="countTable"> count of row of database</param>
        /// <param name="countTableLaterInsert"> count of row of database later compare</param>
        /// <param name="table"> database</param>
        /// <returns></returns>
        bool InsertData(int countTable, int countTableLaterInsert, dynamic table)
        {
            bool check = true;

            if (CheckId(table) == true)
            {
                productTable.Add(table);
                countTableLaterInsert = productTable.Count;

                if (CheckCountDatabase(countTable, countTableLaterInsert) == false)
                    return false;
            }
            else
                return false;

            return check;
        }
        #endregion
    }
}
