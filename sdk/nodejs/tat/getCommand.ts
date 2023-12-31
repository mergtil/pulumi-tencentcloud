// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

export function getCommand(args?: GetCommandArgs, opts?: pulumi.InvokeOptions): Promise<GetCommandResult> {
    args = args || {};

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Tat/getCommand:getCommand", {
        "commandId": args.commandId,
        "commandName": args.commandName,
        "commandType": args.commandType,
        "createdBy": args.createdBy,
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getCommand.
 */
export interface GetCommandArgs {
    commandId?: string;
    commandName?: string;
    commandType?: string;
    createdBy?: string;
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getCommand.
 */
export interface GetCommandResult {
    readonly commandId?: string;
    readonly commandName?: string;
    readonly commandSets: outputs.Tat.GetCommandCommandSet[];
    readonly commandType?: string;
    readonly createdBy?: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly resultOutputFile?: string;
}
export function getCommandOutput(args?: GetCommandOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetCommandResult> {
    return pulumi.output(args).apply((a: any) => getCommand(a, opts))
}

/**
 * A collection of arguments for invoking getCommand.
 */
export interface GetCommandOutputArgs {
    commandId?: pulumi.Input<string>;
    commandName?: pulumi.Input<string>;
    commandType?: pulumi.Input<string>;
    createdBy?: pulumi.Input<string>;
    resultOutputFile?: pulumi.Input<string>;
}
