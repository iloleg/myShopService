

namespace ShopService.Conventions
{
    interface IInitializable
    {
        int Order { get; }
        void Initialize();
    }
}
