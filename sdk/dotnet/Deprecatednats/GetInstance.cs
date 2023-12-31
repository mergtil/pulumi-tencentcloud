// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Deprecatednats
{
    public static class GetInstance
    {
        public static Task<GetInstanceResult> InvokeAsync(GetInstanceArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetInstanceResult>("tencentcloud:Deprecatednats/getInstance:getInstance", args ?? new GetInstanceArgs(), options.WithDefaults());

        public static Output<GetInstanceResult> Invoke(GetInstanceInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetInstanceResult>("tencentcloud:Deprecatednats/getInstance:getInstance", args ?? new GetInstanceInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetInstanceArgs : global::Pulumi.InvokeArgs
    {
        [Input("bandwidth")]
        public int? Bandwidth { get; set; }

        [Input("id")]
        public string? Id { get; set; }

        [Input("maxConcurrent")]
        public int? MaxConcurrent { get; set; }

        [Input("name")]
        public string? Name { get; set; }

        [Input("state")]
        public int? State { get; set; }

        [Input("vpcId")]
        public string? VpcId { get; set; }

        public GetInstanceArgs()
        {
        }
        public static new GetInstanceArgs Empty => new GetInstanceArgs();
    }

    public sealed class GetInstanceInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("bandwidth")]
        public Input<int>? Bandwidth { get; set; }

        [Input("id")]
        public Input<string>? Id { get; set; }

        [Input("maxConcurrent")]
        public Input<int>? MaxConcurrent { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("state")]
        public Input<int>? State { get; set; }

        [Input("vpcId")]
        public Input<string>? VpcId { get; set; }

        public GetInstanceInvokeArgs()
        {
        }
        public static new GetInstanceInvokeArgs Empty => new GetInstanceInvokeArgs();
    }


    [OutputType]
    public sealed class GetInstanceResult
    {
        public readonly int? Bandwidth;
        public readonly string? Id;
        public readonly int? MaxConcurrent;
        public readonly string? Name;
        public readonly ImmutableArray<Outputs.GetInstanceNatResult> Nats;
        public readonly int? State;
        public readonly string? VpcId;

        [OutputConstructor]
        private GetInstanceResult(
            int? bandwidth,

            string? id,

            int? maxConcurrent,

            string? name,

            ImmutableArray<Outputs.GetInstanceNatResult> nats,

            int? state,

            string? vpcId)
        {
            Bandwidth = bandwidth;
            Id = id;
            MaxConcurrent = maxConcurrent;
            Name = name;
            Nats = nats;
            State = state;
            VpcId = vpcId;
        }
    }
}
