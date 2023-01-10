using System.Collections.Generic;

namespace IP1
{
    public class ProductList
    {
        private readonly List<Product> _products;

        public ProductList()
        {
            _products = new List<Product>();
        }

        public int Add(Product product)
        {
            if (product == null || Find(product.Name) != null)
            {
                return -1;
            }
            _products.Add(product);
            return _products.Count;
        }

        public Product Change(string name, Product product)
        {
            int el = _products.FindIndex(x => x.Name == name);
            if (product == null || el == -1)
            {
                return null;
            }
            if (name != product.Name)
            {
                return null;
            }
            _products[el] = product;
            return _products[el];
        }

        public Product Find(string name) => _products.Find(x => x.Name == name);

        public Product Buy(string name, int count, int sum)
        {
            int el = _products.FindIndex(x => x.Name == name);
            if (el == -1)
            {
                return null;
            }
            if (_products[el].Count < count)
            {
                return null;
            }
            if (sum < count * _products[el].Price)
            {
                return null;
            }
            int a = _products[el].ChangeCount(-count);
            if (a == -1)
            {
                return null;
            }
            return new Product(_products[el].Name, count, _products[el].Price);
        }
    }
}
