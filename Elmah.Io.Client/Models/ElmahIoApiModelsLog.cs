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

    public partial class ElmahIoApiModelsLog
    {
        /// <summary>
        /// Initializes a new instance of the ElmahIoApiModelsLog class.
        /// </summary>
        public ElmahIoApiModelsLog() { }

        /// <summary>
        /// Initializes a new instance of the ElmahIoApiModelsLog class.
        /// </summary>
        public ElmahIoApiModelsLog(string id = default(string), string name = default(string))
        {
            Id = id;
            Name = name;
        }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

    }
}
