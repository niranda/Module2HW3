using ShopApp.Models;
using ShopApp.Services;
namespace ShopApp.Providers
{
    public class GiftProvider
    {
        private readonly ConfigService _configuration;

        public GiftProvider()
        {
            _configuration = ConfigService.Instance;
            CandiesContainer = new Sweet[_configuration.AllowedContainerCapacity];
        }

        public Sweet[] CandiesContainer { get; set; }
        public double GeneralWeight { get; set; }
    }
}
