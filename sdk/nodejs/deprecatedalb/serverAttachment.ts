// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

export class ServerAttachment extends pulumi.CustomResource {
    /**
     * Get an existing ServerAttachment resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ServerAttachmentState, opts?: pulumi.CustomResourceOptions): ServerAttachment {
        return new ServerAttachment(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Deprecatedalb/serverAttachment:ServerAttachment';

    /**
     * Returns true if the given object is an instance of ServerAttachment.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ServerAttachment {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ServerAttachment.__pulumiType;
    }

    /**
     * list of backend server.
     */
    public readonly backends!: pulumi.Output<outputs.Deprecatedalb.ServerAttachmentBackend[]>;
    /**
     * listener ID.
     */
    public readonly listenerId!: pulumi.Output<string>;
    /**
     * loadbalancer ID.
     */
    public readonly loadbalancerId!: pulumi.Output<string>;
    /**
     * location ID, only support for layer 7 loadbalancer.
     */
    public readonly locationId!: pulumi.Output<string>;
    /**
     * The protocol type, http or tcp.
     */
    public /*out*/ readonly protocolType!: pulumi.Output<string>;

    /**
     * Create a ServerAttachment resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ServerAttachmentArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ServerAttachmentArgs | ServerAttachmentState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as ServerAttachmentState | undefined;
            resourceInputs["backends"] = state ? state.backends : undefined;
            resourceInputs["listenerId"] = state ? state.listenerId : undefined;
            resourceInputs["loadbalancerId"] = state ? state.loadbalancerId : undefined;
            resourceInputs["locationId"] = state ? state.locationId : undefined;
            resourceInputs["protocolType"] = state ? state.protocolType : undefined;
        } else {
            const args = argsOrState as ServerAttachmentArgs | undefined;
            if ((!args || args.backends === undefined) && !opts.urn) {
                throw new Error("Missing required property 'backends'");
            }
            if ((!args || args.listenerId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'listenerId'");
            }
            if ((!args || args.loadbalancerId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'loadbalancerId'");
            }
            resourceInputs["backends"] = args ? args.backends : undefined;
            resourceInputs["listenerId"] = args ? args.listenerId : undefined;
            resourceInputs["loadbalancerId"] = args ? args.loadbalancerId : undefined;
            resourceInputs["locationId"] = args ? args.locationId : undefined;
            resourceInputs["protocolType"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(ServerAttachment.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering ServerAttachment resources.
 */
export interface ServerAttachmentState {
    /**
     * list of backend server.
     */
    backends?: pulumi.Input<pulumi.Input<inputs.Deprecatedalb.ServerAttachmentBackend>[]>;
    /**
     * listener ID.
     */
    listenerId?: pulumi.Input<string>;
    /**
     * loadbalancer ID.
     */
    loadbalancerId?: pulumi.Input<string>;
    /**
     * location ID, only support for layer 7 loadbalancer.
     */
    locationId?: pulumi.Input<string>;
    /**
     * The protocol type, http or tcp.
     */
    protocolType?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a ServerAttachment resource.
 */
export interface ServerAttachmentArgs {
    /**
     * list of backend server.
     */
    backends: pulumi.Input<pulumi.Input<inputs.Deprecatedalb.ServerAttachmentBackend>[]>;
    /**
     * listener ID.
     */
    listenerId: pulumi.Input<string>;
    /**
     * loadbalancer ID.
     */
    loadbalancerId: pulumi.Input<string>;
    /**
     * location ID, only support for layer 7 loadbalancer.
     */
    locationId?: pulumi.Input<string>;
}