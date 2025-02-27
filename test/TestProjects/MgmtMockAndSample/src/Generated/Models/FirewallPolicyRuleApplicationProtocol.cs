// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace MgmtMockAndSample.Models
{
    /// <summary> Properties of the application rule protocol. </summary>
    public partial class FirewallPolicyRuleApplicationProtocol
    {
        /// <summary> Initializes a new instance of FirewallPolicyRuleApplicationProtocol. </summary>
        public FirewallPolicyRuleApplicationProtocol()
        {
        }

        /// <summary> Initializes a new instance of FirewallPolicyRuleApplicationProtocol. </summary>
        /// <param name="protocolType"> Protocol type. </param>
        /// <param name="port"> Port number for the protocol, cannot be greater than 64000. </param>
        internal FirewallPolicyRuleApplicationProtocol(FirewallPolicyRuleApplicationProtocolType? protocolType, int? port)
        {
            ProtocolType = protocolType;
            Port = port;
        }

        /// <summary> Protocol type. </summary>
        public FirewallPolicyRuleApplicationProtocolType? ProtocolType { get; set; }
        /// <summary> Port number for the protocol, cannot be greater than 64000. </summary>
        public int? Port { get; set; }
    }
}
