// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Postgresql
{
    public static class GetReadonlyGroups
    {
        public static Task<GetReadonlyGroupsResult> InvokeAsync(GetReadonlyGroupsArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetReadonlyGroupsResult>("tencentcloud:Postgresql/getReadonlyGroups:getReadonlyGroups", args ?? new GetReadonlyGroupsArgs(), options.WithDefaults());

        public static Output<GetReadonlyGroupsResult> Invoke(GetReadonlyGroupsInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetReadonlyGroupsResult>("tencentcloud:Postgresql/getReadonlyGroups:getReadonlyGroups", args ?? new GetReadonlyGroupsInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetReadonlyGroupsArgs : global::Pulumi.InvokeArgs
    {
        [Input("filters")]
        private List<Inputs.GetReadonlyGroupsFilterArgs>? _filters;
        public List<Inputs.GetReadonlyGroupsFilterArgs> Filters
        {
            get => _filters ?? (_filters = new List<Inputs.GetReadonlyGroupsFilterArgs>());
            set => _filters = value;
        }

        [Input("orderBy")]
        public string? OrderBy { get; set; }

        [Input("orderByType")]
        public string? OrderByType { get; set; }

        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetReadonlyGroupsArgs()
        {
        }
        public static new GetReadonlyGroupsArgs Empty => new GetReadonlyGroupsArgs();
    }

    public sealed class GetReadonlyGroupsInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("filters")]
        private InputList<Inputs.GetReadonlyGroupsFilterInputArgs>? _filters;
        public InputList<Inputs.GetReadonlyGroupsFilterInputArgs> Filters
        {
            get => _filters ?? (_filters = new InputList<Inputs.GetReadonlyGroupsFilterInputArgs>());
            set => _filters = value;
        }

        [Input("orderBy")]
        public Input<string>? OrderBy { get; set; }

        [Input("orderByType")]
        public Input<string>? OrderByType { get; set; }

        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetReadonlyGroupsInvokeArgs()
        {
        }
        public static new GetReadonlyGroupsInvokeArgs Empty => new GetReadonlyGroupsInvokeArgs();
    }


    [OutputType]
    public sealed class GetReadonlyGroupsResult
    {
        public readonly ImmutableArray<Outputs.GetReadonlyGroupsFilterResult> Filters;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string? OrderBy;
        public readonly string? OrderByType;
        public readonly ImmutableArray<Outputs.GetReadonlyGroupsReadOnlyGroupListResult> ReadOnlyGroupLists;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetReadonlyGroupsResult(
            ImmutableArray<Outputs.GetReadonlyGroupsFilterResult> filters,

            string id,

            string? orderBy,

            string? orderByType,

            ImmutableArray<Outputs.GetReadonlyGroupsReadOnlyGroupListResult> readOnlyGroupLists,

            string? resultOutputFile)
        {
            Filters = filters;
            Id = id;
            OrderBy = orderBy;
            OrderByType = orderByType;
            ReadOnlyGroupLists = readOnlyGroupLists;
            ResultOutputFile = resultOutputFile;
        }
    }
}
