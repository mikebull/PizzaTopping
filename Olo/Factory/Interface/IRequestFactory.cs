using RestSharp;

namespace Olo.Factory.Interface
{
    /// <summary>
    /// Interface descibing a RESTful request of a given order
    /// </summary>
    public interface IRequestFactory
    {
        /// <summary>
        /// Gets all toppings from JSON
        /// </summary>
        /// <returns>A JSON request of the available toppings on a pizza</returns>
        IRestRequest GetAllToppings();
    }
}