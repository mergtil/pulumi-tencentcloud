// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

export function getLayerVersions(args: GetLayerVersionsArgs, opts?: pulumi.InvokeOptions): Promise<GetLayerVersionsResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Scf/getLayerVersions:getLayerVersions", {
        "compatibleRuntimes": args.compatibleRuntimes,
        "layerName": args.layerName,
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getLayerVersions.
 */
export interface GetLayerVersionsArgs {
    compatibleRuntimes?: string[];
    layerName: string;
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getLayerVersions.
 */
export interface GetLayerVersionsResult {
    readonly compatibleRuntimes?: string[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly layerName: string;
    readonly layerVersions: outputs.Scf.GetLayerVersionsLayerVersion[];
    readonly resultOutputFile?: string;
}
export function getLayerVersionsOutput(args: GetLayerVersionsOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetLayerVersionsResult> {
    return pulumi.output(args).apply((a: any) => getLayerVersions(a, opts))
}

/**
 * A collection of arguments for invoking getLayerVersions.
 */
export interface GetLayerVersionsOutputArgs {
    compatibleRuntimes?: pulumi.Input<pulumi.Input<string>[]>;
    layerName: pulumi.Input<string>;
    resultOutputFile?: pulumi.Input<string>;
}
