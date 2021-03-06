﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    //SOLID
    //Open Closed Principle
    //DTO = Data Transformation Object
    class Program
    {
        static void Main(string[] args)
        {
            ProductTest();
            //CategoryTest();
        }






        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {


            ProductManager productManager = new ProductManager(new EfProductDal());

            var result = productManager.GetProductDetails();

            if (result.Success == true)
            {
                foreach (var products in result.Data)
                {
                    Console.WriteLine(products.ProductName + " / / " + products.ProductId);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }


        }
    }
}
