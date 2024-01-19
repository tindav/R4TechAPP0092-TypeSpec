// <auto-generated/>
using Microsoft.Kiota.Abstractions;
using Ready4Tech.Kiota.Client.V1.Api.Dawndusk;
using Ready4Tech.Kiota.Client.V1.Api.Geolocation;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System;
namespace Ready4Tech.Kiota.Client.V1.Api {
    /// <summary>
    /// Builds and executes requests for operations under \v1\api
    /// </summary>
    public class ApiRequestBuilder : BaseRequestBuilder {
        /// <summary>The dawndusk property</summary>
        public DawnduskRequestBuilder Dawndusk { get =>
            new DawnduskRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>The geolocation property</summary>
        public GeolocationRequestBuilder Geolocation { get =>
            new GeolocationRequestBuilder(PathParameters, RequestAdapter);
        }
        /// <summary>
        /// Instantiates a new ApiRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="pathParameters">Path parameters for the request</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ApiRequestBuilder(Dictionary<string, object> pathParameters, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v1/api", pathParameters) {
        }
        /// <summary>
        /// Instantiates a new ApiRequestBuilder and sets the default values.
        /// </summary>
        /// <param name="rawUrl">The raw URL to use for the request builder.</param>
        /// <param name="requestAdapter">The request adapter to use to execute the requests.</param>
        public ApiRequestBuilder(string rawUrl, IRequestAdapter requestAdapter) : base(requestAdapter, "{+baseurl}/v1/api", rawUrl) {
        }
    }
}
