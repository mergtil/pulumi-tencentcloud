// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

export class Vpc extends pulumi.CustomResource {
    /**
     * Get an existing Vpc resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: VpcState, opts?: pulumi.CustomResourceOptions): Vpc {
        return new Vpc(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Vpc/vpc:Vpc';

    /**
     * Returns true if the given object is an instance of Vpc.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Vpc {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Vpc.__pulumiType;
    }

    /**
     * List of Assistant CIDR, NOTE: Only `NORMAL` typed CIDRs included, check the Docker CIDR by readonly
     * `assistant_docker_cidrs`.
     */
    public readonly assistantCidrs!: pulumi.Output<string[]>;
    /**
     * A network address block which should be a subnet of the three internal network segments (10.0.0.0/16, 172.16.0.0/12 and
     * 192.168.0.0/16).
     */
    public readonly cidrBlock!: pulumi.Output<string>;
    /**
     * Creation time of VPC.
     */
    public /*out*/ readonly createTime!: pulumi.Output<string>;
    /**
     * Default route table id, which created automatically after VPC create.
     */
    public /*out*/ readonly defaultRouteTableId!: pulumi.Output<string>;
    /**
     * The DNS server list of the VPC. And you can specify 0 to 5 servers to this list.
     */
    public readonly dnsServers!: pulumi.Output<string[]>;
    /**
     * List of Docker Assistant CIDR.
     */
    public /*out*/ readonly dockerAssistantCidrs!: pulumi.Output<string[]>;
    /**
     * Indicates whether it is the default VPC for this region.
     */
    public /*out*/ readonly isDefault!: pulumi.Output<boolean>;
    /**
     * Indicates whether VPC multicast is enabled. The default value is 'true'.
     */
    public readonly isMulticast!: pulumi.Output<boolean | undefined>;
    /**
     * The name of the VPC.
     */
    public readonly name!: pulumi.Output<string>;
    /**
     * Tags of the VPC.
     */
    public readonly tags!: pulumi.Output<{[key: string]: any} | undefined>;

    /**
     * Create a Vpc resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: VpcArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: VpcArgs | VpcState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as VpcState | undefined;
            resourceInputs["assistantCidrs"] = state ? state.assistantCidrs : undefined;
            resourceInputs["cidrBlock"] = state ? state.cidrBlock : undefined;
            resourceInputs["createTime"] = state ? state.createTime : undefined;
            resourceInputs["defaultRouteTableId"] = state ? state.defaultRouteTableId : undefined;
            resourceInputs["dnsServers"] = state ? state.dnsServers : undefined;
            resourceInputs["dockerAssistantCidrs"] = state ? state.dockerAssistantCidrs : undefined;
            resourceInputs["isDefault"] = state ? state.isDefault : undefined;
            resourceInputs["isMulticast"] = state ? state.isMulticast : undefined;
            resourceInputs["name"] = state ? state.name : undefined;
            resourceInputs["tags"] = state ? state.tags : undefined;
        } else {
            const args = argsOrState as VpcArgs | undefined;
            if ((!args || args.cidrBlock === undefined) && !opts.urn) {
                throw new Error("Missing required property 'cidrBlock'");
            }
            resourceInputs["assistantCidrs"] = args ? args.assistantCidrs : undefined;
            resourceInputs["cidrBlock"] = args ? args.cidrBlock : undefined;
            resourceInputs["dnsServers"] = args ? args.dnsServers : undefined;
            resourceInputs["isMulticast"] = args ? args.isMulticast : undefined;
            resourceInputs["name"] = args ? args.name : undefined;
            resourceInputs["tags"] = args ? args.tags : undefined;
            resourceInputs["createTime"] = undefined /*out*/;
            resourceInputs["defaultRouteTableId"] = undefined /*out*/;
            resourceInputs["dockerAssistantCidrs"] = undefined /*out*/;
            resourceInputs["isDefault"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(Vpc.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Vpc resources.
 */
export interface VpcState {
    /**
     * List of Assistant CIDR, NOTE: Only `NORMAL` typed CIDRs included, check the Docker CIDR by readonly
     * `assistant_docker_cidrs`.
     */
    assistantCidrs?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * A network address block which should be a subnet of the three internal network segments (10.0.0.0/16, 172.16.0.0/12 and
     * 192.168.0.0/16).
     */
    cidrBlock?: pulumi.Input<string>;
    /**
     * Creation time of VPC.
     */
    createTime?: pulumi.Input<string>;
    /**
     * Default route table id, which created automatically after VPC create.
     */
    defaultRouteTableId?: pulumi.Input<string>;
    /**
     * The DNS server list of the VPC. And you can specify 0 to 5 servers to this list.
     */
    dnsServers?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * List of Docker Assistant CIDR.
     */
    dockerAssistantCidrs?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Indicates whether it is the default VPC for this region.
     */
    isDefault?: pulumi.Input<boolean>;
    /**
     * Indicates whether VPC multicast is enabled. The default value is 'true'.
     */
    isMulticast?: pulumi.Input<boolean>;
    /**
     * The name of the VPC.
     */
    name?: pulumi.Input<string>;
    /**
     * Tags of the VPC.
     */
    tags?: pulumi.Input<{[key: string]: any}>;
}

/**
 * The set of arguments for constructing a Vpc resource.
 */
export interface VpcArgs {
    /**
     * List of Assistant CIDR, NOTE: Only `NORMAL` typed CIDRs included, check the Docker CIDR by readonly
     * `assistant_docker_cidrs`.
     */
    assistantCidrs?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * A network address block which should be a subnet of the three internal network segments (10.0.0.0/16, 172.16.0.0/12 and
     * 192.168.0.0/16).
     */
    cidrBlock: pulumi.Input<string>;
    /**
     * The DNS server list of the VPC. And you can specify 0 to 5 servers to this list.
     */
    dnsServers?: pulumi.Input<pulumi.Input<string>[]>;
    /**
     * Indicates whether VPC multicast is enabled. The default value is 'true'.
     */
    isMulticast?: pulumi.Input<boolean>;
    /**
     * The name of the VPC.
     */
    name?: pulumi.Input<string>;
    /**
     * Tags of the VPC.
     */
    tags?: pulumi.Input<{[key: string]: any}>;
}