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

        public void InsertTest(Product row)
        {
            if (dao.Insert(row) == false)
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
            if (dao.Update(row) == false)
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
            if (dao.Delete(row) == false)
            {
                Console.WriteLine("Delete không thành công");
            }
            else
            {
                Console.WriteLine("Delete thành công");
            }
        }

        public void FillAllTest()
        {
            List<Product> list = dao.FillAll();
            foreach (Product item in list)
            {
                Console.WriteLine(item.ID + ", " + item.Name +", " + item.CategoryId);
            }
        }

        public void FillByIdTest()
        {

        }

        public void FillByNameTest()
        {

        }

        public void SearchTest()
        {

        }
    }
}
