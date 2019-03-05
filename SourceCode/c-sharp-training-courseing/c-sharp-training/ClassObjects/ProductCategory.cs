using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_training.ClassObjects
{
    public class Category
    {
        public int Id;
        //public string Name;
        public Product[] products = new Product[3];

        public decimal TotalAmount()
        {
            decimal TotalProductAmount = 0;

            for (int index = 0; index < products.Length; index++)
            {
                TotalProductAmount = TotalProductAmount + products[index].Price;
            }

            return TotalProductAmount;
        }

    }


    public class Product
    {
        public int Id;
        //public string Name;
        public decimal Price;
    }


    class Program
    {
        static void Main(string[] args)
        {
            Category[] category = new Category[2];
            Product product;


            for (int catIndex = 0; catIndex < category.Length; catIndex++)
            {
                category[catIndex] = new Category();

                Console.WriteLine("Enter Category Id");
                category[0].Id = Convert.ToInt32(Console.ReadLine());
                //category[1].Name = Console.ReadLine();

                for (int index = 0; index < category[catIndex].products.Length; index++)
                {
                    product = new Product();
                    Console.WriteLine("Enter Product Id & Price");
                    product.Id = Convert.ToInt32(Console.ReadLine());
                    //product.Name = Console.ReadLine();
                    product.Price = Convert.ToDecimal(Console.ReadLine());
                    category[catIndex].products[index] = product;
                }
            }

            for (int catIndex = 0; catIndex < category.Length; catIndex++)
            {
                Console.WriteLine("Total Amount of this category is {0}", category[catIndex].TotalAmount());
            }

            Console.ReadLine();
        }
    }
}
