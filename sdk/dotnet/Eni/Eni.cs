// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Eni
{
    [TencentcloudResourceType("tencentcloud:Eni/eni:Eni")]
    public partial class Eni : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Creation time of the ENI.
        /// </summary>
        [Output("createTime")]
        public Output<string> CreateTime { get; private set; } = null!;

        /// <summary>
        /// Description of the ENI, maximum length 60.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// The number of intranet IPv4s. When it is greater than 1, there is only one primary intranet IP. The others are auxiliary
        /// intranet IPs, which conflict with `ipv4s`.
        /// </summary>
        [Output("ipv4Count")]
        public Output<int?> Ipv4Count { get; private set; } = null!;

        /// <summary>
        /// An information list of IPv4s. Each element contains the following attributes:
        /// </summary>
        [Output("ipv4Infos")]
        public Output<ImmutableArray<Outputs.EniIpv4Info>> Ipv4Infos { get; private set; } = null!;

        /// <summary>
        /// Applying for intranet IPv4s collection, conflict with `ipv4_count`. When there are multiple ipv4s, can only be one
        /// primary IP, and the maximum length of the array is 30. Each element contains the following attributes:
        /// </summary>
        [Output("ipv4s")]
        public Output<ImmutableArray<Outputs.EniIpv4>> Ipv4s { get; private set; } = null!;

        /// <summary>
        /// MAC address.
        /// </summary>
        [Output("mac")]
        public Output<string> Mac { get; private set; } = null!;

        /// <summary>
        /// Name of the ENI, maximum length 60.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Indicates whether the IP is primary.
        /// </summary>
        [Output("primary")]
        public Output<bool> Primary { get; private set; } = null!;

        /// <summary>
        /// A set of security group IDs.
        /// </summary>
        [Output("securityGroups")]
        public Output<ImmutableArray<string>> SecurityGroups { get; private set; } = null!;

        /// <summary>
        /// State of the ENI.
        /// </summary>
        [Output("state")]
        public Output<string> State { get; private set; } = null!;

        /// <summary>
        /// ID of the subnet within this vpc.
        /// </summary>
        [Output("subnetId")]
        public Output<string> SubnetId { get; private set; } = null!;

        /// <summary>
        /// Tags of the ENI.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, object>?> Tags { get; private set; } = null!;

        /// <summary>
        /// ID of the vpc.
        /// </summary>
        [Output("vpcId")]
        public Output<string> VpcId { get; private set; } = null!;


        /// <summary>
        /// Create a Eni resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Eni(string name, EniArgs args, CustomResourceOptions? options = null)
            : base("tencentcloud:Eni/eni:Eni", name, args ?? new EniArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Eni(string name, Input<string> id, EniState? state = null, CustomResourceOptions? options = null)
            : base("tencentcloud:Eni/eni:Eni", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Eni resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Eni Get(string name, Input<string> id, EniState? state = null, CustomResourceOptions? options = null)
        {
            return new Eni(name, id, state, options);
        }
    }

    public sealed class EniArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Description of the ENI, maximum length 60.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The number of intranet IPv4s. When it is greater than 1, there is only one primary intranet IP. The others are auxiliary
        /// intranet IPs, which conflict with `ipv4s`.
        /// </summary>
        [Input("ipv4Count")]
        public Input<int>? Ipv4Count { get; set; }

        [Input("ipv4s")]
        private InputList<Inputs.EniIpv4Args>? _ipv4s;

        /// <summary>
        /// Applying for intranet IPv4s collection, conflict with `ipv4_count`. When there are multiple ipv4s, can only be one
        /// primary IP, and the maximum length of the array is 30. Each element contains the following attributes:
        /// </summary>
        public InputList<Inputs.EniIpv4Args> Ipv4s
        {
            get => _ipv4s ?? (_ipv4s = new InputList<Inputs.EniIpv4Args>());
            set => _ipv4s = value;
        }

        /// <summary>
        /// Name of the ENI, maximum length 60.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("securityGroups")]
        private InputList<string>? _securityGroups;

        /// <summary>
        /// A set of security group IDs.
        /// </summary>
        public InputList<string> SecurityGroups
        {
            get => _securityGroups ?? (_securityGroups = new InputList<string>());
            set => _securityGroups = value;
        }

        /// <summary>
        /// ID of the subnet within this vpc.
        /// </summary>
        [Input("subnetId", required: true)]
        public Input<string> SubnetId { get; set; } = null!;

        [Input("tags")]
        private InputMap<object>? _tags;

        /// <summary>
        /// Tags of the ENI.
        /// </summary>
        public InputMap<object> Tags
        {
            get => _tags ?? (_tags = new InputMap<object>());
            set => _tags = value;
        }

        /// <summary>
        /// ID of the vpc.
        /// </summary>
        [Input("vpcId", required: true)]
        public Input<string> VpcId { get; set; } = null!;

        public EniArgs()
        {
        }
        public static new EniArgs Empty => new EniArgs();
    }

    public sealed class EniState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Creation time of the ENI.
        /// </summary>
        [Input("createTime")]
        public Input<string>? CreateTime { get; set; }

        /// <summary>
        /// Description of the ENI, maximum length 60.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        /// <summary>
        /// The number of intranet IPv4s. When it is greater than 1, there is only one primary intranet IP. The others are auxiliary
        /// intranet IPs, which conflict with `ipv4s`.
        /// </summary>
        [Input("ipv4Count")]
        public Input<int>? Ipv4Count { get; set; }

        [Input("ipv4Infos")]
        private InputList<Inputs.EniIpv4InfoGetArgs>? _ipv4Infos;

        /// <summary>
        /// An information list of IPv4s. Each element contains the following attributes:
        /// </summary>
        public InputList<Inputs.EniIpv4InfoGetArgs> Ipv4Infos
        {
            get => _ipv4Infos ?? (_ipv4Infos = new InputList<Inputs.EniIpv4InfoGetArgs>());
            set => _ipv4Infos = value;
        }

        [Input("ipv4s")]
        private InputList<Inputs.EniIpv4GetArgs>? _ipv4s;

        /// <summary>
        /// Applying for intranet IPv4s collection, conflict with `ipv4_count`. When there are multiple ipv4s, can only be one
        /// primary IP, and the maximum length of the array is 30. Each element contains the following attributes:
        /// </summary>
        public InputList<Inputs.EniIpv4GetArgs> Ipv4s
        {
            get => _ipv4s ?? (_ipv4s = new InputList<Inputs.EniIpv4GetArgs>());
            set => _ipv4s = value;
        }

        /// <summary>
        /// MAC address.
        /// </summary>
        [Input("mac")]
        public Input<string>? Mac { get; set; }

        /// <summary>
        /// Name of the ENI, maximum length 60.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Indicates whether the IP is primary.
        /// </summary>
        [Input("primary")]
        public Input<bool>? Primary { get; set; }

        [Input("securityGroups")]
        private InputList<string>? _securityGroups;

        /// <summary>
        /// A set of security group IDs.
        /// </summary>
        public InputList<string> SecurityGroups
        {
            get => _securityGroups ?? (_securityGroups = new InputList<string>());
            set => _securityGroups = value;
        }

        /// <summary>
        /// State of the ENI.
        /// </summary>
        [Input("state")]
        public Input<string>? State { get; set; }

        /// <summary>
        /// ID of the subnet within this vpc.
        /// </summary>
        [Input("subnetId")]
        public Input<string>? SubnetId { get; set; }

        [Input("tags")]
        private InputMap<object>? _tags;

        /// <summary>
        /// Tags of the ENI.
        /// </summary>
        public InputMap<object> Tags
        {
            get => _tags ?? (_tags = new InputMap<object>());
            set => _tags = value;
        }

        /// <summary>
        /// ID of the vpc.
        /// </summary>
        [Input("vpcId")]
        public Input<string>? VpcId { get; set; }

        public EniState()
        {
        }
        public static new EniState Empty => new EniState();
    }
}