// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Nat
{
    public static class GetDcRoute
    {
        public static Task<GetDcRouteResult> InvokeAsync(GetDcRouteArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetDcRouteResult>("tencentcloud:Nat/getDcRoute:getDcRoute", args ?? new GetDcRouteArgs(), options.WithDefaults());

        public static Output<GetDcRouteResult> Invoke(GetDcRouteInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetDcRouteResult>("tencentcloud:Nat/getDcRoute:getDcRoute", args ?? new GetDcRouteInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetDcRouteArgs : global::Pulumi.InvokeArgs
    {
        [Input("natGatewayId", required: true)]
        public string NatGatewayId { get; set; } = null!;

        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        [Input("vpcId", required: true)]
        public string VpcId { get; set; } = null!;

        public GetDcRouteArgs()
        {
        }
        public static new GetDcRouteArgs Empty => new GetDcRouteArgs();
    }

    public sealed class GetDcRouteInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("natGatewayId", required: true)]
        public Input<string> NatGatewayId { get; set; } = null!;

        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        [Input("vpcId", required: true)]
        public Input<string> VpcId { get; set; } = null!;

        public GetDcRouteInvokeArgs()
        {
        }
        public static new GetDcRouteInvokeArgs Empty => new GetDcRouteInvokeArgs();
    }


    [OutputType]
    public sealed class GetDcRouteResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly ImmutableArray<Outputs.GetDcRouteNatDirectConnectGatewayRouteSetResult> NatDirectConnectGatewayRouteSets;
        public readonly string NatGatewayId;
        public readonly string? ResultOutputFile;
        public readonly string VpcId;

        [OutputConstructor]
        private GetDcRouteResult(
            string id,

            ImmutableArray<Outputs.GetDcRouteNatDirectConnectGatewayRouteSetResult> natDirectConnectGatewayRouteSets,

            string natGatewayId,

            string? resultOutputFile,

            string vpcId)
        {
            Id = id;
            NatDirectConnectGatewayRouteSets = natDirectConnectGatewayRouteSets;
            NatGatewayId = natGatewayId;
            ResultOutputFile = resultOutputFile;
            VpcId = vpcId;
        }
    }
}
