// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.ApiGateway
{
    [TencentcloudResourceType("tencentcloud:ApiGateway/apiAppAttachment:ApiAppAttachment")]
    public partial class ApiAppAttachment : global::Pulumi.CustomResource
    {
        /// <summary>
        /// The unique ID of the application to be bound.
        /// </summary>
        [Output("apiAppId")]
        public Output<string> ApiAppId { get; private set; } = null!;

        /// <summary>
        /// The unique ID of the API to be bound.
        /// </summary>
        [Output("apiId")]
        public Output<string> ApiId { get; private set; } = null!;

        /// <summary>
        /// The environment to be bound.
        /// </summary>
        [Output("environment")]
        public Output<string> Environment { get; private set; } = null!;

        /// <summary>
        /// The unique ID of the service to be bound.
        /// </summary>
        [Output("serviceId")]
        public Output<string> ServiceId { get; private set; } = null!;


        /// <summary>
        /// Create a ApiAppAttachment resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public ApiAppAttachment(string name, ApiAppAttachmentArgs args, CustomResourceOptions? options = null)
            : base("tencentcloud:ApiGateway/apiAppAttachment:ApiAppAttachment", name, args ?? new ApiAppAttachmentArgs(), MakeResourceOptions(options, ""))
        {
        }

        private ApiAppAttachment(string name, Input<string> id, ApiAppAttachmentState? state = null, CustomResourceOptions? options = null)
            : base("tencentcloud:ApiGateway/apiAppAttachment:ApiAppAttachment", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing ApiAppAttachment resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static ApiAppAttachment Get(string name, Input<string> id, ApiAppAttachmentState? state = null, CustomResourceOptions? options = null)
        {
            return new ApiAppAttachment(name, id, state, options);
        }
    }

    public sealed class ApiAppAttachmentArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The unique ID of the application to be bound.
        /// </summary>
        [Input("apiAppId", required: true)]
        public Input<string> ApiAppId { get; set; } = null!;

        /// <summary>
        /// The unique ID of the API to be bound.
        /// </summary>
        [Input("apiId", required: true)]
        public Input<string> ApiId { get; set; } = null!;

        /// <summary>
        /// The environment to be bound.
        /// </summary>
        [Input("environment", required: true)]
        public Input<string> Environment { get; set; } = null!;

        /// <summary>
        /// The unique ID of the service to be bound.
        /// </summary>
        [Input("serviceId", required: true)]
        public Input<string> ServiceId { get; set; } = null!;

        public ApiAppAttachmentArgs()
        {
        }
        public static new ApiAppAttachmentArgs Empty => new ApiAppAttachmentArgs();
    }

    public sealed class ApiAppAttachmentState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The unique ID of the application to be bound.
        /// </summary>
        [Input("apiAppId")]
        public Input<string>? ApiAppId { get; set; }

        /// <summary>
        /// The unique ID of the API to be bound.
        /// </summary>
        [Input("apiId")]
        public Input<string>? ApiId { get; set; }

        /// <summary>
        /// The environment to be bound.
        /// </summary>
        [Input("environment")]
        public Input<string>? Environment { get; set; }

        /// <summary>
        /// The unique ID of the service to be bound.
        /// </summary>
        [Input("serviceId")]
        public Input<string>? ServiceId { get; set; }

        public ApiAppAttachmentState()
        {
        }
        public static new ApiAppAttachmentState Empty => new ApiAppAttachmentState();
    }
}