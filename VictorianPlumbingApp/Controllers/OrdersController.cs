using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using VictorianPlumbing.Domain;

namespace VictorianPlumbingApp.Controllers
{
    public class OrdersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Receives a PlumbingOrder
        /// </summary>
        /// <param name="plumbingOrder"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("plumbing-order")]
        public async Task<ActionResult> Post([FromBody] PlumbingOrder plumbingOrder)
        {
            if (plumbingOrder == null)
            {
                return BadRequest($"Empty {nameof(plumbingOrder)} was submitted");
            }
            return Ok();
        }
    }
}
