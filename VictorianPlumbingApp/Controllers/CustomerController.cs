using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using VictorianPlumbing.Domain;

namespace VictorianPlumbingApp.Controllers
{
    public class CustomerController : Controller
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
        [Route("Customer")]
        public async Task<ActionResult> Post([FromBody] Customer customer)
        {
            if (customer == null)
            {
                return BadRequest($"Empty {nameof(customer)} was submitted");
            }
            return Ok();
        }
    }
}
