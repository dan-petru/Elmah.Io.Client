// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Elmah.Io.Client.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    public partial class Deployment
    {
        /// <summary>
        /// Initializes a new instance of the Deployment class.
        /// </summary>
        public Deployment()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Deployment class.
        /// </summary>
        /// <param name="id">The ID of this deployment.</param>
        /// <param name="version">The version number of this deployment. The
        /// value of version can be a SemVer compliant string or any other
        /// syntax that you are using as your version numbering scheme.</param>
        /// <param name="created">When was this deployment created.</param>
        /// <param name="createdBy">The elmah.io id of the user creating this
        /// deployment. Since deployments are created on a subscription,
        /// the CreatedBy will contain the id of the user with the
        /// subscription.</param>
        /// <param name="description">Sescription of this deployment in
        /// markdown or clear text.</param>
        /// <param name="userName">The name of the person responsible for
        /// creating this deployment.</param>
        /// <param name="userEmail">The email of the person responsible for
        /// creating this deployment.</param>
        /// <param name="logId">If the deployment is attached a single log,
        /// this property is set to the ID of that log.
        /// If null, the deployment is attached all logs on the
        /// organization.</param>
        public Deployment(string id = default(string), string version = default(string), System.DateTime? created = default(System.DateTime?), string createdBy = default(string), string description = default(string), string userName = default(string), string userEmail = default(string), string logId = default(string))
        {
            Id = id;
            Version = version;
            Created = created;
            CreatedBy = createdBy;
            Description = description;
            UserName = userName;
            UserEmail = userEmail;
            LogId = logId;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the ID of this deployment.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the version number of this deployment. The value of
        /// version can be a SemVer compliant string or any other
        /// syntax that you are using as your version numbering scheme.
        /// </summary>
        [JsonProperty(PropertyName = "version")]
        public string Version { get; set; }

        /// <summary>
        /// Gets or sets when was this deployment created.
        /// </summary>
        [JsonProperty(PropertyName = "created")]
        public System.DateTime? Created { get; set; }

        /// <summary>
        /// Gets or sets the elmah.io id of the user creating this deployment.
        /// Since deployments are created on a subscription,
        /// the CreatedBy will contain the id of the user with the
        /// subscription.
        /// </summary>
        [JsonProperty(PropertyName = "createdBy")]
        public string CreatedBy { get; set; }

        /// <summary>
        /// Gets or sets sescription of this deployment in markdown or clear
        /// text.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        /// <summary>
        /// Gets or sets the name of the person responsible for creating this
        /// deployment.
        /// </summary>
        [JsonProperty(PropertyName = "userName")]
        public string UserName { get; set; }

        /// <summary>
        /// Gets or sets the email of the person responsible for creating this
        /// deployment.
        /// </summary>
        [JsonProperty(PropertyName = "userEmail")]
        public string UserEmail { get; set; }

        /// <summary>
        /// Gets or sets if the deployment is attached a single log, this
        /// property is set to the ID of that log.
        /// If null, the deployment is attached all logs on the organization.
        /// </summary>
        [JsonProperty(PropertyName = "logId")]
        public string LogId { get; set; }

    }
}
