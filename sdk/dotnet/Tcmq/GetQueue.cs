// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Tcmq
{
    public static class GetQueue
    {
        public static Task<GetQueueResult> InvokeAsync(GetQueueArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetQueueResult>("tencentcloud:Tcmq/getQueue:getQueue", args ?? new GetQueueArgs(), options.WithDefaults());

        public static Output<GetQueueResult> Invoke(GetQueueInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetQueueResult>("tencentcloud:Tcmq/getQueue:getQueue", args ?? new GetQueueInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetQueueArgs : global::Pulumi.InvokeArgs
    {
        [Input("filters")]
        private List<Inputs.GetQueueFilterArgs>? _filters;
        public List<Inputs.GetQueueFilterArgs> Filters
        {
            get => _filters ?? (_filters = new List<Inputs.GetQueueFilterArgs>());
            set => _filters = value;
        }

        [Input("isTagFilter")]
        public bool? IsTagFilter { get; set; }

        [Input("limit")]
        public int? Limit { get; set; }

        [Input("offset")]
        public int? Offset { get; set; }

        [Input("queueName")]
        public string? QueueName { get; set; }

        [Input("queueNameLists")]
        private List<string>? _queueNameLists;
        public List<string> QueueNameLists
        {
            get => _queueNameLists ?? (_queueNameLists = new List<string>());
            set => _queueNameLists = value;
        }

        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetQueueArgs()
        {
        }
        public static new GetQueueArgs Empty => new GetQueueArgs();
    }

    public sealed class GetQueueInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("filters")]
        private InputList<Inputs.GetQueueFilterInputArgs>? _filters;
        public InputList<Inputs.GetQueueFilterInputArgs> Filters
        {
            get => _filters ?? (_filters = new InputList<Inputs.GetQueueFilterInputArgs>());
            set => _filters = value;
        }

        [Input("isTagFilter")]
        public Input<bool>? IsTagFilter { get; set; }

        [Input("limit")]
        public Input<int>? Limit { get; set; }

        [Input("offset")]
        public Input<int>? Offset { get; set; }

        [Input("queueName")]
        public Input<string>? QueueName { get; set; }

        [Input("queueNameLists")]
        private InputList<string>? _queueNameLists;
        public InputList<string> QueueNameLists
        {
            get => _queueNameLists ?? (_queueNameLists = new InputList<string>());
            set => _queueNameLists = value;
        }

        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetQueueInvokeArgs()
        {
        }
        public static new GetQueueInvokeArgs Empty => new GetQueueInvokeArgs();
    }


    [OutputType]
    public sealed class GetQueueResult
    {
        public readonly ImmutableArray<Outputs.GetQueueFilterResult> Filters;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly bool? IsTagFilter;
        public readonly int? Limit;
        public readonly int? Offset;
        public readonly ImmutableArray<Outputs.GetQueueQueueListResult> QueueLists;
        public readonly string? QueueName;
        public readonly ImmutableArray<string> QueueNameLists;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetQueueResult(
            ImmutableArray<Outputs.GetQueueFilterResult> filters,

            string id,

            bool? isTagFilter,

            int? limit,

            int? offset,

            ImmutableArray<Outputs.GetQueueQueueListResult> queueLists,

            string? queueName,

            ImmutableArray<string> queueNameLists,

            string? resultOutputFile)
        {
            Filters = filters;
            Id = id;
            IsTagFilter = isTagFilter;
            Limit = limit;
            Offset = offset;
            QueueLists = queueLists;
            QueueName = queueName;
            QueueNameLists = queueNameLists;
            ResultOutputFile = resultOutputFile;
        }
    }
}
