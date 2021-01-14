using System;
using System.Collections.Generic;
using System.Text;

using ExampleOOP.DAO;
using ExampleOOP.Entity;

namespace ExampleOOP.Demo
{
    class AccessoryDAODemo
    {
        AccessoryDAO dao = new AccessoryDAO();

        public void InsertTest(Accessotion row)
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

        public void UpdateTest(Accessotion row)
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

        public void DeleteTest(Accessotion row)
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
            List<Accessotion> list = dao.FillAll();
            foreach (Accessotion item in list)
            {
                Console.WriteLine(item.ID + ", " + item.Name);
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
