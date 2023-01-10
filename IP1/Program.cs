using System;

namespace IP1
{
    class Program
    {
        static void Main()
        {
            showRes();
        }

        static void showRes()
        {
            ProductList list = new ProductList();
            Console.WriteLine("Count: " + list.Add(new Product("banana", 100, 5)));
            Console.WriteLine("Count: " + list.Add(new Product("banana", 50, 5)));
            Console.WriteLine("Count: " + list.Add(new Product("apple", 300, 2)));
            Console.WriteLine("Count: " + list.Add(new Product("tea", 90, 3)));
            Console.WriteLine("Count: " + list.Add(new Product("bread", 120, 2)));
            Console.WriteLine("Count: " + list.Add(new Product("meat", 100, 15)));
            Console.WriteLine("Count: " + list.Add(new Product("apple", 20, 3)));
            Console.WriteLine("Count: " + list.Add(null));

            Console.WriteLine("Find apple: " + list.Find("apple"));
            Console.WriteLine("Find banana: " + list.Find("banana"));
            Console.WriteLine("Find tea: " + list.Find("tea"));
            Console.WriteLine("Find cucumber: " + list.Find("cucumber"));
            Console.WriteLine("Find meat: " + list.Find("meat"));

            Console.WriteLine("Change tea: " + list.Change("tea", new Product("tea", 100, 4)));
            Console.WriteLine("Change meat: " + list.Change("meat", new Product("meat", 200, 20)));
            Console.WriteLine("Change bread: " + list.Change("bread", new Product("black bread", 100, 4)));
            Console.WriteLine("Change bread: " + list.Change("bread", new Product("white bread", 100, 4)));
            Console.WriteLine("Change tea: " + list.Change("tea", new Product("meat", 100, 4)));
            Console.WriteLine("Change tea: " + list.Change("tea", null));

            Console.WriteLine("Check tea: " + list.Find("tea"));
            Console.WriteLine("Bought tea" + list.Buy("tea", 10, 100));
            Console.WriteLine("Check tea: " + list.Find("tea"));
            Console.WriteLine("Bought tea" + list.Buy("tea", 50, 1000));
            Console.WriteLine("Check tea: " + list.Find("tea"));
            Console.WriteLine("Bought tea" + list.Buy("tea", 50, 1000));
            Console.WriteLine("Check tea: " + list.Find("tea"));
            Console.WriteLine("Bought tea" + list.Buy("tea", 50, 1000));
            Console.WriteLine("Check tea: " + list.Find("tea"));
            Console.WriteLine("Bought potato: " + list.Buy("potato", 50, 1000));

            Console.ReadLine();
        }
    }
}
