using ShopApp.Models;

namespace ShopApp.Services.Abstractions
{
    public interface ISortService
    {
        Sweet[] SortByPrice(Sweet[] sweets);
    }
}
