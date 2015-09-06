using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Exceptions_task2
{
    public class Price
    {
        private string _productName;
        private string _storeName;
        private double _cost;

        public Price(string productName, string storeName, double cost)
        {
            _productName = productName;
            _storeName = storeName;
            _cost = cost;
        }

        public string ProductName
        {
            get { return _productName; }
        }

        public string StoreName
        {
            get { return _storeName; }
        }

        public double Cost
        {
            get { return _cost; }
        }
    }
}
