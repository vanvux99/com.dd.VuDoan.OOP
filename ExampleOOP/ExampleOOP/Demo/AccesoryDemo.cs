using System;
using System.Collections.Generic;
using System.Text;

using ExampleOOP.Entity;

namespace ExampleOOP.Demo
{
    class AccesoryDemo
    {
        public void CreateAccessoryTest()
        {
            Accessotion product = new Accessotion(1, "testName");
        }

        public void PrintAccessory(Accessotion accessotion)
        {
            Console.WriteLine(accessotion.GetID());
            Console.WriteLine(accessotion.GetName());
        }
    }
}
