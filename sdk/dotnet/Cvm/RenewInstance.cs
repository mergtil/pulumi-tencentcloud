// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Cvm
{
    [TencentcloudResourceType("tencentcloud:Cvm/renewInstance:RenewInstance")]
    public partial class RenewInstance : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Prepaid mode, that is, yearly and monthly subscription related parameter settings. Through this parameter, you can
        /// specify the renewal duration of the Subscription instance, whether to set automatic renewal, and other attributes. For
        /// yearly and monthly subscription instances, this parameter is required.
        /// </summary>
        [Output("instanceChargePrepaid")]
        public Output<Outputs.RenewInstanceInstanceChargePrepaid?> InstanceChargePrepaid { get; private set; } = null!;

        /// <summary>
        /// Instance ID.
        /// </summary>
        [Output("instanceId")]
        public Output<string> InstanceId { get; private set; } = null!;

        /// <summary>
        /// Whether to renew the elastic data disk. Valid values: - `TRUE`: Indicates to renew the subscription instance and renew
        /// the attached elastic data disk at the same time - `FALSE`: Indicates that the subscription instance will be renewed and
        /// the elastic data disk attached to it will not be renewed Default value: TRUE.
        /// </summary>
        [Output("renewPortableDataDisk")]
        public Output<bool?> RenewPortableDataDisk { get; private set; } = null!;


        /// <summary>
        /// Create a RenewInstance resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public RenewInstance(string name, RenewInstanceArgs args, CustomResourceOptions? options = null)
            : base("tencentcloud:Cvm/renewInstance:RenewInstance", name, args ?? new RenewInstanceArgs(), MakeResourceOptions(options, ""))
        {
        }

        private RenewInstance(string name, Input<string> id, RenewInstanceState? state = null, CustomResourceOptions? options = null)
            : base("tencentcloud:Cvm/renewInstance:RenewInstance", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing RenewInstance resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static RenewInstance Get(string name, Input<string> id, RenewInstanceState? state = null, CustomResourceOptions? options = null)
        {
            return new RenewInstance(name, id, state, options);
        }
    }

    public sealed class RenewInstanceArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Prepaid mode, that is, yearly and monthly subscription related parameter settings. Through this parameter, you can
        /// specify the renewal duration of the Subscription instance, whether to set automatic renewal, and other attributes. For
        /// yearly and monthly subscription instances, this parameter is required.
        /// </summary>
        [Input("instanceChargePrepaid")]
        public Input<Inputs.RenewInstanceInstanceChargePrepaidArgs>? InstanceChargePrepaid { get; set; }

        /// <summary>
        /// Instance ID.
        /// </summary>
        [Input("instanceId", required: true)]
        public Input<string> InstanceId { get; set; } = null!;

        /// <summary>
        /// Whether to renew the elastic data disk. Valid values: - `TRUE`: Indicates to renew the subscription instance and renew
        /// the attached elastic data disk at the same time - `FALSE`: Indicates that the subscription instance will be renewed and
        /// the elastic data disk attached to it will not be renewed Default value: TRUE.
        /// </summary>
        [Input("renewPortableDataDisk")]
        public Input<bool>? RenewPortableDataDisk { get; set; }

        public RenewInstanceArgs()
        {
        }
        public static new RenewInstanceArgs Empty => new RenewInstanceArgs();
    }

    public sealed class RenewInstanceState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Prepaid mode, that is, yearly and monthly subscription related parameter settings. Through this parameter, you can
        /// specify the renewal duration of the Subscription instance, whether to set automatic renewal, and other attributes. For
        /// yearly and monthly subscription instances, this parameter is required.
        /// </summary>
        [Input("instanceChargePrepaid")]
        public Input<Inputs.RenewInstanceInstanceChargePrepaidGetArgs>? InstanceChargePrepaid { get; set; }

        /// <summary>
        /// Instance ID.
        /// </summary>
        [Input("instanceId")]
        public Input<string>? InstanceId { get; set; }

        /// <summary>
        /// Whether to renew the elastic data disk. Valid values: - `TRUE`: Indicates to renew the subscription instance and renew
        /// the attached elastic data disk at the same time - `FALSE`: Indicates that the subscription instance will be renewed and
        /// the elastic data disk attached to it will not be renewed Default value: TRUE.
        /// </summary>
        [Input("renewPortableDataDisk")]
        public Input<bool>? RenewPortableDataDisk { get; set; }

        public RenewInstanceState()
        {
        }
        public static new RenewInstanceState Empty => new RenewInstanceState();
    }
}