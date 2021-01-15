using System;
using System.Collections.Generic;
using System.Text;

using ExampleOOP.Entity;

namespace ExampleOOP.DAO
{
    class AccessoryDAO  : BaseDAO
    {
        Database database = new Database();
        const string ACCESSORY = "accessory";

        public AccessoryDAO() : base()
        { 

        }
        
        public Accessotion FindByName(string name)
        {
            Accessotion result = null;

            foreach (Accessotion item in database.SelectTable(ACCESSORY))
            {
                if (item.Name == name)
                {
                    result = item;
                }
            }

            return result;
        }

        public Accessotion FindById(int id)
        {
            Accessotion result = new Accessotion();

            foreach (Accessotion item in database.SelectTable(ACCESSORY))
            {
                if (item.ID == id)
                {
                    result = item;
                }
            }

            return result;
        }
    }
}
