// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Sql
{
    internal class InstanceFailoverGroupOperationSource : IOperationSource<InstanceFailoverGroupResource>
    {
        private readonly ArmClient _client;

        internal InstanceFailoverGroupOperationSource(ArmClient client)
        {
            _client = client;
        }

        InstanceFailoverGroupResource IOperationSource<InstanceFailoverGroupResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = InstanceFailoverGroupData.DeserializeInstanceFailoverGroupData(document.RootElement);
            return new InstanceFailoverGroupResource(_client, data);
        }

        async ValueTask<InstanceFailoverGroupResource> IOperationSource<InstanceFailoverGroupResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = InstanceFailoverGroupData.DeserializeInstanceFailoverGroupData(document.RootElement);
            return new InstanceFailoverGroupResource(_client, data);
        }
    }
}
