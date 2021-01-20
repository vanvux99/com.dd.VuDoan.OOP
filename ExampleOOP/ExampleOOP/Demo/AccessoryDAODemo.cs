using System;
using System.Collections.Generic;
using System.Text;

using ExampleOOP.DAO;
using ExampleOOP.Entity;

namespace ExampleOOP.Demo
{
    class AccessoryDAODemo 
    {
        BaseDAO dao = new AccessoryDAO();
        const string ACCESSORY = "accessory";

        public void InsertTest(Accessotion row)
        {
            if (dao.Insert(ACCESSORY, row) == false)
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
            if (dao.Update(ACCESSORY, row) == false)
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
            if (dao.Delete(ACCESSORY, row) == false)
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
            foreach (Accessotion item in dao.FindAll(ACCESSORY))
            {
                Console.WriteLine(item.GetID() + ", " + item.GetName());
            }
        }

        public void FindByIdTest(int id)
        {
            Console.WriteLine(dao.FindById(id, ACCESSORY).GetID() + ", " + dao.FindById(id, ACCESSORY).GetName());
        }

        public void FindByNameTest(string name)
        {
            Console.WriteLine(dao.FindByName(name, ACCESSORY).GetID() + ", " + dao.FindByName(name, ACCESSORY).GetName());
        }
    }
}
