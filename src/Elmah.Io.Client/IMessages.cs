// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Elmah.Io.Client
{
    using Microsoft.Rest;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Messages operations.
    /// </summary>
    public partial interface IMessages
    {
        /// <summary>
        /// Fetch messages from a log.
        /// </summary>
        /// <param name='logId'>
        /// The ID of the log containing the messages.
        /// </param>
        /// <param name='pageIndex'>
        /// The page number of the result.
        /// </param>
        /// <param name='pageSize'>
        /// The number of messages to load (max 100) or 15 if not set.
        /// </param>
        /// <param name='query'>
        /// A full-text or Lucene query to limit the messages by.
        /// </param>
        /// <param name='fromParameter'>
        /// A start date and time to search from (not included).
        /// </param>
        /// <param name='to'>
        /// An end date and time to search to (not included).
        /// </param>
        /// <param name='includeHeaders'>
        /// Include headers like server variables and cookies in the result
        /// (slower).
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<MessagesResult>> GetAllWithHttpMessagesAsync(string logId, int? pageIndex = 0, int? pageSize = 15, string query = default(string), System.DateTime? fromParameter = default(System.DateTime?), System.DateTime? to = default(System.DateTime?), bool? includeHeaders = false, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a list of messages by logid and query.
        /// </summary>
        /// <param name='logId'>
        /// The ID of the log containing the message.
        /// </param>
        /// <param name='body'>
        /// A search object containing query, time filters etc.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> DeleteAllWithHttpMessagesAsync(string logId, Search body = default(Search), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create a new message.
        /// </summary>
        /// <param name='logId'>
        /// The ID of the log which should contain the new message.
        /// </param>
        /// <param name='body'>
        /// The message object to create.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<CreateMessageResult>> CreateWithHttpMessagesAsync(string logId, CreateMessage body = default(CreateMessage), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Fetch a message by its ID.
        /// </summary>
        /// <param name='id'>
        /// The ID of the message to fetch.
        /// </param>
        /// <param name='logId'>
        /// The ID of the log containing the message.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<Message>> GetWithHttpMessagesAsync(string id, string logId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Delete a message by its ID.
        /// </summary>
        /// <param name='id'>
        /// The ID of the message to delete.
        /// </param>
        /// <param name='logId'>
        /// The ID of the log containing the message.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> DeleteWithHttpMessagesAsync(string id, string logId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Hide a message by its ID.
        /// </summary>
        /// <param name='id'>
        /// The ID of the message to hide.
        /// </param>
        /// <param name='logId'>
        /// The ID of the log containing the message.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> HideWithHttpMessagesAsync(string id, string logId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Fix a message by its ID.
        /// </summary>
        /// <param name='id'>
        /// The ID of the message to fix.
        /// </param>
        /// <param name='logId'>
        /// The ID of the log containing the message.
        /// </param>
        /// <param name='markAllAsFixed'>
        /// If set to true, all instances of the log message are set to fixed.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse> FixWithHttpMessagesAsync(string id, string logId, bool? markAllAsFixed = false, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create one or more new messages.
        /// </summary>
        /// <param name='logId'>
        /// The ID of the log which should contain the new messages.
        /// </param>
        /// <param name='body'>
        /// The messages to create.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="Microsoft.Rest.HttpOperationException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<HttpOperationResponse<IList<CreateBulkMessageResult>>> CreateBulkWithHttpMessagesAsync(string logId, IList<CreateMessage> body = default(IList<CreateMessage>), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
