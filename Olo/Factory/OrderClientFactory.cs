using Olo.Factory.Interface;
using RestSharp;

namespace Olo.Factory
{
    /// <summary>
    /// Class descibing a REST client factory
    /// </summary>
    /// <seealso cref="IClientFactory" />
    public class OrderClientFactory : IClientFactory
    {
        /// <summary>
        /// Creates an instance of a RESTful client
        /// </summary>
        /// <returns>A rest client</returns>
        public IRestClient Create()
        {
            return new RestClient("http://files.olo.com/pizzas.json");
        }
    }
}
