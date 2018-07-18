// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Network
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// VpnConnectionsOperations operations.
    /// </summary>
    public partial interface IVpnConnectionsOperations
    {
        /// <summary>
        /// Retrieves the details of a vpn connection.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the VpnGateway.
        /// </param>
        /// <param name='gatewayName'>
        /// The name of the gateway.
        /// </param>
        /// <param name='connectionName'>
        /// The name of the vpn connection.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<VpnConnection>> GetWithHttpMessagesAsync(string resourceGroupName, string gatewayName, string connectionName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates a vpn connection to a scalable vpn gateway if it doesn't
        /// exist else updates the existing connection.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the VpnGateway.
        /// </param>
        /// <param name='gatewayName'>
        /// The name of the gateway.
        /// </param>
        /// <param name='connectionName'>
        /// The name of the connection.
        /// </param>
        /// <param name='vpnConnectionParameters'>
        /// Parameters supplied to create or Update a VPN Connection.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<VpnConnection>> CreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string gatewayName, string connectionName, VpnConnection vpnConnectionParameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a vpn connection.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the VpnGateway.
        /// </param>
        /// <param name='gatewayName'>
        /// The name of the gateway.
        /// </param>
        /// <param name='connectionName'>
        /// The name of the connection.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> DeleteWithHttpMessagesAsync(string resourceGroupName, string gatewayName, string connectionName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Retrieves all vpn connections for a particular virtual wan vpn
        /// gateway.
        /// </summary>
        /// <param name='gatewayName'>
        /// The name of the gateway.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<VpnConnection>>> ListByVpnGatewayWithHttpMessagesAsync(string gatewayName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Creates a vpn connection to a scalable vpn gateway if it doesn't
        /// exist else updates the existing connection.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the VpnGateway.
        /// </param>
        /// <param name='gatewayName'>
        /// The name of the gateway.
        /// </param>
        /// <param name='connectionName'>
        /// The name of the connection.
        /// </param>
        /// <param name='vpnConnectionParameters'>
        /// Parameters supplied to create or Update a VPN Connection.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<VpnConnection>> BeginCreateOrUpdateWithHttpMessagesAsync(string resourceGroupName, string gatewayName, string connectionName, VpnConnection vpnConnectionParameters, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Deletes a vpn connection.
        /// </summary>
        /// <param name='resourceGroupName'>
        /// The resource group name of the VpnGateway.
        /// </param>
        /// <param name='gatewayName'>
        /// The name of the gateway.
        /// </param>
        /// <param name='connectionName'>
        /// The name of the connection.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse> BeginDeleteWithHttpMessagesAsync(string resourceGroupName, string gatewayName, string connectionName, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
        /// <summary>
        /// Retrieves all vpn connections for a particular virtual wan vpn
        /// gateway.
        /// </summary>
        /// <param name='nextPageLink'>
        /// The NextLink from the previous successful call to List operation.
        /// </param>
        /// <param name='customHeaders'>
        /// The headers that will be added to request.
        /// </param>
        /// <param name='cancellationToken'>
        /// The cancellation token.
        /// </param>
        /// <exception cref="ErrorException">
        /// Thrown when the operation returned an invalid status code
        /// </exception>
        /// <exception cref="Microsoft.Rest.SerializationException">
        /// Thrown when unable to deserialize the response
        /// </exception>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown when a required parameter is null
        /// </exception>
        Task<AzureOperationResponse<IPage<VpnConnection>>> ListByVpnGatewayNextWithHttpMessagesAsync(string nextPageLink, Dictionary<string, List<string>> customHeaders = null, CancellationToken cancellationToken = default(CancellationToken));
    }
}
