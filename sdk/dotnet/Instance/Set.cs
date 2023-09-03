// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Instance
{
    [TencentcloudResourceType("tencentcloud:Instance/set:Set")]
    public partial class Set : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Associate a public IP address with an instance in a VPC or Classic. Boolean value, Default is false.
        /// </summary>
        [Output("allocatePublicIp")]
        public Output<bool?> AllocatePublicIp { get; private set; } = null!;

        /// <summary>
        /// The available zone for the CVM instance.
        /// </summary>
        [Output("availabilityZone")]
        public Output<string> AvailabilityZone { get; private set; } = null!;

        /// <summary>
        /// bandwidth package id. if user is standard user, then the bandwidth_package_id is needed, or default has
        /// bandwidth_package_id.
        /// </summary>
        [Output("bandwidthPackageId")]
        public Output<string?> BandwidthPackageId { get; private set; } = null!;

        /// <summary>
        /// CAM role name authorized to access.
        /// </summary>
        [Output("camRoleName")]
        public Output<string?> CamRoleName { get; private set; } = null!;

        /// <summary>
        /// Create time of the instance.
        /// </summary>
        [Output("createTime")]
        public Output<string> CreateTime { get; private set; } = null!;

        /// <summary>
        /// Disable enhance service for monitor, it is enabled by default. When this options is set, monitor agent won't be
        /// installed. Modifying will cause the instance reset.
        /// </summary>
        [Output("disableMonitorService")]
        public Output<bool?> DisableMonitorService { get; private set; } = null!;

        /// <summary>
        /// Disable enhance service for security, it is enabled by default. When this options is set, security agent won't be
        /// installed. Modifying will cause the instance reset.
        /// </summary>
        [Output("disableSecurityService")]
        public Output<bool?> DisableSecurityService { get; private set; } = null!;

        /// <summary>
        /// instance ids list to exclude.
        /// </summary>
        [Output("excludeInstanceIds")]
        public Output<ImmutableArray<string>> ExcludeInstanceIds { get; private set; } = null!;

        /// <summary>
        /// Expired time of the instance.
        /// </summary>
        [Output("expiredTime")]
        public Output<string> ExpiredTime { get; private set; } = null!;

        /// <summary>
        /// The hostname of the instance. Windows instance: The name should be a combination of 2 to 15 characters comprised of
        /// letters (case insensitive), numbers, and hyphens (-). Period (.) is not supported, and the name cannot be a string of
        /// pure numbers. Other types (such as Linux) of instances: The name should be a combination of 2 to 60 characters,
        /// supporting multiple periods (.). The piece between two periods is composed of letters (case insensitive), numbers, and
        /// hyphens (-). Modifying will cause the instance reset.
        /// </summary>
        [Output("hostname")]
        public Output<string?> Hostname { get; private set; } = null!;

        /// <summary>
        /// The image to use for the instance. Changing `image_id` will cause the instance reset.
        /// </summary>
        [Output("imageId")]
        public Output<string> ImageId { get; private set; } = null!;

        /// <summary>
        /// The charge type of instance. Only support `POSTPAID_BY_HOUR`.
        /// </summary>
        [Output("instanceChargeType")]
        public Output<string?> InstanceChargeType { get; private set; } = null!;

        /// <summary>
        /// The number of instances to be purchased. Value range:[1,100]; default value: 1.
        /// </summary>
        [Output("instanceCount")]
        public Output<int?> InstanceCount { get; private set; } = null!;

        /// <summary>
        /// instance id list.
        /// </summary>
        [Output("instanceIds")]
        public Output<ImmutableArray<string>> InstanceIds { get; private set; } = null!;

        /// <summary>
        /// The name of the instance. The max length of instance_name is 60, and default value is `Terraform-CVM-Instance`.
        /// </summary>
        [Output("instanceName")]
        public Output<string?> InstanceName { get; private set; } = null!;

        /// <summary>
        /// Current status of the instance.
        /// </summary>
        [Output("instanceStatus")]
        public Output<string> InstanceStatus { get; private set; } = null!;

        /// <summary>
        /// The type of the instance.
        /// </summary>
        [Output("instanceType")]
        public Output<string> InstanceType { get; private set; } = null!;

        /// <summary>
        /// Internet charge type of the instance, Valid values are `BANDWIDTH_PREPAID`, `TRAFFIC_POSTPAID_BY_HOUR`,
        /// `BANDWIDTH_POSTPAID_BY_HOUR` and `BANDWIDTH_PACKAGE`. This value does not need to be set when `allocate_public_ip` is
        /// false.
        /// </summary>
        [Output("internetChargeType")]
        public Output<string> InternetChargeType { get; private set; } = null!;

        /// <summary>
        /// Maximum outgoing bandwidth to the public network, measured in Mbps (Mega bits per second). This value does not need to
        /// be set when `allocate_public_ip` is false.
        /// </summary>
        [Output("internetMaxBandwidthOut")]
        public Output<int> InternetMaxBandwidthOut { get; private set; } = null!;

        /// <summary>
        /// Whether to keep image login or not, default is `false`. When the image type is private or shared or imported, this
        /// parameter can be set `true`. Modifying will cause the instance reset.
        /// </summary>
        [Output("keepImageLogin")]
        public Output<bool?> KeepImageLogin { get; private set; } = null!;

        /// <summary>
        /// The key pair to use for the instance, it looks like `skey-16jig7tx`. Modifying will cause the instance reset.
        /// </summary>
        [Output("keyName")]
        public Output<string> KeyName { get; private set; } = null!;

        /// <summary>
        /// Password for the instance. In order for the new password to take effect, the instance will be restarted after the
        /// password change. Modifying will cause the instance reset.
        /// </summary>
        [Output("password")]
        public Output<string?> Password { get; private set; } = null!;

        /// <summary>
        /// The ID of a placement group.
        /// </summary>
        [Output("placementGroupId")]
        public Output<string?> PlacementGroupId { get; private set; } = null!;

        /// <summary>
        /// The private IP to be assigned to this instance, must be in the provided subnet and available.
        /// </summary>
        [Output("privateIp")]
        public Output<string> PrivateIp { get; private set; } = null!;

        /// <summary>
        /// The project the instance belongs to, default to 0.
        /// </summary>
        [Output("projectId")]
        public Output<int?> ProjectId { get; private set; } = null!;

        /// <summary>
        /// Public IP of the instance.
        /// </summary>
        [Output("publicIp")]
        public Output<string> PublicIp { get; private set; } = null!;

        /// <summary>
        /// A list of security group IDs to associate with.
        /// </summary>
        [Output("securityGroups")]
        public Output<ImmutableArray<string>> SecurityGroups { get; private set; } = null!;

        /// <summary>
        /// The ID of a VPC subnet. If you want to create instances in a VPC network, this parameter must be set.
        /// </summary>
        [Output("subnetId")]
        public Output<string> SubnetId { get; private set; } = null!;

        /// <summary>
        /// System disk snapshot ID used to initialize the system disk. When system disk type is `LOCAL_BASIC` and `LOCAL_SSD`, disk
        /// id is not supported.
        /// </summary>
        [Output("systemDiskId")]
        public Output<string> SystemDiskId { get; private set; } = null!;

        /// <summary>
        /// Size of the system disk. Valid value ranges: (50~1000). and unit is GB. Default is 50GB. If modified, the instance may
        /// force stop.
        /// </summary>
        [Output("systemDiskSize")]
        public Output<int?> SystemDiskSize { get; private set; } = null!;

        /// <summary>
        /// System disk type. For more information on limits of system disk types, see [Storage
        /// Overview](https://intl.cloud.tencent.com/document/product/213/4952). Valid values: `LOCAL_BASIC`: local disk,
        /// `LOCAL_SSD`: local SSD disk, `CLOUD_SSD`: SSD, `CLOUD_PREMIUM`: Premium Cloud Storage, `CLOUD_BSSD`: Basic SSD. NOTE: If
        /// modified, the instance may force stop.
        /// </summary>
        [Output("systemDiskType")]
        public Output<string?> SystemDiskType { get; private set; } = null!;

        /// <summary>
        /// The user data to be injected into this instance. Must be base64 encoded and up to 16 KB.
        /// </summary>
        [Output("userData")]
        public Output<string?> UserData { get; private set; } = null!;

        /// <summary>
        /// The user data to be injected into this instance, in plain text. Conflicts with `user_data`. Up to 16 KB after base64
        /// encoded.
        /// </summary>
        [Output("userDataRaw")]
        public Output<string?> UserDataRaw { get; private set; } = null!;

        /// <summary>
        /// The ID of a VPC network. If you want to create instances in a VPC network, this parameter must be set.
        /// </summary>
        [Output("vpcId")]
        public Output<string> VpcId { get; private set; } = null!;


        /// <summary>
        /// Create a Set resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public Set(string name, SetArgs args, CustomResourceOptions? options = null)
            : base("tencentcloud:Instance/set:Set", name, args ?? new SetArgs(), MakeResourceOptions(options, ""))
        {
        }

        private Set(string name, Input<string> id, SetState? state = null, CustomResourceOptions? options = null)
            : base("tencentcloud:Instance/set:Set", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
                AdditionalSecretOutputs =
                {
                    "password",
                },
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing Set resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static Set Get(string name, Input<string> id, SetState? state = null, CustomResourceOptions? options = null)
        {
            return new Set(name, id, state, options);
        }
    }

    public sealed class SetArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Associate a public IP address with an instance in a VPC or Classic. Boolean value, Default is false.
        /// </summary>
        [Input("allocatePublicIp")]
        public Input<bool>? AllocatePublicIp { get; set; }

        /// <summary>
        /// The available zone for the CVM instance.
        /// </summary>
        [Input("availabilityZone", required: true)]
        public Input<string> AvailabilityZone { get; set; } = null!;

        /// <summary>
        /// bandwidth package id. if user is standard user, then the bandwidth_package_id is needed, or default has
        /// bandwidth_package_id.
        /// </summary>
        [Input("bandwidthPackageId")]
        public Input<string>? BandwidthPackageId { get; set; }

        /// <summary>
        /// CAM role name authorized to access.
        /// </summary>
        [Input("camRoleName")]
        public Input<string>? CamRoleName { get; set; }

        /// <summary>
        /// Disable enhance service for monitor, it is enabled by default. When this options is set, monitor agent won't be
        /// installed. Modifying will cause the instance reset.
        /// </summary>
        [Input("disableMonitorService")]
        public Input<bool>? DisableMonitorService { get; set; }

        /// <summary>
        /// Disable enhance service for security, it is enabled by default. When this options is set, security agent won't be
        /// installed. Modifying will cause the instance reset.
        /// </summary>
        [Input("disableSecurityService")]
        public Input<bool>? DisableSecurityService { get; set; }

        [Input("excludeInstanceIds")]
        private InputList<string>? _excludeInstanceIds;

        /// <summary>
        /// instance ids list to exclude.
        /// </summary>
        public InputList<string> ExcludeInstanceIds
        {
            get => _excludeInstanceIds ?? (_excludeInstanceIds = new InputList<string>());
            set => _excludeInstanceIds = value;
        }

        /// <summary>
        /// The hostname of the instance. Windows instance: The name should be a combination of 2 to 15 characters comprised of
        /// letters (case insensitive), numbers, and hyphens (-). Period (.) is not supported, and the name cannot be a string of
        /// pure numbers. Other types (such as Linux) of instances: The name should be a combination of 2 to 60 characters,
        /// supporting multiple periods (.). The piece between two periods is composed of letters (case insensitive), numbers, and
        /// hyphens (-). Modifying will cause the instance reset.
        /// </summary>
        [Input("hostname")]
        public Input<string>? Hostname { get; set; }

        /// <summary>
        /// The image to use for the instance. Changing `image_id` will cause the instance reset.
        /// </summary>
        [Input("imageId", required: true)]
        public Input<string> ImageId { get; set; } = null!;

        /// <summary>
        /// The charge type of instance. Only support `POSTPAID_BY_HOUR`.
        /// </summary>
        [Input("instanceChargeType")]
        public Input<string>? InstanceChargeType { get; set; }

        /// <summary>
        /// The number of instances to be purchased. Value range:[1,100]; default value: 1.
        /// </summary>
        [Input("instanceCount")]
        public Input<int>? InstanceCount { get; set; }

        /// <summary>
        /// The name of the instance. The max length of instance_name is 60, and default value is `Terraform-CVM-Instance`.
        /// </summary>
        [Input("instanceName")]
        public Input<string>? InstanceName { get; set; }

        /// <summary>
        /// The type of the instance.
        /// </summary>
        [Input("instanceType")]
        public Input<string>? InstanceType { get; set; }

        /// <summary>
        /// Internet charge type of the instance, Valid values are `BANDWIDTH_PREPAID`, `TRAFFIC_POSTPAID_BY_HOUR`,
        /// `BANDWIDTH_POSTPAID_BY_HOUR` and `BANDWIDTH_PACKAGE`. This value does not need to be set when `allocate_public_ip` is
        /// false.
        /// </summary>
        [Input("internetChargeType")]
        public Input<string>? InternetChargeType { get; set; }

        /// <summary>
        /// Maximum outgoing bandwidth to the public network, measured in Mbps (Mega bits per second). This value does not need to
        /// be set when `allocate_public_ip` is false.
        /// </summary>
        [Input("internetMaxBandwidthOut")]
        public Input<int>? InternetMaxBandwidthOut { get; set; }

        /// <summary>
        /// Whether to keep image login or not, default is `false`. When the image type is private or shared or imported, this
        /// parameter can be set `true`. Modifying will cause the instance reset.
        /// </summary>
        [Input("keepImageLogin")]
        public Input<bool>? KeepImageLogin { get; set; }

        /// <summary>
        /// The key pair to use for the instance, it looks like `skey-16jig7tx`. Modifying will cause the instance reset.
        /// </summary>
        [Input("keyName")]
        public Input<string>? KeyName { get; set; }

        [Input("password")]
        private Input<string>? _password;

        /// <summary>
        /// Password for the instance. In order for the new password to take effect, the instance will be restarted after the
        /// password change. Modifying will cause the instance reset.
        /// </summary>
        public Input<string>? Password
        {
            get => _password;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _password = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        /// <summary>
        /// The ID of a placement group.
        /// </summary>
        [Input("placementGroupId")]
        public Input<string>? PlacementGroupId { get; set; }

        /// <summary>
        /// The private IP to be assigned to this instance, must be in the provided subnet and available.
        /// </summary>
        [Input("privateIp")]
        public Input<string>? PrivateIp { get; set; }

        /// <summary>
        /// The project the instance belongs to, default to 0.
        /// </summary>
        [Input("projectId")]
        public Input<int>? ProjectId { get; set; }

        [Input("securityGroups")]
        private InputList<string>? _securityGroups;

        /// <summary>
        /// A list of security group IDs to associate with.
        /// </summary>
        public InputList<string> SecurityGroups
        {
            get => _securityGroups ?? (_securityGroups = new InputList<string>());
            set => _securityGroups = value;
        }

        /// <summary>
        /// The ID of a VPC subnet. If you want to create instances in a VPC network, this parameter must be set.
        /// </summary>
        [Input("subnetId")]
        public Input<string>? SubnetId { get; set; }

        /// <summary>
        /// System disk snapshot ID used to initialize the system disk. When system disk type is `LOCAL_BASIC` and `LOCAL_SSD`, disk
        /// id is not supported.
        /// </summary>
        [Input("systemDiskId")]
        public Input<string>? SystemDiskId { get; set; }

        /// <summary>
        /// Size of the system disk. Valid value ranges: (50~1000). and unit is GB. Default is 50GB. If modified, the instance may
        /// force stop.
        /// </summary>
        [Input("systemDiskSize")]
        public Input<int>? SystemDiskSize { get; set; }

        /// <summary>
        /// System disk type. For more information on limits of system disk types, see [Storage
        /// Overview](https://intl.cloud.tencent.com/document/product/213/4952). Valid values: `LOCAL_BASIC`: local disk,
        /// `LOCAL_SSD`: local SSD disk, `CLOUD_SSD`: SSD, `CLOUD_PREMIUM`: Premium Cloud Storage, `CLOUD_BSSD`: Basic SSD. NOTE: If
        /// modified, the instance may force stop.
        /// </summary>
        [Input("systemDiskType")]
        public Input<string>? SystemDiskType { get; set; }

        /// <summary>
        /// The user data to be injected into this instance. Must be base64 encoded and up to 16 KB.
        /// </summary>
        [Input("userData")]
        public Input<string>? UserData { get; set; }

        /// <summary>
        /// The user data to be injected into this instance, in plain text. Conflicts with `user_data`. Up to 16 KB after base64
        /// encoded.
        /// </summary>
        [Input("userDataRaw")]
        public Input<string>? UserDataRaw { get; set; }

        /// <summary>
        /// The ID of a VPC network. If you want to create instances in a VPC network, this parameter must be set.
        /// </summary>
        [Input("vpcId")]
        public Input<string>? VpcId { get; set; }

        public SetArgs()
        {
        }
        public static new SetArgs Empty => new SetArgs();
    }

    public sealed class SetState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Associate a public IP address with an instance in a VPC or Classic. Boolean value, Default is false.
        /// </summary>
        [Input("allocatePublicIp")]
        public Input<bool>? AllocatePublicIp { get; set; }

        /// <summary>
        /// The available zone for the CVM instance.
        /// </summary>
        [Input("availabilityZone")]
        public Input<string>? AvailabilityZone { get; set; }

        /// <summary>
        /// bandwidth package id. if user is standard user, then the bandwidth_package_id is needed, or default has
        /// bandwidth_package_id.
        /// </summary>
        [Input("bandwidthPackageId")]
        public Input<string>? BandwidthPackageId { get; set; }

        /// <summary>
        /// CAM role name authorized to access.
        /// </summary>
        [Input("camRoleName")]
        public Input<string>? CamRoleName { get; set; }

        /// <summary>
        /// Create time of the instance.
        /// </summary>
        [Input("createTime")]
        public Input<string>? CreateTime { get; set; }

        /// <summary>
        /// Disable enhance service for monitor, it is enabled by default. When this options is set, monitor agent won't be
        /// installed. Modifying will cause the instance reset.
        /// </summary>
        [Input("disableMonitorService")]
        public Input<bool>? DisableMonitorService { get; set; }

        /// <summary>
        /// Disable enhance service for security, it is enabled by default. When this options is set, security agent won't be
        /// installed. Modifying will cause the instance reset.
        /// </summary>
        [Input("disableSecurityService")]
        public Input<bool>? DisableSecurityService { get; set; }

        [Input("excludeInstanceIds")]
        private InputList<string>? _excludeInstanceIds;

        /// <summary>
        /// instance ids list to exclude.
        /// </summary>
        public InputList<string> ExcludeInstanceIds
        {
            get => _excludeInstanceIds ?? (_excludeInstanceIds = new InputList<string>());
            set => _excludeInstanceIds = value;
        }

        /// <summary>
        /// Expired time of the instance.
        /// </summary>
        [Input("expiredTime")]
        public Input<string>? ExpiredTime { get; set; }

        /// <summary>
        /// The hostname of the instance. Windows instance: The name should be a combination of 2 to 15 characters comprised of
        /// letters (case insensitive), numbers, and hyphens (-). Period (.) is not supported, and the name cannot be a string of
        /// pure numbers. Other types (such as Linux) of instances: The name should be a combination of 2 to 60 characters,
        /// supporting multiple periods (.). The piece between two periods is composed of letters (case insensitive), numbers, and
        /// hyphens (-). Modifying will cause the instance reset.
        /// </summary>
        [Input("hostname")]
        public Input<string>? Hostname { get; set; }

        /// <summary>
        /// The image to use for the instance. Changing `image_id` will cause the instance reset.
        /// </summary>
        [Input("imageId")]
        public Input<string>? ImageId { get; set; }

        /// <summary>
        /// The charge type of instance. Only support `POSTPAID_BY_HOUR`.
        /// </summary>
        [Input("instanceChargeType")]
        public Input<string>? InstanceChargeType { get; set; }

        /// <summary>
        /// The number of instances to be purchased. Value range:[1,100]; default value: 1.
        /// </summary>
        [Input("instanceCount")]
        public Input<int>? InstanceCount { get; set; }

        [Input("instanceIds")]
        private InputList<string>? _instanceIds;

        /// <summary>
        /// instance id list.
        /// </summary>
        public InputList<string> InstanceIds
        {
            get => _instanceIds ?? (_instanceIds = new InputList<string>());
            set => _instanceIds = value;
        }

        /// <summary>
        /// The name of the instance. The max length of instance_name is 60, and default value is `Terraform-CVM-Instance`.
        /// </summary>
        [Input("instanceName")]
        public Input<string>? InstanceName { get; set; }

        /// <summary>
        /// Current status of the instance.
        /// </summary>
        [Input("instanceStatus")]
        public Input<string>? InstanceStatus { get; set; }

        /// <summary>
        /// The type of the instance.
        /// </summary>
        [Input("instanceType")]
        public Input<string>? InstanceType { get; set; }

        /// <summary>
        /// Internet charge type of the instance, Valid values are `BANDWIDTH_PREPAID`, `TRAFFIC_POSTPAID_BY_HOUR`,
        /// `BANDWIDTH_POSTPAID_BY_HOUR` and `BANDWIDTH_PACKAGE`. This value does not need to be set when `allocate_public_ip` is
        /// false.
        /// </summary>
        [Input("internetChargeType")]
        public Input<string>? InternetChargeType { get; set; }

        /// <summary>
        /// Maximum outgoing bandwidth to the public network, measured in Mbps (Mega bits per second). This value does not need to
        /// be set when `allocate_public_ip` is false.
        /// </summary>
        [Input("internetMaxBandwidthOut")]
        public Input<int>? InternetMaxBandwidthOut { get; set; }

        /// <summary>
        /// Whether to keep image login or not, default is `false`. When the image type is private or shared or imported, this
        /// parameter can be set `true`. Modifying will cause the instance reset.
        /// </summary>
        [Input("keepImageLogin")]
        public Input<bool>? KeepImageLogin { get; set; }

        /// <summary>
        /// The key pair to use for the instance, it looks like `skey-16jig7tx`. Modifying will cause the instance reset.
        /// </summary>
        [Input("keyName")]
        public Input<string>? KeyName { get; set; }

        [Input("password")]
        private Input<string>? _password;

        /// <summary>
        /// Password for the instance. In order for the new password to take effect, the instance will be restarted after the
        /// password change. Modifying will cause the instance reset.
        /// </summary>
        public Input<string>? Password
        {
            get => _password;
            set
            {
                var emptySecret = Output.CreateSecret(0);
                _password = Output.Tuple<Input<string>?, int>(value, emptySecret).Apply(t => t.Item1);
            }
        }

        /// <summary>
        /// The ID of a placement group.
        /// </summary>
        [Input("placementGroupId")]
        public Input<string>? PlacementGroupId { get; set; }

        /// <summary>
        /// The private IP to be assigned to this instance, must be in the provided subnet and available.
        /// </summary>
        [Input("privateIp")]
        public Input<string>? PrivateIp { get; set; }

        /// <summary>
        /// The project the instance belongs to, default to 0.
        /// </summary>
        [Input("projectId")]
        public Input<int>? ProjectId { get; set; }

        /// <summary>
        /// Public IP of the instance.
        /// </summary>
        [Input("publicIp")]
        public Input<string>? PublicIp { get; set; }

        [Input("securityGroups")]
        private InputList<string>? _securityGroups;

        /// <summary>
        /// A list of security group IDs to associate with.
        /// </summary>
        public InputList<string> SecurityGroups
        {
            get => _securityGroups ?? (_securityGroups = new InputList<string>());
            set => _securityGroups = value;
        }

        /// <summary>
        /// The ID of a VPC subnet. If you want to create instances in a VPC network, this parameter must be set.
        /// </summary>
        [Input("subnetId")]
        public Input<string>? SubnetId { get; set; }

        /// <summary>
        /// System disk snapshot ID used to initialize the system disk. When system disk type is `LOCAL_BASIC` and `LOCAL_SSD`, disk
        /// id is not supported.
        /// </summary>
        [Input("systemDiskId")]
        public Input<string>? SystemDiskId { get; set; }

        /// <summary>
        /// Size of the system disk. Valid value ranges: (50~1000). and unit is GB. Default is 50GB. If modified, the instance may
        /// force stop.
        /// </summary>
        [Input("systemDiskSize")]
        public Input<int>? SystemDiskSize { get; set; }

        /// <summary>
        /// System disk type. For more information on limits of system disk types, see [Storage
        /// Overview](https://intl.cloud.tencent.com/document/product/213/4952). Valid values: `LOCAL_BASIC`: local disk,
        /// `LOCAL_SSD`: local SSD disk, `CLOUD_SSD`: SSD, `CLOUD_PREMIUM`: Premium Cloud Storage, `CLOUD_BSSD`: Basic SSD. NOTE: If
        /// modified, the instance may force stop.
        /// </summary>
        [Input("systemDiskType")]
        public Input<string>? SystemDiskType { get; set; }

        /// <summary>
        /// The user data to be injected into this instance. Must be base64 encoded and up to 16 KB.
        /// </summary>
        [Input("userData")]
        public Input<string>? UserData { get; set; }

        /// <summary>
        /// The user data to be injected into this instance, in plain text. Conflicts with `user_data`. Up to 16 KB after base64
        /// encoded.
        /// </summary>
        [Input("userDataRaw")]
        public Input<string>? UserDataRaw { get; set; }

        /// <summary>
        /// The ID of a VPC network. If you want to create instances in a VPC network, this parameter must be set.
        /// </summary>
        [Input("vpcId")]
        public Input<string>? VpcId { get; set; }

        public SetState()
        {
        }
        public static new SetState Empty => new SetState();
    }
}