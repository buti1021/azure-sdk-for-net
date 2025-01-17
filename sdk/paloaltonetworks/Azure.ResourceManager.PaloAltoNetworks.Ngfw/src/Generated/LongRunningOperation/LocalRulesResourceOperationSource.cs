// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.ResourceManager;

namespace Azure.ResourceManager.PaloAltoNetworks.Ngfw
{
    internal class LocalRulesResourceOperationSource : IOperationSource<LocalRulesResource>
    {
        private readonly ArmClient _client;

        internal LocalRulesResourceOperationSource(ArmClient client)
        {
            _client = client;
        }

        LocalRulesResource IOperationSource<LocalRulesResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = LocalRulesResourceData.DeserializeLocalRulesResourceData(document.RootElement);
            return new LocalRulesResource(_client, data);
        }

        async ValueTask<LocalRulesResource> IOperationSource<LocalRulesResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = LocalRulesResourceData.DeserializeLocalRulesResourceData(document.RootElement);
            return new LocalRulesResource(_client, data);
        }
    }
}
