using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using VictorianPlumbing.Domain;
using VictorianPlumbingApp.Services;

namespace VictorianPlumbingApp.Controllers
{
    public class OrdersController : Controller
    {
        private readonly IPlumbingOrderService PlumbingOrderService;

        public OrdersController(IPlumbingOrderService plumbingOrderService)
        {
            PlumbingOrderService = plumbingOrderService;
        }

        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Receives a Plumbing Order
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
            var result = await PlumbingOrderService.HandleOder(plumbingOrder);
            return Ok(result);
        }
    }
}
