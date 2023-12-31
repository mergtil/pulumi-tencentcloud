// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

export function getTokens(args: GetTokensArgs, opts?: pulumi.InvokeOptions): Promise<GetTokensResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Tcr/getTokens:getTokens", {
        "instanceId": args.instanceId,
        "resultOutputFile": args.resultOutputFile,
        "tokenId": args.tokenId,
    }, opts);
}

/**
 * A collection of arguments for invoking getTokens.
 */
export interface GetTokensArgs {
    instanceId: string;
    resultOutputFile?: string;
    tokenId?: string;
}

/**
 * A collection of values returned by getTokens.
 */
export interface GetTokensResult {
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly instanceId: string;
    readonly resultOutputFile?: string;
    readonly tokenId?: string;
    readonly tokenLists: outputs.Tcr.GetTokensTokenList[];
}
export function getTokensOutput(args: GetTokensOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetTokensResult> {
    return pulumi.output(args).apply((a: any) => getTokens(a, opts))
}

/**
 * A collection of arguments for invoking getTokens.
 */
export interface GetTokensOutputArgs {
    instanceId: pulumi.Input<string>;
    resultOutputFile?: pulumi.Input<string>;
    tokenId?: pulumi.Input<string>;
}
