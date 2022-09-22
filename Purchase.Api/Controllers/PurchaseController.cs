using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Purchase.Api.Repositories.Interfaces;

namespace Purchase.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseController : ControllerBase
    {
        private readonly IPurchaseRepository _purchaseRepository;
        public PurchaseController(IPurchaseRepository purchaseRepository)
        {
            _purchaseRepository = purchaseRepository;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_purchaseRepository.GetAll());
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var article = _purchaseRepository.Get(id);
            if (article is null)
                return NotFound();
            return Ok(article);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var deletedId = _purchaseRepository.Delete(id);
            if (deletedId == 0)
                return NotFound();
            return NoContent();
        }
    }
}
