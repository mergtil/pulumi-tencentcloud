// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

export function getCosRegions(args?: GetCosRegionsArgs, opts?: pulumi.InvokeOptions): Promise<GetCosRegionsResult> {
    args = args || {};

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Audit/getCosRegions:getCosRegions", {
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getCosRegions.
 */
export interface GetCosRegionsArgs {
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getCosRegions.
 */
export interface GetCosRegionsResult {
    readonly auditCosRegionLists: outputs.Audit.GetCosRegionsAuditCosRegionList[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly resultOutputFile?: string;
}
export function getCosRegionsOutput(args?: GetCosRegionsOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetCosRegionsResult> {
    return pulumi.output(args).apply((a: any) => getCosRegions(a, opts))
}

/**
 * A collection of arguments for invoking getCosRegions.
 */
export interface GetCosRegionsOutputArgs {
    resultOutputFile?: pulumi.Input<string>;
}
