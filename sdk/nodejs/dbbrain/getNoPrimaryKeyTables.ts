// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

export function getNoPrimaryKeyTables(args: GetNoPrimaryKeyTablesArgs, opts?: pulumi.InvokeOptions): Promise<GetNoPrimaryKeyTablesResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Dbbrain/getNoPrimaryKeyTables:getNoPrimaryKeyTables", {
        "date": args.date,
        "instanceId": args.instanceId,
        "product": args.product,
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getNoPrimaryKeyTables.
 */
export interface GetNoPrimaryKeyTablesArgs {
    date: string;
    instanceId: string;
    product?: string;
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getNoPrimaryKeyTables.
 */
export interface GetNoPrimaryKeyTablesResult {
    readonly date: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly instanceId: string;
    readonly noPrimaryKeyTableCountDiff: number;
    readonly noPrimaryKeyTables: outputs.Dbbrain.GetNoPrimaryKeyTablesNoPrimaryKeyTable[];
    readonly product?: string;
    readonly resultOutputFile?: string;
    readonly timestamp: number;
}
export function getNoPrimaryKeyTablesOutput(args: GetNoPrimaryKeyTablesOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetNoPrimaryKeyTablesResult> {
    return pulumi.output(args).apply((a: any) => getNoPrimaryKeyTables(a, opts))
}

/**
 * A collection of arguments for invoking getNoPrimaryKeyTables.
 */
export interface GetNoPrimaryKeyTablesOutputArgs {
    date: pulumi.Input<string>;
    instanceId: pulumi.Input<string>;
    product?: pulumi.Input<string>;
    resultOutputFile?: pulumi.Input<string>;
}
