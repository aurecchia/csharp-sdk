/**
 * Wallee SDK Client
 *
 * This client allows to interact with the Wallee API.
 *
 * Wallee API: 1.0.0
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Customweb.Wallee.Client;
using Customweb.Wallee.Util;
using Customweb.Wallee.Model;

namespace Customweb.Wallee.Service
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITransactionInvoiceService : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Count
        /// </summary>
        /// <remarks>
        /// Counts the number of items in the database as restricted by the given filter.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="filter">The filter which restricts the entities which are used to calculate the count. (optional)</param>
        /// <returns>long?</returns>
        long? Count (long? spaceId, EntityQueryFilter filter = null);

        /// <summary>
        /// Count
        /// </summary>
        /// <remarks>
        /// Counts the number of items in the database as restricted by the given filter.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="filter">The filter which restricts the entities which are used to calculate the count. (optional)</param>
        /// <returns>ApiResponse of long?</returns>
        ApiResponse<long?> CountWithHttpInfo (long? spaceId, EntityQueryFilter filter = null);

        /// <summary>
        /// getInvoiceDocument
        /// </summary>
        /// <remarks>
        /// Returns the PDF document for the transaction invoice with given id.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction invoice to get the document for.</param>
        /// <returns>RenderedDocument</returns>
        RenderedDocument GetInvoiceDocument (long? spaceId, long? id);

        /// <summary>
        /// getInvoiceDocument
        /// </summary>
        /// <remarks>
        /// Returns the PDF document for the transaction invoice with given id.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction invoice to get the document for.</param>
        /// <returns>ApiResponse of RenderedDocument</returns>
        ApiResponse<RenderedDocument> GetInvoiceDocumentWithHttpInfo (long? spaceId, long? id);

        /// <summary>
        /// getInvoiceDocumentWithTargetMediaType
        /// </summary>
        /// <remarks>
        /// Returns the PDF document for the transaction invoice with given id and target media type id.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction invoice to get the document for.</param>
        /// <param name="targetMediaTypeId">The id of the target media type for which the invoice should be generated for.</param>
        /// <returns>RenderedDocument</returns>
        RenderedDocument GetInvoiceDocumentWithTargetMediaType (long? spaceId, long? id, long? targetMediaTypeId);

        /// <summary>
        /// getInvoiceDocumentWithTargetMediaType
        /// </summary>
        /// <remarks>
        /// Returns the PDF document for the transaction invoice with given id and target media type id.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction invoice to get the document for.</param>
        /// <param name="targetMediaTypeId">The id of the target media type for which the invoice should be generated for.</param>
        /// <returns>ApiResponse of RenderedDocument</returns>
        ApiResponse<RenderedDocument> GetInvoiceDocumentWithTargetMediaTypeWithHttpInfo (long? spaceId, long? id, long? targetMediaTypeId);

        /// <summary>
        /// isReplacementPossible
        /// </summary>
        /// <remarks>
        /// Returns whether the transaction invoice with the given id can be replaced.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The invoice which should be checked if a replacement is possible.</param>
        /// <returns>bool?</returns>
        bool? IsReplacementPossible (long? spaceId, long? id);

        /// <summary>
        /// isReplacementPossible
        /// </summary>
        /// <remarks>
        /// Returns whether the transaction invoice with the given id can be replaced.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The invoice which should be checked if a replacement is possible.</param>
        /// <returns>ApiResponse of bool?</returns>
        ApiResponse<bool?> IsReplacementPossibleWithHttpInfo (long? spaceId, long? id);

        /// <summary>
        /// Mark as Derecognized
        /// </summary>
        /// <remarks>
        /// Marks the transaction invoice with the given id as derecognized.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction invoice which should be marked as derecognized.</param>
        /// <returns>TransactionInvoice</returns>
        TransactionInvoice MarkAsDerecognized (long? spaceId, long? id);

        /// <summary>
        /// Mark as Derecognized
        /// </summary>
        /// <remarks>
        /// Marks the transaction invoice with the given id as derecognized.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction invoice which should be marked as derecognized.</param>
        /// <returns>ApiResponse of TransactionInvoice</returns>
        ApiResponse<TransactionInvoice> MarkAsDerecognizedWithHttpInfo (long? spaceId, long? id);

        /// <summary>
        /// Mark as Paid
        /// </summary>
        /// <remarks>
        /// Marks the transaction invoice with the given id as paid.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction invoice which should be marked as paid.</param>
        /// <returns>TransactionInvoice</returns>
        TransactionInvoice MarkAsPaid (long? spaceId, long? id);

        /// <summary>
        /// Mark as Paid
        /// </summary>
        /// <remarks>
        /// Marks the transaction invoice with the given id as paid.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction invoice which should be marked as paid.</param>
        /// <returns>ApiResponse of TransactionInvoice</returns>
        ApiResponse<TransactionInvoice> MarkAsPaidWithHttpInfo (long? spaceId, long? id);

        /// <summary>
        /// Read
        /// </summary>
        /// <remarks>
        /// Reads the entity with the given &#39;id&#39; and returns it.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction invoices which should be returned.</param>
        /// <returns>TransactionInvoice</returns>
        TransactionInvoice Read (long? spaceId, long? id);

        /// <summary>
        /// Read
        /// </summary>
        /// <remarks>
        /// Reads the entity with the given &#39;id&#39; and returns it.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction invoices which should be returned.</param>
        /// <returns>ApiResponse of TransactionInvoice</returns>
        ApiResponse<TransactionInvoice> ReadWithHttpInfo (long? spaceId, long? id);

        /// <summary>
        /// replace
        /// </summary>
        /// <remarks>
        /// Replaces the transaction invoice with given id with the replacement and returns the new transaction invoice.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction invoices which should be replaced.</param>
        /// <param name="replacement"></param>
        /// <returns>TransactionInvoice</returns>
        TransactionInvoice Replace (long? spaceId, long? id, TransactionInvoiceReplacement replacement);

        /// <summary>
        /// replace
        /// </summary>
        /// <remarks>
        /// Replaces the transaction invoice with given id with the replacement and returns the new transaction invoice.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction invoices which should be replaced.</param>
        /// <param name="replacement"></param>
        /// <returns>ApiResponse of TransactionInvoice</returns>
        ApiResponse<TransactionInvoice> ReplaceWithHttpInfo (long? spaceId, long? id, TransactionInvoiceReplacement replacement);

        /// <summary>
        /// Search
        /// </summary>
        /// <remarks>
        /// Searches for the entities as specified by the given query.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the transaction invoices which are returned by the search.</param>
        /// <returns>List&lt;TransactionInvoice&gt;</returns>
        List<TransactionInvoice> Search (long? spaceId, EntityQuery query);

        /// <summary>
        /// Search
        /// </summary>
        /// <remarks>
        /// Searches for the entities as specified by the given query.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the transaction invoices which are returned by the search.</param>
        /// <returns>ApiResponse of List&lt;TransactionInvoice&gt;</returns>
        ApiResponse<List<TransactionInvoice>> SearchWithHttpInfo (long? spaceId, EntityQuery query);

        #endregion Synchronous Operations
        #region Asynchronous Operations

        /// <summary>
        /// Count
        /// </summary>
        /// <remarks>
        /// Counts the number of items in the database as restricted by the given filter.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="filter">The filter which restricts the entities which are used to calculate the count. (optional)</param>
        /// <returns>Task of long?</returns>
        System.Threading.Tasks.Task<long?> CountAsync (long? spaceId, EntityQueryFilter filter = null);

        /// <summary>
        /// Count
        /// </summary>
        /// <remarks>
        /// Counts the number of items in the database as restricted by the given filter.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="filter">The filter which restricts the entities which are used to calculate the count. (optional)</param>
        /// <returns>Task of ApiResponse (long?)</returns>
        System.Threading.Tasks.Task<ApiResponse<long?>> CountAsyncWithHttpInfo (long? spaceId, EntityQueryFilter filter = null);

        /// <summary>
        /// getInvoiceDocument
        /// </summary>
        /// <remarks>
        /// Returns the PDF document for the transaction invoice with given id.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction invoice to get the document for.</param>
        /// <returns>Task of RenderedDocument</returns>
        System.Threading.Tasks.Task<RenderedDocument> GetInvoiceDocumentAsync (long? spaceId, long? id);

        /// <summary>
        /// getInvoiceDocument
        /// </summary>
        /// <remarks>
        /// Returns the PDF document for the transaction invoice with given id.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction invoice to get the document for.</param>
        /// <returns>Task of ApiResponse (RenderedDocument)</returns>
        System.Threading.Tasks.Task<ApiResponse<RenderedDocument>> GetInvoiceDocumentAsyncWithHttpInfo (long? spaceId, long? id);

        /// <summary>
        /// getInvoiceDocumentWithTargetMediaType
        /// </summary>
        /// <remarks>
        /// Returns the PDF document for the transaction invoice with given id and target media type id.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction invoice to get the document for.</param>
        /// <param name="targetMediaTypeId">The id of the target media type for which the invoice should be generated for.</param>
        /// <returns>Task of RenderedDocument</returns>
        System.Threading.Tasks.Task<RenderedDocument> GetInvoiceDocumentWithTargetMediaTypeAsync (long? spaceId, long? id, long? targetMediaTypeId);

        /// <summary>
        /// getInvoiceDocumentWithTargetMediaType
        /// </summary>
        /// <remarks>
        /// Returns the PDF document for the transaction invoice with given id and target media type id.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction invoice to get the document for.</param>
        /// <param name="targetMediaTypeId">The id of the target media type for which the invoice should be generated for.</param>
        /// <returns>Task of ApiResponse (RenderedDocument)</returns>
        System.Threading.Tasks.Task<ApiResponse<RenderedDocument>> GetInvoiceDocumentWithTargetMediaTypeAsyncWithHttpInfo (long? spaceId, long? id, long? targetMediaTypeId);

        /// <summary>
        /// isReplacementPossible
        /// </summary>
        /// <remarks>
        /// Returns whether the transaction invoice with the given id can be replaced.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The invoice which should be checked if a replacement is possible.</param>
        /// <returns>Task of bool?</returns>
        System.Threading.Tasks.Task<bool?> IsReplacementPossibleAsync (long? spaceId, long? id);

        /// <summary>
        /// isReplacementPossible
        /// </summary>
        /// <remarks>
        /// Returns whether the transaction invoice with the given id can be replaced.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The invoice which should be checked if a replacement is possible.</param>
        /// <returns>Task of ApiResponse (bool?)</returns>
        System.Threading.Tasks.Task<ApiResponse<bool?>> IsReplacementPossibleAsyncWithHttpInfo (long? spaceId, long? id);

        /// <summary>
        /// Mark as Derecognized
        /// </summary>
        /// <remarks>
        /// Marks the transaction invoice with the given id as derecognized.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction invoice which should be marked as derecognized.</param>
        /// <returns>Task of TransactionInvoice</returns>
        System.Threading.Tasks.Task<TransactionInvoice> MarkAsDerecognizedAsync (long? spaceId, long? id);

        /// <summary>
        /// Mark as Derecognized
        /// </summary>
        /// <remarks>
        /// Marks the transaction invoice with the given id as derecognized.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction invoice which should be marked as derecognized.</param>
        /// <returns>Task of ApiResponse (TransactionInvoice)</returns>
        System.Threading.Tasks.Task<ApiResponse<TransactionInvoice>> MarkAsDerecognizedAsyncWithHttpInfo (long? spaceId, long? id);

        /// <summary>
        /// Mark as Paid
        /// </summary>
        /// <remarks>
        /// Marks the transaction invoice with the given id as paid.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction invoice which should be marked as paid.</param>
        /// <returns>Task of TransactionInvoice</returns>
        System.Threading.Tasks.Task<TransactionInvoice> MarkAsPaidAsync (long? spaceId, long? id);

        /// <summary>
        /// Mark as Paid
        /// </summary>
        /// <remarks>
        /// Marks the transaction invoice with the given id as paid.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction invoice which should be marked as paid.</param>
        /// <returns>Task of ApiResponse (TransactionInvoice)</returns>
        System.Threading.Tasks.Task<ApiResponse<TransactionInvoice>> MarkAsPaidAsyncWithHttpInfo (long? spaceId, long? id);

        /// <summary>
        /// Read
        /// </summary>
        /// <remarks>
        /// Reads the entity with the given &#39;id&#39; and returns it.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction invoices which should be returned.</param>
        /// <returns>Task of TransactionInvoice</returns>
        System.Threading.Tasks.Task<TransactionInvoice> ReadAsync (long? spaceId, long? id);

        /// <summary>
        /// Read
        /// </summary>
        /// <remarks>
        /// Reads the entity with the given &#39;id&#39; and returns it.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction invoices which should be returned.</param>
        /// <returns>Task of ApiResponse (TransactionInvoice)</returns>
        System.Threading.Tasks.Task<ApiResponse<TransactionInvoice>> ReadAsyncWithHttpInfo (long? spaceId, long? id);

        /// <summary>
        /// replace
        /// </summary>
        /// <remarks>
        /// Replaces the transaction invoice with given id with the replacement and returns the new transaction invoice.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction invoices which should be replaced.</param>
        /// <param name="replacement"></param>
        /// <returns>Task of TransactionInvoice</returns>
        System.Threading.Tasks.Task<TransactionInvoice> ReplaceAsync (long? spaceId, long? id, TransactionInvoiceReplacement replacement);

        /// <summary>
        /// replace
        /// </summary>
        /// <remarks>
        /// Replaces the transaction invoice with given id with the replacement and returns the new transaction invoice.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction invoices which should be replaced.</param>
        /// <param name="replacement"></param>
        /// <returns>Task of ApiResponse (TransactionInvoice)</returns>
        System.Threading.Tasks.Task<ApiResponse<TransactionInvoice>> ReplaceAsyncWithHttpInfo (long? spaceId, long? id, TransactionInvoiceReplacement replacement);

        /// <summary>
        /// Search
        /// </summary>
        /// <remarks>
        /// Searches for the entities as specified by the given query.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the transaction invoices which are returned by the search.</param>
        /// <returns>Task of List&lt;TransactionInvoice&gt;</returns>
        System.Threading.Tasks.Task<List<TransactionInvoice>> SearchAsync (long? spaceId, EntityQuery query);

        /// <summary>
        /// Search
        /// </summary>
        /// <remarks>
        /// Searches for the entities as specified by the given query.
        /// </remarks>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the transaction invoices which are returned by the search.</param>
        /// <returns>Task of ApiResponse (List&lt;TransactionInvoice&gt;)</returns>
        System.Threading.Tasks.Task<ApiResponse<List<TransactionInvoice>>> SearchAsyncWithHttpInfo (long? spaceId, EntityQuery query);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TransactionInvoiceService : ITransactionInvoiceService
    {
        private readonly Customweb.Wallee.Client.ExceptionFactory _exceptionFactory;

        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionInvoiceService"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TransactionInvoiceService(Configuration configuration = null)
        {
            this._configuration = CheckArgument.NotNull("configuration", configuration);
            this._apiClient = new ApiClient(configuration);
            this._exceptionFactory = Configuration.ExceptionFactory;
        }

        private readonly ApiClient _apiClient;

        public ApiClient ApiClient
        {
            get { return _apiClient; }
        }

        private readonly Configuration _configuration;

        public Configuration Configuration
        {
            get { return _configuration; }
        }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Customweb.Wallee.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
        }

        /// <summary>
        /// Count Counts the number of items in the database as restricted by the given filter.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="filter">The filter which restricts the entities which are used to calculate the count. (optional)</param>
        /// <returns>long?</returns>
        public long? Count (long? spaceId, EntityQueryFilter filter = null)
        {
             ApiResponse<long?> localVarResponse = CountWithHttpInfo(spaceId, filter);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Count Counts the number of items in the database as restricted by the given filter.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="filter">The filter which restricts the entities which are used to calculate the count. (optional)</param>
        /// <returns>ApiResponse of long?</returns>
        public ApiResponse< long? > CountWithHttpInfo (long? spaceId, EntityQueryFilter filter = null)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling TransactionInvoiceService->Count");
            }

            var localVarPath = "/transaction-invoice/count";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (filter != null && filter.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(filter); // http body (model) parameter
            }
            else
            {
                localVarPostBody = filter; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Count", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<long?>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (long?) ApiClient.Deserialize(localVarResponse, typeof(long?)));
        }

        /// <summary>
        /// Count Counts the number of items in the database as restricted by the given filter.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="filter">The filter which restricts the entities which are used to calculate the count. (optional)</param>
        /// <returns>Task of long?</returns>
        public async System.Threading.Tasks.Task<long?> CountAsync (long? spaceId, EntityQueryFilter filter = null)
        {
             ApiResponse<long?> localVarResponse = await CountAsyncWithHttpInfo(spaceId, filter);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Count Counts the number of items in the database as restricted by the given filter.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="filter">The filter which restricts the entities which are used to calculate the count. (optional)</param>
        /// <returns>Task of ApiResponse (long?)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<long?>> CountAsyncWithHttpInfo (long? spaceId, EntityQueryFilter filter = null)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling TransactionInvoiceService->Count");
            }

            var localVarPath = "/transaction-invoice/count";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (filter != null && filter.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(filter); // http body (model) parameter
            }
            else
            {
                localVarPostBody = filter; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Count", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<long?>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (long?) ApiClient.Deserialize(localVarResponse, typeof(long?)));
        }

        /// <summary>
        /// getInvoiceDocument Returns the PDF document for the transaction invoice with given id.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction invoice to get the document for.</param>
        /// <returns>RenderedDocument</returns>
        public RenderedDocument GetInvoiceDocument (long? spaceId, long? id)
        {
             ApiResponse<RenderedDocument> localVarResponse = GetInvoiceDocumentWithHttpInfo(spaceId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// getInvoiceDocument Returns the PDF document for the transaction invoice with given id.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction invoice to get the document for.</param>
        /// <returns>ApiResponse of RenderedDocument</returns>
        public ApiResponse< RenderedDocument > GetInvoiceDocumentWithHttpInfo (long? spaceId, long? id)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling TransactionInvoiceService->GetInvoiceDocument");
            }
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new ApiException(400, "Missing required parameter 'id' when calling TransactionInvoiceService->GetInvoiceDocument");
            }

            var localVarPath = "/transaction-invoice/getInvoiceDocument";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "*/*"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (id != null) localVarQueryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetInvoiceDocument", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RenderedDocument>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RenderedDocument) ApiClient.Deserialize(localVarResponse, typeof(RenderedDocument)));
        }

        /// <summary>
        /// getInvoiceDocument Returns the PDF document for the transaction invoice with given id.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction invoice to get the document for.</param>
        /// <returns>Task of RenderedDocument</returns>
        public async System.Threading.Tasks.Task<RenderedDocument> GetInvoiceDocumentAsync (long? spaceId, long? id)
        {
             ApiResponse<RenderedDocument> localVarResponse = await GetInvoiceDocumentAsyncWithHttpInfo(spaceId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// getInvoiceDocument Returns the PDF document for the transaction invoice with given id.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction invoice to get the document for.</param>
        /// <returns>Task of ApiResponse (RenderedDocument)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RenderedDocument>> GetInvoiceDocumentAsyncWithHttpInfo (long? spaceId, long? id)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling TransactionInvoiceService->GetInvoiceDocument");
            }
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new ApiException(400, "Missing required parameter 'id' when calling TransactionInvoiceService->GetInvoiceDocument");
            }

            var localVarPath = "/transaction-invoice/getInvoiceDocument";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "*/*"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (id != null) localVarQueryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetInvoiceDocument", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RenderedDocument>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RenderedDocument) ApiClient.Deserialize(localVarResponse, typeof(RenderedDocument)));
        }

        /// <summary>
        /// getInvoiceDocumentWithTargetMediaType Returns the PDF document for the transaction invoice with given id and target media type id.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction invoice to get the document for.</param>
        /// <param name="targetMediaTypeId">The id of the target media type for which the invoice should be generated for.</param>
        /// <returns>RenderedDocument</returns>
        public RenderedDocument GetInvoiceDocumentWithTargetMediaType (long? spaceId, long? id, long? targetMediaTypeId)
        {
             ApiResponse<RenderedDocument> localVarResponse = GetInvoiceDocumentWithTargetMediaTypeWithHttpInfo(spaceId, id, targetMediaTypeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// getInvoiceDocumentWithTargetMediaType Returns the PDF document for the transaction invoice with given id and target media type id.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction invoice to get the document for.</param>
        /// <param name="targetMediaTypeId">The id of the target media type for which the invoice should be generated for.</param>
        /// <returns>ApiResponse of RenderedDocument</returns>
        public ApiResponse< RenderedDocument > GetInvoiceDocumentWithTargetMediaTypeWithHttpInfo (long? spaceId, long? id, long? targetMediaTypeId)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling TransactionInvoiceService->GetInvoiceDocumentWithTargetMediaType");
            }
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new ApiException(400, "Missing required parameter 'id' when calling TransactionInvoiceService->GetInvoiceDocumentWithTargetMediaType");
            }
            // verify the required parameter 'targetMediaTypeId' is set
            if (targetMediaTypeId == null)
            {
                throw new ApiException(400, "Missing required parameter 'targetMediaTypeId' when calling TransactionInvoiceService->GetInvoiceDocumentWithTargetMediaType");
            }

            var localVarPath = "/transaction-invoice/getInvoiceDocumentWithTargetMediaType";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "*/*"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (id != null) localVarQueryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
            if (targetMediaTypeId != null) localVarQueryParams.Add("targetMediaTypeId", ApiClient.ParameterToString(targetMediaTypeId)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetInvoiceDocumentWithTargetMediaType", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RenderedDocument>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RenderedDocument) ApiClient.Deserialize(localVarResponse, typeof(RenderedDocument)));
        }

        /// <summary>
        /// getInvoiceDocumentWithTargetMediaType Returns the PDF document for the transaction invoice with given id and target media type id.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction invoice to get the document for.</param>
        /// <param name="targetMediaTypeId">The id of the target media type for which the invoice should be generated for.</param>
        /// <returns>Task of RenderedDocument</returns>
        public async System.Threading.Tasks.Task<RenderedDocument> GetInvoiceDocumentWithTargetMediaTypeAsync (long? spaceId, long? id, long? targetMediaTypeId)
        {
             ApiResponse<RenderedDocument> localVarResponse = await GetInvoiceDocumentWithTargetMediaTypeAsyncWithHttpInfo(spaceId, id, targetMediaTypeId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// getInvoiceDocumentWithTargetMediaType Returns the PDF document for the transaction invoice with given id and target media type id.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction invoice to get the document for.</param>
        /// <param name="targetMediaTypeId">The id of the target media type for which the invoice should be generated for.</param>
        /// <returns>Task of ApiResponse (RenderedDocument)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<RenderedDocument>> GetInvoiceDocumentWithTargetMediaTypeAsyncWithHttpInfo (long? spaceId, long? id, long? targetMediaTypeId)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling TransactionInvoiceService->GetInvoiceDocumentWithTargetMediaType");
            }
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new ApiException(400, "Missing required parameter 'id' when calling TransactionInvoiceService->GetInvoiceDocumentWithTargetMediaType");
            }
            // verify the required parameter 'targetMediaTypeId' is set
            if (targetMediaTypeId == null)
            {
                throw new ApiException(400, "Missing required parameter 'targetMediaTypeId' when calling TransactionInvoiceService->GetInvoiceDocumentWithTargetMediaType");
            }

            var localVarPath = "/transaction-invoice/getInvoiceDocumentWithTargetMediaType";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "*/*"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (id != null) localVarQueryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
            if (targetMediaTypeId != null) localVarQueryParams.Add("targetMediaTypeId", ApiClient.ParameterToString(targetMediaTypeId)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetInvoiceDocumentWithTargetMediaType", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<RenderedDocument>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (RenderedDocument) ApiClient.Deserialize(localVarResponse, typeof(RenderedDocument)));
        }

        /// <summary>
        /// isReplacementPossible Returns whether the transaction invoice with the given id can be replaced.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The invoice which should be checked if a replacement is possible.</param>
        /// <returns>bool?</returns>
        public bool? IsReplacementPossible (long? spaceId, long? id)
        {
             ApiResponse<bool?> localVarResponse = IsReplacementPossibleWithHttpInfo(spaceId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// isReplacementPossible Returns whether the transaction invoice with the given id can be replaced.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The invoice which should be checked if a replacement is possible.</param>
        /// <returns>ApiResponse of bool?</returns>
        public ApiResponse< bool? > IsReplacementPossibleWithHttpInfo (long? spaceId, long? id)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling TransactionInvoiceService->IsReplacementPossible");
            }
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new ApiException(400, "Missing required parameter 'id' when calling TransactionInvoiceService->IsReplacementPossible");
            }

            var localVarPath = "/transaction-invoice/isReplacementPossible";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "*/*"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (id != null) localVarQueryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("IsReplacementPossible", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<bool?>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (bool?) ApiClient.Deserialize(localVarResponse, typeof(bool?)));
        }

        /// <summary>
        /// isReplacementPossible Returns whether the transaction invoice with the given id can be replaced.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The invoice which should be checked if a replacement is possible.</param>
        /// <returns>Task of bool?</returns>
        public async System.Threading.Tasks.Task<bool?> IsReplacementPossibleAsync (long? spaceId, long? id)
        {
             ApiResponse<bool?> localVarResponse = await IsReplacementPossibleAsyncWithHttpInfo(spaceId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// isReplacementPossible Returns whether the transaction invoice with the given id can be replaced.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The invoice which should be checked if a replacement is possible.</param>
        /// <returns>Task of ApiResponse (bool?)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<bool?>> IsReplacementPossibleAsyncWithHttpInfo (long? spaceId, long? id)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling TransactionInvoiceService->IsReplacementPossible");
            }
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new ApiException(400, "Missing required parameter 'id' when calling TransactionInvoiceService->IsReplacementPossible");
            }

            var localVarPath = "/transaction-invoice/isReplacementPossible";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "*/*"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (id != null) localVarQueryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("IsReplacementPossible", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<bool?>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (bool?) ApiClient.Deserialize(localVarResponse, typeof(bool?)));
        }

        /// <summary>
        /// Mark as Derecognized Marks the transaction invoice with the given id as derecognized.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction invoice which should be marked as derecognized.</param>
        /// <returns>TransactionInvoice</returns>
        public TransactionInvoice MarkAsDerecognized (long? spaceId, long? id)
        {
             ApiResponse<TransactionInvoice> localVarResponse = MarkAsDerecognizedWithHttpInfo(spaceId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Mark as Derecognized Marks the transaction invoice with the given id as derecognized.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction invoice which should be marked as derecognized.</param>
        /// <returns>ApiResponse of TransactionInvoice</returns>
        public ApiResponse< TransactionInvoice > MarkAsDerecognizedWithHttpInfo (long? spaceId, long? id)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling TransactionInvoiceService->MarkAsDerecognized");
            }
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new ApiException(400, "Missing required parameter 'id' when calling TransactionInvoiceService->MarkAsDerecognized");
            }

            var localVarPath = "/transaction-invoice/markAsDerecognized";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (id != null) localVarQueryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("MarkAsDerecognized", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TransactionInvoice>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransactionInvoice) ApiClient.Deserialize(localVarResponse, typeof(TransactionInvoice)));
        }

        /// <summary>
        /// Mark as Derecognized Marks the transaction invoice with the given id as derecognized.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction invoice which should be marked as derecognized.</param>
        /// <returns>Task of TransactionInvoice</returns>
        public async System.Threading.Tasks.Task<TransactionInvoice> MarkAsDerecognizedAsync (long? spaceId, long? id)
        {
             ApiResponse<TransactionInvoice> localVarResponse = await MarkAsDerecognizedAsyncWithHttpInfo(spaceId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Mark as Derecognized Marks the transaction invoice with the given id as derecognized.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction invoice which should be marked as derecognized.</param>
        /// <returns>Task of ApiResponse (TransactionInvoice)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TransactionInvoice>> MarkAsDerecognizedAsyncWithHttpInfo (long? spaceId, long? id)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling TransactionInvoiceService->MarkAsDerecognized");
            }
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new ApiException(400, "Missing required parameter 'id' when calling TransactionInvoiceService->MarkAsDerecognized");
            }

            var localVarPath = "/transaction-invoice/markAsDerecognized";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (id != null) localVarQueryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("MarkAsDerecognized", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TransactionInvoice>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransactionInvoice) ApiClient.Deserialize(localVarResponse, typeof(TransactionInvoice)));
        }

        /// <summary>
        /// Mark as Paid Marks the transaction invoice with the given id as paid.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction invoice which should be marked as paid.</param>
        /// <returns>TransactionInvoice</returns>
        public TransactionInvoice MarkAsPaid (long? spaceId, long? id)
        {
             ApiResponse<TransactionInvoice> localVarResponse = MarkAsPaidWithHttpInfo(spaceId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Mark as Paid Marks the transaction invoice with the given id as paid.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction invoice which should be marked as paid.</param>
        /// <returns>ApiResponse of TransactionInvoice</returns>
        public ApiResponse< TransactionInvoice > MarkAsPaidWithHttpInfo (long? spaceId, long? id)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling TransactionInvoiceService->MarkAsPaid");
            }
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new ApiException(400, "Missing required parameter 'id' when calling TransactionInvoiceService->MarkAsPaid");
            }

            var localVarPath = "/transaction-invoice/markAsPaid";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (id != null) localVarQueryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("MarkAsPaid", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TransactionInvoice>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransactionInvoice) ApiClient.Deserialize(localVarResponse, typeof(TransactionInvoice)));
        }

        /// <summary>
        /// Mark as Paid Marks the transaction invoice with the given id as paid.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction invoice which should be marked as paid.</param>
        /// <returns>Task of TransactionInvoice</returns>
        public async System.Threading.Tasks.Task<TransactionInvoice> MarkAsPaidAsync (long? spaceId, long? id)
        {
             ApiResponse<TransactionInvoice> localVarResponse = await MarkAsPaidAsyncWithHttpInfo(spaceId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Mark as Paid Marks the transaction invoice with the given id as paid.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction invoice which should be marked as paid.</param>
        /// <returns>Task of ApiResponse (TransactionInvoice)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TransactionInvoice>> MarkAsPaidAsyncWithHttpInfo (long? spaceId, long? id)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling TransactionInvoiceService->MarkAsPaid");
            }
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new ApiException(400, "Missing required parameter 'id' when calling TransactionInvoiceService->MarkAsPaid");
            }

            var localVarPath = "/transaction-invoice/markAsPaid";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (id != null) localVarQueryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("MarkAsPaid", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TransactionInvoice>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransactionInvoice) ApiClient.Deserialize(localVarResponse, typeof(TransactionInvoice)));
        }

        /// <summary>
        /// Read Reads the entity with the given &#39;id&#39; and returns it.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction invoices which should be returned.</param>
        /// <returns>TransactionInvoice</returns>
        public TransactionInvoice Read (long? spaceId, long? id)
        {
             ApiResponse<TransactionInvoice> localVarResponse = ReadWithHttpInfo(spaceId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Read Reads the entity with the given &#39;id&#39; and returns it.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction invoices which should be returned.</param>
        /// <returns>ApiResponse of TransactionInvoice</returns>
        public ApiResponse< TransactionInvoice > ReadWithHttpInfo (long? spaceId, long? id)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling TransactionInvoiceService->Read");
            }
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new ApiException(400, "Missing required parameter 'id' when calling TransactionInvoiceService->Read");
            }

            var localVarPath = "/transaction-invoice/read";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "*/*"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (id != null) localVarQueryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Read", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TransactionInvoice>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransactionInvoice) ApiClient.Deserialize(localVarResponse, typeof(TransactionInvoice)));
        }

        /// <summary>
        /// Read Reads the entity with the given &#39;id&#39; and returns it.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction invoices which should be returned.</param>
        /// <returns>Task of TransactionInvoice</returns>
        public async System.Threading.Tasks.Task<TransactionInvoice> ReadAsync (long? spaceId, long? id)
        {
             ApiResponse<TransactionInvoice> localVarResponse = await ReadAsyncWithHttpInfo(spaceId, id);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Read Reads the entity with the given &#39;id&#39; and returns it.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction invoices which should be returned.</param>
        /// <returns>Task of ApiResponse (TransactionInvoice)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TransactionInvoice>> ReadAsyncWithHttpInfo (long? spaceId, long? id)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling TransactionInvoiceService->Read");
            }
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new ApiException(400, "Missing required parameter 'id' when calling TransactionInvoiceService->Read");
            }

            var localVarPath = "/transaction-invoice/read";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "*/*"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (id != null) localVarQueryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Read", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TransactionInvoice>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransactionInvoice) ApiClient.Deserialize(localVarResponse, typeof(TransactionInvoice)));
        }

        /// <summary>
        /// replace Replaces the transaction invoice with given id with the replacement and returns the new transaction invoice.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction invoices which should be replaced.</param>
        /// <param name="replacement"></param>
        /// <returns>TransactionInvoice</returns>
        public TransactionInvoice Replace (long? spaceId, long? id, TransactionInvoiceReplacement replacement)
        {
             ApiResponse<TransactionInvoice> localVarResponse = ReplaceWithHttpInfo(spaceId, id, replacement);
             return localVarResponse.Data;
        }

        /// <summary>
        /// replace Replaces the transaction invoice with given id with the replacement and returns the new transaction invoice.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction invoices which should be replaced.</param>
        /// <param name="replacement"></param>
        /// <returns>ApiResponse of TransactionInvoice</returns>
        public ApiResponse< TransactionInvoice > ReplaceWithHttpInfo (long? spaceId, long? id, TransactionInvoiceReplacement replacement)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling TransactionInvoiceService->Replace");
            }
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new ApiException(400, "Missing required parameter 'id' when calling TransactionInvoiceService->Replace");
            }
            // verify the required parameter 'replacement' is set
            if (replacement == null)
            {
                throw new ApiException(400, "Missing required parameter 'replacement' when calling TransactionInvoiceService->Replace");
            }

            var localVarPath = "/transaction-invoice/replace";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (id != null) localVarQueryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
            if (replacement != null && replacement.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(replacement); // http body (model) parameter
            }
            else
            {
                localVarPostBody = replacement; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Replace", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TransactionInvoice>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransactionInvoice) ApiClient.Deserialize(localVarResponse, typeof(TransactionInvoice)));
        }

        /// <summary>
        /// replace Replaces the transaction invoice with given id with the replacement and returns the new transaction invoice.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction invoices which should be replaced.</param>
        /// <param name="replacement"></param>
        /// <returns>Task of TransactionInvoice</returns>
        public async System.Threading.Tasks.Task<TransactionInvoice> ReplaceAsync (long? spaceId, long? id, TransactionInvoiceReplacement replacement)
        {
             ApiResponse<TransactionInvoice> localVarResponse = await ReplaceAsyncWithHttpInfo(spaceId, id, replacement);
             return localVarResponse.Data;
        }

        /// <summary>
        /// replace Replaces the transaction invoice with given id with the replacement and returns the new transaction invoice.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="id">The id of the transaction invoices which should be replaced.</param>
        /// <param name="replacement"></param>
        /// <returns>Task of ApiResponse (TransactionInvoice)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TransactionInvoice>> ReplaceAsyncWithHttpInfo (long? spaceId, long? id, TransactionInvoiceReplacement replacement)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling TransactionInvoiceService->Replace");
            }
            // verify the required parameter 'id' is set
            if (id == null)
            {
                throw new ApiException(400, "Missing required parameter 'id' when calling TransactionInvoiceService->Replace");
            }
            // verify the required parameter 'replacement' is set
            if (replacement == null)
            {
                throw new ApiException(400, "Missing required parameter 'replacement' when calling TransactionInvoiceService->Replace");
            }

            var localVarPath = "/transaction-invoice/replace";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (id != null) localVarQueryParams.Add("id", ApiClient.ParameterToString(id)); // query parameter
            if (replacement != null && replacement.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(replacement); // http body (model) parameter
            }
            else
            {
                localVarPostBody = replacement; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Replace", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TransactionInvoice>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TransactionInvoice) ApiClient.Deserialize(localVarResponse, typeof(TransactionInvoice)));
        }

        /// <summary>
        /// Search Searches for the entities as specified by the given query.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the transaction invoices which are returned by the search.</param>
        /// <returns>List&lt;TransactionInvoice&gt;</returns>
        public List<TransactionInvoice> Search (long? spaceId, EntityQuery query)
        {
             ApiResponse<List<TransactionInvoice>> localVarResponse = SearchWithHttpInfo(spaceId, query);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search Searches for the entities as specified by the given query.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the transaction invoices which are returned by the search.</param>
        /// <returns>ApiResponse of List&lt;TransactionInvoice&gt;</returns>
        public ApiResponse< List<TransactionInvoice> > SearchWithHttpInfo (long? spaceId, EntityQuery query)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling TransactionInvoiceService->Search");
            }
            // verify the required parameter 'query' is set
            if (query == null)
            {
                throw new ApiException(400, "Missing required parameter 'query' when calling TransactionInvoiceService->Search");
            }

            var localVarPath = "/transaction-invoice/search";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (query != null && query.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(query); // http body (model) parameter
            }
            else
            {
                localVarPostBody = query; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Search", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<TransactionInvoice>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<TransactionInvoice>) ApiClient.Deserialize(localVarResponse, typeof(List<TransactionInvoice>)));
        }

        /// <summary>
        /// Search Searches for the entities as specified by the given query.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the transaction invoices which are returned by the search.</param>
        /// <returns>Task of List&lt;TransactionInvoice&gt;</returns>
        public async System.Threading.Tasks.Task<List<TransactionInvoice>> SearchAsync (long? spaceId, EntityQuery query)
        {
             ApiResponse<List<TransactionInvoice>> localVarResponse = await SearchAsyncWithHttpInfo(spaceId, query);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Search Searches for the entities as specified by the given query.
        /// </summary>
        /// <exception cref="Customweb.Wallee.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="spaceId"></param>
        /// <param name="query">The query restricts the transaction invoices which are returned by the search.</param>
        /// <returns>Task of ApiResponse (List&lt;TransactionInvoice&gt;)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<List<TransactionInvoice>>> SearchAsyncWithHttpInfo (long? spaceId, EntityQuery query)
        {
            // verify the required parameter 'spaceId' is set
            if (spaceId == null)
            {
                throw new ApiException(400, "Missing required parameter 'spaceId' when calling TransactionInvoiceService->Search");
            }
            // verify the required parameter 'query' is set
            if (query == null)
            {
                throw new ApiException(400, "Missing required parameter 'query' when calling TransactionInvoiceService->Search");
            }

            var localVarPath = "/transaction-invoice/search";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>();
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpContentType = ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=utf-8"
            };
            String localVarHttpHeaderAccept = ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
            {
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);
            }

            if (spaceId != null) localVarQueryParams.Add("spaceId", ApiClient.ParameterToString(spaceId)); // query parameter
            if (query != null && query.GetType() != typeof(byte[]))
            {
                localVarPostBody = ApiClient.Serialize(query); // http body (model) parameter
            }
            else
            {
                localVarPostBody = query; // byte array
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("Search", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<List<TransactionInvoice>>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (List<TransactionInvoice>) ApiClient.Deserialize(localVarResponse, typeof(List<TransactionInvoice>)));
        }

    }
}
