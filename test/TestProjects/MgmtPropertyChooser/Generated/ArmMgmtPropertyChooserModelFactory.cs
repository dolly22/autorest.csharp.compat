// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;
using Azure.Core;
using Azure.ResourceManager.Models;
using MgmtPropertyChooser;

namespace MgmtPropertyChooser.Models
{
    /// <summary> Model factory for models. </summary>
    public static partial class ArmMgmtPropertyChooserModelFactory
    {
        /// <summary> Initializes a new instance of VirtualMachineData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="plan"> Specifies information about the marketplace image used to create the virtual machine. This element is only used for marketplace images. Before you can use a marketplace image from an API, you must enable the image for programmatic use.  In the Azure portal, find the marketplace image that you want to use and then click **Want to deploy programmatically, Get Started -&gt;**. Enter any required information and then click **Save**. </param>
        /// <param name="resources"> The virtual machine child extension resources. </param>
        /// <param name="identity"> The identity of the virtual machine, if configured. </param>
        /// <param name="identityWithRenamedProperty"> The identity of the virtual machine, if configured. </param>
        /// <param name="identityWithDifferentPropertyType"> The identity of the virtual machine, if configured. </param>
        /// <param name="identityWithNoUserIdentity"> The identity of the virtual machine, if configured. Current supported identity types: None, SystemAssigned. </param>
        /// <param name="identityWithNoSystemIdentity"> The identity of the virtual machine, if configured. </param>
        /// <param name="identityV3"> The identity of the virtual machine, if configured. </param>
        /// <param name="zones"> The virtual machine zones. </param>
        /// <param name="fakeResources"> The fake resources for the virtual machine. </param>
        /// <param name="fakeSubResourceId"> The fake subresource. </param>
        /// <param name="fakeWritableSubResourceId"> The fake writable subresource. </param>
        /// <param name="provisioningState"> The provisioning state, which only appears in the response. </param>
        /// <param name="licenseType"> Specifies that the image or disk that is being used was licensed on-premises. This element is only used for images that contain the Windows Server operating system. &lt;br&gt;&lt;br&gt; Possible values are: &lt;br&gt;&lt;br&gt; Windows_Client &lt;br&gt;&lt;br&gt; Windows_Server &lt;br&gt;&lt;br&gt; If this element is included in a request for an update, the value must match the initial value. This value cannot be updated. &lt;br&gt;&lt;br&gt; For more information, see [Azure Hybrid Use Benefit for Windows Server](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-hybrid-use-benefit-licensing?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json) &lt;br&gt;&lt;br&gt; Minimum api-version: 2015-06-15. </param>
        /// <param name="vmId"> Specifies the VM unique ID which is a 128-bits identifier that is encoded and stored in all Azure IaaS VMs SMBIOS and can be read using platform BIOS commands. </param>
        /// <param name="extensionsTimeBudget"> Specifies the time alloted for all extensions to start. The time duration should be between 15 minutes and 120 minutes (inclusive) and should be specified in ISO 8601 format. The default value is 90 minutes (PT1H30M). &lt;br&gt;&lt;br&gt; Minimum api-version: 2020-06-01. </param>
        /// <returns> A new <see cref="MgmtPropertyChooser.VirtualMachineData"/> instance for mocking. </returns>
        public static VirtualMachineData VirtualMachineData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, ArmPlan plan = null, IEnumerable<VirtualMachineExtension> resources = null, ManagedServiceIdentity identity = null, IdentityWithRenamedProperty identityWithRenamedProperty = null, IdentityWithDifferentPropertyType identityWithDifferentPropertyType = null, ManagedServiceIdentity identityWithNoUserIdentity = null, IdentityWithNoSystemIdentity identityWithNoSystemIdentity = null, ManagedServiceIdentity identityV3 = null, IEnumerable<string> zones = null, IEnumerable<MgmtPropertyChooserResourceData> fakeResources = null, ResourceIdentifier fakeSubResourceId = null, ResourceIdentifier fakeWritableSubResourceId = null, string provisioningState = null, string licenseType = null, string vmId = null, string extensionsTimeBudget = null)
        {
            tags ??= new Dictionary<string, string>();
            resources ??= new List<VirtualMachineExtension>();
            zones ??= new List<string>();
            fakeResources ??= new List<MgmtPropertyChooserResourceData>();

            return new VirtualMachineData(id, name, resourceType, systemData, tags, location, plan, resources?.ToList(), identity, identityWithRenamedProperty, identityWithDifferentPropertyType, identityWithNoUserIdentity, identityWithNoSystemIdentity, identityV3, zones?.ToList(), fakeResources?.ToList(), fakeSubResourceId != null ? ResourceManagerModelFactory.SubResource(fakeSubResourceId) : null, fakeWritableSubResourceId != null ? ResourceManagerModelFactory.WritableSubResource(fakeWritableSubResourceId) : null, provisioningState, licenseType, vmId, extensionsTimeBudget);
        }

        /// <summary> Initializes a new instance of VirtualMachineExtension. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="tags"> The tags. </param>
        /// <param name="location"> The location. </param>
        /// <param name="forceUpdateTag"> How the extension handler should be forced to update even if the extension configuration has not changed. </param>
        /// <param name="publisher"> The name of the extension handler publisher. </param>
        /// <param name="typePropertiesType"> Specifies the type of the extension; an example is "CustomScriptExtension". </param>
        /// <param name="typeHandlerVersion"> Specifies the version of the script handler. </param>
        /// <param name="autoUpgradeMinorVersion"> Indicates whether the extension should use a newer minor version if one is available at deployment time. Once deployed, however, the extension will not upgrade minor versions unless redeployed, even with this property set to true. </param>
        /// <param name="enableAutomaticUpgrade"> Indicates whether the extension should be automatically upgraded by the platform if there is a newer version of the extension available. </param>
        /// <param name="settings"> Json formatted public settings for the extension. </param>
        /// <param name="protectedSettings"> The extension can contain either protectedSettings or protectedSettingsFromKeyVault or no protected settings at all. </param>
        /// <param name="provisioningState"> The provisioning state, which only appears in the response. </param>
        /// <returns> A new <see cref="Models.VirtualMachineExtension"/> instance for mocking. </returns>
        public static VirtualMachineExtension VirtualMachineExtension(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, IDictionary<string, string> tags = null, AzureLocation location = default, string forceUpdateTag = null, string publisher = null, string typePropertiesType = null, string typeHandlerVersion = null, bool? autoUpgradeMinorVersion = null, bool? enableAutomaticUpgrade = null, BinaryData settings = null, BinaryData protectedSettings = null, string provisioningState = null)
        {
            tags ??= new Dictionary<string, string>();

            return new VirtualMachineExtension(id, name, resourceType, systemData, tags, location, forceUpdateTag, publisher, typePropertiesType, typeHandlerVersion, autoUpgradeMinorVersion, enableAutomaticUpgrade, settings, protectedSettings, provisioningState);
        }

        /// <summary> Initializes a new instance of MgmtPropertyChooserResourceData. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="tags"> Resource tags. </param>
        /// <returns> A new <see cref="Models.MgmtPropertyChooserResourceData"/> instance for mocking. </returns>
        public static MgmtPropertyChooserResourceData MgmtPropertyChooserResourceData(ResourceIdentifier id = null, string name = null, ResourceType resourceType = default, SystemData systemData = null, string location = null, IDictionary<string, string> tags = null)
        {
            tags ??= new Dictionary<string, string>();

            return new MgmtPropertyChooserResourceData(id, name, resourceType, systemData, location, tags);
        }

        /// <summary> Initializes a new instance of IdentityWithRenamedProperty. </summary>
        /// <param name="testPrincipalId"> The principal id of virtual machine identity. This property will only be provided for a system assigned identity. </param>
        /// <param name="tenantId"> The tenant id associated with the virtual machine. This property will only be provided for a system assigned identity. </param>
        /// <param name="resourceIdentityType"> The type of identity used for the virtual machine. The type 'SystemAssigned, UserAssigned' includes both an implicitly created identity and a set of user assigned identities. The type 'None' will remove any identities from the virtual machine. </param>
        /// <param name="userAssignedIdentities"> The list of user identities associated with the Virtual Machine. The user identity dictionary key references will be ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'. </param>
        /// <returns> A new <see cref="Models.IdentityWithRenamedProperty"/> instance for mocking. </returns>
        public static IdentityWithRenamedProperty IdentityWithRenamedProperty(string testPrincipalId = null, string tenantId = null, ResourceIdentityType? resourceIdentityType = null, IDictionary<string, UserAssignedIdentity> userAssignedIdentities = null)
        {
            userAssignedIdentities ??= new Dictionary<string, UserAssignedIdentity>();

            return new IdentityWithRenamedProperty(testPrincipalId, tenantId, resourceIdentityType, userAssignedIdentities);
        }

        /// <summary> Initializes a new instance of IdentityWithDifferentPropertyType. </summary>
        /// <param name="principalId"> The principal id of virtual machine identity. This property will only be provided for a system assigned identity. </param>
        /// <param name="tenantId"> The tenant id associated with the virtual machine. This property will only be provided for a system assigned identity. </param>
        /// <param name="resourceIdentityType"> The type of identity used for the virtual machine. The type 'SystemAssigned, UserAssigned' includes both an implicitly created identity and a set of user assigned identities. The type 'None' will remove any identities from the virtual machine. </param>
        /// <param name="userAssignedIdentities"> The list of user identities associated with the Virtual Machine. The user identity dictionary key references will be ARM resource ids in the form: '/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.ManagedIdentity/userAssignedIdentities/{identityName}'. </param>
        /// <returns> A new <see cref="Models.IdentityWithDifferentPropertyType"/> instance for mocking. </returns>
        public static IdentityWithDifferentPropertyType IdentityWithDifferentPropertyType(string principalId = null, int? tenantId = null, ResourceIdentityType? resourceIdentityType = null, IDictionary<string, UserAssignedIdentity> userAssignedIdentities = null)
        {
            userAssignedIdentities ??= new Dictionary<string, UserAssignedIdentity>();

            return new IdentityWithDifferentPropertyType(principalId, tenantId, resourceIdentityType, userAssignedIdentities);
        }
    }
}
