// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

export class SyncConfig extends pulumi.CustomResource {
    /**
     * Get an existing SyncConfig resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: SyncConfigState, opts?: pulumi.CustomResourceOptions): SyncConfig {
        return new SyncConfig(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Dts/syncConfig:SyncConfig';

    /**
     * Returns true if the given object is an instance of SyncConfig.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is SyncConfig {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === SyncConfig.__pulumiType;
    }

    /**
     * The time period of automatic retry, can be set from 5 to 720 minutes, 0 means no retry.
     */
    public readonly autoRetryTimeRangeMinutes!: pulumi.Output<number | undefined>;
    /**
     * Target end access type, cdb (cloud database), cvm (cloud host self-built), vpc (private network), extranet (external
     * network), vpncloud (vpn access), dcg (dedicated line access), ccn (cloud networking ), intranet (self-developed cloud),
     * noProxy, note that the specific optional value depends on the current link.
     */
    public readonly dstAccessType!: pulumi.Output<string>;
    /**
     * Target information, single-node database use.
     */
    public readonly dstInfo!: pulumi.Output<outputs.Dts.SyncConfigDstInfo>;
    /**
     * Expected start time, when the value of RunMode is Timed, this value is required, such as: 2006-01-02 15:04:05.
     */
    public readonly expectRunTime!: pulumi.Output<string>;
    /**
     * Synchronization instance id (i.e. identifies a synchronization job).
     */
    public readonly jobId!: pulumi.Output<string>;
    /**
     * The enumeration values are liteMode and fullMode, corresponding to lite mode or normal mode respectively.
     */
    public readonly jobMode!: pulumi.Output<string | undefined>;
    /**
     * Sync job name.
     */
    public readonly jobName!: pulumi.Output<string | undefined>;
    /**
     * Synchronize database table object information.
     */
    public readonly objects!: pulumi.Output<outputs.Dts.SyncConfigObjects>;
    /**
     * Sync Task Options.
     */
    public readonly options!: pulumi.Output<outputs.Dts.SyncConfigOptions>;
    /**
     * Operation mode, such as: Immediate (indicates immediate operation, the default value is this value), Timed (indicates
     * scheduled operation).
     */
    public readonly runMode!: pulumi.Output<string | undefined>;
    /**
     * Source access type, cdb (cloud database), cvm (cloud host self-built), vpc (private network), extranet (external
     * network), vpncloud (vpn access), dcg (dedicated line access), ccn (cloud networking ), intranet (self-developed cloud),
     * noProxy, note that the specific optional value depends on the current link.
     */
    public readonly srcAccessType!: pulumi.Output<string>;
    /**
     * Source information, single-node database use.
     */
    public readonly srcInfo!: pulumi.Output<outputs.Dts.SyncConfigSrcInfo>;

    /**
     * Create a SyncConfig resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: SyncConfigArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: SyncConfigArgs | SyncConfigState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as SyncConfigState | undefined;
            resourceInputs["autoRetryTimeRangeMinutes"] = state ? state.autoRetryTimeRangeMinutes : undefined;
            resourceInputs["dstAccessType"] = state ? state.dstAccessType : undefined;
            resourceInputs["dstInfo"] = state ? state.dstInfo : undefined;
            resourceInputs["expectRunTime"] = state ? state.expectRunTime : undefined;
            resourceInputs["jobId"] = state ? state.jobId : undefined;
            resourceInputs["jobMode"] = state ? state.jobMode : undefined;
            resourceInputs["jobName"] = state ? state.jobName : undefined;
            resourceInputs["objects"] = state ? state.objects : undefined;
            resourceInputs["options"] = state ? state.options : undefined;
            resourceInputs["runMode"] = state ? state.runMode : undefined;
            resourceInputs["srcAccessType"] = state ? state.srcAccessType : undefined;
            resourceInputs["srcInfo"] = state ? state.srcInfo : undefined;
        } else {
            const args = argsOrState as SyncConfigArgs | undefined;
            if ((!args || args.dstAccessType === undefined) && !opts.urn) {
                throw new Error("Missing required property 'dstAccessType'");
            }
            if ((!args || args.jobId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'jobId'");
            }
            if ((!args || args.objects === undefined) && !opts.urn) {
                throw new Error("Missing required property 'objects'");
            }
            if ((!args || args.srcAccessType === undefined) && !opts.urn) {
                throw new Error("Missing required property 'srcAccessType'");
            }
            resourceInputs["autoRetryTimeRangeMinutes"] = args ? args.autoRetryTimeRangeMinutes : undefined;
            resourceInputs["dstAccessType"] = args ? args.dstAccessType : undefined;
            resourceInputs["dstInfo"] = args ? args.dstInfo : undefined;
            resourceInputs["expectRunTime"] = args ? args.expectRunTime : undefined;
            resourceInputs["jobId"] = args ? args.jobId : undefined;
            resourceInputs["jobMode"] = args ? args.jobMode : undefined;
            resourceInputs["jobName"] = args ? args.jobName : undefined;
            resourceInputs["objects"] = args ? args.objects : undefined;
            resourceInputs["options"] = args ? args.options : undefined;
            resourceInputs["runMode"] = args ? args.runMode : undefined;
            resourceInputs["srcAccessType"] = args ? args.srcAccessType : undefined;
            resourceInputs["srcInfo"] = args ? args.srcInfo : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(SyncConfig.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering SyncConfig resources.
 */
export interface SyncConfigState {
    /**
     * The time period of automatic retry, can be set from 5 to 720 minutes, 0 means no retry.
     */
    autoRetryTimeRangeMinutes?: pulumi.Input<number>;
    /**
     * Target end access type, cdb (cloud database), cvm (cloud host self-built), vpc (private network), extranet (external
     * network), vpncloud (vpn access), dcg (dedicated line access), ccn (cloud networking ), intranet (self-developed cloud),
     * noProxy, note that the specific optional value depends on the current link.
     */
    dstAccessType?: pulumi.Input<string>;
    /**
     * Target information, single-node database use.
     */
    dstInfo?: pulumi.Input<inputs.Dts.SyncConfigDstInfo>;
    /**
     * Expected start time, when the value of RunMode is Timed, this value is required, such as: 2006-01-02 15:04:05.
     */
    expectRunTime?: pulumi.Input<string>;
    /**
     * Synchronization instance id (i.e. identifies a synchronization job).
     */
    jobId?: pulumi.Input<string>;
    /**
     * The enumeration values are liteMode and fullMode, corresponding to lite mode or normal mode respectively.
     */
    jobMode?: pulumi.Input<string>;
    /**
     * Sync job name.
     */
    jobName?: pulumi.Input<string>;
    /**
     * Synchronize database table object information.
     */
    objects?: pulumi.Input<inputs.Dts.SyncConfigObjects>;
    /**
     * Sync Task Options.
     */
    options?: pulumi.Input<inputs.Dts.SyncConfigOptions>;
    /**
     * Operation mode, such as: Immediate (indicates immediate operation, the default value is this value), Timed (indicates
     * scheduled operation).
     */
    runMode?: pulumi.Input<string>;
    /**
     * Source access type, cdb (cloud database), cvm (cloud host self-built), vpc (private network), extranet (external
     * network), vpncloud (vpn access), dcg (dedicated line access), ccn (cloud networking ), intranet (self-developed cloud),
     * noProxy, note that the specific optional value depends on the current link.
     */
    srcAccessType?: pulumi.Input<string>;
    /**
     * Source information, single-node database use.
     */
    srcInfo?: pulumi.Input<inputs.Dts.SyncConfigSrcInfo>;
}

/**
 * The set of arguments for constructing a SyncConfig resource.
 */
export interface SyncConfigArgs {
    /**
     * The time period of automatic retry, can be set from 5 to 720 minutes, 0 means no retry.
     */
    autoRetryTimeRangeMinutes?: pulumi.Input<number>;
    /**
     * Target end access type, cdb (cloud database), cvm (cloud host self-built), vpc (private network), extranet (external
     * network), vpncloud (vpn access), dcg (dedicated line access), ccn (cloud networking ), intranet (self-developed cloud),
     * noProxy, note that the specific optional value depends on the current link.
     */
    dstAccessType: pulumi.Input<string>;
    /**
     * Target information, single-node database use.
     */
    dstInfo?: pulumi.Input<inputs.Dts.SyncConfigDstInfo>;
    /**
     * Expected start time, when the value of RunMode is Timed, this value is required, such as: 2006-01-02 15:04:05.
     */
    expectRunTime?: pulumi.Input<string>;
    /**
     * Synchronization instance id (i.e. identifies a synchronization job).
     */
    jobId: pulumi.Input<string>;
    /**
     * The enumeration values are liteMode and fullMode, corresponding to lite mode or normal mode respectively.
     */
    jobMode?: pulumi.Input<string>;
    /**
     * Sync job name.
     */
    jobName?: pulumi.Input<string>;
    /**
     * Synchronize database table object information.
     */
    objects: pulumi.Input<inputs.Dts.SyncConfigObjects>;
    /**
     * Sync Task Options.
     */
    options?: pulumi.Input<inputs.Dts.SyncConfigOptions>;
    /**
     * Operation mode, such as: Immediate (indicates immediate operation, the default value is this value), Timed (indicates
     * scheduled operation).
     */
    runMode?: pulumi.Input<string>;
    /**
     * Source access type, cdb (cloud database), cvm (cloud host self-built), vpc (private network), extranet (external
     * network), vpncloud (vpn access), dcg (dedicated line access), ccn (cloud networking ), intranet (self-developed cloud),
     * noProxy, note that the specific optional value depends on the current link.
     */
    srcAccessType: pulumi.Input<string>;
    /**
     * Source information, single-node database use.
     */
    srcInfo?: pulumi.Input<inputs.Dts.SyncConfigSrcInfo>;
}