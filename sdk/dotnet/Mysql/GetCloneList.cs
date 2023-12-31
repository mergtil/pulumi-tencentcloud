// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Mysql
{
    public static class GetCloneList
    {
        public static Task<GetCloneListResult> InvokeAsync(GetCloneListArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetCloneListResult>("tencentcloud:Mysql/getCloneList:getCloneList", args ?? new GetCloneListArgs(), options.WithDefaults());

        public static Output<GetCloneListResult> Invoke(GetCloneListInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetCloneListResult>("tencentcloud:Mysql/getCloneList:getCloneList", args ?? new GetCloneListInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetCloneListArgs : global::Pulumi.InvokeArgs
    {
        [Input("instanceId", required: true)]
        public string InstanceId { get; set; } = null!;

        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetCloneListArgs()
        {
        }
        public static new GetCloneListArgs Empty => new GetCloneListArgs();
    }

    public sealed class GetCloneListInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("instanceId", required: true)]
        public Input<string> InstanceId { get; set; } = null!;

        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetCloneListInvokeArgs()
        {
        }
        public static new GetCloneListInvokeArgs Empty => new GetCloneListInvokeArgs();
    }


    [OutputType]
    public sealed class GetCloneListResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string InstanceId;
        public readonly ImmutableArray<Outputs.GetCloneListItemResult> Items;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetCloneListResult(
            string id,

            string instanceId,

            ImmutableArray<Outputs.GetCloneListItemResult> items,

            string? resultOutputFile)
        {
            Id = id;
            InstanceId = instanceId;
            Items = items;
            ResultOutputFile = resultOutputFile;
        }
    }
}
