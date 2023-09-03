// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Dts
{
    [TencentcloudResourceType("tencentcloud:Dts/migrateJobConfig:MigrateJobConfig")]
    public partial class MigrateJobConfig : global::Pulumi.CustomResource
    {
        /// <summary>
        /// The operation want to perform. Valid values are: `pause`, `continue`, `complete`, `recover`,`stop`.
        /// </summary>
        [Output("action")]
        public Output<string> Action { get; private set; } = null!;

        /// <summary>
        /// complete mode, optional value is waitForSync or immediately.
        /// </summary>
        [Output("completeMode")]
        public Output<string?> CompleteMode { get; private set; } = null!;

        /// <summary>
        /// job id.
        /// </summary>
        [Output("jobId")]
        public Output<string> JobId { get; private set; } = null!;


        /// <summary>
        /// Create a MigrateJobConfig resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public MigrateJobConfig(string name, MigrateJobConfigArgs args, CustomResourceOptions? options = null)
            : base("tencentcloud:Dts/migrateJobConfig:MigrateJobConfig", name, args ?? new MigrateJobConfigArgs(), MakeResourceOptions(options, ""))
        {
        }

        private MigrateJobConfig(string name, Input<string> id, MigrateJobConfigState? state = null, CustomResourceOptions? options = null)
            : base("tencentcloud:Dts/migrateJobConfig:MigrateJobConfig", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing MigrateJobConfig resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static MigrateJobConfig Get(string name, Input<string> id, MigrateJobConfigState? state = null, CustomResourceOptions? options = null)
        {
            return new MigrateJobConfig(name, id, state, options);
        }
    }

    public sealed class MigrateJobConfigArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The operation want to perform. Valid values are: `pause`, `continue`, `complete`, `recover`,`stop`.
        /// </summary>
        [Input("action", required: true)]
        public Input<string> Action { get; set; } = null!;

        /// <summary>
        /// complete mode, optional value is waitForSync or immediately.
        /// </summary>
        [Input("completeMode")]
        public Input<string>? CompleteMode { get; set; }

        /// <summary>
        /// job id.
        /// </summary>
        [Input("jobId", required: true)]
        public Input<string> JobId { get; set; } = null!;

        public MigrateJobConfigArgs()
        {
        }
        public static new MigrateJobConfigArgs Empty => new MigrateJobConfigArgs();
    }

    public sealed class MigrateJobConfigState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The operation want to perform. Valid values are: `pause`, `continue`, `complete`, `recover`,`stop`.
        /// </summary>
        [Input("action")]
        public Input<string>? Action { get; set; }

        /// <summary>
        /// complete mode, optional value is waitForSync or immediately.
        /// </summary>
        [Input("completeMode")]
        public Input<string>? CompleteMode { get; set; }

        /// <summary>
        /// job id.
        /// </summary>
        [Input("jobId")]
        public Input<string>? JobId { get; set; }

        public MigrateJobConfigState()
        {
        }
        public static new MigrateJobConfigState Empty => new MigrateJobConfigState();
    }
}