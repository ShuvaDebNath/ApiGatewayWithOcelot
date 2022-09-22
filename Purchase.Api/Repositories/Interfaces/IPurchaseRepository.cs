namespace Purchase.Api.Repositories.Interfaces
{
    public interface IPurchaseRepository
    {
        List<Models.PurchaseItem> GetAll();
        Models.PurchaseItem? Get(int id);
        int Delete(int id);
    }
}
