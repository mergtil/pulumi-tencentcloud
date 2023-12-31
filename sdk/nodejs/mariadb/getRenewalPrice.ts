// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

export function getRenewalPrice(args: GetRenewalPriceArgs, opts?: pulumi.InvokeOptions): Promise<GetRenewalPriceResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Mariadb/getRenewalPrice:getRenewalPrice", {
        "amountUnit": args.amountUnit,
        "instanceId": args.instanceId,
        "period": args.period,
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getRenewalPrice.
 */
export interface GetRenewalPriceArgs {
    amountUnit?: string;
    instanceId: string;
    period?: number;
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getRenewalPrice.
 */
export interface GetRenewalPriceResult {
    readonly amountUnit?: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly instanceId: string;
    readonly originalPrice: number;
    readonly period?: number;
    readonly price: number;
    readonly resultOutputFile?: string;
}
export function getRenewalPriceOutput(args: GetRenewalPriceOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetRenewalPriceResult> {
    return pulumi.output(args).apply((a: any) => getRenewalPrice(a, opts))
}

/**
 * A collection of arguments for invoking getRenewalPrice.
 */
export interface GetRenewalPriceOutputArgs {
    amountUnit?: pulumi.Input<string>;
    instanceId: pulumi.Input<string>;
    period?: pulumi.Input<number>;
    resultOutputFile?: pulumi.Input<string>;
}
