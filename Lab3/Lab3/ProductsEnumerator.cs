using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class ProductsEnumerator : IEnumerator<IProduct>
    {
        IProduct[] products;
        private int index = -1;

        public ProductsEnumerator(IProduct[] products)
        {
            this.products = products;
        }

        public IProduct Current => products[index];

        object IEnumerator.Current => Current;

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
