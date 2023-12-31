// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

export function getClusterResources(args?: GetClusterResourcesArgs, opts?: pulumi.InvokeOptions): Promise<GetClusterResourcesResult> {
    args = args || {};

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Clb/getClusterResources:getClusterResources", {
        "filters": args.filters,
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getClusterResources.
 */
export interface GetClusterResourcesArgs {
    filters?: inputs.Clb.GetClusterResourcesFilter[];
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getClusterResources.
 */
export interface GetClusterResourcesResult {
    readonly clusterResourceSets: outputs.Clb.GetClusterResourcesClusterResourceSet[];
    readonly filters?: outputs.Clb.GetClusterResourcesFilter[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly resultOutputFile?: string;
}
export function getClusterResourcesOutput(args?: GetClusterResourcesOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetClusterResourcesResult> {
    return pulumi.output(args).apply((a: any) => getClusterResources(a, opts))
}

/**
 * A collection of arguments for invoking getClusterResources.
 */
export interface GetClusterResourcesOutputArgs {
    filters?: pulumi.Input<pulumi.Input<inputs.Clb.GetClusterResourcesFilterArgs>[]>;
    resultOutputFile?: pulumi.Input<string>;
}
