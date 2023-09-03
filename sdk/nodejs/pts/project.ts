// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

export class Project extends pulumi.CustomResource {
    /**
     * Get an existing Project resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ProjectState, opts?: pulumi.CustomResourceOptions): Project {
        return new Project(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Pts/project:Project';

    /**
     * Returns true if the given object is an instance of Project.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Project {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Project.__pulumiType;
    }

    /**
     * App ID.
     */
    public /*out*/ readonly appId!: pulumi.Output<number>;
    /**
     * Creation time.
     */
    public /*out*/ readonly createdAt!: pulumi.Output<string>;
    /**
     * Pts object description.
     */
    public readonly description!: pulumi.Output<string | undefined>;
    /**
     * ptsObjectName, which must be required.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * Project status.
     */
    public /*out*/ readonly status!: pulumi.Output<string>;
    /**
     * Sub-user ID.
     */
    public /*out*/ readonly subAccountUin!: pulumi.Output<string>;
    /**
     * Tags List.
     */
    public readonly tags!: pulumi.Output<outputs.Pts.ProjectTag[] | undefined>;
    /**
     * User ID.
     */
    public /*out*/ readonly uin!: pulumi.Output<string>;
    /**
     * Update time.
     */
    public /*out*/ readonly updatedAt!: pulumi.Output<string>;

    /**
     * Create a Project resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args?: ProjectArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ProjectArgs | ProjectState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as ProjectState | undefined;
            resourceInputs["appId"] = state ? state.appId : undefined;
            resourceInputs["createdAt"] = state ? state.createdAt : undefined;
            resourceInputs["description"] = state ? state.description : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["status"] = state ? state.status : undefined;
            resourceInputs["subAccountUin"] = state ? state.subAccountUin : undefined;
            resourceInputs["tags"] = state ? state.tags : undefined;
            resourceInputs["uin"] = state ? state.uin : undefined;
            resourceInputs["updatedAt"] = state ? state.updatedAt : undefined;
        } else {
            const args = argsOrState as ProjectArgs | undefined;
            resourceInputs["description"] = args ? args.description : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["tags"] = args ? args.tags : undefined;
            resourceInputs["appId"] = undefined /*out*/;
            resourceInputs["createdAt"] = undefined /*out*/;
            resourceInputs["status"] = undefined /*out*/;
            resourceInputs["subAccountUin"] = undefined /*out*/;
            resourceInputs["uin"] = undefined /*out*/;
            resourceInputs["updatedAt"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(Project.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Project resources.
 */
export interface ProjectState {
    /**
     * App ID.
     */
    appId?: pulumi.Input<number>;
    /**
     * Creation time.
     */
    createdAt?: pulumi.Input<string>;
    /**
     * Pts object description.
     */
    description?: pulumi.Input<string>;
    /**
     * ptsObjectName, which must be required.
     */
    name?: pulumi.Input<string>;
    /**
     * Project status.
     */
    status?: pulumi.Input<string>;
    /**
     * Sub-user ID.
     */
    subAccountUin?: pulumi.Input<string>;
    /**
     * Tags List.
     */
    tags?: pulumi.Input<pulumi.Input<inputs.Pts.ProjectTag>[]>;
    /**
     * User ID.
     */
    uin?: pulumi.Input<string>;
    /**
     * Update time.
     */
    updatedAt?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a Project resource.
 */
export interface ProjectArgs {
    /**
     * Pts object description.
     */
    description?: pulumi.Input<string>;
    /**
     * ptsObjectName, which must be required.
     */
    name?: pulumi.Input<string>;
    /**
     * Tags List.
     */
    tags?: pulumi.Input<pulumi.Input<inputs.Pts.ProjectTag>[]>;
}