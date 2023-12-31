// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Monitor
{
    public static class GetBindingObjects
    {
        public static Task<GetBindingObjectsResult> InvokeAsync(GetBindingObjectsArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetBindingObjectsResult>("tencentcloud:Monitor/getBindingObjects:getBindingObjects", args ?? new GetBindingObjectsArgs(), options.WithDefaults());

        public static Output<GetBindingObjectsResult> Invoke(GetBindingObjectsInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetBindingObjectsResult>("tencentcloud:Monitor/getBindingObjects:getBindingObjects", args ?? new GetBindingObjectsInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetBindingObjectsArgs : global::Pulumi.InvokeArgs
    {
        [Input("groupId", required: true)]
        public int GroupId { get; set; }

        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetBindingObjectsArgs()
        {
        }
        public static new GetBindingObjectsArgs Empty => new GetBindingObjectsArgs();
    }

    public sealed class GetBindingObjectsInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("groupId", required: true)]
        public Input<int> GroupId { get; set; } = null!;

        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetBindingObjectsInvokeArgs()
        {
        }
        public static new GetBindingObjectsInvokeArgs Empty => new GetBindingObjectsInvokeArgs();
    }


    [OutputType]
    public sealed class GetBindingObjectsResult
    {
        public readonly int GroupId;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly ImmutableArray<Outputs.GetBindingObjectsListResult> Lists;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetBindingObjectsResult(
            int groupId,

            string id,

            ImmutableArray<Outputs.GetBindingObjectsListResult> lists,

            string? resultOutputFile)
        {
            GroupId = groupId;
            Id = id;
            Lists = lists;
            ResultOutputFile = resultOutputFile;
        }
    }
}
