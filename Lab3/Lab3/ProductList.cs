using System.Collections;

namespace Lab3
{
    public class ProductList<T> : IEnumerable<T> where T : IProduct
    {
        T[] products;

        public int Count => products.Length;

        public ProductList()
        {
            products = new T[0];
        }

        public void SortByPrice(bool asc = true)
        {
            bool swapped = true;
            while (swapped)
            {
                swapped = false;
                for (int i = 0; i < products.Length - 1; i++)
                {
                    var swapCondition = asc ? products[i].GetPrice() < products[i].GetPrice()
                        : products[i].GetPrice() > products[i].GetPrice();
                    if (swapCondition)
                    {
                        T tmp = products[i];
                        products[i] = products[i + 1];
                        products[i + 1] = tmp;
                        swapped = true;
                    }
                }
            }
        }

        public void Add(T product)
        {
            T[] tmp = new T[products.Length + 1];
            for (int i = 0; i < products.Length; i++)
            {
                tmp[i] = products[i];
            }
            tmp[products.Length] = product;

            products = tmp;
        }

        public T this[int key]
        {
            get
            {
                if (key < 0 || key >= products.Length)
                    throw new IndexOutOfRangeException($"index {key} is invalid in ProductsList");

                return products[key];
            }
            set
            {
                if (key < 0 || key >= products.Length)
                    throw new IndexOutOfRangeException($"index {key} is invalid in ProductsList");

                products[key] = value;
            }
        }

        public void PrintProducts()
        {
            for (int i = 0; i < products.Length; i++)
                Console.WriteLine(products[i] + "\n");
        }

        public IEnumerator<T> GetEnumerator()
        {
            return new ProductsEnumerator<T>(products);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
