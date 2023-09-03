// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Ci
{
    [TencentcloudResourceType("tencentcloud:Ci/bucketAttachment:BucketAttachment")]
    public partial class BucketAttachment : global::Pulumi.CustomResource
    {
        /// <summary>
        /// bucket name.
        /// </summary>
        [Output("bucket")]
        public Output<string> Bucket { get; private set; } = null!;

        /// <summary>
        /// Binding object storage state, `on`: bound, `off`: unbound, `unbinding`: unbinding.
        /// </summary>
        [Output("ciStatus")]
        public Output<string> CiStatus { get; private set; } = null!;


        /// <summary>
        /// Create a BucketAttachment resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public BucketAttachment(string name, BucketAttachmentArgs args, CustomResourceOptions? options = null)
            : base("tencentcloud:Ci/bucketAttachment:BucketAttachment", name, args ?? new BucketAttachmentArgs(), MakeResourceOptions(options, ""))
        {
        }

        private BucketAttachment(string name, Input<string> id, BucketAttachmentState? state = null, CustomResourceOptions? options = null)
            : base("tencentcloud:Ci/bucketAttachment:BucketAttachment", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing BucketAttachment resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static BucketAttachment Get(string name, Input<string> id, BucketAttachmentState? state = null, CustomResourceOptions? options = null)
        {
            return new BucketAttachment(name, id, state, options);
        }
    }

    public sealed class BucketAttachmentArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// bucket name.
        /// </summary>
        [Input("bucket", required: true)]
        public Input<string> Bucket { get; set; } = null!;

        public BucketAttachmentArgs()
        {
        }
        public static new BucketAttachmentArgs Empty => new BucketAttachmentArgs();
    }

    public sealed class BucketAttachmentState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// bucket name.
        /// </summary>
        [Input("bucket")]
        public Input<string>? Bucket { get; set; }

        /// <summary>
        /// Binding object storage state, `on`: bound, `off`: unbound, `unbinding`: unbinding.
        /// </summary>
        [Input("ciStatus")]
        public Input<string>? CiStatus { get; set; }

        public BucketAttachmentState()
        {
        }
        public static new BucketAttachmentState Empty => new BucketAttachmentState();
    }
}