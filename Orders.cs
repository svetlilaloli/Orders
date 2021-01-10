using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders
{
    public class Orders
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, PriceQuantity> products = new Dictionary<string, PriceQuantity>();

            while (input != "buy")
            {
                string[] currentRow = input.Split();
                string currentProduct = currentRow[0];
                PriceQuantity currentPriceAndQuantity = new PriceQuantity()
                {
                    Price = double.Parse(currentRow[1]),
                    Quantity = int.Parse(currentRow[2])
                };

                if (!products.ContainsKey(currentProduct))
                {
                    products.Add(currentProduct, currentPriceAndQuantity);
                }
                else
                {
                    int quantity = products[currentProduct].Quantity;

                    products[currentProduct] = new PriceQuantity
                    {
                        Price = currentPriceAndQuantity.Price,
                        Quantity = currentPriceAndQuantity.Quantity + quantity
                    };
                }
                input = Console.ReadLine();
            }

            foreach (var product in products)
            {
                Console.WriteLine("{0} -> {1:f2}", product.Key, product.Value.Price * product.Value.Quantity);
            }
        }
    }
}
