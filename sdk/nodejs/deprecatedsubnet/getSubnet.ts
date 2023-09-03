// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

export function getSubnet(args: GetSubnetArgs, opts?: pulumi.InvokeOptions): Promise<GetSubnetResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Deprecatedsubnet/getSubnet:getSubnet", {
        "subnetId": args.subnetId,
        "vpcId": args.vpcId,
    }, opts);
}

/**
 * A collection of arguments for invoking getSubnet.
 */
export interface GetSubnetArgs {
    subnetId: string;
    vpcId: string;
}

/**
 * A collection of values returned by getSubnet.
 */
export interface GetSubnetResult {
    readonly availabilityZone: string;
    readonly cidrBlock: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly name: string;
    readonly routeTableId: string;
    readonly subnetId: string;
    readonly vpcId: string;
}
export function getSubnetOutput(args: GetSubnetOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetSubnetResult> {
    return pulumi.output(args).apply((a: any) => getSubnet(a, opts))
}

/**
 * A collection of arguments for invoking getSubnet.
 */
export interface GetSubnetOutputArgs {
    subnetId: pulumi.Input<string>;
    vpcId: pulumi.Input<string>;
}