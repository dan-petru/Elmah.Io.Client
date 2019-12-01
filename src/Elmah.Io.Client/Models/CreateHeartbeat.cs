// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Elmah.Io.Client.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class CreateHeartbeat
    {
        /// <summary>
        /// Initializes a new instance of the CreateHeartbeat class.
        /// </summary>
        public CreateHeartbeat()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the CreateHeartbeat class.
        /// </summary>
        /// <param name="result">The result of this heartbeat. Can be "Healthy,
        /// "Degraded", or "Unhealthy". Defaults to "Healthy"</param>
        /// <param name="reason">If result is "Degraded" or "Unhealthy" you can
        /// use this property to specify why.</param>
        /// <param name="application">Optional string to identify which
        /// application logged this message. You can use this if you have
        /// multiple applications and services logging to the same log.
        /// If not set, the application name "Heartbeats" will be set on all
        /// log messages generated from this heartbeat.</param>
        /// <param name="version">Optional string to identify which version of
        /// your application logged this message. If not specified, any errors,
        /// warnings, or information messages will get
        /// the newest version number created through deployment tracking as
        /// with normal log messages.</param>
        public CreateHeartbeat(string result = default(string), string reason = default(string), string application = default(string), string version = default(string))
        {
            Result = result;
            Reason = reason;
            Application = application;
            Version = version;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the result of this heartbeat. Can be "Healthy,
        /// "Degraded", or "Unhealthy". Defaults to "Healthy"
        /// </summary>
        [JsonProperty(PropertyName = "result")]
        public string Result { get; set; }

        /// <summary>
        /// Gets or sets if result is "Degraded" or "Unhealthy" you can use
        /// this property to specify why.
        /// </summary>
        [JsonProperty(PropertyName = "reason")]
        public string Reason { get; set; }

        /// <summary>
        /// Gets or sets optional string to identify which application logged
        /// this message. You can use this if you have multiple applications
        /// and services logging to the same log.
        /// If not set, the application name "Heartbeats" will be set on all
        /// log messages generated from this heartbeat.
        /// </summary>
        [JsonProperty(PropertyName = "application")]
        public string Application { get; set; }

        /// <summary>
        /// Gets or sets optional string to identify which version of your
        /// application logged this message. If not specified, any errors,
        /// warnings, or information messages will get
        /// the newest version number created through deployment tracking as
        /// with normal log messages.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

    }
}