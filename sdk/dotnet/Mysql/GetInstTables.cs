// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Mysql
{
    public static class GetInstTables
    {
        public static Task<GetInstTablesResult> InvokeAsync(GetInstTablesArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetInstTablesResult>("tencentcloud:Mysql/getInstTables:getInstTables", args ?? new GetInstTablesArgs(), options.WithDefaults());

        public static Output<GetInstTablesResult> Invoke(GetInstTablesInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetInstTablesResult>("tencentcloud:Mysql/getInstTables:getInstTables", args ?? new GetInstTablesInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetInstTablesArgs : global::Pulumi.InvokeArgs
    {
        [Input("database", required: true)]
        public string Database { get; set; } = null!;

        [Input("instanceId", required: true)]
        public string InstanceId { get; set; } = null!;

        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        [Input("tableRegexp")]
        public string? TableRegexp { get; set; }

        public GetInstTablesArgs()
        {
        }
        public static new GetInstTablesArgs Empty => new GetInstTablesArgs();
    }

    public sealed class GetInstTablesInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("database", required: true)]
        public Input<string> Database { get; set; } = null!;

        [Input("instanceId", required: true)]
        public Input<string> InstanceId { get; set; } = null!;

        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        [Input("tableRegexp")]
        public Input<string>? TableRegexp { get; set; }

        public GetInstTablesInvokeArgs()
        {
        }
        public static new GetInstTablesInvokeArgs Empty => new GetInstTablesInvokeArgs();
    }


    [OutputType]
    public sealed class GetInstTablesResult
    {
        public readonly string Database;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string InstanceId;
        public readonly ImmutableArray<string> Items;
        public readonly string? ResultOutputFile;
        public readonly string? TableRegexp;

        [OutputConstructor]
        private GetInstTablesResult(
            string database,

            string id,

            string instanceId,

            ImmutableArray<string> items,

            string? resultOutputFile,

            string? tableRegexp)
        {
            Database = database;
            Id = id;
            InstanceId = instanceId;
            Items = items;
            ResultOutputFile = resultOutputFile;
            TableRegexp = tableRegexp;
        }
    }
}
