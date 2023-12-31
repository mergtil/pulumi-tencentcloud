// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

export class BindingObject extends pulumi.CustomResource {
    /**
     * Get an existing BindingObject resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: BindingObjectState, opts?: pulumi.CustomResourceOptions): BindingObject {
        return new BindingObject(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Deprecatedmonitor/bindingObject:BindingObject';

    /**
     * Returns true if the given object is an instance of BindingObject.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is BindingObject {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === BindingObject.__pulumiType;
    }

    /**
     * A list objects. Each element contains the following attributes:
     */
    public readonly dimensions!: pulumi.Output<outputs.Deprecatedmonitor.BindingObjectDimension[]>;
    /**
     * Policy group ID for binding objects.
     */
    public readonly groupId!: pulumi.Output<number>;

    /**
     * Create a BindingObject resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: BindingObjectArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: BindingObjectArgs | BindingObjectState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as BindingObjectState | undefined;
            resourceInputs["dimensions"] = state ? state.dimensions : undefined;
            resourceInputs["groupId"] = state ? state.groupId : undefined;
        } else {
            const args = argsOrState as BindingObjectArgs | undefined;
            if ((!args || args.dimensions === undefined) && !opts.urn) {
                throw new Error("Missing required property 'dimensions'");
            }
            if ((!args || args.groupId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'groupId'");
            }
            resourceInputs["dimensions"] = args ? args.dimensions : undefined;
            resourceInputs["groupId"] = args ? args.groupId : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(BindingObject.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering BindingObject resources.
 */
export interface BindingObjectState {
    /**
     * A list objects. Each element contains the following attributes:
     */
    dimensions?: pulumi.Input<pulumi.Input<inputs.Deprecatedmonitor.BindingObjectDimension>[]>;
    /**
     * Policy group ID for binding objects.
     */
    groupId?: pulumi.Input<number>;
}

/**
 * The set of arguments for constructing a BindingObject resource.
 */
export interface BindingObjectArgs {
    /**
     * A list objects. Each element contains the following attributes:
     */
    dimensions: pulumi.Input<pulumi.Input<inputs.Deprecatedmonitor.BindingObjectDimension>[]>;
    /**
     * Policy group ID for binding objects.
     */
    groupId: pulumi.Input<number>;
}
