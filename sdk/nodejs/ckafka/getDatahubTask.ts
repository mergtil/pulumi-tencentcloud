// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

export function getDatahubTask(args?: GetDatahubTaskArgs, opts?: pulumi.InvokeOptions): Promise<GetDatahubTaskResult> {
    args = args || {};

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Ckafka/getDatahubTask:getDatahubTask", {
        "resource": args.resource,
        "resultOutputFile": args.resultOutputFile,
        "searchWord": args.searchWord,
        "sourceType": args.sourceType,
        "targetType": args.targetType,
        "taskType": args.taskType,
    }, opts);
}

/**
 * A collection of arguments for invoking getDatahubTask.
 */
export interface GetDatahubTaskArgs {
    resource?: string;
    resultOutputFile?: string;
    searchWord?: string;
    sourceType?: string;
    targetType?: string;
    taskType?: string;
}

/**
 * A collection of values returned by getDatahubTask.
 */
export interface GetDatahubTaskResult {
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly resource?: string;
    readonly resultOutputFile?: string;
    readonly searchWord?: string;
    readonly sourceType?: string;
    readonly targetType?: string;
    readonly taskLists: outputs.Ckafka.GetDatahubTaskTaskList[];
    readonly taskType?: string;
}
export function getDatahubTaskOutput(args?: GetDatahubTaskOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetDatahubTaskResult> {
    return pulumi.output(args).apply((a: any) => getDatahubTask(a, opts))
}

/**
 * A collection of arguments for invoking getDatahubTask.
 */
export interface GetDatahubTaskOutputArgs {
    resource?: pulumi.Input<string>;
    resultOutputFile?: pulumi.Input<string>;
    searchWord?: pulumi.Input<string>;
    sourceType?: pulumi.Input<string>;
    targetType?: pulumi.Input<string>;
    taskType?: pulumi.Input<string>;
}
