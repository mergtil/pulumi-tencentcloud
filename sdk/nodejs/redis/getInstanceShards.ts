// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

export function getInstanceShards(args: GetInstanceShardsArgs, opts?: pulumi.InvokeOptions): Promise<GetInstanceShardsResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Redis/getInstanceShards:getInstanceShards", {
        "filterSlave": args.filterSlave,
        "instanceId": args.instanceId,
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getInstanceShards.
 */
export interface GetInstanceShardsArgs {
    filterSlave?: boolean;
    instanceId: string;
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getInstanceShards.
 */
export interface GetInstanceShardsResult {
    readonly filterSlave?: boolean;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly instanceId: string;
    readonly instanceShards: outputs.Redis.GetInstanceShardsInstanceShard[];
    readonly resultOutputFile?: string;
}
export function getInstanceShardsOutput(args: GetInstanceShardsOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetInstanceShardsResult> {
    return pulumi.output(args).apply((a: any) => getInstanceShards(a, opts))
}

/**
 * A collection of arguments for invoking getInstanceShards.
 */
export interface GetInstanceShardsOutputArgs {
    filterSlave?: pulumi.Input<boolean>;
    instanceId: pulumi.Input<string>;
    resultOutputFile?: pulumi.Input<string>;
}
