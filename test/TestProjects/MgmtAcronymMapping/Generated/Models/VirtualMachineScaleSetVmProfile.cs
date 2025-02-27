// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace MgmtAcronymMapping.Models
{
    /// <summary>
    /// Describes a virtual machine scale set virtual machine profile.
    /// Serialized Name: VirtualMachineScaleSetVMProfile
    /// </summary>
    public partial class VirtualMachineScaleSetVmProfile
    {
        /// <summary> Initializes a new instance of VirtualMachineScaleSetVmProfile. </summary>
        public VirtualMachineScaleSetVmProfile()
        {
        }

        /// <summary> Initializes a new instance of VirtualMachineScaleSetVmProfile. </summary>
        /// <param name="osProfile">
        /// Specifies the operating system settings for the virtual machines in the scale set.
        /// Serialized Name: VirtualMachineScaleSetVMProfile.osProfile
        /// </param>
        /// <param name="storageProfile">
        /// Specifies the storage settings for the virtual machine disks.
        /// Serialized Name: VirtualMachineScaleSetVMProfile.storageProfile
        /// </param>
        /// <param name="networkProfile">
        /// Specifies properties of the network interfaces of the virtual machines in the scale set.
        /// Serialized Name: VirtualMachineScaleSetVMProfile.networkProfile
        /// </param>
        /// <param name="securityProfile">
        /// Specifies the Security related profile settings for the virtual machines in the scale set.
        /// Serialized Name: VirtualMachineScaleSetVMProfile.securityProfile
        /// </param>
        /// <param name="diagnosticsProfile">
        /// Specifies the boot diagnostic settings state. &lt;br&gt;&lt;br&gt;Minimum api-version: 2015-06-15.
        /// Serialized Name: VirtualMachineScaleSetVMProfile.diagnosticsProfile
        /// </param>
        /// <param name="extensionProfile">
        /// Specifies a collection of settings for extensions installed on virtual machines in the scale set.
        /// Serialized Name: VirtualMachineScaleSetVMProfile.extensionProfile
        /// </param>
        /// <param name="licenseType">
        /// Specifies that the image or disk that is being used was licensed on-premises. This element is only used for images that contain the Windows Server operating system. &lt;br&gt;&lt;br&gt; Possible values are: &lt;br&gt;&lt;br&gt; Windows_Client &lt;br&gt;&lt;br&gt; Windows_Server &lt;br&gt;&lt;br&gt; If this element is included in a request for an update, the value must match the initial value. This value cannot be updated. &lt;br&gt;&lt;br&gt; For more information, see [Azure Hybrid Use Benefit for Windows Server](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-hybrid-use-benefit-licensing?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json) &lt;br&gt;&lt;br&gt; Minimum api-version: 2015-06-15
        /// Serialized Name: VirtualMachineScaleSetVMProfile.licenseType
        /// </param>
        /// <param name="priority">
        /// Specifies the priority for the virtual machines in the scale set. &lt;br&gt;&lt;br&gt;Minimum api-version: 2017-10-30-preview
        /// Serialized Name: VirtualMachineScaleSetVMProfile.priority
        /// </param>
        /// <param name="evictionPolicy">
        /// Specifies the eviction policy for the Azure Spot virtual machine and Azure Spot scale set. &lt;br&gt;&lt;br&gt;For Azure Spot virtual machines, both 'Deallocate' and 'Delete' are supported and the minimum api-version is 2019-03-01. &lt;br&gt;&lt;br&gt;For Azure Spot scale sets, both 'Deallocate' and 'Delete' are supported and the minimum api-version is 2017-10-30-preview.
        /// Serialized Name: VirtualMachineScaleSetVMProfile.evictionPolicy
        /// </param>
        /// <param name="billingProfile">
        /// Specifies the billing related details of a Azure Spot VMSS. &lt;br&gt;&lt;br&gt;Minimum api-version: 2019-03-01.
        /// Serialized Name: VirtualMachineScaleSetVMProfile.billingProfile
        /// </param>
        /// <param name="scheduledEventsProfile">
        /// Specifies Scheduled Event related configurations.
        /// Serialized Name: VirtualMachineScaleSetVMProfile.scheduledEventsProfile
        /// </param>
        internal VirtualMachineScaleSetVmProfile(VirtualMachineScaleSetOSProfile osProfile, VirtualMachineScaleSetStorageProfile storageProfile, VirtualMachineScaleSetNetworkProfile networkProfile, SecurityProfile securityProfile, DiagnosticsProfile diagnosticsProfile, VirtualMachineScaleSetExtensionProfile extensionProfile, string licenseType, VirtualMachinePriorityType? priority, VirtualMachineEvictionPolicyType? evictionPolicy, BillingProfile billingProfile, ScheduledEventsProfile scheduledEventsProfile)
        {
            OSProfile = osProfile;
            StorageProfile = storageProfile;
            NetworkProfile = networkProfile;
            SecurityProfile = securityProfile;
            DiagnosticsProfile = diagnosticsProfile;
            ExtensionProfile = extensionProfile;
            LicenseType = licenseType;
            Priority = priority;
            EvictionPolicy = evictionPolicy;
            BillingProfile = billingProfile;
            ScheduledEventsProfile = scheduledEventsProfile;
        }

        /// <summary>
        /// Specifies the operating system settings for the virtual machines in the scale set.
        /// Serialized Name: VirtualMachineScaleSetVMProfile.osProfile
        /// </summary>
        public VirtualMachineScaleSetOSProfile OSProfile { get; set; }
        /// <summary>
        /// Specifies the storage settings for the virtual machine disks.
        /// Serialized Name: VirtualMachineScaleSetVMProfile.storageProfile
        /// </summary>
        public VirtualMachineScaleSetStorageProfile StorageProfile { get; set; }
        /// <summary>
        /// Specifies properties of the network interfaces of the virtual machines in the scale set.
        /// Serialized Name: VirtualMachineScaleSetVMProfile.networkProfile
        /// </summary>
        public VirtualMachineScaleSetNetworkProfile NetworkProfile { get; set; }
        /// <summary>
        /// Specifies the Security related profile settings for the virtual machines in the scale set.
        /// Serialized Name: VirtualMachineScaleSetVMProfile.securityProfile
        /// </summary>
        internal SecurityProfile SecurityProfile { get; set; }
        /// <summary>
        /// This property can be used by user in the request to enable or disable the Host Encryption for the virtual machine or virtual machine scale set. This will enable the encryption for all the disks including Resource/Temp disk at host itself. &lt;br&gt;&lt;br&gt; Default: The Encryption at host will be disabled unless this property is set to true for the resource.
        /// Serialized Name: SecurityProfile.encryptionAtHost
        /// </summary>
        public bool? EncryptionAtHost
        {
            get => SecurityProfile is null ? default : SecurityProfile.EncryptionAtHost;
            set
            {
                if (SecurityProfile is null)
                    SecurityProfile = new SecurityProfile();
                SecurityProfile.EncryptionAtHost = value;
            }
        }

        /// <summary>
        /// Specifies the boot diagnostic settings state. &lt;br&gt;&lt;br&gt;Minimum api-version: 2015-06-15.
        /// Serialized Name: VirtualMachineScaleSetVMProfile.diagnosticsProfile
        /// </summary>
        internal DiagnosticsProfile DiagnosticsProfile { get; set; }
        /// <summary>
        /// Boot Diagnostics is a debugging feature which allows you to view Console Output and Screenshot to diagnose VM status. &lt;br&gt;&lt;br&gt; You can easily view the output of your console log. &lt;br&gt;&lt;br&gt; Azure also enables you to see a screenshot of the VM from the hypervisor.
        /// Serialized Name: DiagnosticsProfile.bootDiagnostics
        /// </summary>
        public BootDiagnostics BootDiagnostics
        {
            get => DiagnosticsProfile is null ? default : DiagnosticsProfile.BootDiagnostics;
            set
            {
                if (DiagnosticsProfile is null)
                    DiagnosticsProfile = new DiagnosticsProfile();
                DiagnosticsProfile.BootDiagnostics = value;
            }
        }

        /// <summary>
        /// Specifies a collection of settings for extensions installed on virtual machines in the scale set.
        /// Serialized Name: VirtualMachineScaleSetVMProfile.extensionProfile
        /// </summary>
        public VirtualMachineScaleSetExtensionProfile ExtensionProfile { get; set; }
        /// <summary>
        /// Specifies that the image or disk that is being used was licensed on-premises. This element is only used for images that contain the Windows Server operating system. &lt;br&gt;&lt;br&gt; Possible values are: &lt;br&gt;&lt;br&gt; Windows_Client &lt;br&gt;&lt;br&gt; Windows_Server &lt;br&gt;&lt;br&gt; If this element is included in a request for an update, the value must match the initial value. This value cannot be updated. &lt;br&gt;&lt;br&gt; For more information, see [Azure Hybrid Use Benefit for Windows Server](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-windows-hybrid-use-benefit-licensing?toc=%2fazure%2fvirtual-machines%2fwindows%2ftoc.json) &lt;br&gt;&lt;br&gt; Minimum api-version: 2015-06-15
        /// Serialized Name: VirtualMachineScaleSetVMProfile.licenseType
        /// </summary>
        public string LicenseType { get; set; }
        /// <summary>
        /// Specifies the priority for the virtual machines in the scale set. &lt;br&gt;&lt;br&gt;Minimum api-version: 2017-10-30-preview
        /// Serialized Name: VirtualMachineScaleSetVMProfile.priority
        /// </summary>
        public VirtualMachinePriorityType? Priority { get; set; }
        /// <summary>
        /// Specifies the eviction policy for the Azure Spot virtual machine and Azure Spot scale set. &lt;br&gt;&lt;br&gt;For Azure Spot virtual machines, both 'Deallocate' and 'Delete' are supported and the minimum api-version is 2019-03-01. &lt;br&gt;&lt;br&gt;For Azure Spot scale sets, both 'Deallocate' and 'Delete' are supported and the minimum api-version is 2017-10-30-preview.
        /// Serialized Name: VirtualMachineScaleSetVMProfile.evictionPolicy
        /// </summary>
        public VirtualMachineEvictionPolicyType? EvictionPolicy { get; set; }
        /// <summary>
        /// Specifies the billing related details of a Azure Spot VMSS. &lt;br&gt;&lt;br&gt;Minimum api-version: 2019-03-01.
        /// Serialized Name: VirtualMachineScaleSetVMProfile.billingProfile
        /// </summary>
        internal BillingProfile BillingProfile { get; set; }
        /// <summary>
        /// Specifies the maximum price you are willing to pay for a Azure Spot VM/VMSS. This price is in US Dollars. &lt;br&gt;&lt;br&gt; This price will be compared with the current Azure Spot price for the VM size. Also, the prices are compared at the time of create/update of Azure Spot VM/VMSS and the operation will only succeed if  the maxPrice is greater than the current Azure Spot price. &lt;br&gt;&lt;br&gt; The maxPrice will also be used for evicting a Azure Spot VM/VMSS if the current Azure Spot price goes beyond the maxPrice after creation of VM/VMSS. &lt;br&gt;&lt;br&gt; Possible values are: &lt;br&gt;&lt;br&gt; - Any decimal value greater than zero. Example: 0.01538 &lt;br&gt;&lt;br&gt; -1 – indicates default price to be up-to on-demand. &lt;br&gt;&lt;br&gt; You can set the maxPrice to -1 to indicate that the Azure Spot VM/VMSS should not be evicted for price reasons. Also, the default max price is -1 if it is not provided by you. &lt;br&gt;&lt;br&gt;Minimum api-version: 2019-03-01.
        /// Serialized Name: BillingProfile.maxPrice
        /// </summary>
        public double? BillingMaxPrice
        {
            get => BillingProfile is null ? default : BillingProfile.MaxPrice;
            set
            {
                if (BillingProfile is null)
                    BillingProfile = new BillingProfile();
                BillingProfile.MaxPrice = value;
            }
        }

        /// <summary>
        /// Specifies Scheduled Event related configurations.
        /// Serialized Name: VirtualMachineScaleSetVMProfile.scheduledEventsProfile
        /// </summary>
        internal ScheduledEventsProfile ScheduledEventsProfile { get; set; }
        /// <summary>
        /// Specifies Terminate Scheduled Event related configurations.
        /// Serialized Name: ScheduledEventsProfile.terminateNotificationProfile
        /// </summary>
        public TerminateNotificationProfile ScheduledEventsTerminateNotificationProfile
        {
            get => ScheduledEventsProfile is null ? default : ScheduledEventsProfile.TerminateNotificationProfile;
            set
            {
                if (ScheduledEventsProfile is null)
                    ScheduledEventsProfile = new ScheduledEventsProfile();
                ScheduledEventsProfile.TerminateNotificationProfile = value;
            }
        }
    }
}
