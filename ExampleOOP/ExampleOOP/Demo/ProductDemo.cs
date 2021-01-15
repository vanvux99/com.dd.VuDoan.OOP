using System;
using System.Collections.Generic;
using System.Text;

using ExampleOOP.Entity;

namespace ExampleOOP.Demo
{
    class ProductDemo : Product
    {
        Product products = new Product();
        /*- createProductTest()
        - printProduct(product)*/

        public void CreateProductTest()
        {
            Product product = new Product(1, "testProduct", 1);
        }

        public void PrintProduct(Product product)
        {
            Console.WriteLine(product.ID);
            Console.WriteLine(product.Name);
            Console.WriteLine(product.CategoryID);
        }
    }
}
