// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

export function getTemplateLimits(args?: GetTemplateLimitsArgs, opts?: pulumi.InvokeOptions): Promise<GetTemplateLimitsResult> {
    args = args || {};

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Vpc/getTemplateLimits:getTemplateLimits", {
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getTemplateLimits.
 */
export interface GetTemplateLimitsArgs {
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getTemplateLimits.
 */
export interface GetTemplateLimitsResult {
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly resultOutputFile?: string;
    readonly templateLimits: outputs.Vpc.GetTemplateLimitsTemplateLimit[];
}
export function getTemplateLimitsOutput(args?: GetTemplateLimitsOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetTemplateLimitsResult> {
    return pulumi.output(args).apply((a: any) => getTemplateLimits(a, opts))
}

/**
 * A collection of arguments for invoking getTemplateLimits.
 */
export interface GetTemplateLimitsOutputArgs {
    resultOutputFile?: pulumi.Input<string>;
}