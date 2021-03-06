// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Elmah.Io.Client
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for Deployments.
    /// </summary>
    public static partial class DeploymentsExtensions
    {
            /// <summary>
            /// Fetch a list of deployments.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IList<Deployment> GetAll(this IDeployments operations)
            {
                return operations.GetAllAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Fetch a list of deployments.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<Deployment>> GetAllAsync(this IDeployments operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetAllWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Create a new deployment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// The deployment object to create.
            /// </param>
            public static CreateDeploymentResult Create(this IDeployments operations, CreateDeployment body = default(CreateDeployment))
            {
                return operations.CreateAsync(body).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Create a new deployment.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='body'>
            /// The deployment object to create.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<CreateDeploymentResult> CreateAsync(this IDeployments operations, CreateDeployment body = default(CreateDeployment), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(body, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Fetch a deployment by its ID.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// The ID of the deployment to fetch.
            /// </param>
            public static Deployment Get(this IDeployments operations, string id)
            {
                return operations.GetAsync(id).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Fetch a deployment by its ID.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// The ID of the deployment to fetch.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Deployment> GetAsync(this IDeployments operations, string id, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Delete a deployment by its ID.
            /// </summary>
            /// <remarks>
            /// This endpoint doesn't clear the version number of messages already
            /// annotated with this deployment version.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// The ID of the deployment to delete.
            /// </param>
            public static void Delete(this IDeployments operations, string id)
            {
                operations.DeleteAsync(id).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Delete a deployment by its ID.
            /// </summary>
            /// <remarks>
            /// This endpoint doesn't clear the version number of messages already
            /// annotated with this deployment version.
            /// </remarks>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='id'>
            /// The ID of the deployment to delete.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this IDeployments operations, string id, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(id, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

    }
}
