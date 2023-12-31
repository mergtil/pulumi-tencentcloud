// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

export function getAccessAddress(args: GetAccessAddressArgs, opts?: pulumi.InvokeOptions): Promise<GetAccessAddressResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Tse/getAccessAddress:getAccessAddress", {
        "engineRegion": args.engineRegion,
        "instanceId": args.instanceId,
        "resultOutputFile": args.resultOutputFile,
        "subnetId": args.subnetId,
        "vpcId": args.vpcId,
        "workload": args.workload,
    }, opts);
}

/**
 * A collection of arguments for invoking getAccessAddress.
 */
export interface GetAccessAddressArgs {
    engineRegion?: string;
    instanceId: string;
    resultOutputFile?: string;
    subnetId?: string;
    vpcId?: string;
    workload?: string;
}

/**
 * A collection of values returned by getAccessAddress.
 */
export interface GetAccessAddressResult {
    readonly consoleInternetAddress: string;
    readonly consoleInternetBandWidth: number;
    readonly consoleIntranetAddress: string;
    readonly engineRegion?: string;
    readonly envAddressInfos: outputs.Tse.GetAccessAddressEnvAddressInfo[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly instanceId: string;
    readonly internetAddress: string;
    readonly internetBandWidth: number;
    readonly intranetAddress: string;
    readonly limiterAddressInfos: outputs.Tse.GetAccessAddressLimiterAddressInfo[];
    readonly resultOutputFile?: string;
    readonly subnetId?: string;
    readonly vpcId?: string;
    readonly workload?: string;
}
export function getAccessAddressOutput(args: GetAccessAddressOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetAccessAddressResult> {
    return pulumi.output(args).apply((a: any) => getAccessAddress(a, opts))
}

/**
 * A collection of arguments for invoking getAccessAddress.
 */
export interface GetAccessAddressOutputArgs {
    engineRegion?: pulumi.Input<string>;
    instanceId: pulumi.Input<string>;
    resultOutputFile?: pulumi.Input<string>;
    subnetId?: pulumi.Input<string>;
    vpcId?: pulumi.Input<string>;
    workload?: pulumi.Input<string>;
}
