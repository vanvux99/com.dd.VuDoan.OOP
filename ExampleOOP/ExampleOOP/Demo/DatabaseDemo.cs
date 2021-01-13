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
        Database database = new Database();

        public void InsertTableTest(string name, dynamic row)
        {
            if (database.InsertTable(name, row) == false)
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
            List<object> list = database.SelectTable(name);
            foreach (dynamic item in list)
            {
                Console.WriteLine(item.ID + ", " + item.Name + ", " + item.CategoryId);
            }
        }

        public void UpdateTableTest(object name, object row)
        {
            if (database.UpdateTable(name, row) == false)
            {
                Console.WriteLine("Update không thành công");
            }
            else
            {
                Console.WriteLine("Update thành công");
            }
        }

        public void UpdateTableTest(int id, string name, object row)
        {
            if (database.UpdateTable(id, name, row) == false)
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
            if (database.DeleteTable(name, row) == false)
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
            if (database.TruncateTable(name) == false)
            {
                Console.WriteLine("Insert không thành công");
            }
            else
            {
                Console.WriteLine("Insert thành công");
            }
        }

        public void InitDatabase(string name)
        {
            Random rnd = new Random();

            string[] names = { "Rufus", "Bear", "Dakota", "Fido",
                          "Vanya", "Samuel", "Koani", "Volodya",
                          "Prince", "Yiska" };
            int nameIndex = rnd.Next(names.Length);

            string[] category =
            {
                "caterogy1", "caterogy2", "caterogy3", "caterogy4"
            };
            int categoryIndex = rnd.Next(category.Length);

            string[] accessory =
            {
                "accessory1", "accessory2", "accessory3", "accessory4"
            };
            int accessoryIndex = rnd.Next(accessory.Length);

            switch (name)
            {
                case "productTable":
                    for (int i = 0; i < 10; i++)
                    {
                        string nameProductTable = names[nameIndex];
                        InsertTableTest("productTable", new Product((i + 1), nameProductTable, (i + 1)));
                    }
                    break;

                case "categoryTable":
                    for (int i = 0; i < 10; i++)
                    {
                        InsertTableTest("categoryTable", new Category((i + 1), category[categoryIndex]));
                    }
                    break;

                case "accessoryTable":
                    for (int i = 0; i < 10; i++)
                    {
                        InsertTableTest("accessoryTable", new Accessotion((i + 1), accessory[accessoryIndex]));
                    }
                    break;

                default:
                    Console.WriteLine("Input error.");
                    break;
            }
        }

        public void printTableTest(/**/)
        {

        }
    }
}
