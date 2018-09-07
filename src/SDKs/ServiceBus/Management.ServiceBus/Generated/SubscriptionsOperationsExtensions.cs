// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.ServiceBus
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for SubscriptionsOperations.
    /// </summary>
    public static partial class SubscriptionsOperationsExtensions
    {
            /// <summary>
            /// List all the subscriptions under a specified topic.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639400.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='topicName'>
            /// The topic name.
            /// </param>
            /// <param name='skip'>
            /// Skip is only used if a previous operation returned a partial result. If a
            /// previous response contains a nextLink element, the value of the nextLink
            /// element will include a skip parameter that specifies a starting point to
            /// use for subsequent calls.
            /// </param>
            /// <param name='top'>
            /// May be used to limit the number of results to the most recent N
            /// usageDetails.
            /// </param>
            public static IPage<SBSubscription> ListByTopic(this ISubscriptionsOperations operations, string resourceGroupName, string namespaceName, string topicName, int? skip = default(int?), int? top = default(int?))
            {
                return operations.ListByTopicAsync(resourceGroupName, namespaceName, topicName, skip, top).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List all the subscriptions under a specified topic.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639400.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='topicName'>
            /// The topic name.
            /// </param>
            /// <param name='skip'>
            /// Skip is only used if a previous operation returned a partial result. If a
            /// previous response contains a nextLink element, the value of the nextLink
            /// element will include a skip parameter that specifies a starting point to
            /// use for subsequent calls.
            /// </param>
            /// <param name='top'>
            /// May be used to limit the number of results to the most recent N
            /// usageDetails.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<SBSubscription>> ListByTopicAsync(this ISubscriptionsOperations operations, string resourceGroupName, string namespaceName, string topicName, int? skip = default(int?), int? top = default(int?), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByTopicWithHttpMessagesAsync(resourceGroupName, namespaceName, topicName, skip, top, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Creates a topic subscription.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639385.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='topicName'>
            /// The topic name.
            /// </param>
            /// <param name='subscriptionName'>
            /// The subscription name.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to create a subscription resource.
            /// </param>
            public static SBSubscription CreateOrUpdate(this ISubscriptionsOperations operations, string resourceGroupName, string namespaceName, string topicName, string subscriptionName, SBSubscription parameters)
            {
                return operations.CreateOrUpdateAsync(resourceGroupName, namespaceName, topicName, subscriptionName, parameters).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Creates a topic subscription.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639385.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='topicName'>
            /// The topic name.
            /// </param>
            /// <param name='subscriptionName'>
            /// The subscription name.
            /// </param>
            /// <param name='parameters'>
            /// Parameters supplied to create a subscription resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SBSubscription> CreateOrUpdateAsync(this ISubscriptionsOperations operations, string resourceGroupName, string namespaceName, string topicName, string subscriptionName, SBSubscription parameters, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateWithHttpMessagesAsync(resourceGroupName, namespaceName, topicName, subscriptionName, parameters, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes a subscription from the specified topic.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639381.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='topicName'>
            /// The topic name.
            /// </param>
            /// <param name='subscriptionName'>
            /// The subscription name.
            /// </param>
            public static void Delete(this ISubscriptionsOperations operations, string resourceGroupName, string namespaceName, string topicName, string subscriptionName)
            {
                operations.DeleteAsync(resourceGroupName, namespaceName, topicName, subscriptionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes a subscription from the specified topic.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639381.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='topicName'>
            /// The topic name.
            /// </param>
            /// <param name='subscriptionName'>
            /// The subscription name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task DeleteAsync(this ISubscriptionsOperations operations, string resourceGroupName, string namespaceName, string topicName, string subscriptionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                (await operations.DeleteWithHttpMessagesAsync(resourceGroupName, namespaceName, topicName, subscriptionName, null, cancellationToken).ConfigureAwait(false)).Dispose();
            }

            /// <summary>
            /// Returns a subscription description for the specified topic.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639402.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='topicName'>
            /// The topic name.
            /// </param>
            /// <param name='subscriptionName'>
            /// The subscription name.
            /// </param>
            public static SBSubscription Get(this ISubscriptionsOperations operations, string resourceGroupName, string namespaceName, string topicName, string subscriptionName)
            {
                return operations.GetAsync(resourceGroupName, namespaceName, topicName, subscriptionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns a subscription description for the specified topic.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639402.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// Name of the Resource group within the Azure subscription.
            /// </param>
            /// <param name='namespaceName'>
            /// The namespace name
            /// </param>
            /// <param name='topicName'>
            /// The topic name.
            /// </param>
            /// <param name='subscriptionName'>
            /// The subscription name.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<SBSubscription> GetAsync(this ISubscriptionsOperations operations, string resourceGroupName, string namespaceName, string topicName, string subscriptionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, namespaceName, topicName, subscriptionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// List all the subscriptions under a specified topic.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639400.aspx" />
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<SBSubscription> ListByTopicNext(this ISubscriptionsOperations operations, string nextPageLink)
            {
                return operations.ListByTopicNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// List all the subscriptions under a specified topic.
            /// <see href="https://msdn.microsoft.com/en-us/library/azure/mt639400.aspx" />
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
            public static async Task<IPage<SBSubscription>> ListByTopicNextAsync(this ISubscriptionsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByTopicNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
