using System;
using System.Collections.Generic;
using System.Linq;

namespace AndreyAndBiliard
{
    public class Customer
    {
        public string Name { get; set; }
        public Dictionary<string, int> ProductsAndQuantity { get; set; }
        public decimal Bill { get; set; }
    }

    class MainClass
    {
        static void getProductsAndQUantity(Dictionary<string, decimal> products )
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split('-');
                var product = line[0];
                var price = decimal.Parse(line[1]);

                if (!products.ContainsKey(product))
                {
                    products.Add(product, 0);
                }
                products[product] = price;
            }
        }

        public static void Main()
        {
            var products = new Dictionary<string, decimal>();

            getProductsAndQUantity(products);

            string line = Console.ReadLine();

            List<Customer> customers = new List<Customer>();
            while (line != "end of clients")
            {
                var info = line.Split(new char[] { '-', ',' });

                string name = info[0];
                string product = info[1];
                int quantity = int.Parse(info[2]);

                if (products.ContainsKey(product))
                {
                    bool customerIsPresent = false;

                    Customer customer = new Customer();
                    customer.Name = name;
                    customer.ProductsAndQuantity = new Dictionary<string, int>();
                    customer.ProductsAndQuantity.Add(product, quantity);
                    customer.Bill = customer.Bill + products[product] * quantity;

                    foreach (var c in customers)
                    {
                        if (c.Name == customer.Name)
                        {
                            customerIsPresent = true;
                            if (c.ProductsAndQuantity.ContainsKey(product))
                            {
                                c.ProductsAndQuantity[product] += quantity;
                            }
                            else
                            {
                                c.ProductsAndQuantity.Add(product, quantity);
                            }
                            c.Bill += products[product] * quantity;
                        }
                    }
                    if (!customerIsPresent)
                    {
                        customers.Add(customer);
                    }

                }
                line = Console.ReadLine();
            }


            decimal totalBill = 0M;
            foreach (var c in customers.OrderBy(s => s.Name))
            {
                Console.WriteLine(c.Name);
                foreach (var product in c.ProductsAndQuantity)
                {
                    Console.WriteLine($"-- {product.Key} - {product.Value}");
                }
                Console.WriteLine($"Bill: {c.Bill:F2}");
                totalBill += c.Bill;
            }
            Console.WriteLine($"Total bill: {totalBill:F2}");
        }

    }
}
