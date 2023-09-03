// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

export function getTagRetentionExecutions(args: GetTagRetentionExecutionsArgs, opts?: pulumi.InvokeOptions): Promise<GetTagRetentionExecutionsResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Tcr/getTagRetentionExecutions:getTagRetentionExecutions", {
        "registryId": args.registryId,
        "resultOutputFile": args.resultOutputFile,
        "retentionId": args.retentionId,
    }, opts);
}

/**
 * A collection of arguments for invoking getTagRetentionExecutions.
 */
export interface GetTagRetentionExecutionsArgs {
    registryId: string;
    resultOutputFile?: string;
    retentionId: number;
}

/**
 * A collection of values returned by getTagRetentionExecutions.
 */
export interface GetTagRetentionExecutionsResult {
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly registryId: string;
    readonly resultOutputFile?: string;
    readonly retentionExecutionLists: outputs.Tcr.GetTagRetentionExecutionsRetentionExecutionList[];
    readonly retentionId: number;
}
export function getTagRetentionExecutionsOutput(args: GetTagRetentionExecutionsOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetTagRetentionExecutionsResult> {
    return pulumi.output(args).apply((a: any) => getTagRetentionExecutions(a, opts))
}

/**
 * A collection of arguments for invoking getTagRetentionExecutions.
 */
export interface GetTagRetentionExecutionsOutputArgs {
    registryId: pulumi.Input<string>;
    resultOutputFile?: pulumi.Input<string>;
    retentionId: pulumi.Input<number>;
}