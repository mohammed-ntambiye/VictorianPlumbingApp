using System.Threading.Tasks;

namespace VictorianPlumbing.Domain.Services
{
    public interface IPlumbingOrderService
    {
        Task HandleOder(PlumbingOrder order);
    }
}
