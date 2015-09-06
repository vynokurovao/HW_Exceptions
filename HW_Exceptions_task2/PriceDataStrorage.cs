
using System;
using System.Collections.Generic;

namespace HW_Exceptions_task2
{
    public class PriceDataStrorage
    {
        private SortedSet<Price> _prices = new SortedSet<Price>(new StoreComparer());

        public List<Price> FindAllProductsFromStore(string storeName)
        {
            List<Price> prices = new List<Price>();
            foreach(Price price in _prices)
            {
                if (price.StoreName.Equals(storeName))
                {
                    prices.Add(price);
                }
            }

            if (prices.Count == 0)
            {
                throw new KeyNotFoundException("There is no store with such name");
            }

            return prices;
        }

        public void AddPrice(Price price)
        {
            if (price.Cost < 0)
            {
                throw new ArgumentException("The price can not be negative");
            }
            _prices.Add(price);
        }
    }
}
