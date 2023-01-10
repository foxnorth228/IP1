namespace IP1
{
    public class Product
    {
        private int _count;
        public int Count { get => _count; }

        public string Name { get; }
        public int Price { get; }

        public Product(string name, int count, int price)
        {
            Name = name;
            _count = count;
            Price = price;
        }

        public int ChangeCount(int number)
        {
            if (number < 0)
            {
                if (_count < -1 * number)
                {
                    return -1;
                }
            }
            _count += number;
            return _count;
        }

        public override string ToString()
        {
            return $"Name: {Name} Count: {Count} Price: {Price}";
        }
    }
}
