using System.Threading.Tasks;
using VictorianPlumbing.Domain;

namespace VictorianPlumbingApp.Services
{
    public interface IPlumbingOrderService
    {
        Task<bool> HandleOder(PlumbingOrder order);
    }
}
