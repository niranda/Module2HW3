using ShopApp.Configs;

namespace ShopApp.Services.Abstractions
{
    public interface IConfigService
    {
        int AllowedContainerCapacity { get; }
    }
}
