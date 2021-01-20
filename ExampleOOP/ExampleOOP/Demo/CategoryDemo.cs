using System;
using System.Collections.Generic;
using System.Text;

using ExampleOOP.Entity;

namespace ExampleOOP.Demo
{
    class CategoryDemo : Category
    {
        public void CreateCategoryTest()
        {
            Category category = new Category(1, "testName");
        }

        public void PrintCategory(Category category)
        {
            Console.WriteLine(category.GetID());
            Console.WriteLine(category.GetName());
        }
    }
}
