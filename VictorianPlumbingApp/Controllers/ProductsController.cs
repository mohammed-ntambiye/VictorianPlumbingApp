using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using VictorianPlumbing.Domain;

namespace VictorianPlumbingApp.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Receives a customer
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("product")]
        public async Task<ActionResult> Post([FromBody] Product product)
        {
            if (product == null)
            {
                return BadRequest($"Empty {nameof(product)} was submitted");
            }
            return Ok();
        }
    }
}
