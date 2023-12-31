// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Instances
{
    public static class GetSet
    {
        public static Task<GetSetResult> InvokeAsync(GetSetArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetSetResult>("tencentcloud:Instances/getSet:getSet", args ?? new GetSetArgs(), options.WithDefaults());

        public static Output<GetSetResult> Invoke(GetSetInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetSetResult>("tencentcloud:Instances/getSet:getSet", args ?? new GetSetInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetSetArgs : global::Pulumi.InvokeArgs
    {
        [Input("availabilityZone")]
        public string? AvailabilityZone { get; set; }

        [Input("instanceId")]
        public string? InstanceId { get; set; }

        [Input("instanceName")]
        public string? InstanceName { get; set; }

        [Input("projectId")]
        public int? ProjectId { get; set; }

        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        [Input("subnetId")]
        public string? SubnetId { get; set; }

        [Input("tags")]
        private Dictionary<string, object>? _tags;
        public Dictionary<string, object> Tags
        {
            get => _tags ?? (_tags = new Dictionary<string, object>());
            set => _tags = value;
        }

        [Input("vpcId")]
        public string? VpcId { get; set; }

        public GetSetArgs()
        {
        }
        public static new GetSetArgs Empty => new GetSetArgs();
    }

    public sealed class GetSetInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("availabilityZone")]
        public Input<string>? AvailabilityZone { get; set; }

        [Input("instanceId")]
        public Input<string>? InstanceId { get; set; }

        [Input("instanceName")]
        public Input<string>? InstanceName { get; set; }

        [Input("projectId")]
        public Input<int>? ProjectId { get; set; }

        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        [Input("subnetId")]
        public Input<string>? SubnetId { get; set; }

        [Input("tags")]
        private InputMap<object>? _tags;
        public InputMap<object> Tags
        {
            get => _tags ?? (_tags = new InputMap<object>());
            set => _tags = value;
        }

        [Input("vpcId")]
        public Input<string>? VpcId { get; set; }

        public GetSetInvokeArgs()
        {
        }
        public static new GetSetInvokeArgs Empty => new GetSetInvokeArgs();
    }


    [OutputType]
    public sealed class GetSetResult
    {
        public readonly string? AvailabilityZone;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string? InstanceId;
        public readonly ImmutableArray<Outputs.GetSetInstanceListResult> InstanceLists;
        public readonly string? InstanceName;
        public readonly int? ProjectId;
        public readonly string? ResultOutputFile;
        public readonly string? SubnetId;
        public readonly ImmutableDictionary<string, object>? Tags;
        public readonly string? VpcId;

        [OutputConstructor]
        private GetSetResult(
            string? availabilityZone,

            string id,

            string? instanceId,

            ImmutableArray<Outputs.GetSetInstanceListResult> instanceLists,

            string? instanceName,

            int? projectId,

            string? resultOutputFile,

            string? subnetId,

            ImmutableDictionary<string, object>? tags,

            string? vpcId)
        {
            AvailabilityZone = availabilityZone;
            Id = id;
            InstanceId = instanceId;
            InstanceLists = instanceLists;
            InstanceName = instanceName;
            ProjectId = projectId;
            ResultOutputFile = resultOutputFile;
            SubnetId = subnetId;
            Tags = tags;
            VpcId = vpcId;
        }
    }
}
