// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Dts
{
    [TencentcloudResourceType("tencentcloud:Dts/syncConfig:SyncConfig")]
    public partial class SyncConfig : global::Pulumi.CustomResource
    {
        /// <summary>
        /// The time period of automatic retry, can be set from 5 to 720 minutes, 0 means no retry.
        /// </summary>
        [Output("autoRetryTimeRangeMinutes")]
        public Output<int?> AutoRetryTimeRangeMinutes { get; private set; } = null!;

        /// <summary>
        /// Target end access type, cdb (cloud database), cvm (cloud host self-built), vpc (private network), extranet (external
        /// network), vpncloud (vpn access), dcg (dedicated line access), ccn (cloud networking ), intranet (self-developed cloud),
        /// noProxy, note that the specific optional value depends on the current link.
        /// </summary>
        [Output("dstAccessType")]
        public Output<string> DstAccessType { get; private set; } = null!;

        /// <summary>
        /// Target information, single-node database use.
        /// </summary>
        [Output("dstInfo")]
        public Output<Outputs.SyncConfigDstInfo> DstInfo { get; private set; } = null!;

        /// <summary>
        /// Expected start time, when the value of RunMode is Timed, this value is required, such as: 2006-01-02 15:04:05.
        /// </summary>
        [Output("expectRunTime")]
        public Output<string> ExpectRunTime { get; private set; } = null!;

        /// <summary>
        /// Synchronization instance id (i.e. identifies a synchronization job).
        /// </summary>
        [Output("jobId")]
        public Output<string> JobId { get; private set; } = null!;

        /// <summary>
        /// The enumeration values are liteMode and fullMode, corresponding to lite mode or normal mode respectively.
        /// </summary>
        [Output("jobMode")]
        public Output<string?> JobMode { get; private set; } = null!;

        /// <summary>
        /// Sync job name.
        /// </summary>
        [Output("jobName")]
        public Output<string?> JobName { get; private set; } = null!;

        /// <summary>
        /// Synchronize database table object information.
        /// </summary>
        [Output("objects")]
        public Output<Outputs.SyncConfigObjects> Objects { get; private set; } = null!;

        /// <summary>
        /// Sync Task Options.
        /// </summary>
        [Output("options")]
        public Output<Outputs.SyncConfigOptions> Options { get; private set; } = null!;

        /// <summary>
        /// Operation mode, such as: Immediate (indicates immediate operation, the default value is this value), Timed (indicates
        /// scheduled operation).
        /// </summary>
        [Output("runMode")]
        public Output<string?> RunMode { get; private set; } = null!;

        /// <summary>
        /// Source access type, cdb (cloud database), cvm (cloud host self-built), vpc (private network), extranet (external
        /// network), vpncloud (vpn access), dcg (dedicated line access), ccn (cloud networking ), intranet (self-developed cloud),
        /// noProxy, note that the specific optional value depends on the current link.
        /// </summary>
        [Output("srcAccessType")]
        public Output<string> SrcAccessType { get; private set; } = null!;

        /// <summary>
        /// Source information, single-node database use.
        /// </summary>
        [Output("srcInfo")]
        public Output<Outputs.SyncConfigSrcInfo> SrcInfo { get; private set; } = null!;


        /// <summary>
        /// Create a SyncConfig resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public SyncConfig(string name, SyncConfigArgs args, CustomResourceOptions? options = null)
            : base("tencentcloud:Dts/syncConfig:SyncConfig", name, args ?? new SyncConfigArgs(), MakeResourceOptions(options, ""))
        {
        }

        private SyncConfig(string name, Input<string> id, SyncConfigState? state = null, CustomResourceOptions? options = null)
            : base("tencentcloud:Dts/syncConfig:SyncConfig", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing SyncConfig resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static SyncConfig Get(string name, Input<string> id, SyncConfigState? state = null, CustomResourceOptions? options = null)
        {
            return new SyncConfig(name, id, state, options);
        }
    }

    public sealed class SyncConfigArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The time period of automatic retry, can be set from 5 to 720 minutes, 0 means no retry.
        /// </summary>
        [Input("autoRetryTimeRangeMinutes")]
        public Input<int>? AutoRetryTimeRangeMinutes { get; set; }

        /// <summary>
        /// Target end access type, cdb (cloud database), cvm (cloud host self-built), vpc (private network), extranet (external
        /// network), vpncloud (vpn access), dcg (dedicated line access), ccn (cloud networking ), intranet (self-developed cloud),
        /// noProxy, note that the specific optional value depends on the current link.
        /// </summary>
        [Input("dstAccessType", required: true)]
        public Input<string> DstAccessType { get; set; } = null!;

        /// <summary>
        /// Target information, single-node database use.
        /// </summary>
        [Input("dstInfo")]
        public Input<Inputs.SyncConfigDstInfoArgs>? DstInfo { get; set; }

        /// <summary>
        /// Expected start time, when the value of RunMode is Timed, this value is required, such as: 2006-01-02 15:04:05.
        /// </summary>
        [Input("expectRunTime")]
        public Input<string>? ExpectRunTime { get; set; }

        /// <summary>
        /// Synchronization instance id (i.e. identifies a synchronization job).
        /// </summary>
        [Input("jobId", required: true)]
        public Input<string> JobId { get; set; } = null!;

        /// <summary>
        /// The enumeration values are liteMode and fullMode, corresponding to lite mode or normal mode respectively.
        /// </summary>
        [Input("jobMode")]
        public Input<string>? JobMode { get; set; }

        /// <summary>
        /// Sync job name.
        /// </summary>
        [Input("jobName")]
        public Input<string>? JobName { get; set; }

        /// <summary>
        /// Synchronize database table object information.
        /// </summary>
        [Input("objects", required: true)]
        public Input<Inputs.SyncConfigObjectsArgs> Objects { get; set; } = null!;

        /// <summary>
        /// Sync Task Options.
        /// </summary>
        [Input("options")]
        public Input<Inputs.SyncConfigOptionsArgs>? Options { get; set; }

        /// <summary>
        /// Operation mode, such as: Immediate (indicates immediate operation, the default value is this value), Timed (indicates
        /// scheduled operation).
        /// </summary>
        [Input("runMode")]
        public Input<string>? RunMode { get; set; }

        /// <summary>
        /// Source access type, cdb (cloud database), cvm (cloud host self-built), vpc (private network), extranet (external
        /// network), vpncloud (vpn access), dcg (dedicated line access), ccn (cloud networking ), intranet (self-developed cloud),
        /// noProxy, note that the specific optional value depends on the current link.
        /// </summary>
        [Input("srcAccessType", required: true)]
        public Input<string> SrcAccessType { get; set; } = null!;

        /// <summary>
        /// Source information, single-node database use.
        /// </summary>
        [Input("srcInfo")]
        public Input<Inputs.SyncConfigSrcInfoArgs>? SrcInfo { get; set; }

        public SyncConfigArgs()
        {
        }
        public static new SyncConfigArgs Empty => new SyncConfigArgs();
    }

    public sealed class SyncConfigState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The time period of automatic retry, can be set from 5 to 720 minutes, 0 means no retry.
        /// </summary>
        [Input("autoRetryTimeRangeMinutes")]
        public Input<int>? AutoRetryTimeRangeMinutes { get; set; }

        /// <summary>
        /// Target end access type, cdb (cloud database), cvm (cloud host self-built), vpc (private network), extranet (external
        /// network), vpncloud (vpn access), dcg (dedicated line access), ccn (cloud networking ), intranet (self-developed cloud),
        /// noProxy, note that the specific optional value depends on the current link.
        /// </summary>
        [Input("dstAccessType")]
        public Input<string>? DstAccessType { get; set; }

        /// <summary>
        /// Target information, single-node database use.
        /// </summary>
        [Input("dstInfo")]
        public Input<Inputs.SyncConfigDstInfoGetArgs>? DstInfo { get; set; }

        /// <summary>
        /// Expected start time, when the value of RunMode is Timed, this value is required, such as: 2006-01-02 15:04:05.
        /// </summary>
        [Input("expectRunTime")]
        public Input<string>? ExpectRunTime { get; set; }

        /// <summary>
        /// Synchronization instance id (i.e. identifies a synchronization job).
        /// </summary>
        [Input("jobId")]
        public Input<string>? JobId { get; set; }

        /// <summary>
        /// The enumeration values are liteMode and fullMode, corresponding to lite mode or normal mode respectively.
        /// </summary>
        [Input("jobMode")]
        public Input<string>? JobMode { get; set; }

        /// <summary>
        /// Sync job name.
        /// </summary>
        [Input("jobName")]
        public Input<string>? JobName { get; set; }

        /// <summary>
        /// Synchronize database table object information.
        /// </summary>
        [Input("objects")]
        public Input<Inputs.SyncConfigObjectsGetArgs>? Objects { get; set; }

        /// <summary>
        /// Sync Task Options.
        /// </summary>
        [Input("options")]
        public Input<Inputs.SyncConfigOptionsGetArgs>? Options { get; set; }

        /// <summary>
        /// Operation mode, such as: Immediate (indicates immediate operation, the default value is this value), Timed (indicates
        /// scheduled operation).
        /// </summary>
        [Input("runMode")]
        public Input<string>? RunMode { get; set; }

        /// <summary>
        /// Source access type, cdb (cloud database), cvm (cloud host self-built), vpc (private network), extranet (external
        /// network), vpncloud (vpn access), dcg (dedicated line access), ccn (cloud networking ), intranet (self-developed cloud),
        /// noProxy, note that the specific optional value depends on the current link.
        /// </summary>
        [Input("srcAccessType")]
        public Input<string>? SrcAccessType { get; set; }

        /// <summary>
        /// Source information, single-node database use.
        /// </summary>
        [Input("srcInfo")]
        public Input<Inputs.SyncConfigSrcInfoGetArgs>? SrcInfo { get; set; }

        public SyncConfigState()
        {
        }
        public static new SyncConfigState Empty => new SyncConfigState();
    }
}