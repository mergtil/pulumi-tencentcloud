// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Vpc
{
    [TencentcloudResourceType("tencentcloud:Vpc/bandwidthPackage:BandwidthPackage")]
    public partial class BandwidthPackage : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Bandwidth package name.
        /// </summary>
        [Output("bandwidthPackageName")]
        public Output<string?> BandwidthPackageName { get; private set; } = null!;

        /// <summary>
        /// Bandwidth package billing type, default: TOP5_POSTPAID_BY_MONTH. Optional value: `TOP5_POSTPAID_BY_MONTH`: TOP5 billed
        /// by monthly postpaid; `PERCENT95_POSTPAID_BY_MONTH`: 95 billed monthly postpaid; `FIXED_PREPAID_BY_MONTH`: Monthly
        /// prepaid billing (Type FIXED_PREPAID_BY_MONTH product API capability is under construction); `BANDWIDTH_POSTPAID_BY_DAY`:
        /// bandwidth billed by daily postpaid; `ENHANCED95_POSTPAID_BY_MONTH`: enhanced 95 billed monthly postpaid.
        /// </summary>
        [Output("chargeType")]
        public Output<string?> ChargeType { get; private set; } = null!;

        /// <summary>
        /// Bandwidth packet speed limit size. Unit: Mbps, -1 means no speed limit.
        /// </summary>
        [Output("internetMaxBandwidth")]
        public Output<int?> InternetMaxBandwidth { get; private set; } = null!;

        /// <summary>
        /// Bandwidth packet type, default:BGP, optional:- `BGP`: common BGP shared bandwidth package- `HIGH_QUALITY_BGP`: Quality
        /// BGP Shared Bandwidth Package.
        /// </summary>
        [Output("networkType")]
        public Output<string?> NetworkType { get; private set; } = null!;

        /// <summary>
        /// Tag description list.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, object>?> Tags { get; private set; } = null!;

        /// <summary>
        /// The purchase duration of the prepaid monthly bandwidth package, unit: month, value range: 1~60.
        /// </summary>
        [Output("timeSpan")]
        public Output<int?> TimeSpan { get; private set; } = null!;


        /// <summary>
        /// Create a BandwidthPackage resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public BandwidthPackage(string name, BandwidthPackageArgs? args = null, CustomResourceOptions? options = null)
            : base("tencentcloud:Vpc/bandwidthPackage:BandwidthPackage", name, args ?? new BandwidthPackageArgs(), MakeResourceOptions(options, ""))
        {
        }

        private BandwidthPackage(string name, Input<string> id, BandwidthPackageState? state = null, CustomResourceOptions? options = null)
            : base("tencentcloud:Vpc/bandwidthPackage:BandwidthPackage", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing BandwidthPackage resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static BandwidthPackage Get(string name, Input<string> id, BandwidthPackageState? state = null, CustomResourceOptions? options = null)
        {
            return new BandwidthPackage(name, id, state, options);
        }
    }

    public sealed class BandwidthPackageArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Bandwidth package name.
        /// </summary>
        [Input("bandwidthPackageName")]
        public Input<string>? BandwidthPackageName { get; set; }

        /// <summary>
        /// Bandwidth package billing type, default: TOP5_POSTPAID_BY_MONTH. Optional value: `TOP5_POSTPAID_BY_MONTH`: TOP5 billed
        /// by monthly postpaid; `PERCENT95_POSTPAID_BY_MONTH`: 95 billed monthly postpaid; `FIXED_PREPAID_BY_MONTH`: Monthly
        /// prepaid billing (Type FIXED_PREPAID_BY_MONTH product API capability is under construction); `BANDWIDTH_POSTPAID_BY_DAY`:
        /// bandwidth billed by daily postpaid; `ENHANCED95_POSTPAID_BY_MONTH`: enhanced 95 billed monthly postpaid.
        /// </summary>
        [Input("chargeType")]
        public Input<string>? ChargeType { get; set; }

        /// <summary>
        /// Bandwidth packet speed limit size. Unit: Mbps, -1 means no speed limit.
        /// </summary>
        [Input("internetMaxBandwidth")]
        public Input<int>? InternetMaxBandwidth { get; set; }

        /// <summary>
        /// Bandwidth packet type, default:BGP, optional:- `BGP`: common BGP shared bandwidth package- `HIGH_QUALITY_BGP`: Quality
        /// BGP Shared Bandwidth Package.
        /// </summary>
        [Input("networkType")]
        public Input<string>? NetworkType { get; set; }

        [Input("tags")]
        private InputMap<object>? _tags;

        /// <summary>
        /// Tag description list.
        /// </summary>
        public InputMap<object> Tags
        {
            get => _tags ?? (_tags = new InputMap<object>());
            set => _tags = value;
        }

        /// <summary>
        /// The purchase duration of the prepaid monthly bandwidth package, unit: month, value range: 1~60.
        /// </summary>
        [Input("timeSpan")]
        public Input<int>? TimeSpan { get; set; }

        public BandwidthPackageArgs()
        {
        }
        public static new BandwidthPackageArgs Empty => new BandwidthPackageArgs();
    }

    public sealed class BandwidthPackageState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Bandwidth package name.
        /// </summary>
        [Input("bandwidthPackageName")]
        public Input<string>? BandwidthPackageName { get; set; }

        /// <summary>
        /// Bandwidth package billing type, default: TOP5_POSTPAID_BY_MONTH. Optional value: `TOP5_POSTPAID_BY_MONTH`: TOP5 billed
        /// by monthly postpaid; `PERCENT95_POSTPAID_BY_MONTH`: 95 billed monthly postpaid; `FIXED_PREPAID_BY_MONTH`: Monthly
        /// prepaid billing (Type FIXED_PREPAID_BY_MONTH product API capability is under construction); `BANDWIDTH_POSTPAID_BY_DAY`:
        /// bandwidth billed by daily postpaid; `ENHANCED95_POSTPAID_BY_MONTH`: enhanced 95 billed monthly postpaid.
        /// </summary>
        [Input("chargeType")]
        public Input<string>? ChargeType { get; set; }

        /// <summary>
        /// Bandwidth packet speed limit size. Unit: Mbps, -1 means no speed limit.
        /// </summary>
        [Input("internetMaxBandwidth")]
        public Input<int>? InternetMaxBandwidth { get; set; }

        /// <summary>
        /// Bandwidth packet type, default:BGP, optional:- `BGP`: common BGP shared bandwidth package- `HIGH_QUALITY_BGP`: Quality
        /// BGP Shared Bandwidth Package.
        /// </summary>
        [Input("networkType")]
        public Input<string>? NetworkType { get; set; }

        [Input("tags")]
        private InputMap<object>? _tags;

        /// <summary>
        /// Tag description list.
        /// </summary>
        public InputMap<object> Tags
        {
            get => _tags ?? (_tags = new InputMap<object>());
            set => _tags = value;
        }

        /// <summary>
        /// The purchase duration of the prepaid monthly bandwidth package, unit: month, value range: 1~60.
        /// </summary>
        [Input("timeSpan")]
        public Input<int>? TimeSpan { get; set; }

        public BandwidthPackageState()
        {
        }
        public static new BandwidthPackageState Empty => new BandwidthPackageState();
    }
}