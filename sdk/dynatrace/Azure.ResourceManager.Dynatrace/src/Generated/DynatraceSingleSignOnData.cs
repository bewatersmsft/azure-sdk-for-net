// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;
using Azure.ResourceManager.Dynatrace.Models;
using Azure.ResourceManager.Models;

namespace Azure.ResourceManager.Dynatrace
{
    /// <summary>
    /// A class representing the DynatraceSingleSignOn data model.
    /// Single sign-on configurations for a given monitor resource.
    /// </summary>
    public partial class DynatraceSingleSignOnData : ResourceData
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="DynatraceSingleSignOnData"/>. </summary>
        public DynatraceSingleSignOnData()
        {
            AadDomains = new ChangeTrackingList<string>();
        }

        /// <summary> Initializes a new instance of <see cref="DynatraceSingleSignOnData"/>. </summary>
        /// <param name="id"> The id. </param>
        /// <param name="name"> The name. </param>
        /// <param name="resourceType"> The resourceType. </param>
        /// <param name="systemData"> The systemData. </param>
        /// <param name="singleSignOnState"> State of Single Sign On. </param>
        /// <param name="enterpriseAppId"> Version of the Dynatrace agent installed on the VM. </param>
        /// <param name="singleSignOnUri"> The login URL specific to this Dynatrace Environment. </param>
        /// <param name="aadDomains"> array of Aad(azure active directory) domains. </param>
        /// <param name="provisioningState"> Provisioning state of the resource. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal DynatraceSingleSignOnData(ResourceIdentifier id, string name, ResourceType resourceType, SystemData systemData, DynatraceSingleSignOnState? singleSignOnState, Guid? enterpriseAppId, Uri singleSignOnUri, IList<string> aadDomains, DynatraceProvisioningState? provisioningState, IDictionary<string, BinaryData> serializedAdditionalRawData) : base(id, name, resourceType, systemData)
        {
            SingleSignOnState = singleSignOnState;
            EnterpriseAppId = enterpriseAppId;
            SingleSignOnUri = singleSignOnUri;
            AadDomains = aadDomains;
            ProvisioningState = provisioningState;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> State of Single Sign On. </summary>
        public DynatraceSingleSignOnState? SingleSignOnState { get; set; }
        /// <summary> Version of the Dynatrace agent installed on the VM. </summary>
        public Guid? EnterpriseAppId { get; set; }
        /// <summary> The login URL specific to this Dynatrace Environment. </summary>
        public Uri SingleSignOnUri { get; set; }
        /// <summary> array of Aad(azure active directory) domains. </summary>
        public IList<string> AadDomains { get; }
        /// <summary> Provisioning state of the resource. </summary>
        public DynatraceProvisioningState? ProvisioningState { get; }
    }
}
