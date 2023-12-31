// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

export function getScalingGroups(args?: GetScalingGroupsArgs, opts?: pulumi.InvokeOptions): Promise<GetScalingGroupsResult> {
    args = args || {};

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:As/getScalingGroups:getScalingGroups", {
        "configurationId": args.configurationId,
        "resultOutputFile": args.resultOutputFile,
        "scalingGroupId": args.scalingGroupId,
        "scalingGroupName": args.scalingGroupName,
        "tags": args.tags,
    }, opts);
}

/**
 * A collection of arguments for invoking getScalingGroups.
 */
export interface GetScalingGroupsArgs {
    configurationId?: string;
    resultOutputFile?: string;
    scalingGroupId?: string;
    scalingGroupName?: string;
    tags?: {[key: string]: any};
}

/**
 * A collection of values returned by getScalingGroups.
 */
export interface GetScalingGroupsResult {
    readonly configurationId?: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly resultOutputFile?: string;
    readonly scalingGroupId?: string;
    readonly scalingGroupLists: outputs.As.GetScalingGroupsScalingGroupList[];
    readonly scalingGroupName?: string;
    readonly tags?: {[key: string]: any};
}
export function getScalingGroupsOutput(args?: GetScalingGroupsOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetScalingGroupsResult> {
    return pulumi.output(args).apply((a: any) => getScalingGroups(a, opts))
}

/**
 * A collection of arguments for invoking getScalingGroups.
 */
export interface GetScalingGroupsOutputArgs {
    configurationId?: pulumi.Input<string>;
    resultOutputFile?: pulumi.Input<string>;
    scalingGroupId?: pulumi.Input<string>;
    scalingGroupName?: pulumi.Input<string>;
    tags?: pulumi.Input<{[key: string]: any}>;
}
