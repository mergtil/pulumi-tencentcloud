// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

export function getLastActivity(args: GetLastActivityArgs, opts?: pulumi.InvokeOptions): Promise<GetLastActivityResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:As/getLastActivity:getLastActivity", {
        "autoScalingGroupIds": args.autoScalingGroupIds,
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getLastActivity.
 */
export interface GetLastActivityArgs {
    autoScalingGroupIds: string[];
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getLastActivity.
 */
export interface GetLastActivityResult {
    readonly activitySets: outputs.As.GetLastActivityActivitySet[];
    readonly autoScalingGroupIds: string[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly resultOutputFile?: string;
}
export function getLastActivityOutput(args: GetLastActivityOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetLastActivityResult> {
    return pulumi.output(args).apply((a: any) => getLastActivity(a, opts))
}

/**
 * A collection of arguments for invoking getLastActivity.
 */
export interface GetLastActivityOutputArgs {
    autoScalingGroupIds: pulumi.Input<pulumi.Input<string>[]>;
    resultOutputFile?: pulumi.Input<string>;
}
