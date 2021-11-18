using ShopApp.Models;

namespace ShopApp.Services.Abstractions
{
    public interface ILoggerService
    {
        void SuccessfulTemplate(Sweet[] sweets);
        void SuccessfulBuildLog(Sweet[] sweets, double giftWeight);
        void SuccessfulSortLog(Sweet[] sweets);
        void SuccessfulSearchLog(Sweet[] sweets);
    }
}
