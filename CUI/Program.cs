using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using System;

namespace CUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProductName();
            //NewMethod();
            ProductManager productManager = new ProductManager(new EfProductDal());
            var result = productManager.GetProductDetails();
            if (result.Success == true)
            {
                foreach (var item in result.Data)
                {
                    Console.WriteLine(item.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
            Console.ReadLine();
        }

        //private static void NewMethod()
        //{
        //    ProductManager productManager = new ProductManager(new EfProductDal());
        //    foreach (var item in productManager.GetProductDetails())
        //    {
        //        Console.WriteLine(item.ProductName + "========>" + item.CategoryName);
        //    }
        //}

        //private static void ProductName()
        //{
        //    ProductManager productManager = new ProductManager(new EfProductDal());
        //    foreach (var item in productManager.GetAll())
        //    {
        //        Console.WriteLine(item.ProductName);
        //    }
        //}
    }
}
