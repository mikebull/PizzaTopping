using System.Collections.Generic;
using Olo.Model;

namespace Olo.Service.Interface
{
    /// <summary>
    /// Interface describing an order
    /// </summary>
    public interface IOrderService
    {
        /// <summary>
        /// Gets the most popular toppings from the service
        /// </summary>
        /// <param name="rank">The rank.</param>
        /// <returns>A ranked list of the most popular toppings with a total</returns>
        List<Rank> MostPopularToppings(int rank);
    }
}
