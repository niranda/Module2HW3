using ShopApp.Models;
using ShopApp.Services;

namespace ShopApp.Helpers
{
    public static class GiftServiceExtension
    {
        public static Sweet[] FindByСriterion(this GiftService giftService, SweetType criterion)
        {
            var sweetsArray = giftService.GetGift();
            var outputSweetsArray = new Sweet[sweetsArray.Length];
            var outputIndex = 0;
            for (var i = 0; i < sweetsArray.Length; i++)
            {
                if (sweetsArray[i] == null)
                {
                    break;
                }

                if (sweetsArray[i].Type == criterion)
                {
                    outputSweetsArray[outputIndex] = sweetsArray[i];
                    outputIndex++;
                }
            }

            return outputSweetsArray;
        }
    }
}
