// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Sqlserver
{
    public static class GetAccountDbAttachments
    {
        public static Task<GetAccountDbAttachmentsResult> InvokeAsync(GetAccountDbAttachmentsArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetAccountDbAttachmentsResult>("tencentcloud:Sqlserver/getAccountDbAttachments:getAccountDbAttachments", args ?? new GetAccountDbAttachmentsArgs(), options.WithDefaults());

        public static Output<GetAccountDbAttachmentsResult> Invoke(GetAccountDbAttachmentsInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetAccountDbAttachmentsResult>("tencentcloud:Sqlserver/getAccountDbAttachments:getAccountDbAttachments", args ?? new GetAccountDbAttachmentsInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetAccountDbAttachmentsArgs : global::Pulumi.InvokeArgs
    {
        [Input("accountName")]
        public string? AccountName { get; set; }

        [Input("dbName")]
        public string? DbName { get; set; }

        [Input("instanceId", required: true)]
        public string InstanceId { get; set; } = null!;

        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetAccountDbAttachmentsArgs()
        {
        }
        public static new GetAccountDbAttachmentsArgs Empty => new GetAccountDbAttachmentsArgs();
    }

    public sealed class GetAccountDbAttachmentsInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("accountName")]
        public Input<string>? AccountName { get; set; }

        [Input("dbName")]
        public Input<string>? DbName { get; set; }

        [Input("instanceId", required: true)]
        public Input<string> InstanceId { get; set; } = null!;

        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetAccountDbAttachmentsInvokeArgs()
        {
        }
        public static new GetAccountDbAttachmentsInvokeArgs Empty => new GetAccountDbAttachmentsInvokeArgs();
    }


    [OutputType]
    public sealed class GetAccountDbAttachmentsResult
    {
        public readonly string? AccountName;
        public readonly string? DbName;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string InstanceId;
        public readonly ImmutableArray<Outputs.GetAccountDbAttachmentsListResult> Lists;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetAccountDbAttachmentsResult(
            string? accountName,

            string? dbName,

            string id,

            string instanceId,

            ImmutableArray<Outputs.GetAccountDbAttachmentsListResult> lists,

            string? resultOutputFile)
        {
            AccountName = accountName;
            DbName = dbName;
            Id = id;
            InstanceId = instanceId;
            Lists = lists;
            ResultOutputFile = resultOutputFile;
        }
    }
}