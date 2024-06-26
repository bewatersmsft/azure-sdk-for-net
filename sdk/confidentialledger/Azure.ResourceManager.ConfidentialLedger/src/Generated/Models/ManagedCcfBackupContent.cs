// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.ConfidentialLedger.Models
{
    /// <summary> Object representing Backup properties of a Managed CCF Resource. </summary>
    public partial class ManagedCcfBackupContent
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

        /// <summary> Initializes a new instance of <see cref="ManagedCcfBackupContent"/>. </summary>
        /// <param name="uri"> SAS URI used to access the backup Fileshare. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="uri"/> is null. </exception>
        public ManagedCcfBackupContent(Uri uri)
        {
            Argument.AssertNotNull(uri, nameof(uri));

            Uri = uri;
        }

        /// <summary> Initializes a new instance of <see cref="ManagedCcfBackupContent"/>. </summary>
        /// <param name="restoreRegion"> The region where the backup of the managed CCF resource will eventually be restored to. </param>
        /// <param name="uri"> SAS URI used to access the backup Fileshare. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ManagedCcfBackupContent(string restoreRegion, Uri uri, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            RestoreRegion = restoreRegion;
            Uri = uri;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ManagedCcfBackupContent"/> for deserialization. </summary>
        internal ManagedCcfBackupContent()
        {
        }

        /// <summary> The region where the backup of the managed CCF resource will eventually be restored to. </summary>
        public string RestoreRegion { get; set; }
        /// <summary> SAS URI used to access the backup Fileshare. </summary>
        public Uri Uri { get; }
    }
}
