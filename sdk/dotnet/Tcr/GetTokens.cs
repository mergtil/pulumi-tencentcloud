// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Tcr
{
    public static class GetTokens
    {
        public static Task<GetTokensResult> InvokeAsync(GetTokensArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetTokensResult>("tencentcloud:Tcr/getTokens:getTokens", args ?? new GetTokensArgs(), options.WithDefaults());

        public static Output<GetTokensResult> Invoke(GetTokensInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetTokensResult>("tencentcloud:Tcr/getTokens:getTokens", args ?? new GetTokensInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetTokensArgs : global::Pulumi.InvokeArgs
    {
        [Input("instanceId", required: true)]
        public string InstanceId { get; set; } = null!;

        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        [Input("tokenId")]
        public string? TokenId { get; set; }

        public GetTokensArgs()
        {
        }
        public static new GetTokensArgs Empty => new GetTokensArgs();
    }

    public sealed class GetTokensInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("instanceId", required: true)]
        public Input<string> InstanceId { get; set; } = null!;

        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        [Input("tokenId")]
        public Input<string>? TokenId { get; set; }

        public GetTokensInvokeArgs()
        {
        }
        public static new GetTokensInvokeArgs Empty => new GetTokensInvokeArgs();
    }


    [OutputType]
    public sealed class GetTokensResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string InstanceId;
        public readonly string? ResultOutputFile;
        public readonly string? TokenId;
        public readonly ImmutableArray<Outputs.GetTokensTokenListResult> TokenLists;

        [OutputConstructor]
        private GetTokensResult(
            string id,

            string instanceId,

            string? resultOutputFile,

            string? tokenId,

            ImmutableArray<Outputs.GetTokensTokenListResult> tokenLists)
        {
            Id = id;
            InstanceId = instanceId;
            ResultOutputFile = resultOutputFile;
            TokenId = tokenId;
            TokenLists = tokenLists;
        }
    }
}
