// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

export function getSpecinfos(args: GetSpecinfosArgs, opts?: pulumi.InvokeOptions): Promise<GetSpecinfosResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Postgresql/getSpecinfos:getSpecinfos", {
        "availabilityZone": args.availabilityZone,
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getSpecinfos.
 */
export interface GetSpecinfosArgs {
    availabilityZone: string;
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getSpecinfos.
 */
export interface GetSpecinfosResult {
    readonly availabilityZone: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly lists: outputs.Postgresql.GetSpecinfosList[];
    readonly resultOutputFile?: string;
}
export function getSpecinfosOutput(args: GetSpecinfosOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetSpecinfosResult> {
    return pulumi.output(args).apply((a: any) => getSpecinfos(a, opts))
}

/**
 * A collection of arguments for invoking getSpecinfos.
 */
export interface GetSpecinfosOutputArgs {
    availabilityZone: pulumi.Input<string>;
    resultOutputFile?: pulumi.Input<string>;
}