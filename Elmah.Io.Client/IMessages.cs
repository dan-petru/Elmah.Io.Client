// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Elmah.Io.Client
{
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Rest;
    using Models;

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
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse<MessagesResult>> GetAllWithHttpMessagesAsync(string logId, int? pageIndex = default(int?), int? pageSize = default(int?), string query = default(string), DateTime? fromParameter = default(DateTime?), DateTime? to = default(DateTime?), Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Create a new message.
        /// </summary>
        /// <param name='logId'>
        /// The ID of the log which should contain the new message.
        /// </param>
        /// <param name='message'>
        /// The message object to create.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> CreateWithHttpMessagesAsync(string logId, CreateMessage message, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a list of messages by logid and query.
        /// </summary>
        /// <param name='logId'>
        /// The ID of the log containing the message.
        /// </param>
        /// <param name='search'>
        /// A search object containing query, time filters etc.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        Task<HttpOperationResponse> DeleteAllWithHttpMessagesAsync(string logId, Search search, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
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
        Task<HttpOperationResponse> HideWithHttpMessagesAsync(string id, string logId, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}