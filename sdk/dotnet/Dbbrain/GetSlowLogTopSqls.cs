// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Dbbrain
{
    public static class GetSlowLogTopSqls
    {
        public static Task<GetSlowLogTopSqlsResult> InvokeAsync(GetSlowLogTopSqlsArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetSlowLogTopSqlsResult>("tencentcloud:Dbbrain/getSlowLogTopSqls:getSlowLogTopSqls", args ?? new GetSlowLogTopSqlsArgs(), options.WithDefaults());

        public static Output<GetSlowLogTopSqlsResult> Invoke(GetSlowLogTopSqlsInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetSlowLogTopSqlsResult>("tencentcloud:Dbbrain/getSlowLogTopSqls:getSlowLogTopSqls", args ?? new GetSlowLogTopSqlsInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetSlowLogTopSqlsArgs : global::Pulumi.InvokeArgs
    {
        [Input("endTime", required: true)]
        public string EndTime { get; set; } = null!;

        [Input("instanceId", required: true)]
        public string InstanceId { get; set; } = null!;

        [Input("orderBy")]
        public string? OrderBy { get; set; }

        [Input("product")]
        public string? Product { get; set; }

        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        [Input("schemaLists")]
        private List<Inputs.GetSlowLogTopSqlsSchemaListArgs>? _schemaLists;
        public List<Inputs.GetSlowLogTopSqlsSchemaListArgs> SchemaLists
        {
            get => _schemaLists ?? (_schemaLists = new List<Inputs.GetSlowLogTopSqlsSchemaListArgs>());
            set => _schemaLists = value;
        }

        [Input("sortBy")]
        public string? SortBy { get; set; }

        [Input("startTime", required: true)]
        public string StartTime { get; set; } = null!;

        public GetSlowLogTopSqlsArgs()
        {
        }
        public static new GetSlowLogTopSqlsArgs Empty => new GetSlowLogTopSqlsArgs();
    }

    public sealed class GetSlowLogTopSqlsInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("endTime", required: true)]
        public Input<string> EndTime { get; set; } = null!;

        [Input("instanceId", required: true)]
        public Input<string> InstanceId { get; set; } = null!;

        [Input("orderBy")]
        public Input<string>? OrderBy { get; set; }

        [Input("product")]
        public Input<string>? Product { get; set; }

        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        [Input("schemaLists")]
        private InputList<Inputs.GetSlowLogTopSqlsSchemaListInputArgs>? _schemaLists;
        public InputList<Inputs.GetSlowLogTopSqlsSchemaListInputArgs> SchemaLists
        {
            get => _schemaLists ?? (_schemaLists = new InputList<Inputs.GetSlowLogTopSqlsSchemaListInputArgs>());
            set => _schemaLists = value;
        }

        [Input("sortBy")]
        public Input<string>? SortBy { get; set; }

        [Input("startTime", required: true)]
        public Input<string> StartTime { get; set; } = null!;

        public GetSlowLogTopSqlsInvokeArgs()
        {
        }
        public static new GetSlowLogTopSqlsInvokeArgs Empty => new GetSlowLogTopSqlsInvokeArgs();
    }


    [OutputType]
    public sealed class GetSlowLogTopSqlsResult
    {
        public readonly string EndTime;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string InstanceId;
        public readonly string? OrderBy;
        public readonly string? Product;
        public readonly string? ResultOutputFile;
        public readonly ImmutableArray<Outputs.GetSlowLogTopSqlsRowResult> Rows;
        public readonly ImmutableArray<Outputs.GetSlowLogTopSqlsSchemaListResult> SchemaLists;
        public readonly string? SortBy;
        public readonly string StartTime;

        [OutputConstructor]
        private GetSlowLogTopSqlsResult(
            string endTime,

            string id,

            string instanceId,

            string? orderBy,

            string? product,

            string? resultOutputFile,

            ImmutableArray<Outputs.GetSlowLogTopSqlsRowResult> rows,

            ImmutableArray<Outputs.GetSlowLogTopSqlsSchemaListResult> schemaLists,

            string? sortBy,

            string startTime)
        {
            EndTime = endTime;
            Id = id;
            InstanceId = instanceId;
            OrderBy = orderBy;
            Product = product;
            ResultOutputFile = resultOutputFile;
            Rows = rows;
            SchemaLists = schemaLists;
            SortBy = sortBy;
            StartTime = startTime;
        }
    }
}
