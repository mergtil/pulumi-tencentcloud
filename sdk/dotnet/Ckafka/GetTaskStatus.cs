// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Ckafka
{
    public static class GetTaskStatus
    {
        public static Task<GetTaskStatusResult> InvokeAsync(GetTaskStatusArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetTaskStatusResult>("tencentcloud:Ckafka/getTaskStatus:getTaskStatus", args ?? new GetTaskStatusArgs(), options.WithDefaults());

        public static Output<GetTaskStatusResult> Invoke(GetTaskStatusInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetTaskStatusResult>("tencentcloud:Ckafka/getTaskStatus:getTaskStatus", args ?? new GetTaskStatusInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetTaskStatusArgs : global::Pulumi.InvokeArgs
    {
        [Input("flowId", required: true)]
        public int FlowId { get; set; }

        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetTaskStatusArgs()
        {
        }
        public static new GetTaskStatusArgs Empty => new GetTaskStatusArgs();
    }

    public sealed class GetTaskStatusInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("flowId", required: true)]
        public Input<int> FlowId { get; set; } = null!;

        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetTaskStatusInvokeArgs()
        {
        }
        public static new GetTaskStatusInvokeArgs Empty => new GetTaskStatusInvokeArgs();
    }


    [OutputType]
    public sealed class GetTaskStatusResult
    {
        public readonly int FlowId;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string? ResultOutputFile;
        public readonly ImmutableArray<Outputs.GetTaskStatusResultResult> Results;

        [OutputConstructor]
        private GetTaskStatusResult(
            int flowId,

            string id,

            string? resultOutputFile,

            ImmutableArray<Outputs.GetTaskStatusResultResult> results)
        {
            FlowId = flowId;
            Id = id;
            ResultOutputFile = resultOutputFile;
            Results = results;
        }
    }
}
