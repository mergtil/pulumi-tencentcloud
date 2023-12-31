// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

export function getHttpDomains(args: GetHttpDomainsArgs, opts?: pulumi.InvokeOptions): Promise<GetHttpDomainsResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Gaap/getHttpDomains:getHttpDomains", {
        "domain": args.domain,
        "listenerId": args.listenerId,
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getHttpDomains.
 */
export interface GetHttpDomainsArgs {
    domain: string;
    listenerId: string;
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getHttpDomains.
 */
export interface GetHttpDomainsResult {
    readonly domain: string;
    readonly domains: outputs.Gaap.GetHttpDomainsDomain[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly listenerId: string;
    readonly resultOutputFile?: string;
}
export function getHttpDomainsOutput(args: GetHttpDomainsOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetHttpDomainsResult> {
    return pulumi.output(args).apply((a: any) => getHttpDomains(a, opts))
}

/**
 * A collection of arguments for invoking getHttpDomains.
 */
export interface GetHttpDomainsOutputArgs {
    domain: pulumi.Input<string>;
    listenerId: pulumi.Input<string>;
    resultOutputFile?: pulumi.Input<string>;
}
