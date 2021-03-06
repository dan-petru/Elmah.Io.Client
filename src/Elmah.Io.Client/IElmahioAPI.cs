// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Elmah.Io.Client
{
    using Microsoft.Rest;
    using Models;
    using Newtonsoft.Json;

    /// <summary>
    /// This is the public REST API for elmah.io. All of the integrations
    /// communicates with elmah.io through this API.&lt;br/&gt;&lt;br/&gt;For
    /// additional help getting started with the API, visit the following help
    /// articles:&lt;br/&gt;&lt;ul&gt;&lt;li&gt;[Using the REST
    /// API](https://docs.elmah.io/using-the-rest-api/)&lt;/li&gt;&lt;li&gt;[Where
    /// is my API
    /// key?](https://docs.elmah.io/where-is-my-api-key/)&lt;/li&gt;&lt;li&gt;[Where
    /// is my log
    /// ID?](https://docs.elmah.io/where-is-my-log-id/)&lt;/li&gt;&lt;li&gt;[How
    /// to configure API key
    /// permissions](https://docs.elmah.io/how-to-configure-api-key-permissions/)&lt;/li&gt;&lt;/ul&gt;
    /// </summary>
    public partial interface IElmahioAPI : System.IDisposable
    {
        /// <summary>
        /// The base URI of the service.
        /// </summary>
        System.Uri BaseUri { get; set; }

        /// <summary>
        /// Gets or sets json serialization settings.
        /// </summary>
        JsonSerializerSettings SerializationSettings { get; }

        /// <summary>
        /// Gets or sets json deserialization settings.
        /// </summary>
        JsonSerializerSettings DeserializationSettings { get; }

        /// <summary>
        /// Subscription credentials which uniquely identify client
        /// subscription.
        /// </summary>
        ServiceClientCredentials Credentials { get; }


        /// <summary>
        /// Gets the IDeployments.
        /// </summary>
        IDeployments Deployments { get; }

        /// <summary>
        /// Gets the IHeartbeats.
        /// </summary>
        IHeartbeats Heartbeats { get; }

        /// <summary>
        /// Gets the ILogs.
        /// </summary>
        ILogs Logs { get; }

        /// <summary>
        /// Gets the IMessages.
        /// </summary>
        IMessages Messages { get; }

        /// <summary>
        /// Gets the IUptimeChecks.
        /// </summary>
        IUptimeChecks UptimeChecks { get; }

    }
}
