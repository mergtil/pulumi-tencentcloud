// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

export function getInstanceRebootTime(args: GetInstanceRebootTimeArgs, opts?: pulumi.InvokeOptions): Promise<GetInstanceRebootTimeResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Mysql/getInstanceRebootTime:getInstanceRebootTime", {
        "instanceIds": args.instanceIds,
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getInstanceRebootTime.
 */
export interface GetInstanceRebootTimeArgs {
    instanceIds: string[];
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getInstanceRebootTime.
 */
export interface GetInstanceRebootTimeResult {
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly instanceIds: string[];
    readonly items: outputs.Mysql.GetInstanceRebootTimeItem[];
    readonly resultOutputFile?: string;
}
export function getInstanceRebootTimeOutput(args: GetInstanceRebootTimeOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetInstanceRebootTimeResult> {
    return pulumi.output(args).apply((a: any) => getInstanceRebootTime(a, opts))
}

/**
 * A collection of arguments for invoking getInstanceRebootTime.
 */
export interface GetInstanceRebootTimeOutputArgs {
    instanceIds: pulumi.Input<pulumi.Input<string>[]>;
    resultOutputFile?: pulumi.Input<string>;
}
