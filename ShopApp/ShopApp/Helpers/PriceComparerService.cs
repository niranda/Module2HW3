using System.Collections.Generic;
using ShopApp.Models;

namespace ShopApp.Helpers
{
    public class PriceComparerService : IComparer<Sweet>
    {
        public int Compare(Sweet firstSweet, Sweet secondSweet)
        {
            if (firstSweet == null || secondSweet == null)
            {
                return 0;
            }
            else if (firstSweet.PriceInUAH > secondSweet.PriceInUAH)
            {
                return 1;
            }
            else if (firstSweet.PriceInUAH < secondSweet.PriceInUAH)
            {
                return -1;
            }

            return 0;
        }
    }
}
