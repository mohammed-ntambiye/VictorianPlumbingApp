using System;
using System.Threading.Tasks;
using VictorianPlumbing.Domain;
using VictorianPlumbing.Infrastructure.Repositories;

namespace VictorianPlumbingApp.Services
{
    public class PlumbingOrderService : IPlumbingOrderService
    {
        public ICustomerRepository CustomerRepository;
        public IOrdersRepository OrdersRepository;
        public IProductsRepository ProductRepository;

        public PlumbingOrderService(ICustomerRepository customerRepository, IOrdersRepository ordersRepository, IProductsRepository productRepository)
        {
            CustomerRepository = customerRepository ?? throw new ArgumentNullException(nameof(customerRepository)); ;
            OrdersRepository = ordersRepository ?? throw new ArgumentNullException(nameof(ordersRepository)); ;
            ProductRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository)); ;
        }

        public async Task<bool> HandleOder(PlumbingOrder order)
        {
            //Before passing the split order you'd do some processing
            await CustomerRepository.StoreCustomer(order.Customer);
            await ProductRepository.StoreProducts(order.Items);

            //You would return results from the repository
            return true;
        }
    }
}
