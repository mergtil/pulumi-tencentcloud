// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

export function getImage(args?: GetImageArgs, opts?: pulumi.InvokeOptions): Promise<GetImageResult> {
    args = args || {};

    opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts || {});
    return pulumi.runtime.invoke("tencentcloud:Image/getImage:getImage", {
        "filters": args.filters,
        "imageNameRegex": args.imageNameRegex,
        "osName": args.osName,
        "resultOutputFile": args.resultOutputFile,
    }, opts);
}

/**
 * A collection of arguments for invoking getImage.
 */
export interface GetImageArgs {
    filters?: inputs.Image.GetImageFilter[];
    imageNameRegex?: string;
    osName?: string;
    resultOutputFile?: string;
}

/**
 * A collection of values returned by getImage.
 */
export interface GetImageResult {
    readonly filters?: outputs.Image.GetImageFilter[];
    /**
     * The provider-assigned unique ID for this managed resource.
     */
    readonly id: string;
    readonly imageId: string;
    readonly imageName: string;
    readonly imageNameRegex?: string;
    readonly osName?: string;
    readonly resultOutputFile?: string;
}
export function getImageOutput(args?: GetImageOutputArgs, opts?: pulumi.InvokeOptions): pulumi.Output<GetImageResult> {
    return pulumi.output(args).apply((a: any) => getImage(a, opts))
}

/**
 * A collection of arguments for invoking getImage.
 */
export interface GetImageOutputArgs {
    filters?: pulumi.Input<pulumi.Input<inputs.Image.GetImageFilterArgs>[]>;
    imageNameRegex?: pulumi.Input<string>;
    osName?: pulumi.Input<string>;
    resultOutputFile?: pulumi.Input<string>;
}