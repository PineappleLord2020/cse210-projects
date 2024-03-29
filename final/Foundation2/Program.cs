using System;

class Program
{
    static void Main(string[] args)
    {
        bool run = true;
        List<Order> orders = new List<Order>();

        if (run){
            List<Product>products = new List<Product> {
                new Product("Lego Star Wars Millenium Falcon", 75152, 850, 1),
                new Product("Lego Ninjago Wolf Mask Shadow Dojo", 71813, 120, 2),
            };
            Address address = new Address("201 Abandoned Temple Road", "New Ninjago City", "California", "USA");
            Customer customer = new Customer("Kai Smith", address);
            Order order = new Order(products, customer);
            orders.Add(order);
            products = new List<Product> {
                new Product("Lego Marvel Avengers Tower", 76269, 500, 2),
                new Product("Lego Minecraft The Skeleton Dungeon", 21189, 35, 3),
            };
            address = new Address("304 Sky Dojo Court", "Jamanakai Village", "Tokyo", "JP");
            customer = new Customer("Jay Walker", address);
            order = new Order(products, customer);
            orders.Add(order);

            foreach (var orderinfo in orders){
                Console.WriteLine(orderinfo.ShippingLabel());
                orderinfo.PackingLabel();
                Console.WriteLine(orderinfo.TotalPrice());
                Console.WriteLine();
            }
        }
    }
}