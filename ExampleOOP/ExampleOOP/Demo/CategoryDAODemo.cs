using System;
using System.Collections.Generic;
using System.Text;

using ExampleOOP.DAO;
using ExampleOOP.Entity;

namespace ExampleOOP.Demo
{
    class CategoryDAODemo
    {
        BaseDAO dao = new CategoryDAO();
        const string CATEGORY = "category";

        public void InsertTest(Category row)
        {
            if (dao.Insert(CATEGORY, row) == false)
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
            if (dao.Update(CATEGORY, row) == false)
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
            if (dao.Delete(CATEGORY, row) == false)
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
            foreach (Category item in dao.FindAll(CATEGORY))
            {
                Console.WriteLine(item.ID + ", " + item.Name);
            }
        }
    }
}
