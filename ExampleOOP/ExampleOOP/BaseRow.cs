using System;
using System.Collections.Generic;
using System.Text;

namespace ExampleOOP
{
    public abstract class BaseRow
    {
        /**
         * 
            Các lớp trong entity đều có function giống nhau là gì? 
            Hãy gom  function này vào lớp asbtract là BaseRow. 
            Các lớp entity phải thừa kế từ lớp BaseRow.
            Hãy suy ra lợi điểm của class abstract trong trường hợp này là gì.
            Đọc lại lý thuyết class abstract
         * 
         */

        //public abstract Object(int id, string name, int sencondID);
        public abstract string Name { get; set; }

        public abstract int ID { get; set; }


    }
}
