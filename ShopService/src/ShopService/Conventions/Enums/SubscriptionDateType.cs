using System.ComponentModel.DataAnnotations;

namespace ShopService.Conventions.Enums
{
    public enum SubscriptionDateType
    {
        [Display(Name = "Подписка Остановлена")]
        Suspend = 10,
        [Display(Name = "Подписка Начата")]
        Start = 20
    }
}
