using Purchase.Api.Models;
using Purchase.Api.Repositories.Interfaces;

namespace Purchase.Api.Repositories.Implements
{
    public class PurchaseRepository : List<Models.PurchaseItem>, IPurchaseRepository
    {
        private readonly static List<Models.PurchaseItem> _purchaseItems = Populate();

        private static List<Models.PurchaseItem> Populate()
        {
            var result = new List<Models.PurchaseItem>()
            {
                new Models.PurchaseItem
                {
                    Id = 1,
                    PurchaseItems = "White Chips",
                    PurchaseQty = 10560,
                    PurchaseRate = 64,
                    PurchaseAmount = 675840,
                    SupplierId = 1
                },
                new Models.PurchaseItem
                {
                    Id = 2,
                    PurchaseItems = "Brown Chips",
                    PurchaseQty = 9530,
                    PurchaseRate = 32,
                    PurchaseAmount = 304960,
                    SupplierId= 1  
                },
                new Models.PurchaseItem
                {
                    Id = 3,
                    PurchaseItems = "Green Chips",
                    PurchaseQty = 9850,
                    PurchaseRate = 35,
                    PurchaseAmount = 344750,
                    SupplierId = 2
                }
            };

            return result;
        }

        public List<Models.PurchaseItem> GetAll()
        {
            return _purchaseItems;
        }

        public Models.PurchaseItem? Get(int id)
        {
            return _purchaseItems.FirstOrDefault(x => x.Id == id);
        }

        public int Delete(int id)
        {
            var removed = _purchaseItems.SingleOrDefault(x => x.Id == id);

            if (removed != null)
                _purchaseItems.Remove(removed);

            return removed?.Id ?? 0;
        }
    }
}
