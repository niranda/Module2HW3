using System;
using ShopApp.Models;
using ShopApp.Providers;
using ShopApp.Services.Abstractions;

namespace ShopApp.Services
{
    public class GiftService : IGiftService
    {
        private static readonly GiftService _instance = new GiftService();
        private readonly GiftProvider _giftProvider;
        private readonly ConfigService _configuration;

        static GiftService()
        {
        }

        public GiftService()
        {
            _giftProvider = new GiftProvider();
            _configuration = ConfigService.Instance;
        }

        public static GiftService Instance => _instance;

        public void BuildGift(Sweet[] sweets)
        {
            var length = Math.Min(sweets.Length, _configuration.AllowedContainerCapacity);
            for (var i = 0; i < length; i++)
            {
                if (sweets[i] == null)
                {
                    break;
                }

                _giftProvider.CandiesContainer[i] = sweets[i];
                _giftProvider.GeneralWeight += sweets[i].WeightInGm;
            }
        }

        public Sweet[] GetGift()
        {
            return _giftProvider.CandiesContainer;
        }

        public double GetGiftWeight()
        {
            return _giftProvider.GeneralWeight;
        }
    }
}
