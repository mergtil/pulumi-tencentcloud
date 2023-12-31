// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

export function getNamespaces(args: GetNamespacesArgs, opts?: pulumi.InvokeOptions): Promise<GetNamespacesResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Tcr/getNamespaces:getNamespaces", {
        "instanceId": args.instanceId,
        "namespaceName": args.namespaceName,
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getNamespaces.
 */
export interface GetNamespacesArgs {
    instanceId: string;
    namespaceName?: string;
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getNamespaces.
 */
export interface GetNamespacesResult {
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly instanceId: string;
    readonly namespaceLists: outputs.Tcr.GetNamespacesNamespaceList[];
    readonly namespaceName?: string;
    readonly resultOutputFile?: string;
}
export function getNamespacesOutput(args: GetNamespacesOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetNamespacesResult> {
    return pulumi.output(args).apply((a: any) => getNamespaces(a, opts))
}

/**
 * A collection of arguments for invoking getNamespaces.
 */
export interface GetNamespacesOutputArgs {
    instanceId: pulumi.Input<string>;
    namespaceName?: pulumi.Input<string>;
    resultOutputFile?: pulumi.Input<string>;
}
