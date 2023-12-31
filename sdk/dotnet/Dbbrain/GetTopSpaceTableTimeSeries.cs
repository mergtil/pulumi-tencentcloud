// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Dbbrain
{
    public static class GetTopSpaceTableTimeSeries
    {
        public static Task<GetTopSpaceTableTimeSeriesResult> InvokeAsync(GetTopSpaceTableTimeSeriesArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetTopSpaceTableTimeSeriesResult>("tencentcloud:Dbbrain/getTopSpaceTableTimeSeries:getTopSpaceTableTimeSeries", args ?? new GetTopSpaceTableTimeSeriesArgs(), options.WithDefaults());

        public static Output<GetTopSpaceTableTimeSeriesResult> Invoke(GetTopSpaceTableTimeSeriesInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetTopSpaceTableTimeSeriesResult>("tencentcloud:Dbbrain/getTopSpaceTableTimeSeries:getTopSpaceTableTimeSeries", args ?? new GetTopSpaceTableTimeSeriesInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetTopSpaceTableTimeSeriesArgs : global::Pulumi.InvokeArgs
    {
        [Input("endDate")]
        public string? EndDate { get; set; }

        [Input("instanceId", required: true)]
        public string InstanceId { get; set; } = null!;

        [Input("limit")]
        public int? Limit { get; set; }

        [Input("product")]
        public string? Product { get; set; }

        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        [Input("sortBy")]
        public string? SortBy { get; set; }

        [Input("startDate")]
        public string? StartDate { get; set; }

        public GetTopSpaceTableTimeSeriesArgs()
        {
        }
        public static new GetTopSpaceTableTimeSeriesArgs Empty => new GetTopSpaceTableTimeSeriesArgs();
    }

    public sealed class GetTopSpaceTableTimeSeriesInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("endDate")]
        public Input<string>? EndDate { get; set; }

        [Input("instanceId", required: true)]
        public Input<string> InstanceId { get; set; } = null!;

        [Input("limit")]
        public Input<int>? Limit { get; set; }

        [Input("product")]
        public Input<string>? Product { get; set; }

        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        [Input("sortBy")]
        public Input<string>? SortBy { get; set; }

        [Input("startDate")]
        public Input<string>? StartDate { get; set; }

        public GetTopSpaceTableTimeSeriesInvokeArgs()
        {
        }
        public static new GetTopSpaceTableTimeSeriesInvokeArgs Empty => new GetTopSpaceTableTimeSeriesInvokeArgs();
    }


    [OutputType]
    public sealed class GetTopSpaceTableTimeSeriesResult
    {
        public readonly string? EndDate;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string InstanceId;
        public readonly int? Limit;
        public readonly string? Product;
        public readonly string? ResultOutputFile;
        public readonly string? SortBy;
        public readonly string? StartDate;
        public readonly ImmutableArray<Outputs.GetTopSpaceTableTimeSeriesTopSpaceTableTimeSeriesResult> DbbrainTopSpaceTableTimeSeries;

        [OutputConstructor]
        private GetTopSpaceTableTimeSeriesResult(
            string? endDate,

            string id,

            string instanceId,

            int? limit,

            string? product,

            string? resultOutputFile,

            string? sortBy,

            string? startDate,

            ImmutableArray<Outputs.GetTopSpaceTableTimeSeriesTopSpaceTableTimeSeriesResult> topSpaceTableTimeSeries)
        {
            EndDate = endDate;
            Id = id;
            InstanceId = instanceId;
            Limit = limit;
            Product = product;
            ResultOutputFile = resultOutputFile;
            SortBy = sortBy;
            StartDate = startDate;
            DbbrainTopSpaceTableTimeSeries = topSpaceTableTimeSeries;
        }
    }
}
