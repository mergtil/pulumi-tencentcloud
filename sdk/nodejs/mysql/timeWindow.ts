// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

export class TimeWindow extends pulumi.CustomResource {
    /**
     * Get an existing TimeWindow resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: TimeWindowState, opts?: pulumi.CustomResourceOptions): TimeWindow {
        return new TimeWindow(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Mysql/timeWindow:TimeWindow';

    /**
     * Returns true if the given object is an instance of TimeWindow.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is TimeWindow {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === TimeWindow.__pulumiType;
    }

    /**
     * Instance ID in the format of cdb-c1nl9rpv or cdbro-c1nl9rpv. It is the same as the instance ID displayed on the
     * TencentDB Console page.
     */
    public readonly instanceId!: pulumi.Output<string>;
    /**
     * Data delay threshold. It takes effect only for source instance and disaster recovery instance. Default value: 10.
     */
    public readonly maxDelayTime!: pulumi.Output<number | undefined>;
    /**
     * Time period available for maintenance after modification in the format of 10:00-12:00. Each period lasts from half an
     * hour to three hours, with the start time and end time aligned by half-hour. Up to two time periods can be set. Start and
     * end time range: [00:00, 24:00].
     */
    public readonly timeRanges!: pulumi.Output<string[]>;
    /**
     * Specifies for which day to modify the time period. Value range: Monday, Tuesday, Wednesday, Thursday, Friday, Saturday,
     * Sunday. If it is not specified or is left blank, the time period will be modified for every day by default.
     */
    public readonly weekdays!: pulumi.Output<string[] | undefined>;

    /**
     * Create a TimeWindow resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: TimeWindowArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: TimeWindowArgs | TimeWindowState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as TimeWindowState | undefined;
            resourceInputs["instanceId"] = state ? state.instanceId : undefined;
            resourceInputs["maxDelayTime"] = state ? state.maxDelayTime : undefined;
            resourceInputs["timeRanges"] = state ? state.timeRanges : undefined;
            resourceInputs["weekdays"] = state ? state.weekdays : undefined;
        } else {
            const args = argsOrState as TimeWindowArgs | undefined;
            if ((!args || args.instanceId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'instanceId'");
            }
            if ((!args || args.timeRanges === undefined) && !opts.urn) {
                throw new Error("Missing required property 'timeRanges'");
            }
            resourceInputs["instanceId"] = args ? args.instanceId : undefined;
            resourceInputs["maxDelayTime"] = args ? args.maxDelayTime : undefined;
            resourceInputs["timeRanges"] = args ? args.timeRanges : undefined;
            resourceInputs["weekdays"] = args ? args.weekdays : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(TimeWindow.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering TimeWindow resources.
 */
export interface TimeWindowState {
    /**
     * Instance ID in the format of cdb-c1nl9rpv or cdbro-c1nl9rpv. It is the same as the instance ID displayed on the
     * TencentDB Console page.
     */
    instanceId?: pulumi.Input<string>;
    /**
     * Data delay threshold. It takes effect only for source instance and disaster recovery instance. Default value: 10.
     */
    maxDelayTime?: pulumi.Input<number>;
    /**
     * Time period available for maintenance after modification in the format of 10:00-12:00. Each period lasts from half an
     * hour to three hours, with the start time and end time aligned by half-hour. Up to two time periods can be set. Start and
     * end time range: [00:00, 24:00].
     */
    timeRanges?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Specifies for which day to modify the time period. Value range: Monday, Tuesday, Wednesday, Thursday, Friday, Saturday,
     * Sunday. If it is not specified or is left blank, the time period will be modified for every day by default.
     */
    weekdays?: pulumi.Input<pulumi.Input<string>[]>;
}

/**
 * The set of arguments for constructing a TimeWindow resource.
 */
export interface TimeWindowArgs {
    /**
     * Instance ID in the format of cdb-c1nl9rpv or cdbro-c1nl9rpv. It is the same as the instance ID displayed on the
     * TencentDB Console page.
     */
    instanceId: pulumi.Input<string>;
    /**
     * Data delay threshold. It takes effect only for source instance and disaster recovery instance. Default value: 10.
     */
    maxDelayTime?: pulumi.Input<number>;
    /**
     * Time period available for maintenance after modification in the format of 10:00-12:00. Each period lasts from half an
     * hour to three hours, with the start time and end time aligned by half-hour. Up to two time periods can be set. Start and
     * end time range: [00:00, 24:00].
     */
    timeRanges: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Specifies for which day to modify the time period. Value range: Monday, Tuesday, Wednesday, Thursday, Friday, Saturday,
     * Sunday. If it is not specified or is left blank, the time period will be modified for every day by default.
     */
    weekdays?: pulumi.Input<pulumi.Input<string>[]>;
}