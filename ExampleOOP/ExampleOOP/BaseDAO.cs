using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleOOP
{
    public abstract class BaseDAO
    {
        public abstract bool Insert(BaseRow row);
        public abstract bool Update(BaseRow row);
        public abstract bool Delete(BaseRow row);

        public List<BaseRow> FillAll();
    }
}
