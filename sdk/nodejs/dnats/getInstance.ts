// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

export function getInstance(args?: GetInstanceArgs, opts?: pulumi.InvokeOptions): Promise<GetInstanceResult> {
    args = args || {};

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Dnats/getInstance:getInstance", {
        "description": args.description,
        "elasticIp": args.elasticIp,
        "elasticPort": args.elasticPort,
        "natId": args.natId,
        "privateIp": args.privateIp,
        "privatePort": args.privatePort,
        "resultOutputFile": args.resultOutputFile,
        "vpcId": args.vpcId,
    }, opts);
}

/**
 * A collection of arguments for invoking getInstance.
 */
export interface GetInstanceArgs {
    description?: string;
    elasticIp?: string;
    elasticPort?: string;
    natId?: string;
    privateIp?: string;
    privatePort?: string;
    resultOutputFile?: string;
    vpcId?: string;
}

/**
 * A collection of values returned by getInstance.
 */
export interface GetInstanceResult {
    readonly description?: string;
    readonly dnatLists: outputs.Dnats.GetInstanceDnatList[];
    readonly elasticIp?: string;
    readonly elasticPort?: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly natId?: string;
    readonly privateIp?: string;
    readonly privatePort?: string;
    readonly resultOutputFile?: string;
    readonly vpcId?: string;
}
export function getInstanceOutput(args?: GetInstanceOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetInstanceResult> {
    return pulumi.output(args).apply((a: any) => getInstance(a, opts))
}

/**
 * A collection of arguments for invoking getInstance.
 */
export interface GetInstanceOutputArgs {
    description?: pulumi.Input<string>;
    elasticIp?: pulumi.Input<string>;
    elasticPort?: pulumi.Input<string>;
    natId?: pulumi.Input<string>;
    privateIp?: pulumi.Input<string>;
    privatePort?: pulumi.Input<string>;
    resultOutputFile?: pulumi.Input<string>;
    vpcId?: pulumi.Input<string>;
}