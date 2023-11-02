// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Text.Json;
using Azure.Core;

namespace Azure.ResourceManager.HybridNetwork.Models
{
    public partial class AzureStorageAccountCredential
    {
        internal static AzureStorageAccountCredential DeserializeAzureStorageAccountCredential(JsonElement element)
        {
            if (element.ValueKind == JsonValueKind.Null)
            {
                return null;
            }
            Optional<ResourceIdentifier> storageAccountId = default;
            Optional<IReadOnlyList<AzureStorageAccountContainerCredential>> containerCredentials = default;
            Optional<DateTimeOffset> expiry = default;
            CredentialType credentialType = default;
            foreach (var property in element.EnumerateObject())
            {
                if (property.NameEquals("storageAccountId"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    storageAccountId = new ResourceIdentifier(property.Value.GetString());
                    continue;
                }
                if (property.NameEquals("containerCredentials"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    List<AzureStorageAccountContainerCredential> array = new List<AzureStorageAccountContainerCredential>();
                    foreach (var item in property.Value.EnumerateArray())
                    {
                        array.Add(AzureStorageAccountContainerCredential.DeserializeAzureStorageAccountContainerCredential(item));
                    }
                    containerCredentials = array;
                    continue;
                }
                if (property.NameEquals("expiry"u8))
                {
                    if (property.Value.ValueKind == JsonValueKind.Null)
                    {
                        continue;
                    }
                    expiry = property.Value.GetDateTimeOffset("O");
                    continue;
                }
                if (property.NameEquals("credentialType"u8))
                {
                    credentialType = new CredentialType(property.Value.GetString());
                    continue;
                }
            }
            return new AzureStorageAccountCredential(credentialType, storageAccountId.Value, Optional.ToList(containerCredentials), Optional.ToNullable(expiry));
        }
    }
}
