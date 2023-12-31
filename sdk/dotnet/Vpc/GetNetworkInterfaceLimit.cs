// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Vpc
{
    public static class GetNetworkInterfaceLimit
    {
        public static Task<GetNetworkInterfaceLimitResult> InvokeAsync(GetNetworkInterfaceLimitArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetNetworkInterfaceLimitResult>("tencentcloud:Vpc/getNetworkInterfaceLimit:getNetworkInterfaceLimit", args ?? new GetNetworkInterfaceLimitArgs(), options.WithDefaults());

        public static Output<GetNetworkInterfaceLimitResult> Invoke(GetNetworkInterfaceLimitInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetNetworkInterfaceLimitResult>("tencentcloud:Vpc/getNetworkInterfaceLimit:getNetworkInterfaceLimit", args ?? new GetNetworkInterfaceLimitInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetNetworkInterfaceLimitArgs : global::Pulumi.InvokeArgs
    {
        [Input("instanceId", required: true)]
        public string InstanceId { get; set; } = null!;

        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetNetworkInterfaceLimitArgs()
        {
        }
        public static new GetNetworkInterfaceLimitArgs Empty => new GetNetworkInterfaceLimitArgs();
    }

    public sealed class GetNetworkInterfaceLimitInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("instanceId", required: true)]
        public Input<string> InstanceId { get; set; } = null!;

        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetNetworkInterfaceLimitInvokeArgs()
        {
        }
        public static new GetNetworkInterfaceLimitInvokeArgs Empty => new GetNetworkInterfaceLimitInvokeArgs();
    }


    [OutputType]
    public sealed class GetNetworkInterfaceLimitResult
    {
        public readonly int EniPrivateIpAddressQuantity;
        public readonly int EniQuantity;
        public readonly int ExtendEniPrivateIpAddressQuantity;
        public readonly int ExtendEniQuantity;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string InstanceId;
        public readonly string? ResultOutputFile;
        public readonly int SubEniPrivateIpAddressQuantity;
        public readonly int SubEniQuantity;

        [OutputConstructor]
        private GetNetworkInterfaceLimitResult(
            int eniPrivateIpAddressQuantity,

            int eniQuantity,

            int extendEniPrivateIpAddressQuantity,

            int extendEniQuantity,

            string id,

            string instanceId,

            string? resultOutputFile,

            int subEniPrivateIpAddressQuantity,

            int subEniQuantity)
        {
            EniPrivateIpAddressQuantity = eniPrivateIpAddressQuantity;
            EniQuantity = eniQuantity;
            ExtendEniPrivateIpAddressQuantity = extendEniPrivateIpAddressQuantity;
            ExtendEniQuantity = extendEniQuantity;
            Id = id;
            InstanceId = instanceId;
            ResultOutputFile = resultOutputFile;
            SubEniPrivateIpAddressQuantity = subEniPrivateIpAddressQuantity;
            SubEniQuantity = subEniQuantity;
        }
    }
}
