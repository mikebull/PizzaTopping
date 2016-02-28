using RestSharp;

namespace Olo.Factory.Interface
{
    /// <summary>
    /// Interface descibing a REST client factory
    /// </summary>
    public interface IClientFactory
    {
        /// <summary>
        /// Creates an instance of a RESTful client
        /// </summary>
        /// <returns>A rest client</returns>
        IRestClient Create();
    }
}