/* 
 * Infoplus API
 *
 * Infoplus API.
 *
 * OpenAPI spec version: beta
 * Contact: api@infopluscommerce.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Infoplus.Client;
using Infoplus.Model;

namespace Infoplus.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IFulfillmentProcessPickBatchGroupApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get a fulfillmentProcessPickBatchGroup by id
        /// </summary>
        /// <remarks>
        /// Returns the fulfillmentProcessPickBatchGroup identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fulfillmentProcessPickBatchGroupId">Id of fulfillmentProcessPickBatchGroup to be returned.</param>
        /// <returns>FulfillmentProcessPickBatchGroup</returns>
        FulfillmentProcessPickBatchGroup GetFulfillmentProcessGroupPicksByById (string fulfillmentProcessPickBatchGroupId);

        /// <summary>
        /// Get a fulfillmentProcessPickBatchGroup by id
        /// </summary>
        /// <remarks>
        /// Returns the fulfillmentProcessPickBatchGroup identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fulfillmentProcessPickBatchGroupId">Id of fulfillmentProcessPickBatchGroup to be returned.</param>
        /// <returns>ApiResponse of FulfillmentProcessPickBatchGroup</returns>
        ApiResponse<FulfillmentProcessPickBatchGroup> GetFulfillmentProcessGroupPicksByByIdWithHttpInfo (string fulfillmentProcessPickBatchGroupId);
        /// <summary>
        /// Search fulfillmentProcessPickBatchGroups
        /// </summary>
        /// <remarks>
        /// Returns the list of fulfillmentProcessPickBatchGroups that match the given searchText.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchText">Search text, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <returns>List&lt;FulfillmentProcessPickBatchGroup&gt;</returns>
        List<FulfillmentProcessPickBatchGroup> GetFulfillmentProcessPickBatchGroupBySearchText (string searchText = null, int? page = null, int? limit = null);

        /// <summary>
        /// Search fulfillmentProcessPickBatchGroups
        /// </summary>
        /// <remarks>
        /// Returns the list of fulfillmentProcessPickBatchGroups that match the given searchText.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchText">Search text, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <returns>ApiResponse of List&lt;FulfillmentProcessPickBatchGroup&gt;</returns>
        ApiResponse<List<FulfillmentProcessPickBatchGroup>> GetFulfillmentProcessPickBatchGroupBySearchTextWithHttpInfo (string searchText = null, int? page = null, int? limit = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get a fulfillmentProcessPickBatchGroup by id
        /// </summary>
        /// <remarks>
        /// Returns the fulfillmentProcessPickBatchGroup identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fulfillmentProcessPickBatchGroupId">Id of fulfillmentProcessPickBatchGroup to be returned.</param>
        /// <returns>Task of FulfillmentProcessPickBatchGroup</returns>
        System.Threading.Tasks.Task<FulfillmentProcessPickBatchGroup> GetFulfillmentProcessGroupPicksByByIdAsync (string fulfillmentProcessPickBatchGroupId);

        /// <summary>
        /// Get a fulfillmentProcessPickBatchGroup by id
        /// </summary>
        /// <remarks>
        /// Returns the fulfillmentProcessPickBatchGroup identified by the specified id.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fulfillmentProcessPickBatchGroupId">Id of fulfillmentProcessPickBatchGroup to be returned.</param>
        /// <returns>Task of ApiResponse (FulfillmentProcessPickBatchGroup)</returns>
        System.Threading.Tasks.Task<ApiResponse<FulfillmentProcessPickBatchGroup>> GetFulfillmentProcessGroupPicksByByIdAsyncWithHttpInfo (string fulfillmentProcessPickBatchGroupId);
        /// <summary>
        /// Search fulfillmentProcessPickBatchGroups
        /// </summary>
        /// <remarks>
        /// Returns the list of fulfillmentProcessPickBatchGroups that match the given searchText.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchText">Search text, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <returns>Task of List&lt;FulfillmentProcessPickBatchGroup&gt;</returns>
        System.Threading.Tasks.Task<List<FulfillmentProcessPickBatchGroup>> GetFulfillmentProcessPickBatchGroupBySearchTextAsync (string searchText = null, int? page = null, int? limit = null);

        /// <summary>
        /// Search fulfillmentProcessPickBatchGroups
        /// </summary>
        /// <remarks>
        /// Returns the list of fulfillmentProcessPickBatchGroups that match the given searchText.
        /// </remarks>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchText">Search text, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;FulfillmentProcessPickBatchGroup&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<FulfillmentProcessPickBatchGroup>>> GetFulfillmentProcessPickBatchGroupBySearchTextAsyncWithHttpInfo (string searchText = null, int? page = null, int? limit = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class FulfillmentProcessPickBatchGroupApi : IFulfillmentProcessPickBatchGroupApi
    {
        private Infoplus.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="FulfillmentProcessPickBatchGroupApi"/> class.
        /// </summary>
        /// <returns></returns>
        public FulfillmentProcessPickBatchGroupApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = Infoplus.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FulfillmentProcessPickBatchGroupApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public FulfillmentProcessPickBatchGroupApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Infoplus.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Infoplus.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Get a fulfillmentProcessPickBatchGroup by id Returns the fulfillmentProcessPickBatchGroup identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fulfillmentProcessPickBatchGroupId">Id of fulfillmentProcessPickBatchGroup to be returned.</param>
        /// <returns>FulfillmentProcessPickBatchGroup</returns>
        public FulfillmentProcessPickBatchGroup GetFulfillmentProcessGroupPicksByById (string fulfillmentProcessPickBatchGroupId)
        {
             ApiResponse<FulfillmentProcessPickBatchGroup> localVarResponse = GetFulfillmentProcessGroupPicksByByIdWithHttpInfo(fulfillmentProcessPickBatchGroupId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a fulfillmentProcessPickBatchGroup by id Returns the fulfillmentProcessPickBatchGroup identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fulfillmentProcessPickBatchGroupId">Id of fulfillmentProcessPickBatchGroup to be returned.</param>
        /// <returns>ApiResponse of FulfillmentProcessPickBatchGroup</returns>
        public ApiResponse< FulfillmentProcessPickBatchGroup > GetFulfillmentProcessGroupPicksByByIdWithHttpInfo (string fulfillmentProcessPickBatchGroupId)
        {
            // verify the required parameter 'fulfillmentProcessPickBatchGroupId' is set
            if (fulfillmentProcessPickBatchGroupId == null)
                throw new ApiException(400, "Missing required parameter 'fulfillmentProcessPickBatchGroupId' when calling FulfillmentProcessPickBatchGroupApi->GetFulfillmentProcessGroupPicksByById");

            var localVarPath = "/beta/fulfillmentProcessPickBatchGroup/{fulfillmentProcessPickBatchGroupId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (fulfillmentProcessPickBatchGroupId != null) localVarPathParams.Add("fulfillmentProcessPickBatchGroupId", Configuration.ApiClient.ParameterToString(fulfillmentProcessPickBatchGroupId)); // path parameter

            // authentication (api_key) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("API-Key")))
            {
                localVarHeaderParams["API-Key"] = Configuration.GetApiKeyWithPrefix("API-Key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetFulfillmentProcessGroupPicksByById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<FulfillmentProcessPickBatchGroup>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FulfillmentProcessPickBatchGroup) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FulfillmentProcessPickBatchGroup)));
        }

        /// <summary>
        /// Get a fulfillmentProcessPickBatchGroup by id Returns the fulfillmentProcessPickBatchGroup identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fulfillmentProcessPickBatchGroupId">Id of fulfillmentProcessPickBatchGroup to be returned.</param>
        /// <returns>Task of FulfillmentProcessPickBatchGroup</returns>
        public async System.Threading.Tasks.Task<FulfillmentProcessPickBatchGroup> GetFulfillmentProcessGroupPicksByByIdAsync (string fulfillmentProcessPickBatchGroupId)
        {
             ApiResponse<FulfillmentProcessPickBatchGroup> localVarResponse = await GetFulfillmentProcessGroupPicksByByIdAsyncWithHttpInfo(fulfillmentProcessPickBatchGroupId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a fulfillmentProcessPickBatchGroup by id Returns the fulfillmentProcessPickBatchGroup identified by the specified id.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="fulfillmentProcessPickBatchGroupId">Id of fulfillmentProcessPickBatchGroup to be returned.</param>
        /// <returns>Task of ApiResponse (FulfillmentProcessPickBatchGroup)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<FulfillmentProcessPickBatchGroup>> GetFulfillmentProcessGroupPicksByByIdAsyncWithHttpInfo (string fulfillmentProcessPickBatchGroupId)
        {
            // verify the required parameter 'fulfillmentProcessPickBatchGroupId' is set
            if (fulfillmentProcessPickBatchGroupId == null)
                throw new ApiException(400, "Missing required parameter 'fulfillmentProcessPickBatchGroupId' when calling FulfillmentProcessPickBatchGroupApi->GetFulfillmentProcessGroupPicksByById");

            var localVarPath = "/beta/fulfillmentProcessPickBatchGroup/{fulfillmentProcessPickBatchGroupId}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (fulfillmentProcessPickBatchGroupId != null) localVarPathParams.Add("fulfillmentProcessPickBatchGroupId", Configuration.ApiClient.ParameterToString(fulfillmentProcessPickBatchGroupId)); // path parameter

            // authentication (api_key) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("API-Key")))
            {
                localVarHeaderParams["API-Key"] = Configuration.GetApiKeyWithPrefix("API-Key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetFulfillmentProcessGroupPicksByById", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<FulfillmentProcessPickBatchGroup>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (FulfillmentProcessPickBatchGroup) Configuration.ApiClient.Deserialize(localVarResponse, typeof(FulfillmentProcessPickBatchGroup)));
        }

        /// <summary>
        /// Search fulfillmentProcessPickBatchGroups Returns the list of fulfillmentProcessPickBatchGroups that match the given searchText.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchText">Search text, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <returns>List&lt;FulfillmentProcessPickBatchGroup&gt;</returns>
        public List<FulfillmentProcessPickBatchGroup> GetFulfillmentProcessPickBatchGroupBySearchText (string searchText = null, int? page = null, int? limit = null)
        {
             ApiResponse<List<FulfillmentProcessPickBatchGroup>> localVarResponse = GetFulfillmentProcessPickBatchGroupBySearchTextWithHttpInfo(searchText, page, limit);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search fulfillmentProcessPickBatchGroups Returns the list of fulfillmentProcessPickBatchGroups that match the given searchText.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchText">Search text, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <returns>ApiResponse of List&lt;FulfillmentProcessPickBatchGroup&gt;</returns>
        public ApiResponse< List<FulfillmentProcessPickBatchGroup> > GetFulfillmentProcessPickBatchGroupBySearchTextWithHttpInfo (string searchText = null, int? page = null, int? limit = null)
        {

            var localVarPath = "/beta/fulfillmentProcessPickBatchGroup/search";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (searchText != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "searchText", searchText)); // query parameter
            if (page != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter

            // authentication (api_key) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("API-Key")))
            {
                localVarHeaderParams["API-Key"] = Configuration.GetApiKeyWithPrefix("API-Key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetFulfillmentProcessPickBatchGroupBySearchText", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<FulfillmentProcessPickBatchGroup>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<FulfillmentProcessPickBatchGroup>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<FulfillmentProcessPickBatchGroup>)));
        }

        /// <summary>
        /// Search fulfillmentProcessPickBatchGroups Returns the list of fulfillmentProcessPickBatchGroups that match the given searchText.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchText">Search text, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <returns>Task of List&lt;FulfillmentProcessPickBatchGroup&gt;</returns>
        public async System.Threading.Tasks.Task<List<FulfillmentProcessPickBatchGroup>> GetFulfillmentProcessPickBatchGroupBySearchTextAsync (string searchText = null, int? page = null, int? limit = null)
        {
             ApiResponse<List<FulfillmentProcessPickBatchGroup>> localVarResponse = await GetFulfillmentProcessPickBatchGroupBySearchTextAsyncWithHttpInfo(searchText, page, limit);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Search fulfillmentProcessPickBatchGroups Returns the list of fulfillmentProcessPickBatchGroups that match the given searchText.
        /// </summary>
        /// <exception cref="Infoplus.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="searchText">Search text, used to filter results. (optional)</param>
        /// <param name="page">Result page number.  Defaults to 1. (optional)</param>
        /// <param name="limit">Maximum results per page.  Defaults to 20.  Max allowed value is 250. (optional)</param>
        /// <returns>Task of ApiResponse (List&lt;FulfillmentProcessPickBatchGroup&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<FulfillmentProcessPickBatchGroup>>> GetFulfillmentProcessPickBatchGroupBySearchTextAsyncWithHttpInfo (string searchText = null, int? page = null, int? limit = null)
        {

            var localVarPath = "/beta/fulfillmentProcessPickBatchGroup/search";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (searchText != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "searchText", searchText)); // query parameter
            if (page != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "page", page)); // query parameter
            if (limit != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "limit", limit)); // query parameter

            // authentication (api_key) required
            if (!String.IsNullOrEmpty(Configuration.GetApiKeyWithPrefix("API-Key")))
            {
                localVarHeaderParams["API-Key"] = Configuration.GetApiKeyWithPrefix("API-Key");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetFulfillmentProcessPickBatchGroupBySearchText", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<FulfillmentProcessPickBatchGroup>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<FulfillmentProcessPickBatchGroup>) Configuration.ApiClient.Deserialize(localVarResponse, typeof(List<FulfillmentProcessPickBatchGroup>)));
        }

    }
}
