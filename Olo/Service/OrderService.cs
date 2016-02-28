using System.Collections.Generic;
using System.Linq;
using Olo.Factory.Interface;
using Olo.Model;
using Olo.Service.Interface;

namespace Olo.Service
{
    /// <summary>
    /// Class describing an order
    /// </summary>
    /// <seealso cref="IOrderService" />
    public class OrderService : IOrderService
    {
        /// <summary>
        /// The client
        /// </summary>
        private readonly IClientFactory _client;

        /// <summary>
        /// The request
        /// </summary>
        private readonly IRequestFactory _request;

        /// <summary>
        /// Initialises a new instance of the <see cref="OrderService"/> class.
        /// </summary>
        /// <param name="client">The client.</param>
        /// <param name="request">The request.</param>
        public OrderService(IClientFactory client, IRequestFactory request)
        {
            _client = client;
            _request = request;
        }

        /// <summary>
        /// Gets the most popular toppings from the service
        /// </summary>
        /// <param name="rank">The rank.</param>
        /// <returns>A ranked list of the most popular toppings with a total</returns>
        public List<Rank> MostPopularToppings(int rank)
        {
            var client = _client.Create();
            var request = _request.GetAllToppings();

            var pizzas = client
                .Execute<List<Pizza>>(request)
                .Data;

            return pizzas
                .SelectMany(pizza => pizza.Toppings)
                .GroupBy(topping => topping)
                .Select(topping => new Rank { Topping = topping.Key, Total = topping.Count() })
                .OrderByDescending(topping => topping.Total)
                .Take(rank)
                .ToList();
        }
    }
}
