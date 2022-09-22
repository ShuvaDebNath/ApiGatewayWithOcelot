using Order.Api.Models;
using Order.Api.Repositories.Interfaces;

namespace Order.Api.Repositories.Implements
{
    public class SupplierRepository : List<Models.Suppliers>, ISupplierRepository
    {
        private readonly static List<Models.Suppliers> _suppliers = Populate();

        private static List<Models.Suppliers> Populate()
        {
            return new List<Models.Suppliers>
            {
                new Models.Suppliers
                {
                    Id = 1,
                    SupplierName = "Nur Enterprise"
                },
                new Models.Suppliers
                {
                    Id = 2,
                    SupplierName = "Maak Corporation"
                },
                new Models.Suppliers
                {
                    Id = 3,
                    SupplierName = "Bismillah Enterprise"
                }
            };
        }

        public List<Models.Suppliers> GetAll()
        {
            return _suppliers;
        }

        public Models.Suppliers Insert(Models.Suppliers suppliers)
        {
            var maxId = _suppliers.Max(x => x.Id);

            suppliers.Id = ++maxId;
            _suppliers.Add(suppliers);

            return suppliers;
        }

        public Models.Suppliers? Get(int id)
        {
            return _suppliers.FirstOrDefault(x => x.Id == id);
        }
    }
}
