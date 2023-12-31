// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

export function getDbInstanceClasses(args: GetDbInstanceClassesArgs, opts?: pulumi.InvokeOptions): Promise<GetDbInstanceClassesResult> {

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Postgresql/getDbInstanceClasses:getDbInstanceClasses", {
        "dbEngine": args.dbEngine,
        "dbMajorVersion": args.dbMajorVersion,
        "resultOutputFile": args.resultOutputFile,
        "zone": args.zone,
    }, opts);
}

/**
 * A collection of arguments for invoking getDbInstanceClasses.
 */
export interface GetDbInstanceClassesArgs {
    dbEngine: string;
    dbMajorVersion: string;
    resultOutputFile?: string;
    zone: string;
}

/**
 * A collection of values returned by getDbInstanceClasses.
 */
export interface GetDbInstanceClassesResult {
    readonly classInfoSets: outputs.Postgresql.GetDbInstanceClassesClassInfoSet[];
    readonly dbEngine: string;
    readonly dbMajorVersion: string;
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly resultOutputFile?: string;
    readonly zone: string;
}
export function getDbInstanceClassesOutput(args: GetDbInstanceClassesOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetDbInstanceClassesResult> {
    return pulumi.output(args).apply((a: any) => getDbInstanceClasses(a, opts))
}

/**
 * A collection of arguments for invoking getDbInstanceClasses.
 */
export interface GetDbInstanceClassesOutputArgs {
    dbEngine: pulumi.Input<string>;
    dbMajorVersion: pulumi.Input<string>;
    resultOutputFile?: pulumi.Input<string>;
    zone: pulumi.Input<string>;
}
