// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

export function getSwitchRecord(args: GetSwitchRecordArgs, opts?: pulumi.InvokeOptions): Promise<GetSwitchRecordResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Mysql/getSwitchRecord:getSwitchRecord", {
        "instanceId": args.instanceId,
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getSwitchRecord.
 */
export interface GetSwitchRecordArgs {
    instanceId: string;
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getSwitchRecord.
 */
export interface GetSwitchRecordResult {
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly instanceId: string;
    readonly items: outputs.Mysql.GetSwitchRecordItem[];
    readonly resultOutputFile?: string;
}
export function getSwitchRecordOutput(args: GetSwitchRecordOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetSwitchRecordResult> {
    return pulumi.output(args).apply((a: any) => getSwitchRecord(a, opts))
}

/**
 * A collection of arguments for invoking getSwitchRecord.
 */
export interface GetSwitchRecordOutputArgs {
    instanceId: pulumi.Input<string>;
    resultOutputFile?: pulumi.Input<string>;
}
