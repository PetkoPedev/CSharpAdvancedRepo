using System;
using System.Collections.Generic;
using System.Linq;

namespace P03_ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            var shops = new Dictionary<string, Dictionary<string, double>>();
            string line;
            while ((line = Console.ReadLine())!= "Revision")
            {
                string[] productInfo = line.Split(", ");
                string shop = productInfo[0];
                string product = productInfo[1];
                double price = double.Parse(productInfo[2]);

                if (!shops.ContainsKey(shop))
                {
                    shops.Add(shop, new Dictionary<string, double>());
                }
                shops[shop].Add(product, price);
            }

            var orderedShops = shops.OrderBy(s => s.Key).ToDictionary(x => x.Key, x => x.Value);

            foreach (var sh in orderedShops)
            {
                Console.WriteLine($"{sh.Key}->");
                foreach (var pr in sh.Value)
                {
                    Console.WriteLine($"Product: {pr.Key}, Price: {pr.Value}");
                }
            }
        }
    }
}
