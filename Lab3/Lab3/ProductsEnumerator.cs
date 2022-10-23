using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class ProductsEnumerator<T> : IEnumerator<T> where T : IProduct
    {
        T[] products;
        private int index = -1;

        public ProductsEnumerator(T[] products)
        {
            this.products = products;
        }

        public IProduct Current => products[index];

        object IEnumerator.Current => Current;

        T IEnumerator<T>.Current => products[index];

        public void Dispose() { }

        public bool MoveNext()
        {
            return ++index < products.Length;
        }

        public void Reset()
        {
            index = -1;
        }
    }
}
