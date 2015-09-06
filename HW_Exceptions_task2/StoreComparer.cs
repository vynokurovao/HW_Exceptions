using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Exceptions_task2
{
    public class StoreComparer : Comparer<Price>
    {
        public override int Compare(Price price1, Price price2)
        {
            if (!price1.StoreName.Equals(price2.StoreName))
            {
                return price1.StoreName.CompareTo(price2.StoreName);
            }
            else if (!price1.ProductName.Equals(price2.ProductName))
            {
                return price1.ProductName.CompareTo(price2.ProductName);
            }
            else if (!price1.Cost.Equals(price2.Cost))
            {
                return price1.Cost.CompareTo(price2.Cost);
            }
            else
            {
                return (price1.GetHashCode().CompareTo(price2.GetHashCode()));
            }
        }
    }
}
