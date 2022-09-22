using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Order.Api.Repositories.Interfaces;

namespace Order.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuppliersController : ControllerBase
    {
        private readonly ISupplierRepository _supplierRepository;

        public SuppliersController(ISupplierRepository supplierRepository)
        {
            _supplierRepository = supplierRepository;

        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_supplierRepository.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var suppliers = _supplierRepository.Get(id);

            if (suppliers is null)
                return NotFound();

            return Ok(suppliers);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Models.Suppliers suppliers)
        {
            var result = _supplierRepository.Insert(suppliers);

            return Created($"/get/{result.Id}", result);
        }
    }
}
