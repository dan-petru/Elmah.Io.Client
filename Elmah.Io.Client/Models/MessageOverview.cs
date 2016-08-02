// Code generated by Microsoft (R) AutoRest Code Generator 0.16.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Elmah.Io.Client.Models
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;

    public partial class MessageOverview
    {
        /// <summary>
        /// Initializes a new instance of the MessageOverview class.
        /// </summary>
        public MessageOverview() { }

        /// <summary>
        /// Initializes a new instance of the MessageOverview class.
        /// </summary>
        public MessageOverview(string id = default(string), string application = default(string), string detail = default(string), string hostname = default(string), string title = default(string), string source = default(string), int? statusCode = default(int?), DateTime? dateTime = default(DateTime?), string type = default(string), string user = default(string), string severity = default(string), string url = default(string), string method = default(string), string version = default(string))
        {
            Id = id;
            Application = application;
            Detail = detail;
            Hostname = hostname;
            Title = title;
            Source = source;
            StatusCode = statusCode;
            DateTime = dateTime;
            Type = type;
            User = user;
            Severity = severity;
            Url = url;
            Method = method;
            Version = version;
        }

        /// <summary>
        /// The ID of this message.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Used to identify which application logged this message. You can
        /// use this if you have multiple applications and services logging
        /// to the same log
        /// </summary>
        [JsonProperty(PropertyName = "application")]
        public string Application { get; set; }

        /// <summary>
        /// A longer description of the message. For errors this could be a
        /// stacktrace, but it's really up to you what to log in there.
        /// </summary>
        [JsonProperty(PropertyName = "detail")]
        public string Detail { get; set; }

        /// <summary>
        /// The hostname of the server logging the message.
        /// </summary>
        [JsonProperty(PropertyName = "hostname")]
        public string Hostname { get; set; }

        /// <summary>
        /// The textual title or headline of the message to log.
        /// </summary>
        [JsonProperty(PropertyName = "title")]
        public string Title { get; set; }

        /// <summary>
        /// The source of the code logging the message. This could be the
        /// assembly name.
        /// </summary>
        [JsonProperty(PropertyName = "source")]
        public string Source { get; set; }

        /// <summary>
        /// If the message logged relates to a HTTP status code, you can put
        /// the code in this property. This would probably only be relevant
        /// for errors,
        /// but could be used for logging successful status codes
        /// as well.
        /// </summary>
        [JsonProperty(PropertyName = "statusCode")]
        public int? StatusCode { get; set; }

        /// <summary>
        /// The date and time of the message. If you don't provide us with a
        /// value in dateTime, we will set the current date and time in UTC.
        /// </summary>
        [JsonProperty(PropertyName = "dateTime")]
        public DateTime? DateTime { get; set; }

        /// <summary>
        /// The type of message. If logging an error, the type of the
        /// exception would go into type but you can put anything in there,
        /// that makes sense for your domain.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// An identification of the user triggering this message. You can put
        /// the users email address or your user key into this property.
        /// </summary>
        [JsonProperty(PropertyName = "user")]
        public string User { get; set; }

        /// <summary>
        /// An enum value representing the severity of this message. The
        /// following values are allowed: Verbose, Debug, Information,
        /// Warning, Error, Fatal
        /// </summary>
        [JsonProperty(PropertyName = "severity")]
        public string Severity { get; set; }

        /// <summary>
        /// If message relates to a HTTP request, you may send the URL of that
        /// request. If you don't provide us with an URL, we will try to find
        /// a key named URL in serverVariables.
        /// </summary>
        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        /// <summary>
        /// If message relates to a HTTP request, you may send the HTTP method
        /// of that request. If you don't provide us with a method, we will
        /// try to find a key named REQUEST_METHOD in serverVariables.
        /// </summary>
        [JsonProperty(PropertyName = "method")]
        public string Method { get; set; }

        /// <summary>
        /// Versions can be used to distinguish messages from different
        /// versions of your software. The value of version can be a SemVer
        /// compliant string or any other
        /// syntax that you are using as your version numbering
        /// scheme.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

    }
}
