// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Eip
{
    [TencentcloudResourceType("tencentcloud:Eip/eip:Eip")]
    public partial class Eip : global::Pulumi.CustomResource
    {
        /// <summary>
        /// ID of anti DDos package, it must set when `type` is `AntiDDoSEIP`.
        /// </summary>
        [Output("antiDdosPackageId")]
        public Output<string> AntiDdosPackageId { get; private set; } = null!;

        /// <summary>
        /// The zone of anycast. Valid value: `ANYCAST_ZONE_GLOBAL` and `ANYCAST_ZONE_OVERSEAS`.
        /// </summary>
        [Output("anycastZone")]
        public Output<string?> AnycastZone { get; private set; } = null!;

        /// <summary>
        /// Indicates whether the anycast eip can be associated to a CLB.
        /// </summary>
        [Output("applicableForClb")]
        public Output<bool?> ApplicableForClb { get; private set; } = null!;

        /// <summary>
        /// Auto renew flag. 0 - default state (manual renew); 1 - automatic renew; 2 - explicit no automatic renew. NOTES: Only
        /// supported prepaid EIP.
        /// </summary>
        [Output("autoRenewFlag")]
        public Output<int?> AutoRenewFlag { get; private set; } = null!;

        /// <summary>
        /// ID of bandwidth package, it will set when `internet_charge_type` is `BANDWIDTH_PACKAGE`.
        /// </summary>
        [Output("bandwidthPackageId")]
        public Output<string> BandwidthPackageId { get; private set; } = null!;

        /// <summary>
        /// The charge type of eip. Valid values: `BANDWIDTH_PACKAGE`, `BANDWIDTH_POSTPAID_BY_HOUR`, `BANDWIDTH_PREPAID_BY_MONTH`
        /// and `TRAFFIC_POSTPAID_BY_HOUR`.
        /// </summary>
        [Output("internetChargeType")]
        public Output<string> InternetChargeType { get; private set; } = null!;

        /// <summary>
        /// The bandwidth limit of EIP, unit is Mbps.
        /// </summary>
        [Output("internetMaxBandwidthOut")]
        public Output<int> InternetMaxBandwidthOut { get; private set; } = null!;

        /// <summary>
        /// Internet service provider of eip. Valid value: `BGP`, `CMCC`, `CTCC` and `CUCC`.
        /// </summary>
        [Output("internetServiceProvider")]
        public Output<string?> InternetServiceProvider { get; private set; } = null!;

        /// <summary>
        /// The name of eip.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// Period of instance. Default value: `1`. Valid value: `1`, `2`, `3`, `4`, `6`, `7`, `8`, `9`, `12`, `24`, `36`. NOTES:
        /// must set when `internet_charge_type` is `BANDWIDTH_PREPAID_BY_MONTH`.
        /// </summary>
        [Output("prepaidPeriod")]
        public Output<int?> PrepaidPeriod { get; private set; } = null!;

        /// <summary>
        /// The elastic IP address.
        /// </summary>
        [Output("publicIp")]
        public Output<string> PublicIp { get; private set; } = null!;

        /// <summary>
        /// The EIP current status.
        /// </summary>
        [Output("status")]
        public Output<string> Status { get; private set; } = null!;

        /// <summary>
        /// The tags of eip.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableDictionary<string, object>?> Tags { get; private set; } = null!;

        /// <summary>
        /// The type of eip. Valid value: `EIP` and `AnycastEIP` and `HighQualityEIP` and `AntiDDoSEIP`. Default is `EIP`.
        /// </summary>
        [Output("type")]
        public Output<string?> Type { get; private set; } = null!;


        /// <summary>
        /// Create a Eip resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Eip(string name, EipArgs? args = null, CustomResourceOptions? options = null)
            : base("tencentcloud:Eip/eip:Eip", name, args ?? new EipArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Eip(string name, Input<string> id, EipState? state = null, CustomResourceOptions? options = null)
            : base("tencentcloud:Eip/eip:Eip", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing Eip resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Eip Get(string name, Input<string> id, EipState? state = null, CustomResourceOptions? options = null)
        {
            return new Eip(name, id, state, options);
        }
    }

    public sealed class EipArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// ID of anti DDos package, it must set when `type` is `AntiDDoSEIP`.
        /// </summary>
        [Input("antiDdosPackageId")]
        public Input<string>? AntiDdosPackageId { get; set; }

        /// <summary>
        /// The zone of anycast. Valid value: `ANYCAST_ZONE_GLOBAL` and `ANYCAST_ZONE_OVERSEAS`.
        /// </summary>
        [Input("anycastZone")]
        public Input<string>? AnycastZone { get; set; }

        /// <summary>
        /// Indicates whether the anycast eip can be associated to a CLB.
        /// </summary>
        [Input("applicableForClb")]
        public Input<bool>? ApplicableForClb { get; set; }

        /// <summary>
        /// Auto renew flag. 0 - default state (manual renew); 1 - automatic renew; 2 - explicit no automatic renew. NOTES: Only
        /// supported prepaid EIP.
        /// </summary>
        [Input("autoRenewFlag")]
        public Input<int>? AutoRenewFlag { get; set; }

        /// <summary>
        /// ID of bandwidth package, it will set when `internet_charge_type` is `BANDWIDTH_PACKAGE`.
        /// </summary>
        [Input("bandwidthPackageId")]
        public Input<string>? BandwidthPackageId { get; set; }

        /// <summary>
        /// The charge type of eip. Valid values: `BANDWIDTH_PACKAGE`, `BANDWIDTH_POSTPAID_BY_HOUR`, `BANDWIDTH_PREPAID_BY_MONTH`
        /// and `TRAFFIC_POSTPAID_BY_HOUR`.
        /// </summary>
        [Input("internetChargeType")]
        public Input<string>? InternetChargeType { get; set; }

        /// <summary>
        /// The bandwidth limit of EIP, unit is Mbps.
        /// </summary>
        [Input("internetMaxBandwidthOut")]
        public Input<int>? InternetMaxBandwidthOut { get; set; }

        /// <summary>
        /// Internet service provider of eip. Valid value: `BGP`, `CMCC`, `CTCC` and `CUCC`.
        /// </summary>
        [Input("internetServiceProvider")]
        public Input<string>? InternetServiceProvider { get; set; }

        /// <summary>
        /// The name of eip.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Period of instance. Default value: `1`. Valid value: `1`, `2`, `3`, `4`, `6`, `7`, `8`, `9`, `12`, `24`, `36`. NOTES:
        /// must set when `internet_charge_type` is `BANDWIDTH_PREPAID_BY_MONTH`.
        /// </summary>
        [Input("prepaidPeriod")]
        public Input<int>? PrepaidPeriod { get; set; }

        [Input("tags")]
        private InputMap<object>? _tags;

        /// <summary>
        /// The tags of eip.
        /// </summary>
        public InputMap<object> Tags
        {
            get => _tags ?? (_tags = new InputMap<object>());
            set => _tags = value;
        }

        /// <summary>
        /// The type of eip. Valid value: `EIP` and `AnycastEIP` and `HighQualityEIP` and `AntiDDoSEIP`. Default is `EIP`.
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        public EipArgs()
        {
        }
        public static new EipArgs Empty => new EipArgs();
    }

    public sealed class EipState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// ID of anti DDos package, it must set when `type` is `AntiDDoSEIP`.
        /// </summary>
        [Input("antiDdosPackageId")]
        public Input<string>? AntiDdosPackageId { get; set; }

        /// <summary>
        /// The zone of anycast. Valid value: `ANYCAST_ZONE_GLOBAL` and `ANYCAST_ZONE_OVERSEAS`.
        /// </summary>
        [Input("anycastZone")]
        public Input<string>? AnycastZone { get; set; }

        /// <summary>
        /// Indicates whether the anycast eip can be associated to a CLB.
        /// </summary>
        [Input("applicableForClb")]
        public Input<bool>? ApplicableForClb { get; set; }

        /// <summary>
        /// Auto renew flag. 0 - default state (manual renew); 1 - automatic renew; 2 - explicit no automatic renew. NOTES: Only
        /// supported prepaid EIP.
        /// </summary>
        [Input("autoRenewFlag")]
        public Input<int>? AutoRenewFlag { get; set; }

        /// <summary>
        /// ID of bandwidth package, it will set when `internet_charge_type` is `BANDWIDTH_PACKAGE`.
        /// </summary>
        [Input("bandwidthPackageId")]
        public Input<string>? BandwidthPackageId { get; set; }

        /// <summary>
        /// The charge type of eip. Valid values: `BANDWIDTH_PACKAGE`, `BANDWIDTH_POSTPAID_BY_HOUR`, `BANDWIDTH_PREPAID_BY_MONTH`
        /// and `TRAFFIC_POSTPAID_BY_HOUR`.
        /// </summary>
        [Input("internetChargeType")]
        public Input<string>? InternetChargeType { get; set; }

        /// <summary>
        /// The bandwidth limit of EIP, unit is Mbps.
        /// </summary>
        [Input("internetMaxBandwidthOut")]
        public Input<int>? InternetMaxBandwidthOut { get; set; }

        /// <summary>
        /// Internet service provider of eip. Valid value: `BGP`, `CMCC`, `CTCC` and `CUCC`.
        /// </summary>
        [Input("internetServiceProvider")]
        public Input<string>? InternetServiceProvider { get; set; }

        /// <summary>
        /// The name of eip.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// Period of instance. Default value: `1`. Valid value: `1`, `2`, `3`, `4`, `6`, `7`, `8`, `9`, `12`, `24`, `36`. NOTES:
        /// must set when `internet_charge_type` is `BANDWIDTH_PREPAID_BY_MONTH`.
        /// </summary>
        [Input("prepaidPeriod")]
        public Input<int>? PrepaidPeriod { get; set; }

        /// <summary>
        /// The elastic IP address.
        /// </summary>
        [Input("publicIp")]
        public Input<string>? PublicIp { get; set; }

        /// <summary>
        /// The EIP current status.
        /// </summary>
        [Input("status")]
        public Input<string>? Status { get; set; }

        [Input("tags")]
        private InputMap<object>? _tags;

        /// <summary>
        /// The tags of eip.
        /// </summary>
        public InputMap<object> Tags
        {
            get => _tags ?? (_tags = new InputMap<object>());
            set => _tags = value;
        }

        /// <summary>
        /// The type of eip. Valid value: `EIP` and `AnycastEIP` and `HighQualityEIP` and `AntiDDoSEIP`. Default is `EIP`.
        /// </summary>
        [Input("type")]
        public Input<string>? Type { get; set; }

        public EipState()
        {
        }
        public static new EipState Empty => new EipState();
    }
}