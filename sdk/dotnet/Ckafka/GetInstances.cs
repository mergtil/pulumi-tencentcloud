// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Ckafka
{
    public static class GetInstances
    {
        public static Task<GetInstancesResult> InvokeAsync(GetInstancesArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetInstancesResult>("tencentcloud:Ckafka/getInstances:getInstances", args ?? new GetInstancesArgs(), options.WithDefaults());

        public static Output<GetInstancesResult> Invoke(GetInstancesInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetInstancesResult>("tencentcloud:Ckafka/getInstances:getInstances", args ?? new GetInstancesInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetInstancesArgs : global::Pulumi.InvokeArgs
    {
        [Input("filters")]
        private List<Inputs.GetInstancesFilterArgs>? _filters;
        public List<Inputs.GetInstancesFilterArgs> Filters
        {
            get => _filters ?? (_filters = new List<Inputs.GetInstancesFilterArgs>());
            set => _filters = value;
        }

        [Input("instanceIds")]
        private List<string>? _instanceIds;
        public List<string> InstanceIds
        {
            get => _instanceIds ?? (_instanceIds = new List<string>());
            set => _instanceIds = value;
        }

        [Input("limit")]
        public int? Limit { get; set; }

        [Input("offset")]
        public int? Offset { get; set; }

        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        [Input("searchWord")]
        public string? SearchWord { get; set; }

        [Input("statuses")]
        private List<int>? _statuses;
        public List<int> Statuses
        {
            get => _statuses ?? (_statuses = new List<int>());
            set => _statuses = value;
        }

        [Input("tagKey")]
        public string? TagKey { get; set; }

        public GetInstancesArgs()
        {
        }
        public static new GetInstancesArgs Empty => new GetInstancesArgs();
    }

    public sealed class GetInstancesInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("filters")]
        private InputList<Inputs.GetInstancesFilterInputArgs>? _filters;
        public InputList<Inputs.GetInstancesFilterInputArgs> Filters
        {
            get => _filters ?? (_filters = new InputList<Inputs.GetInstancesFilterInputArgs>());
            set => _filters = value;
        }

        [Input("instanceIds")]
        private InputList<string>? _instanceIds;
        public InputList<string> InstanceIds
        {
            get => _instanceIds ?? (_instanceIds = new InputList<string>());
            set => _instanceIds = value;
        }

        [Input("limit")]
        public Input<int>? Limit { get; set; }

        [Input("offset")]
        public Input<int>? Offset { get; set; }

        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        [Input("searchWord")]
        public Input<string>? SearchWord { get; set; }

        [Input("statuses")]
        private InputList<int>? _statuses;
        public InputList<int> Statuses
        {
            get => _statuses ?? (_statuses = new InputList<int>());
            set => _statuses = value;
        }

        [Input("tagKey")]
        public Input<string>? TagKey { get; set; }

        public GetInstancesInvokeArgs()
        {
        }
        public static new GetInstancesInvokeArgs Empty => new GetInstancesInvokeArgs();
    }


    [OutputType]
    public sealed class GetInstancesResult
    {
        public readonly ImmutableArray<Outputs.GetInstancesFilterResult> Filters;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly ImmutableArray<string> InstanceIds;
        public readonly ImmutableArray<Outputs.GetInstancesInstanceListResult> InstanceLists;
        public readonly int? Limit;
        public readonly int? Offset;
        public readonly string? ResultOutputFile;
        public readonly string? SearchWord;
        public readonly ImmutableArray<int> Statuses;
        public readonly string? TagKey;

        [OutputConstructor]
        private GetInstancesResult(
            ImmutableArray<Outputs.GetInstancesFilterResult> filters,

            string id,

            ImmutableArray<string> instanceIds,

            ImmutableArray<Outputs.GetInstancesInstanceListResult> instanceLists,

            int? limit,

            int? offset,

            string? resultOutputFile,

            string? searchWord,

            ImmutableArray<int> statuses,

            string? tagKey)
        {
            Filters = filters;
            Id = id;
            InstanceIds = instanceIds;
            InstanceLists = instanceLists;
            Limit = limit;
            Offset = offset;
            ResultOutputFile = resultOutputFile;
            SearchWord = searchWord;
            Statuses = statuses;
            TagKey = tagKey;
        }
    }
}