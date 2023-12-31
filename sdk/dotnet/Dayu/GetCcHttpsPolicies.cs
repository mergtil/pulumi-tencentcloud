// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Dayu
{
    public static class GetCcHttpsPolicies
    {
        public static Task<GetCcHttpsPoliciesResult> InvokeAsync(GetCcHttpsPoliciesArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetCcHttpsPoliciesResult>("tencentcloud:Dayu/getCcHttpsPolicies:getCcHttpsPolicies", args ?? new GetCcHttpsPoliciesArgs(), options.WithDefaults());

        public static Output<GetCcHttpsPoliciesResult> Invoke(GetCcHttpsPoliciesInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetCcHttpsPoliciesResult>("tencentcloud:Dayu/getCcHttpsPolicies:getCcHttpsPolicies", args ?? new GetCcHttpsPoliciesInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetCcHttpsPoliciesArgs : global::Pulumi.InvokeArgs
    {
        [Input("name")]
        public string? Name { get; set; }

        [Input("policyId")]
        public string? PolicyId { get; set; }

        [Input("resourceId", required: true)]
        public string ResourceId { get; set; } = null!;

        [Input("resourceType", required: true)]
        public string ResourceType { get; set; } = null!;

        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetCcHttpsPoliciesArgs()
        {
        }
        public static new GetCcHttpsPoliciesArgs Empty => new GetCcHttpsPoliciesArgs();
    }

    public sealed class GetCcHttpsPoliciesInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("policyId")]
        public Input<string>? PolicyId { get; set; }

        [Input("resourceId", required: true)]
        public Input<string> ResourceId { get; set; } = null!;

        [Input("resourceType", required: true)]
        public Input<string> ResourceType { get; set; } = null!;

        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetCcHttpsPoliciesInvokeArgs()
        {
        }
        public static new GetCcHttpsPoliciesInvokeArgs Empty => new GetCcHttpsPoliciesInvokeArgs();
    }


    [OutputType]
    public sealed class GetCcHttpsPoliciesResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly ImmutableArray<Outputs.GetCcHttpsPoliciesListResult> Lists;
        public readonly string? Name;
        public readonly string? PolicyId;
        public readonly string ResourceId;
        public readonly string ResourceType;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetCcHttpsPoliciesResult(
            string id,

            ImmutableArray<Outputs.GetCcHttpsPoliciesListResult> lists,

            string? name,

            string? policyId,

            string resourceId,

            string resourceType,

            string? resultOutputFile)
        {
            Id = id;
            Lists = lists;
            Name = name;
            PolicyId = policyId;
            ResourceId = resourceId;
            ResourceType = resourceType;
            ResultOutputFile = resultOutputFile;
        }
    }
}
