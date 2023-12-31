// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Tdcpg
{
    public static class GetInstances
    {
        public static Task<GetInstancesResult> InvokeAsync(GetInstancesArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetInstancesResult>("tencentcloud:Tdcpg/getInstances:getInstances", args ?? new GetInstancesArgs(), options.WithDefaults());

        public static Output<GetInstancesResult> Invoke(GetInstancesInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetInstancesResult>("tencentcloud:Tdcpg/getInstances:getInstances", args ?? new GetInstancesInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetInstancesArgs : global::Pulumi.InvokeArgs
    {
        [Input("clusterId", required: true)]
        public string ClusterId { get; set; } = null!;

        [Input("instanceId")]
        public string? InstanceId { get; set; }

        [Input("instanceName")]
        public string? InstanceName { get; set; }

        [Input("instanceType")]
        public string? InstanceType { get; set; }

        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        [Input("status")]
        public string? Status { get; set; }

        public GetInstancesArgs()
        {
        }
        public static new GetInstancesArgs Empty => new GetInstancesArgs();
    }

    public sealed class GetInstancesInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("clusterId", required: true)]
        public Input<string> ClusterId { get; set; } = null!;

        [Input("instanceId")]
        public Input<string>? InstanceId { get; set; }

        [Input("instanceName")]
        public Input<string>? InstanceName { get; set; }

        [Input("instanceType")]
        public Input<string>? InstanceType { get; set; }

        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        [Input("status")]
        public Input<string>? Status { get; set; }

        public GetInstancesInvokeArgs()
        {
        }
        public static new GetInstancesInvokeArgs Empty => new GetInstancesInvokeArgs();
    }


    [OutputType]
    public sealed class GetInstancesResult
    {
        public readonly string ClusterId;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string? InstanceId;
        public readonly string? InstanceName;
        public readonly string? InstanceType;
        public readonly ImmutableArray<Outputs.GetInstancesListResult> Lists;
        public readonly string? ResultOutputFile;
        public readonly string? Status;

        [OutputConstructor]
        private GetInstancesResult(
            string clusterId,

            string id,

            string? instanceId,

            string? instanceName,

            string? instanceType,

            ImmutableArray<Outputs.GetInstancesListResult> lists,

            string? resultOutputFile,

            string? status)
        {
            ClusterId = clusterId;
            Id = id;
            InstanceId = instanceId;
            InstanceName = instanceName;
            InstanceType = instanceType;
            Lists = lists;
            ResultOutputFile = resultOutputFile;
            Status = status;
        }
    }
}
