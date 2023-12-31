// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Sqlserver
{
    public static class GetDbCharsets
    {
        public static Task<GetDbCharsetsResult> InvokeAsync(GetDbCharsetsArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetDbCharsetsResult>("tencentcloud:Sqlserver/getDbCharsets:getDbCharsets", args ?? new GetDbCharsetsArgs(), options.WithDefaults());

        public static Output<GetDbCharsetsResult> Invoke(GetDbCharsetsInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetDbCharsetsResult>("tencentcloud:Sqlserver/getDbCharsets:getDbCharsets", args ?? new GetDbCharsetsInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetDbCharsetsArgs : global::Pulumi.InvokeArgs
    {
        [Input("instanceId", required: true)]
        public string InstanceId { get; set; } = null!;

        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetDbCharsetsArgs()
        {
        }
        public static new GetDbCharsetsArgs Empty => new GetDbCharsetsArgs();
    }

    public sealed class GetDbCharsetsInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("instanceId", required: true)]
        public Input<string> InstanceId { get; set; } = null!;

        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetDbCharsetsInvokeArgs()
        {
        }
        public static new GetDbCharsetsInvokeArgs Empty => new GetDbCharsetsInvokeArgs();
    }


    [OutputType]
    public sealed class GetDbCharsetsResult
    {
        public readonly ImmutableArray<string> DatabaseCharsets;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string InstanceId;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetDbCharsetsResult(
            ImmutableArray<string> databaseCharsets,

            string id,

            string instanceId,

            string? resultOutputFile)
        {
            DatabaseCharsets = databaseCharsets;
            Id = id;
            InstanceId = instanceId;
            ResultOutputFile = resultOutputFile;
        }
    }
}
