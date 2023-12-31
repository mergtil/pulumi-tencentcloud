// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Ha
{
    public static class GetVips
    {
        public static Task<GetVipsResult> InvokeAsync(GetVipsArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetVipsResult>("tencentcloud:Ha/getVips:getVips", args ?? new GetVipsArgs(), options.WithDefaults());

        public static Output<GetVipsResult> Invoke(GetVipsInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetVipsResult>("tencentcloud:Ha/getVips:getVips", args ?? new GetVipsInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetVipsArgs : global::Pulumi.InvokeArgs
    {
        [Input("addressIp")]
        public string? AddressIp { get; set; }

        [Input("id")]
        public string? Id { get; set; }

        [Input("name")]
        public string? Name { get; set; }

        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        [Input("subnetId")]
        public string? SubnetId { get; set; }

        [Input("vpcId")]
        public string? VpcId { get; set; }

        public GetVipsArgs()
        {
        }
        public static new GetVipsArgs Empty => new GetVipsArgs();
    }

    public sealed class GetVipsInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("addressIp")]
        public Input<string>? AddressIp { get; set; }

        [Input("id")]
        public Input<string>? Id { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        [Input("subnetId")]
        public Input<string>? SubnetId { get; set; }

        [Input("vpcId")]
        public Input<string>? VpcId { get; set; }

        public GetVipsInvokeArgs()
        {
        }
        public static new GetVipsInvokeArgs Empty => new GetVipsInvokeArgs();
    }


    [OutputType]
    public sealed class GetVipsResult
    {
        public readonly string? AddressIp;
        public readonly ImmutableArray<Outputs.GetVipsHaVipListResult> HaVipLists;
        public readonly string? Id;
        public readonly string? Name;
        public readonly string? ResultOutputFile;
        public readonly string? SubnetId;
        public readonly string? VpcId;

        [OutputConstructor]
        private GetVipsResult(
            string? addressIp,

            ImmutableArray<Outputs.GetVipsHaVipListResult> haVipLists,

            string? id,

            string? name,

            string? resultOutputFile,

            string? subnetId,

            string? vpcId)
        {
            AddressIp = addressIp;
            HaVipLists = haVipLists;
            Id = id;
            Name = name;
            ResultOutputFile = resultOutputFile;
            SubnetId = subnetId;
            VpcId = vpcId;
        }
    }
}
