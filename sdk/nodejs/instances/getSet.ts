// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

export function getSet(args?: GetSetArgs, opts?: pulumi.InvokeOptions): Promise<GetSetResult> {
    args = args || {};

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Instances/getSet:getSet", {
        "availabilityZone": args.availabilityZone,
        "instanceId": args.instanceId,
        "instanceName": args.instanceName,
        "projectId": args.projectId,
        "resultOutputFile": args.resultOutputFile,
        "subnetId": args.subnetId,
        "tags": args.tags,
        "vpcId": args.vpcId,
    }, opts);
}

/**
 * A collection of arguments for invoking getSet.
 */
export interface GetSetArgs {
    availabilityZone?: string;
    instanceId?: string;
    instanceName?: string;
    projectId?: number;
    resultOutputFile?: string;
    subnetId?: string;
    tags?: {[key: string]: any};
    vpcId?: string;
}

/**
 * A collection of values returned by getSet.
 */
export interface GetSetResult {
    readonly availabilityZone?: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly instanceId?: string;
    readonly instanceLists: outputs.Instances.GetSetInstanceList[];
    readonly instanceName?: string;
    readonly projectId?: number;
    readonly resultOutputFile?: string;
    readonly subnetId?: string;
    readonly tags?: {[key: string]: any};
    readonly vpcId?: string;
}
export function getSetOutput(args?: GetSetOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetSetResult> {
    return pulumi.output(args).apply((a: any) => getSet(a, opts))
}

/**
 * A collection of arguments for invoking getSet.
 */
export interface GetSetOutputArgs {
    availabilityZone?: pulumi.Input<string>;
    instanceId?: pulumi.Input<string>;
    instanceName?: pulumi.Input<string>;
    projectId?: pulumi.Input<number>;
    resultOutputFile?: pulumi.Input<string>;
    subnetId?: pulumi.Input<string>;
    tags?: pulumi.Input<{[key: string]: any}>;
    vpcId?: pulumi.Input<string>;
}
