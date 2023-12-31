// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

export function getContainerGroup(args?: GetContainerGroupArgs, opts?: pulumi.InvokeOptions): Promise<GetContainerGroupResult> {
    args = args || {};

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Tsf/getContainerGroup:getContainerGroup", {
        "applicationId": args.applicationId,
        "clusterId": args.clusterId,
        "namespaceId": args.namespaceId,
        "orderBy": args.orderBy,
        "orderType": args.orderType,
        "resultOutputFile": args.resultOutputFile,
        "searchWord": args.searchWord,
    }, opts);
}

/**
 * A collection of arguments for invoking getContainerGroup.
 */
export interface GetContainerGroupArgs {
    applicationId?: string;
    clusterId?: string;
    namespaceId?: string;
    orderBy?: string;
    orderType?: number;
    resultOutputFile?: string;
    searchWord?: string;
}

/**
 * A collection of values returned by getContainerGroup.
 */
export interface GetContainerGroupResult {
    readonly applicationId?: string;
    readonly clusterId?: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly namespaceId?: string;
    readonly orderBy?: string;
    readonly orderType?: number;
    readonly resultOutputFile?: string;
    readonly results: outputs.Tsf.GetContainerGroupResult[];
    readonly searchWord?: string;
}
export function getContainerGroupOutput(args?: GetContainerGroupOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetContainerGroupResult> {
    return pulumi.output(args).apply((a: any) => getContainerGroup(a, opts))
}

/**
 * A collection of arguments for invoking getContainerGroup.
 */
export interface GetContainerGroupOutputArgs {
    applicationId?: pulumi.Input<string>;
    clusterId?: pulumi.Input<string>;
    namespaceId?: pulumi.Input<string>;
    orderBy?: pulumi.Input<string>;
    orderType?: pulumi.Input<number>;
    resultOutputFile?: pulumi.Input<string>;
    searchWord?: pulumi.Input<string>;
}
