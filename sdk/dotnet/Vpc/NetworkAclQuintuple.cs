// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Vpc
{
    [TencentcloudResourceType("tencentcloud:Vpc/networkAclQuintuple:NetworkAclQuintuple")]
    public partial class NetworkAclQuintuple : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Network ACL instance ID. For example:acl-12345678.
        /// </summary>
        [Output("networkAclId")]
        public Output<string> NetworkAclId { get; private set; } = null!;

        /// <summary>
        /// Network quintuple ACL rule set.
        /// </summary>
        [Output("networkAclQuintupleSet")]
        public Output<Outputs.NetworkAclQuintupleNetworkAclQuintupleSet> NetworkAclQuintupleSet { get; private set; } = null!;


        /// <summary>
        /// Create a NetworkAclQuintuple resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public NetworkAclQuintuple(string name, NetworkAclQuintupleArgs args, CustomResourceOptions? options = null)
            : base("tencentcloud:Vpc/networkAclQuintuple:NetworkAclQuintuple", name, args ?? new NetworkAclQuintupleArgs(), MakeResourceOptions(options, ""))
        {
        }

        private NetworkAclQuintuple(string name, Input<string> id, NetworkAclQuintupleState? state = null, CustomResourceOptions? options = null)
            : base("tencentcloud:Vpc/networkAclQuintuple:NetworkAclQuintuple", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing NetworkAclQuintuple resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static NetworkAclQuintuple Get(string name, Input<string> id, NetworkAclQuintupleState? state = null, CustomResourceOptions? options = null)
        {
            return new NetworkAclQuintuple(name, id, state, options);
        }
    }

    public sealed class NetworkAclQuintupleArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Network ACL instance ID. For example:acl-12345678.
        /// </summary>
        [Input("networkAclId", required: true)]
        public Input<string> NetworkAclId { get; set; } = null!;

        /// <summary>
        /// Network quintuple ACL rule set.
        /// </summary>
        [Input("networkAclQuintupleSet", required: true)]
        public Input<Inputs.NetworkAclQuintupleNetworkAclQuintupleSetArgs> NetworkAclQuintupleSet { get; set; } = null!;

        public NetworkAclQuintupleArgs()
        {
        }
        public static new NetworkAclQuintupleArgs Empty => new NetworkAclQuintupleArgs();
    }

    public sealed class NetworkAclQuintupleState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Network ACL instance ID. For example:acl-12345678.
        /// </summary>
        [Input("networkAclId")]
        public Input<string>? NetworkAclId { get; set; }

        /// <summary>
        /// Network quintuple ACL rule set.
        /// </summary>
        [Input("networkAclQuintupleSet")]
        public Input<Inputs.NetworkAclQuintupleNetworkAclQuintupleSetGetArgs>? NetworkAclQuintupleSet { get; set; }

        public NetworkAclQuintupleState()
        {
        }
        public static new NetworkAclQuintupleState Empty => new NetworkAclQuintupleState();
    }
}