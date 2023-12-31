// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Mysql
{
    public static class GetInstanceParamRecord
    {
        public static Task<GetInstanceParamRecordResult> InvokeAsync(GetInstanceParamRecordArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetInstanceParamRecordResult>("tencentcloud:Mysql/getInstanceParamRecord:getInstanceParamRecord", args ?? new GetInstanceParamRecordArgs(), options.WithDefaults());

        public static Output<GetInstanceParamRecordResult> Invoke(GetInstanceParamRecordInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetInstanceParamRecordResult>("tencentcloud:Mysql/getInstanceParamRecord:getInstanceParamRecord", args ?? new GetInstanceParamRecordInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetInstanceParamRecordArgs : global::Pulumi.InvokeArgs
    {
        [Input("instanceId", required: true)]
        public string InstanceId { get; set; } = null!;

        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetInstanceParamRecordArgs()
        {
        }
        public static new GetInstanceParamRecordArgs Empty => new GetInstanceParamRecordArgs();
    }

    public sealed class GetInstanceParamRecordInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("instanceId", required: true)]
        public Input<string> InstanceId { get; set; } = null!;

        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetInstanceParamRecordInvokeArgs()
        {
        }
        public static new GetInstanceParamRecordInvokeArgs Empty => new GetInstanceParamRecordInvokeArgs();
    }


    [OutputType]
    public sealed class GetInstanceParamRecordResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string InstanceId;
        public readonly ImmutableArray<Outputs.GetInstanceParamRecordItemResult> Items;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetInstanceParamRecordResult(
            string id,

            string instanceId,

            ImmutableArray<Outputs.GetInstanceParamRecordItemResult> items,

            string? resultOutputFile)
        {
            Id = id;
            InstanceId = instanceId;
            Items = items;
            ResultOutputFile = resultOutputFile;
        }
    }
}
