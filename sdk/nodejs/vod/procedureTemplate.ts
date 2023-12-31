// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

export class ProcedureTemplate extends pulumi.CustomResource {
    /**
     * Get an existing ProcedureTemplate resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ProcedureTemplateState, opts?: pulumi.CustomResourceOptions): ProcedureTemplate {
        return new ProcedureTemplate(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Vod/procedureTemplate:ProcedureTemplate';

    /**
     * Returns true if the given object is an instance of ProcedureTemplate.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ProcedureTemplate {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ProcedureTemplate.__pulumiType;
    }

    /**
     * Template description. Length limit: 256 characters.
     */
    public readonly comment!: pulumi.Output<string | undefined>;
    /**
     * Creation time of template in ISO date format.
     */
    public /*out*/ readonly createTime!: pulumi.Output<string>;
    /**
     * Parameter of video processing task.
     */
    public readonly mediaProcessTask!: pulumi.Output<outputs.Vod.ProcedureTemplateMediaProcessTask | undefined>;
    /**
     * Task flow name (up to 20 characters).
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * Subapplication ID in VOD. If you need to access a resource in a subapplication, enter the subapplication ID in this
     * field; otherwise, leave it empty.
     */
    public readonly subAppId!: pulumi.Output<number | undefined>;
    /**
     * Last modified time of template in ISO date format.
     */
    public /*out*/ readonly updateTime!: pulumi.Output<string>;

    /**
     * Create a ProcedureTemplate resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: ProcedureTemplateArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ProcedureTemplateArgs | ProcedureTemplateState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as ProcedureTemplateState | undefined;
            resourceInputs["comment"] = state ? state.comment : undefined;
            resourceInputs["createTime"] = state ? state.createTime : undefined;
            resourceInputs["mediaProcessTask"] = state ? state.mediaProcessTask : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["subAppId"] = state ? state.subAppId : undefined;
            resourceInputs["updateTime"] = state ? state.updateTime : undefined;
        } else {
            const args = argsOrState as ProcedureTemplateArgs | undefined;
            resourceInputs["comment"] = args ? args.comment : undefined;
            resourceInputs["mediaProcessTask"] = args ? args.mediaProcessTask : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["subAppId"] = args ? args.subAppId : undefined;
            resourceInputs["createTime"] = undefined /*out*/;
            resourceInputs["updateTime"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(ProcedureTemplate.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering ProcedureTemplate resources.
 */
export interface ProcedureTemplateState {
    /**
     * Template description. Length limit: 256 characters.
     */
    comment?: pulumi.Input<string>;
    /**
     * Creation time of template in ISO date format.
     */
    createTime?: pulumi.Input<string>;
    /**
     * Parameter of video processing task.
     */
    mediaProcessTask?: pulumi.Input<inputs.Vod.ProcedureTemplateMediaProcessTask>;
    /**
     * Task flow name (up to 20 characters).
     */
    name?: pulumi.Input<string>;
    /**
     * Subapplication ID in VOD. If you need to access a resource in a subapplication, enter the subapplication ID in this
     * field; otherwise, leave it empty.
     */
    subAppId?: pulumi.Input<number>;
    /**
     * Last modified time of template in ISO date format.
     */
    updateTime?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a ProcedureTemplate resource.
 */
export interface ProcedureTemplateArgs {
    /**
     * Template description. Length limit: 256 characters.
     */
    comment?: pulumi.Input<string>;
    /**
     * Parameter of video processing task.
     */
    mediaProcessTask?: pulumi.Input<inputs.Vod.ProcedureTemplateMediaProcessTask>;
    /**
     * Task flow name (up to 20 characters).
     */
    name?: pulumi.Input<string>;
    /**
     * Subapplication ID in VOD. If you need to access a resource in a subapplication, enter the subapplication ID in this
     * field; otherwise, leave it empty.
     */
    subAppId?: pulumi.Input<number>;
}
