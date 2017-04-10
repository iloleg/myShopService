using ShopService.Conventions.SVC.Queries;

namespace ShopService.SVC.Criterions.DeliveryIntervals
{
    public class DeliveryIntervalTemplateViewModelCriterion : ICriterion
    {
        public DeliveryIntervalTemplateViewModelCriterion(long? deliveryIntervalTemplateId)
        {
            DeliveryIntervalTemplateId = deliveryIntervalTemplateId;
        }

        public long? DeliveryIntervalTemplateId { get; set; }
    }
}
