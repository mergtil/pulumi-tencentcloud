// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Vpn
{
    [TencentcloudResourceType("tencentcloud:Vpn/customerGateway:CustomerGateway")]
    public partial class CustomerGateway : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Create time of the customer gateway.
        /// </summary>
        [Output("createTime")]
        public Output<string> CreateTime { get; private set; } = null!;

        /// <summary>
        /// Name of the customer gateway. The length of character is limited to 1-60.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Public IP of the customer gateway.
        /// </summary>
        [Output("publicIpAddress")]
        public Output<string> PublicIpAddress { get; private set; } = null!;

        /// <summary>
        /// A list of tags used to associate different resources.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, object>?> Tags { get; private set; } = null!;


        /// <summary>
        /// Create a CustomerGateway resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public CustomerGateway(string name, CustomerGatewayArgs args, CustomResourceOptions? options = null)
            : base("tencentcloud:Vpn/customerGateway:CustomerGateway", name, args ?? new CustomerGatewayArgs(), MakeResourceOptions(options, ""))
        {
        }

        private CustomerGateway(string name, Input<string> id, CustomerGatewayState? state = null, CustomResourceOptions? options = null)
            : base("tencentcloud:Vpn/customerGateway:CustomerGateway", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing CustomerGateway resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static CustomerGateway Get(string name, Input<string> id, CustomerGatewayState? state = null, CustomResourceOptions? options = null)
        {
            return new CustomerGateway(name, id, state, options);
        }
    }

    public sealed class CustomerGatewayArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Name of the customer gateway. The length of character is limited to 1-60.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Public IP of the customer gateway.
        /// </summary>
        [Input("publicIpAddress", required: true)]
        public Input<string> PublicIpAddress { get; set; } = null!;

        [Input("tags")]
        private InputMap<object>? _tags;

        /// <summary>
        /// A list of tags used to associate different resources.
        /// </summary>
        public InputMap<object> Tags
        {
            get => _tags ?? (_tags = new InputMap<object>());
            set => _tags = value;
        }

        public CustomerGatewayArgs()
        {
        }
        public static new CustomerGatewayArgs Empty => new CustomerGatewayArgs();
    }

    public sealed class CustomerGatewayState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Create time of the customer gateway.
        /// </summary>
        [Input("createTime")]
        public Input<string>? CreateTime { get; set; }

        /// <summary>
        /// Name of the customer gateway. The length of character is limited to 1-60.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Public IP of the customer gateway.
        /// </summary>
        [Input("publicIpAddress")]
        public Input<string>? PublicIpAddress { get; set; }

        [Input("tags")]
        private InputMap<object>? _tags;

        /// <summary>
        /// A list of tags used to associate different resources.
        /// </summary>
        public InputMap<object> Tags
        {
            get => _tags ?? (_tags = new InputMap<object>());
            set => _tags = value;
        }

        public CustomerGatewayState()
        {
        }
        public static new CustomerGatewayState Empty => new CustomerGatewayState();
    }
}