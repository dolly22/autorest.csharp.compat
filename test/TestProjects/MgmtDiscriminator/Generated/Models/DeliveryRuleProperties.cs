// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace MgmtDiscriminator.Models
{
    /// <summary> The properties. </summary>
    public partial class DeliveryRuleProperties
    {
        /// <summary> Initializes a new instance of DeliveryRuleProperties. </summary>
        public DeliveryRuleProperties()
        {
            Actions = new ChangeTrackingList<DeliveryRuleAction>();
            ExtraMappingInfo = new ChangeTrackingDictionary<string, DeliveryRuleAction>();
        }

        /// <summary> Initializes a new instance of DeliveryRuleProperties. </summary>
        /// <param name="order"> The order in which the rules are applied for the endpoint. Possible values {0,1,2,3,………}. A rule with a lesser order will be applied before a rule with a greater order. Rule with order 0 is a special rule. It does not require any condition and actions listed in it will always be applied. </param>
        /// <param name="conditions">
        /// The condition that must be matched for the actions to be executed
        /// Please note <see cref="DeliveryRuleCondition"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DeliveryRuleQueryStringCondition"/>, <see cref="DeliveryRuleRemoteAddressCondition"/> and <see cref="DeliveryRuleRequestMethodCondition"/>.
        /// </param>
        /// <param name="actions">
        /// A list of actions that are executed when all the conditions of a rule are satisfied.
        /// Please note <see cref="DeliveryRuleAction"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DeliveryRuleCacheExpirationAction"/>, <see cref="DeliveryRuleCacheKeyQueryStringAction"/>, <see cref="DeliveryRuleRequestHeaderAction"/>, <see cref="DeliveryRuleResponseHeaderAction"/>, <see cref="OriginGroupOverrideAction"/>, <see cref="DeliveryRuleRouteConfigurationOverrideAction"/>, <see cref="UrlRedirectAction"/>, <see cref="UrlRewriteAction"/> and <see cref="UrlSigningAction"/>.
        /// </param>
        /// <param name="extraMappingInfo">
        /// A dictionary of mapping details about the actions that are executed when all the conditions of a rule are satisfied.
        /// Please note <see cref="DeliveryRuleAction"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DeliveryRuleCacheExpirationAction"/>, <see cref="DeliveryRuleCacheKeyQueryStringAction"/>, <see cref="DeliveryRuleRequestHeaderAction"/>, <see cref="DeliveryRuleResponseHeaderAction"/>, <see cref="OriginGroupOverrideAction"/>, <see cref="DeliveryRuleRouteConfigurationOverrideAction"/>, <see cref="UrlRedirectAction"/>, <see cref="UrlRewriteAction"/> and <see cref="UrlSigningAction"/>.
        /// </param>
        /// <param name="pet">
        /// A pet
        /// Please note <see cref="Models.Pet"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="Cat"/> and <see cref="Dog"/>.
        /// </param>
        /// <param name="foo"> put a readonly property here so that this model will show up in the model factory. </param>
        internal DeliveryRuleProperties(int? order, DeliveryRuleCondition conditions, IList<DeliveryRuleAction> actions, IDictionary<string, DeliveryRuleAction> extraMappingInfo, Pet pet, string foo)
        {
            Order = order;
            Conditions = conditions;
            Actions = actions;
            ExtraMappingInfo = extraMappingInfo;
            Pet = pet;
            Foo = foo;
        }

        /// <summary> The order in which the rules are applied for the endpoint. Possible values {0,1,2,3,………}. A rule with a lesser order will be applied before a rule with a greater order. Rule with order 0 is a special rule. It does not require any condition and actions listed in it will always be applied. </summary>
        public int? Order { get; set; }
        /// <summary>
        /// The condition that must be matched for the actions to be executed
        /// Please note <see cref="DeliveryRuleCondition"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DeliveryRuleQueryStringCondition"/>, <see cref="DeliveryRuleRemoteAddressCondition"/> and <see cref="DeliveryRuleRequestMethodCondition"/>.
        /// </summary>
        public DeliveryRuleCondition Conditions { get; set; }
        /// <summary>
        /// A list of actions that are executed when all the conditions of a rule are satisfied.
        /// Please note <see cref="DeliveryRuleAction"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DeliveryRuleCacheExpirationAction"/>, <see cref="DeliveryRuleCacheKeyQueryStringAction"/>, <see cref="DeliveryRuleRequestHeaderAction"/>, <see cref="DeliveryRuleResponseHeaderAction"/>, <see cref="OriginGroupOverrideAction"/>, <see cref="DeliveryRuleRouteConfigurationOverrideAction"/>, <see cref="UrlRedirectAction"/>, <see cref="UrlRewriteAction"/> and <see cref="UrlSigningAction"/>.
        /// </summary>
        public IList<DeliveryRuleAction> Actions { get; }
        /// <summary>
        /// A dictionary of mapping details about the actions that are executed when all the conditions of a rule are satisfied.
        /// Please note <see cref="DeliveryRuleAction"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="DeliveryRuleCacheExpirationAction"/>, <see cref="DeliveryRuleCacheKeyQueryStringAction"/>, <see cref="DeliveryRuleRequestHeaderAction"/>, <see cref="DeliveryRuleResponseHeaderAction"/>, <see cref="OriginGroupOverrideAction"/>, <see cref="DeliveryRuleRouteConfigurationOverrideAction"/>, <see cref="UrlRedirectAction"/>, <see cref="UrlRewriteAction"/> and <see cref="UrlSigningAction"/>.
        /// </summary>
        public IDictionary<string, DeliveryRuleAction> ExtraMappingInfo { get; }
        /// <summary>
        /// A pet
        /// Please note <see cref="Models.Pet"/> is the base class. According to the scenario, a derived class of the base class might need to be assigned here, or this property needs to be casted to one of the possible derived classes.
        /// The available derived classes include <see cref="Cat"/> and <see cref="Dog"/>.
        /// </summary>
        public Pet Pet { get; set; }
        /// <summary> put a readonly property here so that this model will show up in the model factory. </summary>
        public string Foo { get; }
    }
}
