using System;
using System.Collections.Generic;
using System.Threading;

using ExampleOOP.DAO;
using ExampleOOP.Demo;
using ExampleOOP.Entity;

namespace ExampleOOP
{
    class Program
    {
        static DatabaseDemo demo = new DatabaseDemo();
        static Database database = new Database();
        static Random rnd = new Random();
        static ProductDAODemo productDAODemo = new ProductDAODemo();

        static void Main(string[] args)
        {
            TestInsert();

            foreach (var item in Database.productTable)
            {
                Console.WriteLine(item.ID +", " + item.Name +", " +item.CategoryID);
            }

        }

        static void TestInsert()
        {
            Product product = new Product(1, "uchiha", 1);
            productDAODemo.InsertTest(product);
        }





















        void CMT()
        {
            /*string[] names = { "Rufus", "Bear", "Dakota", "Fido",
                          "Vanya", "Samuel", "Koani", "Volodya",
                          "Prince", "Yiska" };
            int nameIndex = rnd.Next(1, names.Length);

            string[] category =
            {
                "caterogy1", "caterogy2", "caterogy3", "caterogy4"
            };
            int categoryIndex = rnd.Next(1, category.Length);

            string[] accessory =
            {
                "accessory1", "accessory2", "accessory3", "accessory4"
            };
            int accessoryIndex = rnd.Next(1, accessory.Length);*//*


            for (int i = 0; i < 1; i++)
            {
                demo.InitDatabase("product", new Product((i + 1), names[nameIndex], (i + 1)));
                demo.InitDatabase("category", new Category((i + 1), names[nameIndex]));
                demo.InitDatabase("accessory", new Accessotion((i + 1), names[nameIndex]));

            }

            Console.WriteLine("product");
            try
            {
                if (database.productTable.Count <= 0)
                {
                    Console.WriteLine("table null");
                }
                foreach (Product item in database.productTable)
                {
                    Console.WriteLine(item.Name);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }


            // test product
            Product product = new Product(1, "a", 1);

            Console.WriteLine(product.ID);
            Console.WriteLine(product.Name);
            Console.WriteLine(product.CategoryId);

            Category category = new Category(032418, "uchiha");

            Console.WriteLine(category.ID);
            Console.WriteLine(category.Name);*/
        }
    }
}


























/**
 *  chưa viết method ở bài 5
 *  random ở hàm insert bị trùng nhau do thời gian chạy vòng lặp rất nhanh
 */




/*database.productTable = new List<Product>(5)
    {
        new Product(1, "product1", 1),
        new Product(1, "product2", 1),
        new Product(1, "product3", 1),
        new Product(1, "product4", 1),
        new Product(1, "product5", 1)
    };

database.categoryTable = new List<Category>(5)
    {
        new Category(1, "caterogy1"),
        new Category(1, "caterogy2"),
        new Category(1, "caterogy3"),
        new Category(1, "caterogy4"),
        new Category(1, "caterogy5")
    };

database.accessoryTable = new List<Accessotion>(5)
    {
        new Accessotion(1, "accessory1"),
        new Accessotion(1, "accessory2"),
        new Accessotion(1, "accessory3"),
        new Accessotion(1, "accessory4"),
        new Accessotion(1, "accessory5")
    };*/
