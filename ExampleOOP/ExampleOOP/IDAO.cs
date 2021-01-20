using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleOOP
{
    interface IDAO
    {
        public bool Insert(string nameObject, BaseRow row);
        public bool Update(string nameObject, BaseRow row);
        public bool Delete(string nameObject, BaseRow row);
        public List<Object> FindAll(string nameObject);
        public BaseRow FindByName(string name, string nameObject);
        public BaseRow FindById(int id, string nameObject);
    }
}
