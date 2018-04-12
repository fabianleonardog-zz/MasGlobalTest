using RestSharp;

namespace MasGlobalTest.RestServiceClient
{
    /// <summary>
    /// Class that consume the rest operations of GrowthCodeTestService
    /// </summary>
    public class ServiceClient
    {
        // <summary>
        /// client
        /// </summary>
        private RestClient client;
        /// <summary>
        /// Rquest
        /// </summary>
        private RestRequest request;
        /// <summary>
        /// Response
        /// </summary>
        private IRestResponse response;

        /// <summary>
        /// Default constructor
        /// </summary>
        public ServiceClient(string serviceUrl)
        {
            this.client = new RestClient(serviceUrl);
        }

        /// <summary>
        /// Execute Get methods
        /// </summary>
        /// <returns></returns>
        public IRestResponse ExcuteGetMethod(string urlAction)
        {
            this.request = new RestRequest(urlAction, Method.GET);
            this.response = this.client.Execute(this.request);
            return this.response;
        }
    }
}
