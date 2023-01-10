using NUnit.Framework;
using IP1;

namespace IP1.Tests
{
    public class Tests
    {
        Product Banana;
        Product Apple;
        Product Meat;
        Product Bread;
        Product Tea;
        ProductList list;

        [SetUp]
        public void Setup()
        {
            Banana = new Product("banana", 100, 5);
            Apple = new Product("apple", 300, 2);
            Meat = new Product("meat", 100, 15);
            Bread = new Product("bread", 120, 2);
            Tea = new Product("tea", 90, 3);
            list = new ProductList();
        }

        [Test]
        public void TestAdd()
        {
            Assert.AreEqual(list.Add(Banana), 1, "Add Error 1");
            Assert.AreEqual(list.Add(new Product("banana", 50, 5)), -1, "Add Error 2");
            Assert.AreEqual(list.Add(Apple), 2, "Add Error 3");
            Assert.AreEqual(list.Add(Tea), 3, "Add Error 4");
            Assert.AreEqual(list.Add(Bread), 4, "Add Error 5");
            Assert.AreEqual(list.Add(Meat), 5, "Add Error 6");
            Assert.AreEqual(list.Add(new Product("apple", 20, 3)), -1, "Add Error 7");
            Assert.AreEqual(list.Add(null), -1, "Add Error 8");
        }
        
        [Test]
        public void TestFind()
        {
            list.Add(Tea);
            list.Add(Meat);
            list.Add(Apple);
            list.Add(Banana);
            Assert.AreEqual(list.Find("apple").ToString(), Apple.ToString(), "Find Error 1");
            Assert.AreEqual(list.Find("banana").ToString(), Banana.ToString(), "Find Error 2");
            Assert.AreEqual(list.Find("tea").ToString(), Tea.ToString(), "Find Error 3");
            Assert.AreEqual(list.Find("meat").ToString(), Meat.ToString(), "Find Error 4");
            Assert.Null(list.Find("cucumber"), "Find Error 5");
        }

        
        [Test]
        public void TestChange()
        {
            list.Add(Tea);
            list.Add(Meat);
            list.Add(Bread);
            Tea = new Product("tea", 100, 4);
            Meat = new Product("meat", 200, 20);
            Assert.AreEqual(list.Change("tea", Tea).ToString(), Tea.ToString(), "Change error 1");
            Assert.AreEqual(list.Change("meat", Meat).ToString(), Meat.ToString(), "Change error 2");

            Assert.Null(list.Change("bread", new Product("black bread", 100, 4)), null, "Change error 3");
            Assert.Null(list.Change("bread", new Product("white bread", 100, 4)), null, "Change error 4");
            Assert.Null(list.Change("tea", new Product("meat", 100, 4)), null, "Change error 5");
            Assert.Null(list.Change("tea", null), null, "Change error 6");
            Assert.Null(list.Change("ss", null), null, "Change error 7");
        }
        
        [Test]
        public void TestBuy()
        {
            Tea = new Product("tea", 100, 4);
            list.Add(Tea);
            Assert.AreEqual(list.Buy("tea", 10, 100).ToString(), new Product("tea", 10, 4).ToString(), "Bought Test 1");
            Assert.AreEqual(list.Find("tea").ToString(), new Product("tea", 90, 4).ToString(), "Bought Test 2");

            Assert.AreEqual(list.Buy("tea", 50, 1000).ToString(), new Product("tea", 50, 4).ToString(), "Bought Test 3");
            Assert.AreEqual(list.Find("tea").ToString(), new Product("tea", 40, 4).ToString(), "Bought Test 4");

            Assert.Null(list.Buy("tea", 50, 1000), "Bought Test 5");
            Assert.AreEqual(list.Find("tea").ToString(), new Product("tea", 40, 4).ToString(), "Bought Test 6");

            Assert.Null(list.Buy("tea", 10, 10), "Bought Test 7");
            Assert.AreEqual(list.Find("tea").ToString(), new Product("tea", 40, 4).ToString(), "Bought Test 8");
            Assert.Null(list.Buy("potato", 50, 1000), "Bought Test 9");
        }
        
    }
}