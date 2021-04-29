using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using VictorianPlumbing.Domain;

namespace VictorianPlumbing.Infrastructure.Repositories
{
    public class ProductsRepository : IProductsRepository
    {
        protected IDbConnection Db { get; private set; }

        public ProductsRepository(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                // throw new ArgumentNullException(nameof(connectionString));
            }

            //Db = new SqlConnection(connectionString);
        }

        public Task StoreProducts(List<Product> products)
        {
            throw new NotImplementedException();
        }
    }
}
