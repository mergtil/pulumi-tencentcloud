// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Sqlserver
{
    public static class GetBackupCommands
    {
        public static Task<GetBackupCommandsResult> InvokeAsync(GetBackupCommandsArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetBackupCommandsResult>("tencentcloud:Sqlserver/getBackupCommands:getBackupCommands", args ?? new GetBackupCommandsArgs(), options.WithDefaults());

        public static Output<GetBackupCommandsResult> Invoke(GetBackupCommandsInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetBackupCommandsResult>("tencentcloud:Sqlserver/getBackupCommands:getBackupCommands", args ?? new GetBackupCommandsInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetBackupCommandsArgs : global::Pulumi.InvokeArgs
    {
        [Input("backupFileType", required: true)]
        public string BackupFileType { get; set; } = null!;

        [Input("dataBaseName", required: true)]
        public string DataBaseName { get; set; } = null!;

        [Input("isRecovery", required: true)]
        public string IsRecovery { get; set; } = null!;

        [Input("localPath")]
        public string? LocalPath { get; set; }

        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetBackupCommandsArgs()
        {
        }
        public static new GetBackupCommandsArgs Empty => new GetBackupCommandsArgs();
    }

    public sealed class GetBackupCommandsInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("backupFileType", required: true)]
        public Input<string> BackupFileType { get; set; } = null!;

        [Input("dataBaseName", required: true)]
        public Input<string> DataBaseName { get; set; } = null!;

        [Input("isRecovery", required: true)]
        public Input<string> IsRecovery { get; set; } = null!;

        [Input("localPath")]
        public Input<string>? LocalPath { get; set; }

        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetBackupCommandsInvokeArgs()
        {
        }
        public static new GetBackupCommandsInvokeArgs Empty => new GetBackupCommandsInvokeArgs();
    }


    [OutputType]
    public sealed class GetBackupCommandsResult
    {
        public readonly string BackupFileType;
        public readonly string DataBaseName;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string IsRecovery;
        public readonly ImmutableArray<Outputs.GetBackupCommandsListResult> Lists;
        public readonly string? LocalPath;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetBackupCommandsResult(
            string backupFileType,

            string dataBaseName,

            string id,

            string isRecovery,

            ImmutableArray<Outputs.GetBackupCommandsListResult> lists,

            string? localPath,

            string? resultOutputFile)
        {
            BackupFileType = backupFileType;
            DataBaseName = dataBaseName;
            Id = id;
            IsRecovery = isRecovery;
            Lists = lists;
            LocalPath = localPath;
            ResultOutputFile = resultOutputFile;
        }
    }
}
