// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Compute.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Identity for the virtual machine.
    /// </summary>
    public partial class VirtualMachineIdentity
    {
        /// <summary>
        /// Initializes a new instance of the VirtualMachineIdentity class.
        /// </summary>
        public VirtualMachineIdentity()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the VirtualMachineIdentity class.
        /// </summary>
        /// <param name="principalId">The principal id of virtual machine
        /// identity. This property will only be provided for a system assigned
        /// identity.</param>
        /// <param name="tenantId">The tenant id associated with the virtual
        /// machine. This property will only be provided for a system assigned
        /// identity.</param>
        /// <param name="type">The type of identity used for the virtual
        /// machine. The type 'SystemAssigned, UserAssigned' includes both an
        /// implicitly created identity and a set of user assigned identities.
        /// The type 'None' will remove any identities from the virtual
        /// machine. Possible values include: 'SystemAssigned', 'UserAssigned',
        /// 'SystemAssigned, UserAssigned', 'None'</param>
        /// <param name="userAssignedIdentities">The list of user identities
        /// associated with the Virtual Machine. The user identity dictionary
        /// key references will be ARM resource ids in the form:
        /// '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.</param>
        public VirtualMachineIdentity(string principalId = default(string), string tenantId = default(string), ResourceIdentityType? type = default(ResourceIdentityType?), IDictionary<string, VirtualMachineIdentityUserAssignedIdentitiesValue> userAssignedIdentities = default(IDictionary<string, VirtualMachineIdentityUserAssignedIdentitiesValue>))
        {
            PrincipalId = principalId;
            TenantId = tenantId;
            Type = type;
            UserAssignedIdentities = userAssignedIdentities;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets the principal id of virtual machine identity. This property
        /// will only be provided for a system assigned identity.
        /// </summary>
        [JsonProperty(PropertyName = "principalId")]
        public string PrincipalId { get; private set; }

        /// <summary>
        /// Gets the tenant id associated with the virtual machine. This
        /// property will only be provided for a system assigned identity.
        /// </summary>
        [JsonProperty(PropertyName = "tenantId")]
        public string TenantId { get; private set; }

        /// <summary>
        /// Gets or sets the type of identity used for the virtual machine. The
        /// type 'SystemAssigned, UserAssigned' includes both an implicitly
        /// created identity and a set of user assigned identities. The type
        /// 'None' will remove any identities from the virtual machine.
        /// Possible values include: 'SystemAssigned', 'UserAssigned',
        /// 'SystemAssigned, UserAssigned', 'None'
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public ResourceIdentityType? Type { get; set; }

        /// <summary>
        /// Gets or sets the list of user identities associated with the
        /// Virtual Machine. The user identity dictionary key references will
        /// be ARM resource ids in the form:
        /// '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'.
        /// </summary>
        [JsonProperty(PropertyName = "userAssignedIdentities")]
        public IDictionary<string, VirtualMachineIdentityUserAssignedIdentitiesValue> UserAssignedIdentities { get; set; }

    }
}
