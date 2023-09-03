// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Mysql
{
    [TencentcloudResourceType("tencentcloud:Mysql/deployGroup:DeployGroup")]
    public partial class DeployGroup : global::Pulumi.CustomResource
    {
        /// <summary>
        /// The name of deploy group. the maximum length cannot exceed 60 characters.
        /// </summary>
        [Output("deployGroupName")]
        public Output<string> DeployGroupName { get; private set; } = null!;

        /// <summary>
        /// The description of deploy group. the maximum length cannot exceed 200 characters.
        /// </summary>
        [Output("description")]
        public Output<string?> Description { get; private set; } = null!;

        /// <summary>
        /// The device class of deploy group. optional value is SH12+SH02, TS85, etc.
        /// </summary>
        [Output("devClasses")]
        public Output<ImmutableArray<string>> DevClasses { get; private set; } = null!;

        /// <summary>
        /// The limit on the number of instances on the same physical machine in deploy group affinity policy 1.
        /// </summary>
        [Output("limitNum")]
        public Output<int?> LimitNum { get; private set; } = null!;


        /// <summary>
        /// Create a DeployGroup resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public DeployGroup(string name, DeployGroupArgs args, CustomResourceOptions? options = null)
            : base("tencentcloud:Mysql/deployGroup:DeployGroup", name, args ?? new DeployGroupArgs(), MakeResourceOptions(options, ""))
        {
        }

        private DeployGroup(string name, Input<string> id, DeployGroupState? state = null, CustomResourceOptions? options = null)
            : base("tencentcloud:Mysql/deployGroup:DeployGroup", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing DeployGroup resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static DeployGroup Get(string name, Input<string> id, DeployGroupState? state = null, CustomResourceOptions? options = null)
        {
            return new DeployGroup(name, id, state, options);
        }
    }

    public sealed class DeployGroupArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of deploy group. the maximum length cannot exceed 60 characters.
        /// </summary>
        [Input("deployGroupName", required: true)]
        public Input<string> DeployGroupName { get; set; } = null!;

        /// <summary>
        /// The description of deploy group. the maximum length cannot exceed 200 characters.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("devClasses")]
        private InputList<string>? _devClasses;

        /// <summary>
        /// The device class of deploy group. optional value is SH12+SH02, TS85, etc.
        /// </summary>
        public InputList<string> DevClasses
        {
            get => _devClasses ?? (_devClasses = new InputList<string>());
            set => _devClasses = value;
        }

        /// <summary>
        /// The limit on the number of instances on the same physical machine in deploy group affinity policy 1.
        /// </summary>
        [Input("limitNum")]
        public Input<int>? LimitNum { get; set; }

        public DeployGroupArgs()
        {
        }
        public static new DeployGroupArgs Empty => new DeployGroupArgs();
    }

    public sealed class DeployGroupState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The name of deploy group. the maximum length cannot exceed 60 characters.
        /// </summary>
        [Input("deployGroupName")]
        public Input<string>? DeployGroupName { get; set; }

        /// <summary>
        /// The description of deploy group. the maximum length cannot exceed 200 characters.
        /// </summary>
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("devClasses")]
        private InputList<string>? _devClasses;

        /// <summary>
        /// The device class of deploy group. optional value is SH12+SH02, TS85, etc.
        /// </summary>
        public InputList<string> DevClasses
        {
            get => _devClasses ?? (_devClasses = new InputList<string>());
            set => _devClasses = value;
        }

        /// <summary>
        /// The limit on the number of instances on the same physical machine in deploy group affinity policy 1.
        /// </summary>
        [Input("limitNum")]
        public Input<int>? LimitNum { get; set; }

        public DeployGroupState()
        {
        }
        public static new DeployGroupState Empty => new DeployGroupState();
    }
}