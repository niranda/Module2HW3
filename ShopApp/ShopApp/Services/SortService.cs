using System;
using ShopApp.Models;
using ShopApp.Helpers;
using ShopApp.Services.Abstractions;

namespace ShopApp.Services
{
    public class SortService : ISortService
    {
        public Sweet[] SortByPrice(Sweet[] sweets)
        {
            Array.Sort(sweets, new PriceComparerService());
            return sweets;
        }
    }
}
