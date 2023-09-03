// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

export function getSamlProviders(args?: GetSamlProvidersArgs, opts?: pulumi.InvokeOptions): Promise<GetSamlProvidersResult> {
    args = args || {};

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Cam/getSamlProviders:getSamlProviders", {
        "description": args.description,
        "name": args.name,
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getSamlProviders.
 */
export interface GetSamlProvidersArgs {
    description?: string;
    name?: string;
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getSamlProviders.
 */
export interface GetSamlProvidersResult {
    readonly description?: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly name?: string;
    readonly providerLists: outputs.Cam.GetSamlProvidersProviderList[];
    readonly resultOutputFile?: string;
}
export function getSamlProvidersOutput(args?: GetSamlProvidersOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetSamlProvidersResult> {
    return pulumi.output(args).apply((a: any) => getSamlProviders(a, opts))
}

/**
 * A collection of arguments for invoking getSamlProviders.
 */
export interface GetSamlProvidersOutputArgs {
    description?: pulumi.Input<string>;
    name?: pulumi.Input<string>;
    resultOutputFile?: pulumi.Input<string>;
}