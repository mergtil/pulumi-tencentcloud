// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

export function getBundle(args?: GetBundleArgs, opts?: pulumi.InvokeOptions): Promise<GetBundleResult> {
    args = args || {};

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Lighthouse/getBundle:getBundle", {
        "bundleIds": args.bundleIds,
        "filters": args.filters,
        "limit": args.limit,
        "offset": args.offset,
        "resultOutputFile": args.resultOutputFile,
        "zones": args.zones,
    }, opts);
}

/**
 * A collection of arguments for invoking getBundle.
 */
export interface GetBundleArgs {
    bundleIds?: string[];
    filters?: inputs.Lighthouse.GetBundleFilter[];
    limit?: number;
    offset?: number;
    resultOutputFile?: string;
    zones?: string[];
}

/**
 * A collection of values returned by getBundle.
 */
export interface GetBundleResult {
    readonly bundleIds?: string[];
    readonly bundleSets: outputs.Lighthouse.GetBundleBundleSet[];
    readonly filters?: outputs.Lighthouse.GetBundleFilter[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly limit?: number;
    readonly offset?: number;
    readonly resultOutputFile?: string;
    readonly zones?: string[];
}
export function getBundleOutput(args?: GetBundleOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetBundleResult> {
    return pulumi.output(args).apply((a: any) => getBundle(a, opts))
}

/**
 * A collection of arguments for invoking getBundle.
 */
export interface GetBundleOutputArgs {
    bundleIds?: pulumi.Input<pulumi.Input<string>[]>;
    filters?: pulumi.Input<pulumi.Input<inputs.Lighthouse.GetBundleFilterArgs>[]>;
    limit?: pulumi.Input<number>;
    offset?: pulumi.Input<number>;
    resultOutputFile?: pulumi.Input<string>;
    zones?: pulumi.Input<pulumi.Input<string>[]>;
}
