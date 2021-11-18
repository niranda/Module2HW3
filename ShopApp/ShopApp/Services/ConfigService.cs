using ShopApp.Configs;
using ShopApp.Services.Abstractions;

namespace ShopApp.Services
{
    public class ConfigService : IConfigService
    {
        private static readonly ConfigService _instance = new ConfigService();
        static ConfigService()
        {
        }

        private ConfigService()
        {
            var config = GetConfig();
            AllowedContainerCapacity = config.AllowedContainerCapacity;
        }

        public static ConfigService Instance => _instance;

        public int AllowedContainerCapacity { get; }

        private Config GetConfig()
        {
            return new Config
            {
                AllowedContainerCapacity = 4
            };
        }
    }
}
