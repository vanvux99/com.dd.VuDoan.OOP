using System;
using System.Collections.Generic;
using System.Text;

using ExampleOOP.DAO;
using ExampleOOP.Entity;

namespace ExampleOOP.Demo
{
    class CategoryDAODemo
    {
        CategoryDAO dao = new CategoryDAO();

        public void InsertTest(Category row)
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

        public void UpdateTest(Category row)
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

        public void DeleteTest(Category row)
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
            List<Category> list = dao.FillAll();
            foreach (Category item in list)
            {
                Console.WriteLine(item.ID + ", " + item.Name);
            }
        }
    }
}
