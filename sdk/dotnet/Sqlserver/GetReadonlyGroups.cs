// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Sqlserver
{
    public static class GetReadonlyGroups
    {
        public static Task<GetReadonlyGroupsResult> InvokeAsync(GetReadonlyGroupsArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetReadonlyGroupsResult>("tencentcloud:Sqlserver/getReadonlyGroups:getReadonlyGroups", args ?? new GetReadonlyGroupsArgs(), options.WithDefaults());

        public static Output<GetReadonlyGroupsResult> Invoke(GetReadonlyGroupsInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetReadonlyGroupsResult>("tencentcloud:Sqlserver/getReadonlyGroups:getReadonlyGroups", args ?? new GetReadonlyGroupsInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetReadonlyGroupsArgs : global::Pulumi.InvokeArgs
    {
        [Input("masterInstanceId")]
        public string? MasterInstanceId { get; set; }

        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetReadonlyGroupsArgs()
        {
        }
        public static new GetReadonlyGroupsArgs Empty => new GetReadonlyGroupsArgs();
    }

    public sealed class GetReadonlyGroupsInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("masterInstanceId")]
        public Input<string>? MasterInstanceId { get; set; }

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
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly ImmutableArray<Outputs.GetReadonlyGroupsListResult> Lists;
        public readonly string? MasterInstanceId;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetReadonlyGroupsResult(
            string id,

            ImmutableArray<Outputs.GetReadonlyGroupsListResult> lists,

            string? masterInstanceId,

            string? resultOutputFile)
        {
            Id = id;
            Lists = lists;
            MasterInstanceId = masterInstanceId;
            ResultOutputFile = resultOutputFile;
        }
    }
}