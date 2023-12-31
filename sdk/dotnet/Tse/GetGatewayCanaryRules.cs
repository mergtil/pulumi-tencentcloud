// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Tse
{
    public static class GetGatewayCanaryRules
    {
        public static Task<GetGatewayCanaryRulesResult> InvokeAsync(GetGatewayCanaryRulesArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetGatewayCanaryRulesResult>("tencentcloud:Tse/getGatewayCanaryRules:getGatewayCanaryRules", args ?? new GetGatewayCanaryRulesArgs(), options.WithDefaults());

        public static Output<GetGatewayCanaryRulesResult> Invoke(GetGatewayCanaryRulesInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetGatewayCanaryRulesResult>("tencentcloud:Tse/getGatewayCanaryRules:getGatewayCanaryRules", args ?? new GetGatewayCanaryRulesInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetGatewayCanaryRulesArgs : global::Pulumi.InvokeArgs
    {
        [Input("gatewayId", required: true)]
        public string GatewayId { get; set; } = null!;

        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        [Input("serviceId", required: true)]
        public string ServiceId { get; set; } = null!;

        public GetGatewayCanaryRulesArgs()
        {
        }
        public static new GetGatewayCanaryRulesArgs Empty => new GetGatewayCanaryRulesArgs();
    }

    public sealed class GetGatewayCanaryRulesInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("gatewayId", required: true)]
        public Input<string> GatewayId { get; set; } = null!;

        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        [Input("serviceId", required: true)]
        public Input<string> ServiceId { get; set; } = null!;

        public GetGatewayCanaryRulesInvokeArgs()
        {
        }
        public static new GetGatewayCanaryRulesInvokeArgs Empty => new GetGatewayCanaryRulesInvokeArgs();
    }


    [OutputType]
    public sealed class GetGatewayCanaryRulesResult
    {
        public readonly string GatewayId;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string? ResultOutputFile;
        public readonly ImmutableArray<Outputs.GetGatewayCanaryRulesResultResult> Results;
        public readonly string ServiceId;

        [OutputConstructor]
        private GetGatewayCanaryRulesResult(
            string gatewayId,

            string id,

            string? resultOutputFile,

            ImmutableArray<Outputs.GetGatewayCanaryRulesResultResult> results,

            string serviceId)
        {
            GatewayId = gatewayId;
            Id = id;
            ResultOutputFile = resultOutputFile;
            Results = results;
            ServiceId = serviceId;
        }
    }
}
