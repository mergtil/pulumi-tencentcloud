// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

export function getLogFiles(args: GetLogFilesArgs, opts?: pulumi.InvokeOptions): Promise<GetLogFilesResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Dcdb/getLogFiles:getLogFiles", {
        "instanceId": args.instanceId,
        "resultOutputFile": args.resultOutputFile,
        "shardId": args.shardId,
        "type": args.type,
    }, opts);
}

/**
 * A collection of arguments for invoking getLogFiles.
 */
export interface GetLogFilesArgs {
    instanceId: string;
    resultOutputFile?: string;
    shardId: string;
    type: number;
}

/**
 * A collection of values returned by getLogFiles.
 */
export interface GetLogFilesResult {
    readonly files: outputs.Dcdb.GetLogFilesFile[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly instanceId: string;
    readonly normalPrefix: string;
    readonly resultOutputFile?: string;
    readonly shardId: string;
    readonly type: number;
    readonly vpcPrefix: string;
}
export function getLogFilesOutput(args: GetLogFilesOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetLogFilesResult> {
    return pulumi.output(args).apply((a: any) => getLogFiles(a, opts))
}

/**
 * A collection of arguments for invoking getLogFiles.
 */
export interface GetLogFilesOutputArgs {
    instanceId: pulumi.Input<string>;
    resultOutputFile?: pulumi.Input<string>;
    shardId: pulumi.Input<string>;
    type: pulumi.Input<number>;
}