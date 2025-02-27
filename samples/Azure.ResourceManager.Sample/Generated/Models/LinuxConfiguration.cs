// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;

namespace Azure.ResourceManager.Sample.Models
{
    /// <summary>
    /// Specifies the Linux operating system settings on the virtual machine. &lt;br&gt;&lt;br&gt;For a list of supported Linux distributions, see [Linux on Azure-Endorsed Distributions](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-endorsed-distros?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json) &lt;br&gt;&lt;br&gt; For running non-endorsed distributions, see [Information for Non-Endorsed Distributions](https://docs.microsoft.com/azure/virtual-machines/virtual-machines-linux-create-upload-generic?toc=%2fazure%2fvirtual-machines%2flinux%2ftoc.json).
    /// Serialized Name: LinuxConfiguration
    /// </summary>
    public partial class LinuxConfiguration
    {
        /// <summary> Initializes a new instance of LinuxConfiguration. </summary>
        public LinuxConfiguration()
        {
        }

        /// <summary> Initializes a new instance of LinuxConfiguration. </summary>
        /// <param name="disablePasswordAuthentication">
        /// Specifies whether password authentication should be disabled.
        /// Serialized Name: LinuxConfiguration.disablePasswordAuthentication
        /// </param>
        /// <param name="ssh">
        /// Specifies the ssh key configuration for a Linux OS.
        /// Serialized Name: LinuxConfiguration.ssh
        /// </param>
        /// <param name="provisionVmAgent">
        /// Indicates whether virtual machine agent should be provisioned on the virtual machine. &lt;br&gt;&lt;br&gt; When this property is not specified in the request body, default behavior is to set it to true.  This will ensure that VM Agent is installed on the VM so that extensions can be added to the VM later.
        /// Serialized Name: LinuxConfiguration.provisionVMAgent
        /// </param>
        internal LinuxConfiguration(bool? disablePasswordAuthentication, SshConfiguration ssh, bool? provisionVmAgent)
        {
            DisablePasswordAuthentication = disablePasswordAuthentication;
            Ssh = ssh;
            ProvisionVmAgent = provisionVmAgent;
        }

        /// <summary>
        /// Specifies whether password authentication should be disabled.
        /// Serialized Name: LinuxConfiguration.disablePasswordAuthentication
        /// </summary>
        public bool? DisablePasswordAuthentication { get; set; }
        /// <summary>
        /// Specifies the ssh key configuration for a Linux OS.
        /// Serialized Name: LinuxConfiguration.ssh
        /// </summary>
        internal SshConfiguration Ssh { get; set; }
        /// <summary>
        /// The list of SSH public keys used to authenticate with linux based VMs.
        /// Serialized Name: SshConfiguration.publicKeys
        /// </summary>
        public IList<SshPublicKeyInfo> SshPublicKeys
        {
            get
            {
                if (Ssh is null)
                    Ssh = new SshConfiguration();
                return Ssh.PublicKeys;
            }
        }

        /// <summary>
        /// Indicates whether virtual machine agent should be provisioned on the virtual machine. &lt;br&gt;&lt;br&gt; When this property is not specified in the request body, default behavior is to set it to true.  This will ensure that VM Agent is installed on the VM so that extensions can be added to the VM later.
        /// Serialized Name: LinuxConfiguration.provisionVMAgent
        /// </summary>
        public bool? ProvisionVmAgent { get; set; }
    }
}
