using System;
using System.Collections.Generic;
using System.Text;

using ExampleOOP.DAO;
using ExampleOOP.Entity;


namespace ExampleOOP.Demo
{
    class ProductDAODemo
    {
        ProductDAO dao = new ProductDAO();
        const string PRODUCT = "product";

        public void InsertTest(Product row)
        {
            if (dao.Insert(PRODUCT, row) == false)
            {
                Console.WriteLine("Insert không thành công");
            }
            else
            {
                Console.WriteLine("Insert thành công");
            }
        }

        public void UpdateTest(Product row)
        {
            if (dao.Update(PRODUCT, row) == false)
            {
                Console.WriteLine("Update không thành công");
            }
            else
            {
                Console.WriteLine("Update thành công");
            }
        }

        public void DeleteTest(Product row)
        {
            if (dao.Delete(PRODUCT, row) == false)
            {
                Console.WriteLine("Delete không thành công");
            }
            else
            {
                Console.WriteLine("Delete thành công");
            }
        }

        public void FindAllTest()
        {
            foreach (Product item in dao.FindAll(PRODUCT))
            {
                Console.WriteLine(item.GetID() + ", " + item.GetName() + ", " + item.GetCategoryID());
            }
        }

        public void FindByIdTest(int id)
        {
            Console.WriteLine(dao.FindById(id, PRODUCT).GetID() + ", " + dao.FindById(id, PRODUCT).GetName());
        }

        public void FindByNameTest(string name)
        {
            Console.WriteLine(dao.FindByName(name, PRODUCT).GetID() + ", " + dao.FindByName(name, PRODUCT).GetName());
        }
    }
}
