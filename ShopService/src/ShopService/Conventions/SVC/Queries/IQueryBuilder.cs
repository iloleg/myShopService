namespace ShopService.Conventions.SVC.Queries
{
    public interface IQueryBuilder
    {
        IQueryFor<TResult> For<TResult>();
    }
}
