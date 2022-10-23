using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal interface IFoodProduct : IProduct
    {
        DateTime GetExpireDate();
        void SetExpireDate(DateTime date);
    }
}
