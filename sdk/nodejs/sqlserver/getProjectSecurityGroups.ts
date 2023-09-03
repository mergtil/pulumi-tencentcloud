// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

export function getProjectSecurityGroups(args: GetProjectSecurityGroupsArgs, opts?: pulumi.InvokeOptions): Promise<GetProjectSecurityGroupsResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Sqlserver/getProjectSecurityGroups:getProjectSecurityGroups", {
        "projectId": args.projectId,
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getProjectSecurityGroups.
 */
export interface GetProjectSecurityGroupsArgs {
    projectId: number;
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getProjectSecurityGroups.
 */
export interface GetProjectSecurityGroupsResult {
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly projectId: number;
    readonly resultOutputFile?: string;
    readonly securityGroupSets: outputs.Sqlserver.GetProjectSecurityGroupsSecurityGroupSet[];
}
export function getProjectSecurityGroupsOutput(args: GetProjectSecurityGroupsOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetProjectSecurityGroupsResult> {
    return pulumi.output(args).apply((a: any) => getProjectSecurityGroups(a, opts))
}

/**
 * A collection of arguments for invoking getProjectSecurityGroups.
 */
export interface GetProjectSecurityGroupsOutputArgs {
    projectId: pulumi.Input<number>;
    resultOutputFile?: pulumi.Input<string>;
}