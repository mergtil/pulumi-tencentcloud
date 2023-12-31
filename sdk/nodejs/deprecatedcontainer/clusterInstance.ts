// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

import * as pulumi from "@pulumi/pulumi";
import * as utilities from "../utilities";

export class ClusterInstance extends pulumi.CustomResource {
    /**
     * Get an existing ClusterInstance resource's state with the given name, ID, and optional extra
     * properties used to qualify the lookup.
     *
     * @param name The _unique_ name of the resulting resource.
     * @param id The _unique_ provider ID of the resource to lookup.
     * @param state Any extra arguments used during the lookup.
     * @param opts Optional settings to control the behavior of the CustomResource.
     */
    public static get(name: string, id: pulumi.Input<pulumi.ID>, state?: ClusterInstanceState, opts?: pulumi.CustomResourceOptions): ClusterInstance {
        return new ClusterInstance(name, <any>state, { ...opts, id: id });
    }

    /** @internal */
    public static readonly __pulumiType = 'tencentcloud:Deprecatedcontainer/clusterInstance:ClusterInstance';

    /**
     * Returns true if the given object is an instance of ClusterInstance.  This is designed to work even
     * when multiple copies of the Pulumi SDK have been loaded into the same process.
     */
    public static isInstance(obj: any): obj is ClusterInstance {
        if (obj === undefined || obj === null) {
            return false;
        }
        return obj['__pulumiType'] === ClusterInstance.__pulumiType;
    }

    /**
     * Describe the reason when node is in abnormal state(if it was).
     */
    public /*out*/ readonly abnormalReason!: pulumi.Output<string>;
    /**
     * The network bandwidth of the node.
     */
    public readonly bandwidth!: pulumi.Output<number>;
    /**
     * The network type of the node.
     */
    public readonly bandwidthType!: pulumi.Output<string>;
    /**
     * The id of the cluster.
     */
    public readonly clusterId!: pulumi.Output<string>;
    /**
     * The cpu of the node.
     *
     * @deprecated It has been deprecated from version 1.16.0. Set 'instance_type' instead.
     */
    public readonly cpu!: pulumi.Output<number | undefined>;
    /**
     * The type of node needed by cvm.
     */
    public readonly cvmType!: pulumi.Output<string | undefined>;
    /**
     * The docker graph path is going to mounted.
     */
    public readonly dockerGraphPath!: pulumi.Output<string | undefined>;
    /**
     * An id identify the node, provided by cvm.
     */
    public /*out*/ readonly instanceId!: pulumi.Output<string>;
    /**
     * The name ot node.
     */
    public readonly instanceName!: pulumi.Output<string | undefined>;
    /**
     * The instance type of the node needed by cvm.
     */
    public readonly instanceType!: pulumi.Output<string | undefined>;
    /**
     * Describe whether the node is normal.
     */
    public /*out*/ readonly isNormal!: pulumi.Output<number>;
    /**
     * Describe whether the node enable the gateway capability.
     */
    public readonly isVpcGateway!: pulumi.Output<number>;
    /**
     * The key_id of each node(if using key pair to access).
     */
    public readonly keyId!: pulumi.Output<string | undefined>;
    /**
     * Describe the lan ip of the node.
     */
    public /*out*/ readonly lanIp!: pulumi.Output<string>;
    /**
     * The memory of the node.
     *
     * @deprecated It has been deprecated from version 1.16.0. Set 'instance_type' instead.
     */
    public readonly mem!: pulumi.Output<number | undefined>;
    /**
     * The path which volume is going to be mounted.
     */
    public readonly mountTarget!: pulumi.Output<string | undefined>;
    /**
     * The password of each node.
     */
    public readonly password!: pulumi.Output<string | undefined>;
    /**
     * The puchase duration of the node needed by cvm.
     */
    public readonly period!: pulumi.Output<number | undefined>;
    /**
     * Indicate whether wan ip is needed.
     */
    public readonly requireWanIp!: pulumi.Output<number | undefined>;
    /**
     * The size of the root volume.
     */
    public readonly rootSize!: pulumi.Output<number>;
    /**
     * The type of the root volume. see more from CVM.
     */
    public readonly rootType!: pulumi.Output<string | undefined>;
    /**
     * The security group id.
     */
    public readonly sgId!: pulumi.Output<string | undefined>;
    /**
     * The size of the data volume.
     */
    public readonly storageSize!: pulumi.Output<number>;
    /**
     * The type of the data volume. see more from CVM.
     */
    public readonly storageType!: pulumi.Output<string | undefined>;
    /**
     * The subnet id which the node stays in.
     */
    public readonly subnetId!: pulumi.Output<string>;
    /**
     * Determine whether the node will be schedulable. 0 is the default meaning node will be schedulable. 1 for unschedulable.
     */
    public readonly unschedulable!: pulumi.Output<number | undefined>;
    /**
     * User defined script in a base64-format. The script runs after the kubernetes component is ready on node. see more from
     * CCS api documents.
     */
    public readonly userScript!: pulumi.Output<string | undefined>;
    /**
     * Describe the wan ip of the node.
     */
    public /*out*/ readonly wanIp!: pulumi.Output<string>;
    /**
     * The zone which the node stays in.
     */
    public readonly zoneId!: pulumi.Output<string>;

    /**
     * Create a ClusterInstance resource with the given unique name, arguments, and options.
     *
     * @param name The _unique_ name of the resource.
     * @param args The arguments to use to populate this resource's properties.
     * @param opts A bag of options that control this resource's behavior.
     */
    constructor(name: string, args: ClusterInstanceArgs, opts?: pulumi.CustomResourceOptions)
    constructor(name: string, argsOrState?: ClusterInstanceArgs | ClusterInstanceState, opts?: pulumi.CustomResourceOptions) {
        let resourceInputs: pulumi.Inputs = {};
        opts = opts || {};
        if (opts.id) {
            const state = argsOrState as ClusterInstanceState | undefined;
            resourceInputs["abnormalReason"] = state ? state.abnormalReason : undefined;
            resourceInputs["bandwidth"] = state ? state.bandwidth : undefined;
            resourceInputs["bandwidthType"] = state ? state.bandwidthType : undefined;
            resourceInputs["clusterId"] = state ? state.clusterId : undefined;
            resourceInputs["cpu"] = state ? state.cpu : undefined;
            resourceInputs["cvmType"] = state ? state.cvmType : undefined;
            resourceInputs["dockerGraphPath"] = state ? state.dockerGraphPath : undefined;
            resourceInputs["instanceId"] = state ? state.instanceId : undefined;
            resourceInputs["instanceName"] = state ? state.instanceName : undefined;
            resourceInputs["instanceType"] = state ? state.instanceType : undefined;
            resourceInputs["isNormal"] = state ? state.isNormal : undefined;
            resourceInputs["isVpcGateway"] = state ? state.isVpcGateway : undefined;
            resourceInputs["keyId"] = state ? state.keyId : undefined;
            resourceInputs["lanIp"] = state ? state.lanIp : undefined;
            resourceInputs["mem"] = state ? state.mem : undefined;
            resourceInputs["mountTarget"] = state ? state.mountTarget : undefined;
            resourceInputs["password"] = state ? state.password : undefined;
            resourceInputs["period"] = state ? state.period : undefined;
            resourceInputs["requireWanIp"] = state ? state.requireWanIp : undefined;
            resourceInputs["rootSize"] = state ? state.rootSize : undefined;
            resourceInputs["rootType"] = state ? state.rootType : undefined;
            resourceInputs["sgId"] = state ? state.sgId : undefined;
            resourceInputs["storageSize"] = state ? state.storageSize : undefined;
            resourceInputs["storageType"] = state ? state.storageType : undefined;
            resourceInputs["subnetId"] = state ? state.subnetId : undefined;
            resourceInputs["unschedulable"] = state ? state.unschedulable : undefined;
            resourceInputs["userScript"] = state ? state.userScript : undefined;
            resourceInputs["wanIp"] = state ? state.wanIp : undefined;
            resourceInputs["zoneId"] = state ? state.zoneId : undefined;
        } else {
            const args = argsOrState as ClusterInstanceArgs | undefined;
            if ((!args || args.bandwidth === undefined) && !opts.urn) {
                throw new Error("Missing required property 'bandwidth'");
            }
            if ((!args || args.bandwidthType === undefined) && !opts.urn) {
                throw new Error("Missing required property 'bandwidthType'");
            }
            if ((!args || args.clusterId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'clusterId'");
            }
            if ((!args || args.isVpcGateway === undefined) && !opts.urn) {
                throw new Error("Missing required property 'isVpcGateway'");
            }
            if ((!args || args.rootSize === undefined) && !opts.urn) {
                throw new Error("Missing required property 'rootSize'");
            }
            if ((!args || args.storageSize === undefined) && !opts.urn) {
                throw new Error("Missing required property 'storageSize'");
            }
            if ((!args || args.subnetId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'subnetId'");
            }
            if ((!args || args.zoneId === undefined) && !opts.urn) {
                throw new Error("Missing required property 'zoneId'");
            }
            resourceInputs["bandwidth"] = args ? args.bandwidth : undefined;
            resourceInputs["bandwidthType"] = args ? args.bandwidthType : undefined;
            resourceInputs["clusterId"] = args ? args.clusterId : undefined;
            resourceInputs["cpu"] = args ? args.cpu : undefined;
            resourceInputs["cvmType"] = args ? args.cvmType : undefined;
            resourceInputs["dockerGraphPath"] = args ? args.dockerGraphPath : undefined;
            resourceInputs["instanceName"] = args ? args.instanceName : undefined;
            resourceInputs["instanceType"] = args ? args.instanceType : undefined;
            resourceInputs["isVpcGateway"] = args ? args.isVpcGateway : undefined;
            resourceInputs["keyId"] = args ? args.keyId : undefined;
            resourceInputs["mem"] = args ? args.mem : undefined;
            resourceInputs["mountTarget"] = args ? args.mountTarget : undefined;
            resourceInputs["password"] = args ? args.password : undefined;
            resourceInputs["period"] = args ? args.period : undefined;
            resourceInputs["requireWanIp"] = args ? args.requireWanIp : undefined;
            resourceInputs["rootSize"] = args ? args.rootSize : undefined;
            resourceInputs["rootType"] = args ? args.rootType : undefined;
            resourceInputs["sgId"] = args ? args.sgId : undefined;
            resourceInputs["storageSize"] = args ? args.storageSize : undefined;
            resourceInputs["storageType"] = args ? args.storageType : undefined;
            resourceInputs["subnetId"] = args ? args.subnetId : undefined;
            resourceInputs["unschedulable"] = args ? args.unschedulable : undefined;
            resourceInputs["userScript"] = args ? args.userScript : undefined;
            resourceInputs["zoneId"] = args ? args.zoneId : undefined;
            resourceInputs["abnormalReason"] = undefined /*out*/;
            resourceInputs["instanceId"] = undefined /*out*/;
            resourceInputs["isNormal"] = undefined /*out*/;
            resourceInputs["lanIp"] = undefined /*out*/;
            resourceInputs["wanIp"] = undefined /*out*/;
        }
        opts = pulumi.mergeOptions(utilities.resourceOptsDefaults(), opts);
        super(ClusterInstance.__pulumiType, name, resourceInputs, opts);
    }
}

/**
 * Input properties used for looking up and filtering ClusterInstance resources.
 */
export interface ClusterInstanceState {
    /**
     * Describe the reason when node is in abnormal state(if it was).
     */
    abnormalReason?: pulumi.Input<string>;
    /**
     * The network bandwidth of the node.
     */
    bandwidth?: pulumi.Input<number>;
    /**
     * The network type of the node.
     */
    bandwidthType?: pulumi.Input<string>;
    /**
     * The id of the cluster.
     */
    clusterId?: pulumi.Input<string>;
    /**
     * The cpu of the node.
     *
     * @deprecated It has been deprecated from version 1.16.0. Set 'instance_type' instead.
     */
    cpu?: pulumi.Input<number>;
    /**
     * The type of node needed by cvm.
     */
    cvmType?: pulumi.Input<string>;
    /**
     * The docker graph path is going to mounted.
     */
    dockerGraphPath?: pulumi.Input<string>;
    /**
     * An id identify the node, provided by cvm.
     */
    instanceId?: pulumi.Input<string>;
    /**
     * The name ot node.
     */
    instanceName?: pulumi.Input<string>;
    /**
     * The instance type of the node needed by cvm.
     */
    instanceType?: pulumi.Input<string>;
    /**
     * Describe whether the node is normal.
     */
    isNormal?: pulumi.Input<number>;
    /**
     * Describe whether the node enable the gateway capability.
     */
    isVpcGateway?: pulumi.Input<number>;
    /**
     * The key_id of each node(if using key pair to access).
     */
    keyId?: pulumi.Input<string>;
    /**
     * Describe the lan ip of the node.
     */
    lanIp?: pulumi.Input<string>;
    /**
     * The memory of the node.
     *
     * @deprecated It has been deprecated from version 1.16.0. Set 'instance_type' instead.
     */
    mem?: pulumi.Input<number>;
    /**
     * The path which volume is going to be mounted.
     */
    mountTarget?: pulumi.Input<string>;
    /**
     * The password of each node.
     */
    password?: pulumi.Input<string>;
    /**
     * The puchase duration of the node needed by cvm.
     */
    period?: pulumi.Input<number>;
    /**
     * Indicate whether wan ip is needed.
     */
    requireWanIp?: pulumi.Input<number>;
    /**
     * The size of the root volume.
     */
    rootSize?: pulumi.Input<number>;
    /**
     * The type of the root volume. see more from CVM.
     */
    rootType?: pulumi.Input<string>;
    /**
     * The security group id.
     */
    sgId?: pulumi.Input<string>;
    /**
     * The size of the data volume.
     */
    storageSize?: pulumi.Input<number>;
    /**
     * The type of the data volume. see more from CVM.
     */
    storageType?: pulumi.Input<string>;
    /**
     * The subnet id which the node stays in.
     */
    subnetId?: pulumi.Input<string>;
    /**
     * Determine whether the node will be schedulable. 0 is the default meaning node will be schedulable. 1 for unschedulable.
     */
    unschedulable?: pulumi.Input<number>;
    /**
     * User defined script in a base64-format. The script runs after the kubernetes component is ready on node. see more from
     * CCS api documents.
     */
    userScript?: pulumi.Input<string>;
    /**
     * Describe the wan ip of the node.
     */
    wanIp?: pulumi.Input<string>;
    /**
     * The zone which the node stays in.
     */
    zoneId?: pulumi.Input<string>;
}

/**
 * The set of arguments for constructing a ClusterInstance resource.
 */
export interface ClusterInstanceArgs {
    /**
     * The network bandwidth of the node.
     */
    bandwidth: pulumi.Input<number>;
    /**
     * The network type of the node.
     */
    bandwidthType: pulumi.Input<string>;
    /**
     * The id of the cluster.
     */
    clusterId: pulumi.Input<string>;
    /**
     * The cpu of the node.
     *
     * @deprecated It has been deprecated from version 1.16.0. Set 'instance_type' instead.
     */
    cpu?: pulumi.Input<number>;
    /**
     * The type of node needed by cvm.
     */
    cvmType?: pulumi.Input<string>;
    /**
     * The docker graph path is going to mounted.
     */
    dockerGraphPath?: pulumi.Input<string>;
    /**
     * The name ot node.
     */
    instanceName?: pulumi.Input<string>;
    /**
     * The instance type of the node needed by cvm.
     */
    instanceType?: pulumi.Input<string>;
    /**
     * Describe whether the node enable the gateway capability.
     */
    isVpcGateway: pulumi.Input<number>;
    /**
     * The key_id of each node(if using key pair to access).
     */
    keyId?: pulumi.Input<string>;
    /**
     * The memory of the node.
     *
     * @deprecated It has been deprecated from version 1.16.0. Set 'instance_type' instead.
     */
    mem?: pulumi.Input<number>;
    /**
     * The path which volume is going to be mounted.
     */
    mountTarget?: pulumi.Input<string>;
    /**
     * The password of each node.
     */
    password?: pulumi.Input<string>;
    /**
     * The puchase duration of the node needed by cvm.
     */
    period?: pulumi.Input<number>;
    /**
     * Indicate whether wan ip is needed.
     */
    requireWanIp?: pulumi.Input<number>;
    /**
     * The size of the root volume.
     */
    rootSize: pulumi.Input<number>;
    /**
     * The type of the root volume. see more from CVM.
     */
    rootType?: pulumi.Input<string>;
    /**
     * The security group id.
     */
    sgId?: pulumi.Input<string>;
    /**
     * The size of the data volume.
     */
    storageSize: pulumi.Input<number>;
    /**
     * The type of the data volume. see more from CVM.
     */
    storageType?: pulumi.Input<string>;
    /**
     * The subnet id which the node stays in.
     */
    subnetId: pulumi.Input<string>;
    /**
     * Determine whether the node will be schedulable. 0 is the default meaning node will be schedulable. 1 for unschedulable.
     */
    unschedulable?: pulumi.Input<number>;
    /**
     * User defined script in a base64-format. The script runs after the kubernetes component is ready on node. see more from
     * CCS api documents.
     */
    userScript?: pulumi.Input<string>;
    /**
     * The zone which the node stays in.
     */
    zoneId: pulumi.Input<string>;
}
