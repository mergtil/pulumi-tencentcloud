// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Redis
{
    [TencentcloudResourceType("tencentcloud:Redis/startupInstanceOperation:StartupInstanceOperation")]
    public partial class StartupInstanceOperation : global::Pulumi.CustomResource
    {
        /// <summary>
        /// The ID of instance.
        /// </summary>
        [Output("instanceId")]
        public Output<string> InstanceId { get; private set; } = null!;


        /// <summary>
        /// Create a StartupInstanceOperation resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public StartupInstanceOperation(string name, StartupInstanceOperationArgs args, CustomResourceOptions? options = null)
            : base("tencentcloud:Redis/startupInstanceOperation:StartupInstanceOperation", name, args ?? new StartupInstanceOperationArgs(), MakeResourceOptions(options, ""))
        {
        }

        private StartupInstanceOperation(string name, Input<string> id, StartupInstanceOperationState? state = null, CustomResourceOptions? options = null)
            : base("tencentcloud:Redis/startupInstanceOperation:StartupInstanceOperation", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing StartupInstanceOperation resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static StartupInstanceOperation Get(string name, Input<string> id, StartupInstanceOperationState? state = null, CustomResourceOptions? options = null)
        {
            return new StartupInstanceOperation(name, id, state, options);
        }
    }

    public sealed class StartupInstanceOperationArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The ID of instance.
        /// </summary>
        [Input("instanceId", required: true)]
        public Input<string> InstanceId { get; set; } = null!;

        public StartupInstanceOperationArgs()
        {
        }
        public static new StartupInstanceOperationArgs Empty => new StartupInstanceOperationArgs();
    }

    public sealed class StartupInstanceOperationState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The ID of instance.
        /// </summary>
        [Input("instanceId")]
        public Input<string>? InstanceId { get; set; }

        public StartupInstanceOperationState()
        {
        }
        public static new StartupInstanceOperationState Empty => new StartupInstanceOperationState();
    }
}