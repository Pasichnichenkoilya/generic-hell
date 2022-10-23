using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {
			try
			{
                ProductList<IProduct> productList = new ProductList<IProduct>();

                productList.Add(new FoodProduct("Milk", 15.75f, new DateTime(2022, 10, 25)));
                productList.Add(new FoodProduct("Pizza", 30f, new DateTime(2022, 10, 21)));
                productList.Add(new FoodProduct("Bread", 10.50f, new DateTime(2022, 11, 15)));

                productList.Add(new VehicleProduct("Jaguar Supercar", 12000000, 315.56f));
                productList.Add(new VehicleProduct("Bike", 450000, 155.77f));
                productList.Add(new VehicleProduct("Boeing 737", 112600000, 950f));

                Console.WriteLine($"Products count: {productList.Count}\n");

                productList.PrintProducts();

                productList.SortByPrice();
                Console.WriteLine("-----------Sorted-----------");
                productList.PrintProducts();

                Console.WriteLine($"Average product price: {Product.GetAverageProductPrice()}");

                Console.WriteLine("\n-----------Exceptions-----------\n");
                //productList.Add(new FoodProduct("Milk", -15.75f, new DateTime(2022, 10, 25))); // exception test
                //Console.WriteLine($"Price of -2th element: {productList[-2].GetPrice()}"); // exception test
                //Console.WriteLine($"Price of -2th element: {productList[2000].GetPrice()}"); // exception test

                foreach (var item in productList.Where(p => p.GetName()[0] == 'B'))
                {
                    Console.WriteLine(item);
                }
            }
            catch (Exception e)
			{
				Console.WriteLine(e.Message);
			}
        }
    }
}