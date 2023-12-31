// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Dcdb.Inputs
{

    public sealed class GetUpgradePriceExpandShardConfigArgs : global::Pulumi.InvokeArgs
    {
        [Input("shardInstanceIds", required: true)]
        private List<string>? _shardInstanceIds;
        public List<string> ShardInstanceIds
        {
            get => _shardInstanceIds ?? (_shardInstanceIds = new List<string>());
            set => _shardInstanceIds = value;
        }

        [Input("shardMemory", required: true)]
        public int ShardMemory { get; set; }

        [Input("shardNodeCount")]
        public int? ShardNodeCount { get; set; }

        [Input("shardStorage", required: true)]
        public int ShardStorage { get; set; }

        public GetUpgradePriceExpandShardConfigArgs()
        {
        }
        public static new GetUpgradePriceExpandShardConfigArgs Empty => new GetUpgradePriceExpandShardConfigArgs();
    }
}
