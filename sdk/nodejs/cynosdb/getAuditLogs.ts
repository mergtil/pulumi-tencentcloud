// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

export function getAuditLogs(args: GetAuditLogsArgs, opts?: pulumi.InvokeOptions): Promise<GetAuditLogsResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Cynosdb/getAuditLogs:getAuditLogs", {
        "endTime": args.endTime,
        "filter": args.filter,
        "instanceId": args.instanceId,
        "order": args.order,
        "orderBy": args.orderBy,
        "resultOutputFile": args.resultOutputFile,
        "startTime": args.startTime,
    }, opts);
}

/**
 * A collection of arguments for invoking getAuditLogs.
 */
export interface GetAuditLogsArgs {
    endTime: string;
    filter?: inputs.Cynosdb.GetAuditLogsFilter;
    instanceId: string;
    order?: string;
    orderBy?: string;
    resultOutputFile?: string;
    startTime: string;
}

/**
 * A collection of values returned by getAuditLogs.
 */
export interface GetAuditLogsResult {
    readonly endTime: string;
    readonly filter?: outputs.Cynosdb.GetAuditLogsFilter;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly instanceId: string;
    readonly items: outputs.Cynosdb.GetAuditLogsItem[];
    readonly order?: string;
    readonly orderBy?: string;
    readonly resultOutputFile?: string;
    readonly startTime: string;
}
export function getAuditLogsOutput(args: GetAuditLogsOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetAuditLogsResult> {
    return pulumi.output(args).apply((a: any) => getAuditLogs(a, opts))
}

/**
 * A collection of arguments for invoking getAuditLogs.
 */
export interface GetAuditLogsOutputArgs {
    endTime: pulumi.Input<string>;
    filter?: pulumi.Input<inputs.Cynosdb.GetAuditLogsFilterArgs>;
    instanceId: pulumi.Input<string>;
    order?: pulumi.Input<string>;
    orderBy?: pulumi.Input<string>;
    resultOutputFile?: pulumi.Input<string>;
    startTime: pulumi.Input<string>;
}