// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Enis
{
    public static class GetEnis
    {
        public static Task<GetEnisResult> InvokeAsync(GetEnisArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetEnisResult>("tencentcloud:Enis/getEnis:getEnis", args ?? new GetEnisArgs(), options.WithDefaults());

        public static Output<GetEnisResult> Invoke(GetEnisInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetEnisResult>("tencentcloud:Enis/getEnis:getEnis", args ?? new GetEnisInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetEnisArgs : global::Pulumi.InvokeArgs
    {
        [Input("description")]
        public string? Description { get; set; }

        [Input("ids")]
        private List<string>? _ids;
        public List<string> Ids
        {
            get => _ids ?? (_ids = new List<string>());
            set => _ids = value;
        }

        [Input("instanceId")]
        public string? InstanceId { get; set; }

        [Input("ipv4")]
        public string? Ipv4 { get; set; }

        [Input("name")]
        public string? Name { get; set; }

        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        [Input("securityGroup")]
        public string? SecurityGroup { get; set; }

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

        public GetEnisArgs()
        {
        }
        public static new GetEnisArgs Empty => new GetEnisArgs();
    }

    public sealed class GetEnisInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("ids")]
        private InputList<string>? _ids;
        public InputList<string> Ids
        {
            get => _ids ?? (_ids = new InputList<string>());
            set => _ids = value;
        }

        [Input("instanceId")]
        public Input<string>? InstanceId { get; set; }

        [Input("ipv4")]
        public Input<string>? Ipv4 { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        [Input("securityGroup")]
        public Input<string>? SecurityGroup { get; set; }

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

        public GetEnisInvokeArgs()
        {
        }
        public static new GetEnisInvokeArgs Empty => new GetEnisInvokeArgs();
    }


    [OutputType]
    public sealed class GetEnisResult
    {
        public readonly string? Description;
        public readonly ImmutableArray<Outputs.GetEnisEniResult> EnisEnis;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly ImmutableArray<string> Ids;
        public readonly string? InstanceId;
        public readonly string? Ipv4;
        public readonly string? Name;
        public readonly string? ResultOutputFile;
        public readonly string? SecurityGroup;
        public readonly string? SubnetId;
        public readonly ImmutableDictionary<string, object>? Tags;
        public readonly string? VpcId;

        [OutputConstructor]
        private GetEnisResult(
            string? description,

            ImmutableArray<Outputs.GetEnisEniResult> enis,

            string id,

            ImmutableArray<string> ids,

            string? instanceId,

            string? ipv4,

            string? name,

            string? resultOutputFile,

            string? securityGroup,

            string? subnetId,

            ImmutableDictionary<string, object>? tags,

            string? vpcId)
        {
            Description = description;
            EnisEnis = enis;
            Id = id;
            Ids = ids;
            InstanceId = instanceId;
            Ipv4 = ipv4;
            Name = name;
            ResultOutputFile = resultOutputFile;
            SecurityGroup = securityGroup;
            SubnetId = subnetId;
            Tags = tags;
            VpcId = vpcId;
        }
    }
}