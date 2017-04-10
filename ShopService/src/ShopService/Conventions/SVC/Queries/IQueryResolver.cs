namespace ShopService.Conventions.SVC.Queries
{
    public interface IQueryResolver
    {
        IQuery<TCriterion, TResult> Resolve<TCriterion, TResult>() where TCriterion : ICriterion;
    }
}
