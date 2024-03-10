using Demo.Listing.Api.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace Demo.Listings.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ListingsController : ControllerBase
    {
        private readonly ILogger<ListingsController> _logger;

        public ListingsController(ILogger<ListingsController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public IActionResult Add([FromBody] ListingReq listingReq)
        {
            return Ok();
        }
    }

}