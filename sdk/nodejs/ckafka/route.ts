// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as inputs from "../types/input";
import * as outputs from "../types/output";
import * as utilities from "../utilities";

export class Route extends pulumi.CustomResource {
    /**
     * Get an existing Route resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: RouteState, opts?: pulumi.CustomResourceOptions): Route {
        return new Route(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Ckafka/route:Route';

    /**
     * Returns true if the given object is an instance of Route.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is Route {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === Route.__pulumiType;
    }

    /**
     * Access type. Valid values: - 0: PLAINTEXT (in clear text, supported by both the old version and the community version
     * without user information) - 1: SASL_PLAINTEXT (in clear text, but at the beginning of the data, authentication will be
     * logged in through SASL, which is only supported by the community version) - 2: SSL (SSL encrypted communication without
     * user information, supported by both older and community versions) - 3: SASL_SSL (SSL encrypted communication. When the
     * data starts, authentication will be logged in through SASL. Only the community version supports it).
     */
    public readonly accessType!: pulumi.Output<number>;
    /**
     * Auth flag.
     */
    public readonly authFlag!: pulumi.Output<number | undefined>;
    /**
     * Virtual IP list (1 to 1 broker nodes).
     */
    public /*out*/ readonly brokerVipLists!: pulumi.Output<outputs.Ckafka.RouteBrokerVipList[]>;
    /**
     * Caller appid.
     */
    public readonly callerAppid!: pulumi.Output<number | undefined>;
    /**
     * Instance id.
     */
    public readonly instanceId!: pulumi.Output<string>;
    /**
     * Ip.
     */
    public readonly ip!: pulumi.Output<string>;
    /**
     * Public network.
     */
    public readonly publicNetwork!: pulumi.Output<number | undefined>;
    /**
     * Subnet id.
     */
    public readonly subnetId!: pulumi.Output<string>;
    /**
     * Virtual IP list.
     */
    public /*out*/ readonly vipLists!: pulumi.Output<outputs.Ckafka.RouteVipList[]>;
    /**
     * Routing network type (3:vpc routing; 4: standard support routing; 7: professional support routing).
     */
    public readonly vipType!: pulumi.Output<number>;
    /**
     * Vpc id.
     */
    public readonly vpcId!: pulumi.Output<string>;

    /**
     * Create a Route resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: RouteArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: RouteArgs | RouteState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as RouteState | undefined;
            resourceInputs["accessType"] = state ? state.accessType : undefined;
            resourceInputs["authFlag"] = state ? state.authFlag : undefined;
            resourceInputs["brokerVipLists"] = state ? state.brokerVipLists : undefined;
            resourceInputs["callerAppid"] = state ? state.callerAppid : undefined;
            resourceInputs["instanceId"] = state ? state.instanceId : undefined;
            resourceInputs["ip"] = state ? state.ip : undefined;
            resourceInputs["publicNetwork"] = state ? state.publicNetwork : undefined;
            resourceInputs["subnetId"] = state ? state.subnetId : undefined;
            resourceInputs["vipLists"] = state ? state.vipLists : undefined;
            resourceInputs["vipType"] = state ? state.vipType : undefined;
            resourceInputs["vpcId"] = state ? state.vpcId : undefined;
        } else {
            const args = argsOrState as RouteArgs | undefined;
            if ((!args || args.instanceId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'instanceId'");
            }
            if ((!args || args.vipType === undefined) && !opts.urn) {
                throw new Error("Missing required property 'vipType'");
            }
            resourceInputs["accessType"] = args ? args.accessType : undefined;
            resourceInputs["authFlag"] = args ? args.authFlag : undefined;
            resourceInputs["callerAppid"] = args ? args.callerAppid : undefined;
            resourceInputs["instanceId"] = args ? args.instanceId : undefined;
            resourceInputs["ip"] = args ? args.ip : undefined;
            resourceInputs["publicNetwork"] = args ? args.publicNetwork : undefined;
            resourceInputs["subnetId"] = args ? args.subnetId : undefined;
            resourceInputs["vipType"] = args ? args.vipType : undefined;
            resourceInputs["vpcId"] = args ? args.vpcId : undefined;
            resourceInputs["brokerVipLists"] = undefined /*out*/;
            resourceInputs["vipLists"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(Route.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering Route resources.
 */
export interface RouteState {
    /**
     * Access type. Valid values: - 0: PLAINTEXT (in clear text, supported by both the old version and the community version
     * without user information) - 1: SASL_PLAINTEXT (in clear text, but at the beginning of the data, authentication will be
     * logged in through SASL, which is only supported by the community version) - 2: SSL (SSL encrypted communication without
     * user information, supported by both older and community versions) - 3: SASL_SSL (SSL encrypted communication. When the
     * data starts, authentication will be logged in through SASL. Only the community version supports it).
     */
    accessType?: pulumi.Input<number>;
    /**
     * Auth flag.
     */
    authFlag?: pulumi.Input<number>;
    /**
     * Virtual IP list (1 to 1 broker nodes).
     */
    brokerVipLists?: pulumi.Input<pulumi.Input<inputs.Ckafka.RouteBrokerVipList>[]>;
    /**
     * Caller appid.
     */
    callerAppid?: pulumi.Input<number>;
    /**
     * Instance id.
     */
    instanceId?: pulumi.Input<string>;
    /**
     * Ip.
     */
    ip?: pulumi.Input<string>;
    /**
     * Public network.
     */
    publicNetwork?: pulumi.Input<number>;
    /**
     * Subnet id.
     */
    subnetId?: pulumi.Input<string>;
    /**
     * Virtual IP list.
     */
    vipLists?: pulumi.Input<pulumi.Input<inputs.Ckafka.RouteVipList>[]>;
    /**
     * Routing network type (3:vpc routing; 4: standard support routing; 7: professional support routing).
     */
    vipType?: pulumi.Input<number>;
    /**
     * Vpc id.
     */
    vpcId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a Route resource.
 */
export interface RouteArgs {
    /**
     * Access type. Valid values: - 0: PLAINTEXT (in clear text, supported by both the old version and the community version
     * without user information) - 1: SASL_PLAINTEXT (in clear text, but at the beginning of the data, authentication will be
     * logged in through SASL, which is only supported by the community version) - 2: SSL (SSL encrypted communication without
     * user information, supported by both older and community versions) - 3: SASL_SSL (SSL encrypted communication. When the
     * data starts, authentication will be logged in through SASL. Only the community version supports it).
     */
    accessType?: pulumi.Input<number>;
    /**
     * Auth flag.
     */
    authFlag?: pulumi.Input<number>;
    /**
     * Caller appid.
     */
    callerAppid?: pulumi.Input<number>;
    /**
     * Instance id.
     */
    instanceId: pulumi.Input<string>;
    /**
     * Ip.
     */
    ip?: pulumi.Input<string>;
    /**
     * Public network.
     */
    publicNetwork?: pulumi.Input<number>;
    /**
     * Subnet id.
     */
    subnetId?: pulumi.Input<string>;
    /**
     * Routing network type (3:vpc routing; 4: standard support routing; 7: professional support routing).
     */
    vipType: pulumi.Input<number>;
    /**
     * Vpc id.
     */
    vpcId?: pulumi.Input<string>;
}