using Olo.Factory.Interface;
using RestSharp;

namespace Olo.Factory
{
    /// <summary>
    /// Class descibing a RESTful request of a given order
    /// </summary>
    /// <seealso cref="IRequestFactory" />
    public class OrderRequestFactory : IRequestFactory
    {
        /// <summary>
        /// Gets all toppings from JSON
        /// </summary>
        /// <returns>A JSON request of the available toppings on a pizza</returns>
        public IRestRequest GetAllToppings()
        {
            return new RestRequest(Method.GET)
            {
                OnBeforeDeserialization = resp => { resp.ContentType = "application/json"; }
            };
        }
    }
}
