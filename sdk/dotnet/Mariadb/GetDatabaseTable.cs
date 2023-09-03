// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Mariadb
{
    public static class GetDatabaseTable
    {
        public static Task<GetDatabaseTableResult> InvokeAsync(GetDatabaseTableArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetDatabaseTableResult>("tencentcloud:Mariadb/getDatabaseTable:getDatabaseTable", args ?? new GetDatabaseTableArgs(), options.WithDefaults());

        public static Output<GetDatabaseTableResult> Invoke(GetDatabaseTableInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetDatabaseTableResult>("tencentcloud:Mariadb/getDatabaseTable:getDatabaseTable", args ?? new GetDatabaseTableInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetDatabaseTableArgs : global::Pulumi.InvokeArgs
    {
        [Input("dbName", required: true)]
        public string DbName { get; set; } = null!;

        [Input("instanceId", required: true)]
        public string InstanceId { get; set; } = null!;

        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        [Input("table", required: true)]
        public string Table { get; set; } = null!;

        public GetDatabaseTableArgs()
        {
        }
        public static new GetDatabaseTableArgs Empty => new GetDatabaseTableArgs();
    }

    public sealed class GetDatabaseTableInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("dbName", required: true)]
        public Input<string> DbName { get; set; } = null!;

        [Input("instanceId", required: true)]
        public Input<string> InstanceId { get; set; } = null!;

        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        [Input("table", required: true)]
        public Input<string> Table { get; set; } = null!;

        public GetDatabaseTableInvokeArgs()
        {
        }
        public static new GetDatabaseTableInvokeArgs Empty => new GetDatabaseTableInvokeArgs();
    }


    [OutputType]
    public sealed class GetDatabaseTableResult
    {
        public readonly ImmutableArray<Outputs.GetDatabaseTableColResult> Cols;
        public readonly string DbName;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string InstanceId;
        public readonly string? ResultOutputFile;
        public readonly string Table;

        [OutputConstructor]
        private GetDatabaseTableResult(
            ImmutableArray<Outputs.GetDatabaseTableColResult> cols,

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