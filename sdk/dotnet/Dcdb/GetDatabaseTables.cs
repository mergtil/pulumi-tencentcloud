// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Dcdb
{
    public static class GetDatabaseTables
    {
        public static Task<GetDatabaseTablesResult> InvokeAsync(GetDatabaseTablesArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetDatabaseTablesResult>("tencentcloud:Dcdb/getDatabaseTables:getDatabaseTables", args ?? new GetDatabaseTablesArgs(), options.WithDefaults());

        public static Output<GetDatabaseTablesResult> Invoke(GetDatabaseTablesInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetDatabaseTablesResult>("tencentcloud:Dcdb/getDatabaseTables:getDatabaseTables", args ?? new GetDatabaseTablesInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetDatabaseTablesArgs : global::Pulumi.InvokeArgs
    {
        [Input("dbName", required: true)]
        public string DbName { get; set; } = null!;

        [Input("instanceId", required: true)]
        public string InstanceId { get; set; } = null!;

        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        [Input("table", required: true)]
        public string Table { get; set; } = null!;

        public GetDatabaseTablesArgs()
        {
        }
        public static new GetDatabaseTablesArgs Empty => new GetDatabaseTablesArgs();
    }

    public sealed class GetDatabaseTablesInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("dbName", required: true)]
        public Input<string> DbName { get; set; } = null!;

        [Input("instanceId", required: true)]
        public Input<string> InstanceId { get; set; } = null!;

        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        [Input("table", required: true)]
        public Input<string> Table { get; set; } = null!;

        public GetDatabaseTablesInvokeArgs()
        {
        }
        public static new GetDatabaseTablesInvokeArgs Empty => new GetDatabaseTablesInvokeArgs();
    }


    [OutputType]
    public sealed class GetDatabaseTablesResult
    {
        public readonly ImmutableArray<Outputs.GetDatabaseTablesColResult> Cols;
        public readonly string DbName;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string InstanceId;
        public readonly string? ResultOutputFile;
        public readonly string Table;

        [OutputConstructor]
        private GetDatabaseTablesResult(
            ImmutableArray<Outputs.GetDatabaseTablesColResult> cols,

            string dbName,

            string id,

            string instanceId,

            string? resultOutputFile,

            string table)
        {
            Cols = cols;
            DbName = dbName;
            Id = id;
            InstanceId = instanceId;
            ResultOutputFile = resultOutputFile;
            Table = table;
        }
    }
}
