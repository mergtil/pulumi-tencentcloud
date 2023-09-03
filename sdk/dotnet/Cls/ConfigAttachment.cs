// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Cls
{
    [TencentcloudResourceType("tencentcloud:Cls/configAttachment:ConfigAttachment")]
    public partial class ConfigAttachment : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Collection configuration id.
        /// </summary>
        [Output("configId")]
        public Output<string> ConfigId { get; private set; } = null!;

        /// <summary>
        /// Machine group id.
        /// </summary>
        [Output("groupId")]
        public Output<string> GroupId { get; private set; } = null!;


        /// <summary>
        /// Create a ConfigAttachment resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ConfigAttachment(string name, ConfigAttachmentArgs args, CustomResourceOptions? options = null)
            : base("tencentcloud:Cls/configAttachment:ConfigAttachment", name, args ?? new ConfigAttachmentArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ConfigAttachment(string name, Input<string> id, ConfigAttachmentState? state = null, CustomResourceOptions? options = null)
            : base("tencentcloud:Cls/configAttachment:ConfigAttachment", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing ConfigAttachment resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ConfigAttachment Get(string name, Input<string> id, ConfigAttachmentState? state = null, CustomResourceOptions? options = null)
        {
            return new ConfigAttachment(name, id, state, options);
        }
    }

    public sealed class ConfigAttachmentArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Collection configuration id.
        /// </summary>
        [Input("configId", required: true)]
        public Input<string> ConfigId { get; set; } = null!;

        /// <summary>
        /// Machine group id.
        /// </summary>
        [Input("groupId", required: true)]
        public Input<string> GroupId { get; set; } = null!;

        public ConfigAttachmentArgs()
        {
        }
        public static new ConfigAttachmentArgs Empty => new ConfigAttachmentArgs();
    }

    public sealed class ConfigAttachmentState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Collection configuration id.
        /// </summary>
        [Input("configId")]
        public Input<string>? ConfigId { get; set; }

        /// <summary>
        /// Machine group id.
        /// </summary>
        [Input("groupId")]
        public Input<string>? GroupId { get; set; }

        public ConfigAttachmentState()
        {
        }
        public static new ConfigAttachmentState Empty => new ConfigAttachmentState();
    }
}