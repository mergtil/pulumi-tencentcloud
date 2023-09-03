// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

export function getRoMinScale(args?: GetRoMinScaleArgs, opts?: pulumi.InvokeOptions): Promise<GetRoMinScaleResult> {
    args = args || {};

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Mysql/getRoMinScale:getRoMinScale", {
        "masterInstanceId": args.masterInstanceId,
        "resultOutputFile": args.resultOutputFile,
        "roInstanceId": args.roInstanceId,
    }, opts);
}

/**
 * A collection of arguments for invoking getRoMinScale.
 */
export interface GetRoMinScaleArgs {
    masterInstanceId?: string;
    resultOutputFile?: string;
    roInstanceId?: string;
}

/**
 * A collection of values returned by getRoMinScale.
 */
export interface GetRoMinScaleResult {
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly masterInstanceId?: string;
    readonly memory: number;
    readonly resultOutputFile?: string;
    readonly roInstanceId?: string;
    readonly volume: number;
}
export function getRoMinScaleOutput(args?: GetRoMinScaleOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetRoMinScaleResult> {
    return pulumi.output(args).apply((a: any) => getRoMinScale(a, opts))
}

/**
 * A collection of arguments for invoking getRoMinScale.
 */
export interface GetRoMinScaleOutputArgs {
    masterInstanceId?: pulumi.Input<string>;
    resultOutputFile?: pulumi.Input<string>;
    roInstanceId?: pulumi.Input<string>;
}