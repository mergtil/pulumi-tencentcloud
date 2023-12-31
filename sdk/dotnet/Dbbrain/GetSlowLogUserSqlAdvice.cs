// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Dbbrain
{
    public static class GetSlowLogUserSqlAdvice
    {
        public static Task<GetSlowLogUserSqlAdviceResult> InvokeAsync(GetSlowLogUserSqlAdviceArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetSlowLogUserSqlAdviceResult>("tencentcloud:Dbbrain/getSlowLogUserSqlAdvice:getSlowLogUserSqlAdvice", args ?? new GetSlowLogUserSqlAdviceArgs(), options.WithDefaults());

        public static Output<GetSlowLogUserSqlAdviceResult> Invoke(GetSlowLogUserSqlAdviceInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetSlowLogUserSqlAdviceResult>("tencentcloud:Dbbrain/getSlowLogUserSqlAdvice:getSlowLogUserSqlAdvice", args ?? new GetSlowLogUserSqlAdviceInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetSlowLogUserSqlAdviceArgs : global::Pulumi.InvokeArgs
    {
        [Input("instanceId", required: true)]
        public string InstanceId { get; set; } = null!;

        [Input("product")]
        public string? Product { get; set; }

        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        [Input("schema")]
        public string? Schema { get; set; }

        [Input("sqlText", required: true)]
        public string SqlText { get; set; } = null!;

        public GetSlowLogUserSqlAdviceArgs()
        {
        }
        public static new GetSlowLogUserSqlAdviceArgs Empty => new GetSlowLogUserSqlAdviceArgs();
    }

    public sealed class GetSlowLogUserSqlAdviceInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("instanceId", required: true)]
        public Input<string> InstanceId { get; set; } = null!;

        [Input("product")]
        public Input<string>? Product { get; set; }

        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        [Input("schema")]
        public Input<string>? Schema { get; set; }

        [Input("sqlText", required: true)]
        public Input<string> SqlText { get; set; } = null!;

        public GetSlowLogUserSqlAdviceInvokeArgs()
        {
        }
        public static new GetSlowLogUserSqlAdviceInvokeArgs Empty => new GetSlowLogUserSqlAdviceInvokeArgs();
    }


    [OutputType]
    public sealed class GetSlowLogUserSqlAdviceResult
    {
        public readonly string Advices;
        public readonly string Comments;
        public readonly string Cost;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string InstanceId;
        public readonly string? Product;
        public readonly string RequestId;
        public readonly string? ResultOutputFile;
        public readonly string Schema;
        public readonly string SqlPlan;
        public readonly string SqlText;
        public readonly string Tables;

        [OutputConstructor]
        private GetSlowLogUserSqlAdviceResult(
            string advices,

            string comments,

            string cost,

            string id,

            string instanceId,

            string? product,

            string requestId,

            string? resultOutputFile,

            string schema,

            string sqlPlan,

            string sqlText,

            string tables)
        {
            Advices = advices;
            Comments = comments;
            Cost = cost;
            Id = id;
            InstanceId = instanceId;
            Product = product;
            RequestId = requestId;
            ResultOutputFile = resultOutputFile;
            Schema = schema;
            SqlPlan = sqlPlan;
            SqlText = sqlText;
            Tables = tables;
        }
    }
}
