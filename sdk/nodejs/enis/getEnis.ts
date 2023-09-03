// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

export function getEnis(args?: GetEnisArgs, opts?: pulumi.InvokeOptions): Promise<GetEnisResult> {
    args = args || {};

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Enis/getEnis:getEnis", {
        "description": args.description,
        "ids": args.ids,
        "instanceId": args.instanceId,
        "ipv4": args.ipv4,
        "name": args.name,
        "resultOutputFile": args.resultOutputFile,
        "securityGroup": args.securityGroup,
        "subnetId": args.subnetId,
        "tags": args.tags,
        "vpcId": args.vpcId,
    }, opts);
}

/**
 * A collection of arguments for invoking getEnis.
 */
export interface GetEnisArgs {
    description?: string;
    ids?: string[];
    instanceId?: string;
    ipv4?: string;
    name?: string;
    resultOutputFile?: string;
    securityGroup?: string;
    subnetId?: string;
    tags?: {[key: string]: any};
    vpcId?: string;
}

/**
 * A collection of values returned by getEnis.
 */
export interface GetEnisResult {
    readonly description?: string;
    readonly enis: outputs.Enis.GetEnisEni[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly ids?: string[];
    readonly instanceId?: string;
    readonly ipv4?: string;
    readonly name?: string;
    readonly resultOutputFile?: string;
    readonly securityGroup?: string;
    readonly subnetId?: string;
    readonly tags?: {[key: string]: any};
    readonly vpcId?: string;
}
export function getEnisOutput(args?: GetEnisOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetEnisResult> {
    return pulumi.output(args).apply((a: any) => getEnis(a, opts))
}

/**
 * A collection of arguments for invoking getEnis.
 */
export interface GetEnisOutputArgs {
    description?: pulumi.Input<string>;
    ids?: pulumi.Input<pulumi.Input<string>[]>;
    instanceId?: pulumi.Input<string>;
    ipv4?: pulumi.Input<string>;
    name?: pulumi.Input<string>;
    resultOutputFile?: pulumi.Input<string>;
    securityGroup?: pulumi.Input<string>;
    subnetId?: pulumi.Input<string>;
    tags?: pulumi.Input<{[key: string]: any}>;
    vpcId?: pulumi.Input<string>;
}