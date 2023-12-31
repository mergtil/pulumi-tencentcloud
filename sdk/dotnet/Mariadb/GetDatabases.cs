// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Mariadb
{
    public static class GetDatabases
    {
        public static Task<GetDatabasesResult> InvokeAsync(GetDatabasesArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetDatabasesResult>("tencentcloud:Mariadb/getDatabases:getDatabases", args ?? new GetDatabasesArgs(), options.WithDefaults());

        public static Output<GetDatabasesResult> Invoke(GetDatabasesInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetDatabasesResult>("tencentcloud:Mariadb/getDatabases:getDatabases", args ?? new GetDatabasesInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetDatabasesArgs : global::Pulumi.InvokeArgs
    {
        [Input("instanceId", required: true)]
        public string InstanceId { get; set; } = null!;

        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetDatabasesArgs()
        {
        }
        public static new GetDatabasesArgs Empty => new GetDatabasesArgs();
    }

    public sealed class GetDatabasesInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("instanceId", required: true)]
        public Input<string> InstanceId { get; set; } = null!;

        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetDatabasesInvokeArgs()
        {
        }
        public static new GetDatabasesInvokeArgs Empty => new GetDatabasesInvokeArgs();
    }


    [OutputType]
    public sealed class GetDatabasesResult
    {
        public readonly ImmutableArray<Outputs.GetDatabasesDatabaseResult> MariadbDatabases;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string InstanceId;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetDatabasesResult(
            ImmutableArray<Outputs.GetDatabasesDatabaseResult> databases,

            string id,

            string instanceId,

            string? resultOutputFile)
        {
            MariadbDatabases = databases;
            Id = id;
            InstanceId = instanceId;
            ResultOutputFile = resultOutputFile;
        }
    }
}
