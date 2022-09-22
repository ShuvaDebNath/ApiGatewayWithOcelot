namespace Order.Api.Repositories.Interfaces
{
    public interface ISupplierRepository
    {
        List<Models.Suppliers> GetAll();
        Models.Suppliers? Get(int id);
        Models.Suppliers Insert(Models.Suppliers suppliers);
    }
}
