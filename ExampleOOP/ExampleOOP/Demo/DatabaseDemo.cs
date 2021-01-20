using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

using ExampleOOP.DAO;
using ExampleOOP.Entity;

namespace ExampleOOP.Demo
{
    class DatabaseDemo
    {
        public void InsertTableTest(string name, dynamic row)
        {
            if (Database.Instance.InsertTable(name, row) == false)
            {
                Console.WriteLine("Insert không thành công");
            }
            else
            {
                Console.WriteLine("Insert thành công");
            }
        }

        public void SelectTableTest(string name)
        {
            List<BaseRow> list = Database.Instance.SelectTable(name);

            switch (name)
            {
                case "product":
                    foreach (Product item in list)
                    {
                        Console.WriteLine(item.GetID() + ", " + item.GetName() + ", " + item.GetCategoryID());
                    }
                    break;

                case "category":
                case "accessory":
                    foreach (dynamic item in list)
                    {
                        Console.WriteLine(item.ID + ", " + item.Name);
                    }
                    break;

                default:
                    Console.WriteLine("Object invalid");
                    break;
            }
        }

        public void UpdateTableTest(string name, BaseRow row)
        {
            if (Database.Instance.UpdateTable(name, row) == false)
            {
                Console.WriteLine("Update không thành công");
            }
            else
            {
                Console.WriteLine("Update thành công");
            }
        }

        public void UpdateTableTest(int id, string name, BaseRow row)
        {
            if (Database.Instance.UpdateTable(id, name, row) == false)
            {
                Console.WriteLine("Update không thành công");
            }
            else
            {
                Console.WriteLine("Update thành công");
            }
        }

        public void DeleteTableTest(string name, dynamic row)
        {
            if (Database.Instance.DeleteTable(name, row) == false)
            {
                Console.WriteLine("Delete không thành công");
            }
            else
            {
                Console.WriteLine("Delete thành công");
            }
        }

        public void TruncateTableTest(string name, dynamic row)
        {
            if (Database.Instance.TruncateTable(name) == false)
            {
                Console.WriteLine("Insert không thành công");
            }
            else
            {
                Console.WriteLine("Insert thành công");
            }
        }

        public void InitDatabase(string name, object nameInsert)
        {
            switch (name)
            {
                case "product":
                    InsertTableTest("product", nameInsert);
                    break;

                case "category":
                    InsertTableTest("category", nameInsert);

                    break;

                case "accessory":
                    InsertTableTest("accessory", nameInsert);

                    break;

                default:
                    Console.WriteLine("Input error");
                    break;
            }
        }

        public void printTableTest(/**/)
        {

        }
    }
}
