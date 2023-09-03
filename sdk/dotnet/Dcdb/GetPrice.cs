// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Dcdb
{
    public static class GetPrice
    {
        public static Task<GetPriceResult> InvokeAsync(GetPriceArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetPriceResult>("tencentcloud:Dcdb/getPrice:getPrice", args ?? new GetPriceArgs(), options.WithDefaults());

        public static Output<GetPriceResult> Invoke(GetPriceInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetPriceResult>("tencentcloud:Dcdb/getPrice:getPrice", args ?? new GetPriceInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetPriceArgs : global::Pulumi.InvokeArgs
    {
        [Input("amountUnit")]
        public string? AmountUnit { get; set; }

        [Input("instanceCount", required: true)]
        public int InstanceCount { get; set; }

        [Input("paymode")]
        public string? Paymode { get; set; }

        [Input("period", required: true)]
        public int Period { get; set; }

        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        [Input("shardCount", required: true)]
        public int ShardCount { get; set; }

        [Input("shardMemory", required: true)]
        public int ShardMemory { get; set; }

        [Input("shardNodeCount", required: true)]
        public int ShardNodeCount { get; set; }

        [Input("shardStorage", required: true)]
        public int ShardStorage { get; set; }

        [Input("zone", required: true)]
        public string Zone { get; set; } = null!;

        public GetPriceArgs()
        {
        }
        public static new GetPriceArgs Empty => new GetPriceArgs();
    }

    public sealed class GetPriceInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("amountUnit")]
        public Input<string>? AmountUnit { get; set; }

        [Input("instanceCount", required: true)]
        public Input<int> InstanceCount { get; set; } = null!;

        [Input("paymode")]
        public Input<string>? Paymode { get; set; }

        [Input("period", required: true)]
        public Input<int> Period { get; set; } = null!;

        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        [Input("shardCount", required: true)]
        public Input<int> ShardCount { get; set; } = null!;

        [Input("shardMemory", required: true)]
        public Input<int> ShardMemory { get; set; } = null!;

        [Input("shardNodeCount", required: true)]
        public Input<int> ShardNodeCount { get; set; } = null!;

        [Input("shardStorage", required: true)]
        public Input<int> ShardStorage { get; set; } = null!;

        [Input("zone", required: true)]
        public Input<string> Zone { get; set; } = null!;

        public GetPriceInvokeArgs()
        {
        }
        public static new GetPriceInvokeArgs Empty => new GetPriceInvokeArgs();
    }


    [OutputType]
    public sealed class GetPriceResult
    {
        public readonly string? AmountUnit;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly int InstanceCount;
        public readonly int OriginalPrice;
        public readonly string? Paymode;
        public readonly int Period;
        public readonly int DcdbPrice;
        public readonly string? ResultOutputFile;
        public readonly int ShardCount;
        public readonly int ShardMemory;
        public readonly int ShardNodeCount;
        public readonly int ShardStorage;
        public readonly string Zone;

        [OutputConstructor]
        private GetPriceResult(
            string? amountUnit,

            string id,

            int instanceCount,

            int originalPrice,

            string? paymode,

            int period,

            int price,

            string? resultOutputFile,

            int shardCount,

            int shardMemory,

            int shardNodeCount,

            int shardStorage,

            string zone)
        {
            AmountUnit = amountUnit;
            Id = id;
            InstanceCount = instanceCount;
            OriginalPrice = originalPrice;
            Paymode = paymode;
            Period = period;
            DcdbPrice = price;
            ResultOutputFile = resultOutputFile;
            ShardCount = shardCount;
            ShardMemory = shardMemory;
            ShardNodeCount = shardNodeCount;
            ShardStorage = shardStorage;
            Zone = zone;
        }
    }
}