// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

export function getNats(args?: GetNatsArgs, opts?: pulumi.InvokeOptions): Promise<GetNatsResult> {
    args = args || {};

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Deprecatednats/getNats:getNats", {
        "bandwidth": args.bandwidth,
        "id": args.id,
        "maxConcurrent": args.maxConcurrent,
        "name": args.name,
        "state": args.state,
        "vpcId": args.vpcId,
    }, opts);
}

/**
 * A collection of arguments for invoking getNats.
 */
export interface GetNatsArgs {
    bandwidth?: number;
    id?: string;
    maxConcurrent?: number;
    name?: string;
    state?: number;
    vpcId?: string;
}

/**
 * A collection of values returned by getNats.
 */
export interface GetNatsResult {
    readonly bandwidth?: number;
    readonly id?: string;
    readonly maxConcurrent?: number;
    readonly name?: string;
    readonly nats: outputs.Deprecatednats.GetNatsNat[];
    readonly state?: number;
    readonly vpcId?: string;
}
export function getNatsOutput(args?: GetNatsOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetNatsResult> {
    return pulumi.output(args).apply((a: any) => getNats(a, opts))
}

/**
 * A collection of arguments for invoking getNats.
 */
export interface GetNatsOutputArgs {
    bandwidth?: pulumi.Input<number>;
    id?: pulumi.Input<string>;
    maxConcurrent?: pulumi.Input<number>;
    name?: pulumi.Input<string>;
    state?: pulumi.Input<number>;
    vpcId?: pulumi.Input<string>;
}