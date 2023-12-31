// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Dayu
{
    public static class GetDdosPolicyAttachments
    {
        public static Task<GetDdosPolicyAttachmentsResult> InvokeAsync(GetDdosPolicyAttachmentsArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetDdosPolicyAttachmentsResult>("tencentcloud:Dayu/getDdosPolicyAttachments:getDdosPolicyAttachments", args ?? new GetDdosPolicyAttachmentsArgs(), options.WithDefaults());

        public static Output<GetDdosPolicyAttachmentsResult> Invoke(GetDdosPolicyAttachmentsInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetDdosPolicyAttachmentsResult>("tencentcloud:Dayu/getDdosPolicyAttachments:getDdosPolicyAttachments", args ?? new GetDdosPolicyAttachmentsInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetDdosPolicyAttachmentsArgs : global::Pulumi.InvokeArgs
    {
        [Input("policyId")]
        public string? PolicyId { get; set; }

        [Input("resourceId")]
        public string? ResourceId { get; set; }

        [Input("resourceType", required: true)]
        public string ResourceType { get; set; } = null!;

        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetDdosPolicyAttachmentsArgs()
        {
        }
        public static new GetDdosPolicyAttachmentsArgs Empty => new GetDdosPolicyAttachmentsArgs();
    }

    public sealed class GetDdosPolicyAttachmentsInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("policyId")]
        public Input<string>? PolicyId { get; set; }

        [Input("resourceId")]
        public Input<string>? ResourceId { get; set; }

        [Input("resourceType", required: true)]
        public Input<string> ResourceType { get; set; } = null!;

        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetDdosPolicyAttachmentsInvokeArgs()
        {
        }
        public static new GetDdosPolicyAttachmentsInvokeArgs Empty => new GetDdosPolicyAttachmentsInvokeArgs();
    }


    [OutputType]
    public sealed class GetDdosPolicyAttachmentsResult
    {
        public readonly ImmutableArray<Outputs.GetDdosPolicyAttachmentsDayuDdosPolicyAttachmentListResult> DayuDdosPolicyAttachmentLists;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string? PolicyId;
        public readonly string? ResourceId;
        public readonly string ResourceType;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetDdosPolicyAttachmentsResult(
            ImmutableArray<Outputs.GetDdosPolicyAttachmentsDayuDdosPolicyAttachmentListResult> dayuDdosPolicyAttachmentLists,

            string id,

            string? policyId,

            string? resourceId,

            string resourceType,

            string? resultOutputFile)
        {
            DayuDdosPolicyAttachmentLists = dayuDdosPolicyAttachmentLists;
            Id = id;
            PolicyId = policyId;
            ResourceId = resourceId;
            ResourceType = resourceType;
            ResultOutputFile = resultOutputFile;
        }
    }
}
