// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Dbbrain
{
    public static class GetHealthScores
    {
        public static Task<GetHealthScoresResult> InvokeAsync(GetHealthScoresArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetHealthScoresResult>("tencentcloud:Dbbrain/getHealthScores:getHealthScores", args ?? new GetHealthScoresArgs(), options.WithDefaults());

        public static Output<GetHealthScoresResult> Invoke(GetHealthScoresInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetHealthScoresResult>("tencentcloud:Dbbrain/getHealthScores:getHealthScores", args ?? new GetHealthScoresInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetHealthScoresArgs : global::Pulumi.InvokeArgs
    {
        [Input("instanceId", required: true)]
        public string InstanceId { get; set; } = null!;

        [Input("product", required: true)]
        public string Product { get; set; } = null!;

        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        [Input("time", required: true)]
        public string Time { get; set; } = null!;

        public GetHealthScoresArgs()
        {
        }
        public static new GetHealthScoresArgs Empty => new GetHealthScoresArgs();
    }

    public sealed class GetHealthScoresInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("instanceId", required: true)]
        public Input<string> InstanceId { get; set; } = null!;

        [Input("product", required: true)]
        public Input<string> Product { get; set; } = null!;

        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        [Input("time", required: true)]
        public Input<string> Time { get; set; } = null!;

        public GetHealthScoresInvokeArgs()
        {
        }
        public static new GetHealthScoresInvokeArgs Empty => new GetHealthScoresInvokeArgs();
    }


    [OutputType]
    public sealed class GetHealthScoresResult
    {
        public readonly ImmutableArray<Outputs.GetHealthScoresDataResult> Datas;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string InstanceId;
        public readonly string Product;
        public readonly string? ResultOutputFile;
        public readonly string Time;

        [OutputConstructor]
        private GetHealthScoresResult(
            ImmutableArray<Outputs.GetHealthScoresDataResult> datas,

            string id,

            string instanceId,

            string product,

            string? resultOutputFile,

            string time)
        {
            Datas = datas;
            Id = id;
            InstanceId = instanceId;
            Product = product;
            ResultOutputFile = resultOutputFile;
            Time = time;
        }
    }
}
