// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Redis
{
    public static class GetBackupDownloadInfo
    {
        public static Task<GetBackupDownloadInfoResult> InvokeAsync(GetBackupDownloadInfoArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetBackupDownloadInfoResult>("tencentcloud:Redis/getBackupDownloadInfo:getBackupDownloadInfo", args ?? new GetBackupDownloadInfoArgs(), options.WithDefaults());

        public static Output<GetBackupDownloadInfoResult> Invoke(GetBackupDownloadInfoInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetBackupDownloadInfoResult>("tencentcloud:Redis/getBackupDownloadInfo:getBackupDownloadInfo", args ?? new GetBackupDownloadInfoInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetBackupDownloadInfoArgs : global::Pulumi.InvokeArgs
    {
        [Input("backupId", required: true)]
        public string BackupId { get; set; } = null!;

        [Input("instanceId", required: true)]
        public string InstanceId { get; set; } = null!;

        [Input("ipComparisonSymbol")]
        public string? IpComparisonSymbol { get; set; }

        [Input("limitIps")]
        private List<string>? _limitIps;
        public List<string> LimitIps
        {
            get => _limitIps ?? (_limitIps = new List<string>());
            set => _limitIps = value;
        }

        [Input("limitType")]
        public string? LimitType { get; set; }

        [Input("limitVpcs")]
        private List<Inputs.GetBackupDownloadInfoLimitVpcArgs>? _limitVpcs;
        public List<Inputs.GetBackupDownloadInfoLimitVpcArgs> LimitVpcs
        {
            get => _limitVpcs ?? (_limitVpcs = new List<Inputs.GetBackupDownloadInfoLimitVpcArgs>());
            set => _limitVpcs = value;
        }

        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        [Input("vpcComparisonSymbol")]
        public string? VpcComparisonSymbol { get; set; }

        public GetBackupDownloadInfoArgs()
        {
        }
        public static new GetBackupDownloadInfoArgs Empty => new GetBackupDownloadInfoArgs();
    }

    public sealed class GetBackupDownloadInfoInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("backupId", required: true)]
        public Input<string> BackupId { get; set; } = null!;

        [Input("instanceId", required: true)]
        public Input<string> InstanceId { get; set; } = null!;

        [Input("ipComparisonSymbol")]
        public Input<string>? IpComparisonSymbol { get; set; }

        [Input("limitIps")]
        private InputList<string>? _limitIps;
        public InputList<string> LimitIps
        {
            get => _limitIps ?? (_limitIps = new InputList<string>());
            set => _limitIps = value;
        }

        [Input("limitType")]
        public Input<string>? LimitType { get; set; }

        [Input("limitVpcs")]
        private InputList<Inputs.GetBackupDownloadInfoLimitVpcInputArgs>? _limitVpcs;
        public InputList<Inputs.GetBackupDownloadInfoLimitVpcInputArgs> LimitVpcs
        {
            get => _limitVpcs ?? (_limitVpcs = new InputList<Inputs.GetBackupDownloadInfoLimitVpcInputArgs>());
            set => _limitVpcs = value;
        }

        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        [Input("vpcComparisonSymbol")]
        public Input<string>? VpcComparisonSymbol { get; set; }

        public GetBackupDownloadInfoInvokeArgs()
        {
        }
        public static new GetBackupDownloadInfoInvokeArgs Empty => new GetBackupDownloadInfoInvokeArgs();
    }


    [OutputType]
    public sealed class GetBackupDownloadInfoResult
    {
        public readonly string BackupId;
        public readonly ImmutableArray<Outputs.GetBackupDownloadInfoBackupInfoResult> BackupInfos;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string InstanceId;
        public readonly string? IpComparisonSymbol;
        public readonly ImmutableArray<string> LimitIps;
        public readonly string? LimitType;
        public readonly ImmutableArray<Outputs.GetBackupDownloadInfoLimitVpcResult> LimitVpcs;
        public readonly string? ResultOutputFile;
        public readonly string? VpcComparisonSymbol;

        [OutputConstructor]
        private GetBackupDownloadInfoResult(
            string backupId,

            ImmutableArray<Outputs.GetBackupDownloadInfoBackupInfoResult> backupInfos,

            string id,

            string instanceId,

            string? ipComparisonSymbol,

            ImmutableArray<string> limitIps,

            string? limitType,

            ImmutableArray<Outputs.GetBackupDownloadInfoLimitVpcResult> limitVpcs,

            string? resultOutputFile,

            string? vpcComparisonSymbol)
        {
            BackupId = backupId;
            BackupInfos = backupInfos;
            Id = id;
            InstanceId = instanceId;
            IpComparisonSymbol = ipComparisonSymbol;
            LimitIps = limitIps;
            LimitType = limitType;
            LimitVpcs = limitVpcs;
            ResultOutputFile = resultOutputFile;
            VpcComparisonSymbol = vpcComparisonSymbol;
        }
    }
}
