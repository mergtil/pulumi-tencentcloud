// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

export class Parameters extends pulumi.CustomResource {
    /**
     * Get an existing Parameters resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ParametersState, opts?: pulumi.CustomResourceOptions): Parameters {
        return new Parameters(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Mariadb/parameters:Parameters';

    /**
     * Returns true if the given object is an instance of Parameters.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Parameters {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Parameters.__pulumiType;
    }

    /**
     * instance id.
     */
    public readonly instanceId!: pulumi.Output<string>;
    /**
     * Number of days to keep, no more than 30.
     */
    public readonly params!: pulumi.Output<outputs.Mariadb.ParametersParam[]>;

    /**
     * Create a Parameters resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ParametersArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ParametersArgs | ParametersState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as ParametersState | undefined;
            resourceInputs["instanceId"] = state ? state.instanceId : undefined;
            resourceInputs["params"] = state ? state.params : undefined;
        } else {
            const args = argsOrState as ParametersArgs | undefined;
            if ((!args || args.instanceId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'instanceId'");
            }
            if ((!args || args.params === undefined) && !opts.urn) {
                throw new Error("Missing required property 'params'");
            }
            resourceInputs["instanceId"] = args ? args.instanceId : undefined;
            resourceInputs["params"] = args ? args.params : undefined;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(Parameters.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Parameters resources.
 */
export interface ParametersState {
    /**
     * instance id.
     */
    instanceId?: pulumi.Input<string>;
    /**
     * Number of days to keep, no more than 30.
     */
    params?: pulumi.Input<pulumi.Input<inputs.Mariadb.ParametersParam>[]>;
}

/**
 * The set of arguments for constructing a Parameters resource.
 */
export interface ParametersArgs {
    /**
     * instance id.
     */
    instanceId: pulumi.Input<string>;
    /**
     * Number of days to keep, no more than 30.
     */
    params: pulumi.Input<pulumi.Input<inputs.Mariadb.ParametersParam>[]>;
}
