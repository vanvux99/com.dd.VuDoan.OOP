using System;
using System.Collections.Generic;
using System.Text;

using ExampleOOP.Entity;

namespace ExampleOOP.Demo
{
    class ProductDemo : Product
    {
        Product products = new Product();

        public void CreateProductTest()
        {
            Product product = new Product(1, "testProduct", 1);
        }

        public void PrintProduct(Product product)
        {
            Console.WriteLine(product.GetID());
            Console.WriteLine(product.GetName());
            Console.WriteLine(product.GetCategoryID());
        }
    }
}
