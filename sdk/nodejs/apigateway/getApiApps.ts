// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

export function getApiApps(args?: GetApiAppsArgs, opts?: pulumi.InvokeOptions): Promise<GetApiAppsResult> {
    args = args || {};

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:ApiGateway/getApiApps:getApiApps", {
        "apiAppId": args.apiAppId,
        "apiAppName": args.apiAppName,
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getApiApps.
 */
export interface GetApiAppsArgs {
    apiAppId?: string;
    apiAppName?: string;
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getApiApps.
 */
export interface GetApiAppsResult {
    readonly apiAppId?: string;
    readonly apiAppLists: outputs.ApiGateway.GetApiAppsApiAppList[];
    readonly apiAppName?: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly resultOutputFile?: string;
}
export function getApiAppsOutput(args?: GetApiAppsOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetApiAppsResult> {
    return pulumi.output(args).apply((a: any) => getApiApps(a, opts))
}

/**
 * A collection of arguments for invoking getApiApps.
 */
export interface GetApiAppsOutputArgs {
    apiAppId?: pulumi.Input<string>;
    apiAppName?: pulumi.Input<string>;
    resultOutputFile?: pulumi.Input<string>;
}
