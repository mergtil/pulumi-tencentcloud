// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Dayu
{
    public static class GetEip
    {
        public static Task<GetEipResult> InvokeAsync(GetEipArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetEipResult>("tencentcloud:Dayu/getEip:getEip", args ?? new GetEipArgs(), options.WithDefaults());

        public static Output<GetEipResult> Invoke(GetEipInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetEipResult>("tencentcloud:Dayu/getEip:getEip", args ?? new GetEipInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetEipArgs : global::Pulumi.InvokeArgs
    {
        [Input("bindStatuses")]
        private List<string>? _bindStatuses;
        public List<string> BindStatuses
        {
            get => _bindStatuses ?? (_bindStatuses = new List<string>());
            set => _bindStatuses = value;
        }

        [Input("limit")]
        public int? Limit { get; set; }

        [Input("offset")]
        public int? Offset { get; set; }

        [Input("resourceId", required: true)]
        public string ResourceId { get; set; } = null!;

        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetEipArgs()
        {
        }
        public static new GetEipArgs Empty => new GetEipArgs();
    }

    public sealed class GetEipInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("bindStatuses")]
        private InputList<string>? _bindStatuses;
        public InputList<string> BindStatuses
        {
            get => _bindStatuses ?? (_bindStatuses = new InputList<string>());
            set => _bindStatuses = value;
        }

        [Input("limit")]
        public Input<int>? Limit { get; set; }

        [Input("offset")]
        public Input<int>? Offset { get; set; }

        [Input("resourceId", required: true)]
        public Input<string> ResourceId { get; set; } = null!;

        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetEipInvokeArgs()
        {
        }
        public static new GetEipInvokeArgs Empty => new GetEipInvokeArgs();
    }


    [OutputType]
    public sealed class GetEipResult
    {
        public readonly ImmutableArray<string> BindStatuses;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly int? Limit;
        public readonly ImmutableArray<Outputs.GetEipListResult> Lists;
        public readonly int? Offset;
        public readonly string ResourceId;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetEipResult(
            ImmutableArray<string> bindStatuses,

            string id,

            int? limit,

            ImmutableArray<Outputs.GetEipListResult> lists,

            int? offset,

            string resourceId,

            string? resultOutputFile)
        {
            BindStatuses = bindStatuses;
            Id = id;
            Limit = limit;
            Lists = lists;
            Offset = offset;
            ResourceId = resourceId;
            ResultOutputFile = resultOutputFile;
        }
    }
}
