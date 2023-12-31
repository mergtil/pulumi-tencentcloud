// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Tdmq
{
    public static class GetEnvironmentAttributes
    {
        public static Task<GetEnvironmentAttributesResult> InvokeAsync(GetEnvironmentAttributesArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetEnvironmentAttributesResult>("tencentcloud:Tdmq/getEnvironmentAttributes:getEnvironmentAttributes", args ?? new GetEnvironmentAttributesArgs(), options.WithDefaults());

        public static Output<GetEnvironmentAttributesResult> Invoke(GetEnvironmentAttributesInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetEnvironmentAttributesResult>("tencentcloud:Tdmq/getEnvironmentAttributes:getEnvironmentAttributes", args ?? new GetEnvironmentAttributesInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetEnvironmentAttributesArgs : global::Pulumi.InvokeArgs
    {
        [Input("clusterId")]
        public string? ClusterId { get; set; }

        [Input("environmentId", required: true)]
        public string EnvironmentId { get; set; } = null!;

        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetEnvironmentAttributesArgs()
        {
        }
        public static new GetEnvironmentAttributesArgs Empty => new GetEnvironmentAttributesArgs();
    }

    public sealed class GetEnvironmentAttributesInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("clusterId")]
        public Input<string>? ClusterId { get; set; }

        [Input("environmentId", required: true)]
        public Input<string> EnvironmentId { get; set; } = null!;

        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetEnvironmentAttributesInvokeArgs()
        {
        }
        public static new GetEnvironmentAttributesInvokeArgs Empty => new GetEnvironmentAttributesInvokeArgs();
    }


    [OutputType]
    public sealed class GetEnvironmentAttributesResult
    {
        public readonly string? ClusterId;
        public readonly string EnvironmentId;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly int MsgTtl;
        public readonly int RateInByte;
        public readonly int RateInSize;
        public readonly string Remark;
        public readonly int Replicas;
        public readonly string? ResultOutputFile;
        public readonly int RetentionHours;
        public readonly int RetentionSize;

        [OutputConstructor]
        private GetEnvironmentAttributesResult(
            string? clusterId,

            string environmentId,

            string id,

            int msgTtl,

            int rateInByte,

            int rateInSize,

            string remark,

            int replicas,

            string? resultOutputFile,

            int retentionHours,

            int retentionSize)
        {
            ClusterId = clusterId;
            EnvironmentId = environmentId;
            Id = id;
            MsgTtl = msgTtl;
            RateInByte = rateInByte;
            RateInSize = rateInSize;
            Remark = remark;
            Replicas = replicas;
            ResultOutputFile = resultOutputFile;
            RetentionHours = retentionHours;
            RetentionSize = retentionSize;
        }
    }
}
