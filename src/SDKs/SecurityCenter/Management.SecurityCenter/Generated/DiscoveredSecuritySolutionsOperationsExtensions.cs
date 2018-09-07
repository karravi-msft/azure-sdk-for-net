// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Security
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for DiscoveredSecuritySolutionsOperations.
    /// </summary>
    public static partial class DiscoveredSecuritySolutionsOperationsExtensions
    {
            /// <summary>
            /// Gets a list of discovered Security Solutions for the subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<DiscoveredSecuritySolution> List(this IDiscoveredSecuritySolutionsOperations operations)
            {
                return operations.ListAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of discovered Security Solutions for the subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<DiscoveredSecuritySolution>> ListAsync(this IDiscoveredSecuritySolutionsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of discovered Security Solutions for the subscription and
            /// location.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<DiscoveredSecuritySolution> ListByHomeRegion(this IDiscoveredSecuritySolutionsOperations operations)
            {
                return operations.ListByHomeRegionAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of discovered Security Solutions for the subscription and
            /// location.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<DiscoveredSecuritySolution>> ListByHomeRegionAsync(this IDiscoveredSecuritySolutionsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByHomeRegionWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a specific discovered Security Solution.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='discoveredSecuritySolutionName'>
            /// Name of a discovered security solution.
            /// </param>
            public static DiscoveredSecuritySolution Get(this IDiscoveredSecuritySolutionsOperations operations, string resourceGroupName, string discoveredSecuritySolutionName)
            {
                return operations.GetAsync(resourceGroupName, discoveredSecuritySolutionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a specific discovered Security Solution.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='discoveredSecuritySolutionName'>
            /// Name of a discovered security solution.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<DiscoveredSecuritySolution> GetAsync(this IDiscoveredSecuritySolutionsOperations operations, string resourceGroupName, string discoveredSecuritySolutionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, discoveredSecuritySolutionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of discovered Security Solutions for the subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<DiscoveredSecuritySolution> ListNext(this IDiscoveredSecuritySolutionsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of discovered Security Solutions for the subscription.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<DiscoveredSecuritySolution>> ListNextAsync(this IDiscoveredSecuritySolutionsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Gets a list of discovered Security Solutions for the subscription and
            /// location.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<DiscoveredSecuritySolution> ListByHomeRegionNext(this IDiscoveredSecuritySolutionsOperations operations, string nextPageLink)
            {
                return operations.ListByHomeRegionNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets a list of discovered Security Solutions for the subscription and
            /// location.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<DiscoveredSecuritySolution>> ListByHomeRegionNextAsync(this IDiscoveredSecuritySolutionsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByHomeRegionNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
