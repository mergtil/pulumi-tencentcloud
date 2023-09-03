// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

export class Watermark extends pulumi.CustomResource {
    /**
     * Get an existing Watermark resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: WatermarkState, opts?: pulumi.CustomResourceOptions): Watermark {
        return new Watermark(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Css/watermark:Watermark';

    /**
     * Returns true if the given object is an instance of Watermark.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Watermark {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Watermark.__pulumiType;
    }

    /**
     * height of the picture.
     */
    public readonly height!: pulumi.Output<number | undefined>;
    /**
     * watermark url.
     */
    public readonly pictureUrl!: pulumi.Output<string>;
    /**
     * status. 0: not used, 1: used.
     */
    public /*out*/ readonly status!: pulumi.Output<number>;
    /**
     * watermark name.
     */
    public readonly watermarkName!: pulumi.Output<string>;
    /**
     * width of the picture.
     */
    public readonly width!: pulumi.Output<number | undefined>;
    /**
     * x position of the picture.
     */
    public readonly xPosition!: pulumi.Output<number | undefined>;
    /**
     * y position of the picture.
     */
    public readonly yPosition!: pulumi.Output<number | undefined>;

    /**
     * Create a Watermark resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: WatermarkArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: WatermarkArgs | WatermarkState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as WatermarkState | undefined;
            resourceInputs["height"] = state ? state.height : undefined;
            resourceInputs["pictureUrl"] = state ? state.pictureUrl : undefined;
            resourceInputs["status"] = state ? state.status : undefined;
            resourceInputs["watermarkName"] = state ? state.watermarkName : undefined;
            resourceInputs["width"] = state ? state.width : undefined;
            resourceInputs["xPosition"] = state ? state.xPosition : undefined;
            resourceInputs["yPosition"] = state ? state.yPosition : undefined;
        } else {
            const args = argsOrState as WatermarkArgs | undefined;
            if ((!args || args.pictureUrl === undefined) && !opts.urn) {
                throw new Error("Missing required property 'pictureUrl'");
            }
            if ((!args || args.watermarkName === undefined) && !opts.urn) {
                throw new Error("Missing required property 'watermarkName'");
            }
            resourceInputs["height"] = args ? args.height : undefined;
            resourceInputs["pictureUrl"] = args ? args.pictureUrl : undefined;
            resourceInputs["watermarkName"] = args ? args.watermarkName : undefined;
            resourceInputs["width"] = args ? args.width : undefined;
            resourceInputs["xPosition"] = args ? args.xPosition : undefined;
            resourceInputs["yPosition"] = args ? args.yPosition : undefined;
            resourceInputs["status"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(Watermark.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Watermark resources.
 */
export interface WatermarkState {
    /**
     * height of the picture.
     */
    height?: pulumi.Input<number>;
    /**
     * watermark url.
     */
    pictureUrl?: pulumi.Input<string>;
    /**
     * status. 0: not used, 1: used.
     */
    status?: pulumi.Input<number>;
    /**
     * watermark name.
     */
    watermarkName?: pulumi.Input<string>;
    /**
     * width of the picture.
     */
    width?: pulumi.Input<number>;
    /**
     * x position of the picture.
     */
    xPosition?: pulumi.Input<number>;
    /**
     * y position of the picture.
     */
    yPosition?: pulumi.Input<number>;
}

/**
 * The set of arguments for constructing a Watermark resource.
 */
export interface WatermarkArgs {
    /**
     * height of the picture.
     */
    height?: pulumi.Input<number>;
    /**
     * watermark url.
     */
    pictureUrl: pulumi.Input<string>;
    /**
     * watermark name.
     */
    watermarkName: pulumi.Input<string>;
    /**
     * width of the picture.
     */
    width?: pulumi.Input<number>;
    /**
     * x position of the picture.
     */
    xPosition?: pulumi.Input<number>;
    /**
     * y position of the picture.
     */
    yPosition?: pulumi.Input<number>;
}