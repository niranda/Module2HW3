using ShopApp.Models;

namespace ShopApp.Services.Abstractions
{
    public interface IGiftService
    {
        void BuildGift(Sweet[] sweets);
        Sweet[] GetGift();
        double GetGiftWeight();
    }
}
