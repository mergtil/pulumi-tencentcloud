// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Address
{
    public static class GetTemplateGroups
    {
        public static Task<GetTemplateGroupsResult> InvokeAsync(GetTemplateGroupsArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetTemplateGroupsResult>("tencentcloud:Address/getTemplateGroups:getTemplateGroups", args ?? new GetTemplateGroupsArgs(), options.WithDefaults());

        public static Output<GetTemplateGroupsResult> Invoke(GetTemplateGroupsInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetTemplateGroupsResult>("tencentcloud:Address/getTemplateGroups:getTemplateGroups", args ?? new GetTemplateGroupsInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetTemplateGroupsArgs : global::Pulumi.InvokeArgs
    {
        [Input("id")]
        public string? Id { get; set; }

        [Input("name")]
        public string? Name { get; set; }

        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetTemplateGroupsArgs()
        {
        }
        public static new GetTemplateGroupsArgs Empty => new GetTemplateGroupsArgs();
    }

    public sealed class GetTemplateGroupsInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("id")]
        public Input<string>? Id { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetTemplateGroupsInvokeArgs()
        {
        }
        public static new GetTemplateGroupsInvokeArgs Empty => new GetTemplateGroupsInvokeArgs();
    }


    [OutputType]
    public sealed class GetTemplateGroupsResult
    {
        public readonly ImmutableArray<Outputs.GetTemplateGroupsGroupListResult> GroupLists;
        public readonly string? Id;
        public readonly string? Name;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetTemplateGroupsResult(
            ImmutableArray<Outputs.GetTemplateGroupsGroupListResult> groupLists,

            string? id,

            string? name,

            string? resultOutputFile)
        {
            GroupLists = groupLists;
            Id = id;
            Name = name;
            ResultOutputFile = resultOutputFile;
        }
    }
}
