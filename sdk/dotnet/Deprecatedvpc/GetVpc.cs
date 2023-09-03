// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Deprecatedvpc
{
    public static class GetVpc
    {
        public static Task<GetVpcResult> InvokeAsync(GetVpcArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetVpcResult>("tencentcloud:Deprecatedvpc/getVpc:getVpc", args ?? new GetVpcArgs(), options.WithDefaults());

        public static Output<GetVpcResult> Invoke(GetVpcInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetVpcResult>("tencentcloud:Deprecatedvpc/getVpc:getVpc", args ?? new GetVpcInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetVpcArgs : global::Pulumi.InvokeArgs
    {
        [Input("id")]
        public string? Id { get; set; }

        [Input("name")]
        public string? Name { get; set; }

        public GetVpcArgs()
        {
        }
        public static new GetVpcArgs Empty => new GetVpcArgs();
    }

    public sealed class GetVpcInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("id")]
        public Input<string>? Id { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        public GetVpcInvokeArgs()
        {
        }
        public static new GetVpcInvokeArgs Empty => new GetVpcInvokeArgs();
    }


    [OutputType]
    public sealed class GetVpcResult
    {
        public readonly string CidrBlock;
        public readonly string Id;
        public readonly bool IsDefault;
        public readonly bool IsMulticast;
        public readonly string Name;

        [OutputConstructor]
        private GetVpcResult(
            string cidrBlock,

            string id,

            bool isDefault,

            bool isMulticast,

            string name)
        {
            CidrBlock = cidrBlock;
            Id = id;
            IsDefault = isDefault;
            IsMulticast = isMulticast;
            Name = name;
        }
    }
}