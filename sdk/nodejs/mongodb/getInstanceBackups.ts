// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

export function getInstanceBackups(args: GetInstanceBackupsArgs, opts?: pulumi.InvokeOptions): Promise<GetInstanceBackupsResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Mongodb/getInstanceBackups:getInstanceBackups", {
        "backupMethod": args.backupMethod,
        "instanceId": args.instanceId,
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getInstanceBackups.
 */
export interface GetInstanceBackupsArgs {
    backupMethod?: number;
    instanceId: string;
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getInstanceBackups.
 */
export interface GetInstanceBackupsResult {
    readonly backupLists: outputs.Mongodb.GetInstanceBackupsBackupList[];
    readonly backupMethod?: number;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly instanceId: string;
    readonly resultOutputFile?: string;
}
export function getInstanceBackupsOutput(args: GetInstanceBackupsOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetInstanceBackupsResult> {
    return pulumi.output(args).apply((a: any) => getInstanceBackups(a, opts))
}

/**
 * A collection of arguments for invoking getInstanceBackups.
 */
export interface GetInstanceBackupsOutputArgs {
    backupMethod?: pulumi.Input<number>;
    instanceId: pulumi.Input<string>;
    resultOutputFile?: pulumi.Input<string>;
}
