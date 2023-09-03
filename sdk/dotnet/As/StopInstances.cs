// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.As
{
    [TencentcloudResourceType("tencentcloud:As/stopInstances:StopInstances")]
    public partial class StopInstances : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Launch configuration ID.
        /// </summary>
        [Output("autoScalingGroupId")]
        public Output<string> AutoScalingGroupId { get; private set; } = null!;

        /// <summary>
        /// List of cvm instances to stop.
        /// </summary>
        [Output("instanceIds")]
        public Output<ImmutableArray<string>> InstanceIds { get; private set; } = null!;

        /// <summary>
        /// Billing method of a pay-as-you-go instance after shutdown. Available values: `KEEP_CHARGING`,`STOP_CHARGING`. Default
        /// `KEEP_CHARGING`.
        /// </summary>
        [Output("stoppedMode")]
        public Output<string?> StoppedMode { get; private set; } = null!;


        /// <summary>
        /// Create a StopInstances resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public StopInstances(string name, StopInstancesArgs args, CustomResourceOptions? options = null)
            : base("tencentcloud:As/stopInstances:StopInstances", name, args ?? new StopInstancesArgs(), MakeResourceOptions(options, ""))
        {
        }

        private StopInstances(string name, Input<string> id, StopInstancesState? state = null, CustomResourceOptions? options = null)
            : base("tencentcloud:As/stopInstances:StopInstances", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing StopInstances resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static StopInstances Get(string name, Input<string> id, StopInstancesState? state = null, CustomResourceOptions? options = null)
        {
            return new StopInstances(name, id, state, options);
        }
    }

    public sealed class StopInstancesArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Launch configuration ID.
        /// </summary>
        [Input("autoScalingGroupId", required: true)]
        public Input<string> AutoScalingGroupId { get; set; } = null!;

        [Input("instanceIds", required: true)]
        private InputList<string>? _instanceIds;

        /// <summary>
        /// List of cvm instances to stop.
        /// </summary>
        public InputList<string> InstanceIds
        {
            get => _instanceIds ?? (_instanceIds = new InputList<string>());
            set => _instanceIds = value;
        }

        /// <summary>
        /// Billing method of a pay-as-you-go instance after shutdown. Available values: `KEEP_CHARGING`,`STOP_CHARGING`. Default
        /// `KEEP_CHARGING`.
        /// </summary>
        [Input("stoppedMode")]
        public Input<string>? StoppedMode { get; set; }

        public StopInstancesArgs()
        {
        }
        public static new StopInstancesArgs Empty => new StopInstancesArgs();
    }

    public sealed class StopInstancesState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Launch configuration ID.
        /// </summary>
        [Input("autoScalingGroupId")]
        public Input<string>? AutoScalingGroupId { get; set; }

        [Input("instanceIds")]
        private InputList<string>? _instanceIds;

        /// <summary>
        /// List of cvm instances to stop.
        /// </summary>
        public InputList<string> InstanceIds
        {
            get => _instanceIds ?? (_instanceIds = new InputList<string>());
            set => _instanceIds = value;
        }

        /// <summary>
        /// Billing method of a pay-as-you-go instance after shutdown. Available values: `KEEP_CHARGING`,`STOP_CHARGING`. Default
        /// `KEEP_CHARGING`.
        /// </summary>
        [Input("stoppedMode")]
        public Input<string>? StoppedMode { get; set; }

        public StopInstancesState()
        {
        }
        public static new StopInstancesState Empty => new StopInstancesState();
    }
}