// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Tsf.Outputs
{

    [OutputType]
    public sealed class GetUsableUnitNamespacesResultContentResult
    {
        public readonly string CreatedTime;
        public readonly string GatewayInstanceId;
        public readonly string Id;
        public readonly string NamespaceId;
        public readonly string NamespaceName;
        public readonly string UpdatedTime;

        [OutputConstructor]
        private GetUsableUnitNamespacesResultContentResult(
            string createdTime,

            string gatewayInstanceId,

            string id,

            string namespaceId,

            string namespaceName,

            string updatedTime)
        {
            CreatedTime = createdTime;
            GatewayInstanceId = gatewayInstanceId;
            Id = id;
            NamespaceId = namespaceId;
            NamespaceName = namespaceName;
            UpdatedTime = updatedTime;
        }
    }
}
