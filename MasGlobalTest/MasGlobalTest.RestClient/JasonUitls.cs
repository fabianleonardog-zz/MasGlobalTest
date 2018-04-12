using RestSharp;
using RestSharp.Deserializers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasGlobalTest.RestServiceClient
{
    public static class JasonUitls<T>
    {
        /// <summary>
        /// Get the objetc response from json response
        /// </summary>
        /// <returns></returns>
        public static T GetObjectResponse(IRestResponse response)
        {
            JsonDeserializer deserial = new JsonDeserializer();
            return deserial.Deserialize<T>(response);
        }
    }
}
