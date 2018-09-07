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
    /// Extension methods for PricingsOperations.
    /// </summary>
    public static partial class PricingsOperationsExtensions
    {
            /// <summary>
            /// Security pricing configurations in the subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            public static IPage<Pricing> List(this IPricingsOperations operations)
            {
                return operations.ListAsync().GetAwaiter().GetResult();
            }

            /// <summary>
            /// Security pricing configurations in the subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Pricing>> ListAsync(this IPricingsOperations operations, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListWithHttpMessagesAsync(null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Security pricing configurations in the resource group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            public static IPage<Pricing> ListByResourceGroup(this IPricingsOperations operations, string resourceGroupName)
            {
                return operations.ListByResourceGroupAsync(resourceGroupName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Security pricing configurations in the resource group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<Pricing>> ListByResourceGroupAsync(this IPricingsOperations operations, string resourceGroupName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupWithHttpMessagesAsync(resourceGroupName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Security pricing configuration in the subscriptionSecurity pricing
            /// configuration in the subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='pricingName'>
            /// name of the pricing configuration
            /// </param>
            public static Pricing GetSubscriptionPricing(this IPricingsOperations operations, string pricingName)
            {
                return operations.GetSubscriptionPricingAsync(pricingName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Security pricing configuration in the subscriptionSecurity pricing
            /// configuration in the subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='pricingName'>
            /// name of the pricing configuration
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Pricing> GetSubscriptionPricingAsync(this IPricingsOperations operations, string pricingName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetSubscriptionPricingWithHttpMessagesAsync(pricingName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Security pricing configuration in the subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='pricingName'>
            /// name of the pricing configuration
            /// </param>
            /// <param name='pricingTier'>
            /// Pricing tier type. Possible values include: 'Free', 'Standard'
            /// </param>
            public static Pricing UpdateSubscriptionPricing(this IPricingsOperations operations, string pricingName, string pricingTier)
            {
                return operations.UpdateSubscriptionPricingAsync(pricingName, pricingTier).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Security pricing configuration in the subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='pricingName'>
            /// name of the pricing configuration
            /// </param>
            /// <param name='pricingTier'>
            /// Pricing tier type. Possible values include: 'Free', 'Standard'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Pricing> UpdateSubscriptionPricingAsync(this IPricingsOperations operations, string pricingName, string pricingTier, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.UpdateSubscriptionPricingWithHttpMessagesAsync(pricingName, pricingTier, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Security pricing configuration in the resource group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='pricingName'>
            /// name of the pricing configuration
            /// </param>
            public static Pricing GetResourceGroupPricing(this IPricingsOperations operations, string resourceGroupName, string pricingName)
            {
                return operations.GetResourceGroupPricingAsync(resourceGroupName, pricingName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Security pricing configuration in the resource group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='pricingName'>
            /// name of the pricing configuration
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Pricing> GetResourceGroupPricingAsync(this IPricingsOperations operations, string resourceGroupName, string pricingName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetResourceGroupPricingWithHttpMessagesAsync(resourceGroupName, pricingName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Security pricing configuration in the resource group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='pricingName'>
            /// name of the pricing configuration
            /// </param>
            /// <param name='pricingTier'>
            /// Pricing tier type. Possible values include: 'Free', 'Standard'
            /// </param>
            public static Pricing CreateOrUpdateResourceGroupPricing(this IPricingsOperations operations, string resourceGroupName, string pricingName, string pricingTier)
            {
                return operations.CreateOrUpdateResourceGroupPricingAsync(resourceGroupName, pricingName, pricingTier).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Security pricing configuration in the resource group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group within the user's subscription. The name is
            /// case insensitive.
            /// </param>
            /// <param name='pricingName'>
            /// name of the pricing configuration
            /// </param>
            /// <param name='pricingTier'>
            /// Pricing tier type. Possible values include: 'Free', 'Standard'
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Pricing> CreateOrUpdateResourceGroupPricingAsync(this IPricingsOperations operations, string resourceGroupName, string pricingName, string pricingTier, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateOrUpdateResourceGroupPricingWithHttpMessagesAsync(resourceGroupName, pricingName, pricingTier, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Security pricing configurations in the subscription
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Pricing> ListNext(this IPricingsOperations operations, string nextPageLink)
            {
                return operations.ListNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Security pricing configurations in the subscription
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
            public static async Task<IPage<Pricing>> ListNextAsync(this IPricingsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Security pricing configurations in the resource group
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            public static IPage<Pricing> ListByResourceGroupNext(this IPricingsOperations operations, string nextPageLink)
            {
                return operations.ListByResourceGroupNextAsync(nextPageLink).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Security pricing configurations in the resource group
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
            public static async Task<IPage<Pricing>> ListByResourceGroupNextAsync(this IPricingsOperations operations, string nextPageLink, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByResourceGroupNextWithHttpMessagesAsync(nextPageLink, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}
