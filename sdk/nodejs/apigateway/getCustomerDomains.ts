// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

export function getCustomerDomains(args: GetCustomerDomainsArgs, opts?: pulumi.InvokeOptions): Promise<GetCustomerDomainsResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:ApiGateway/getCustomerDomains:getCustomerDomains", {
        "resultOutputFile": args.resultOutputFile,
        "serviceId": args.serviceId,
    }, opts);
}

/**
 * A collection of arguments for invoking getCustomerDomains.
 */
export interface GetCustomerDomainsArgs {
    resultOutputFile?: string;
    serviceId: string;
}

/**
 * A collection of values returned by getCustomerDomains.
 */
export interface GetCustomerDomainsResult {
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly lists: outputs.ApiGateway.GetCustomerDomainsList[];
    readonly resultOutputFile?: string;
    readonly serviceId: string;
}
export function getCustomerDomainsOutput(args: GetCustomerDomainsOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetCustomerDomainsResult> {
    return pulumi.output(args).apply((a: any) => getCustomerDomains(a, opts))
}

/**
 * A collection of arguments for invoking getCustomerDomains.
 */
export interface GetCustomerDomainsOutputArgs {
    resultOutputFile?: pulumi.Input<string>;
    serviceId: pulumi.Input<string>;
}