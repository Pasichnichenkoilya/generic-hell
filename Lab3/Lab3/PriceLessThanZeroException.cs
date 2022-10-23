using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    public class PriceLessThanZeroException : Exception
    {
        public readonly float invalidPrice;

        public PriceLessThanZeroException(float invalidPrice, string message) : base($"PriceLessThanZeroException occured: {message}")
        {
            this.invalidPrice = invalidPrice;
        }
    }
}
