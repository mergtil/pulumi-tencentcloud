// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

export function getBinlogDownloadUrl(args: GetBinlogDownloadUrlArgs, opts?: pulumi.InvokeOptions): Promise<GetBinlogDownloadUrlResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Cynosdb/getBinlogDownloadUrl:getBinlogDownloadUrl", {
        "binlogId": args.binlogId,
        "clusterId": args.clusterId,
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getBinlogDownloadUrl.
 */
export interface GetBinlogDownloadUrlArgs {
    binlogId: number;
    clusterId: string;
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getBinlogDownloadUrl.
 */
export interface GetBinlogDownloadUrlResult {
    readonly binlogId: number;
    readonly clusterId: string;
    readonly downloadUrl: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly resultOutputFile?: string;
}
export function getBinlogDownloadUrlOutput(args: GetBinlogDownloadUrlOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetBinlogDownloadUrlResult> {
    return pulumi.output(args).apply((a: any) => getBinlogDownloadUrl(a, opts))
}

/**
 * A collection of arguments for invoking getBinlogDownloadUrl.
 */
export interface GetBinlogDownloadUrlOutputArgs {
    binlogId: pulumi.Input<number>;
    clusterId: pulumi.Input<string>;
    resultOutputFile?: pulumi.Input<string>;
}
