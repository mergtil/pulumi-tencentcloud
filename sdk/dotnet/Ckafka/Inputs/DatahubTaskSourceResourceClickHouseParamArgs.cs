// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Ckafka.Inputs
{

    public sealed class DatahubTaskSourceResourceClickHouseParamArgs : global::Pulumi.ResourceArgs
    {
        [Input("cluster", required: true)]
        public Input<string> Cluster { get; set; } = null!;

        [Input("database", required: true)]
        public Input<string> Database { get; set; } = null!;

        [Input("dropCls")]
        public Input<Inputs.DatahubTaskSourceResourceClickHouseParamDropClsArgs>? DropCls { get; set; }

        [Input("dropInvalidMessage")]
        public Input<bool>? DropInvalidMessage { get; set; }

        [Input("ip")]
        public Input<string>? Ip { get; set; }

        [Input("password")]
        public Input<string>? Password { get; set; }

        [Input("port")]
        public Input<int>? Port { get; set; }

        [Input("resource", required: true)]
        public Input<string> Resource { get; set; } = null!;

        [Input("schemas", required: true)]
        private InputList<Inputs.DatahubTaskSourceResourceClickHouseParamSchemaArgs>? _schemas;
        public InputList<Inputs.DatahubTaskSourceResourceClickHouseParamSchemaArgs> Schemas
        {
            get => _schemas ?? (_schemas = new InputList<Inputs.DatahubTaskSourceResourceClickHouseParamSchemaArgs>());
            set => _schemas = value;
        }

        [Input("selfBuilt")]
        public Input<bool>? SelfBuilt { get; set; }

        [Input("serviceVip")]
        public Input<string>? ServiceVip { get; set; }

        [Input("table", required: true)]
        public Input<string> Table { get; set; } = null!;

        [Input("type")]
        public Input<string>? Type { get; set; }

        [Input("uniqVpcId")]
        public Input<string>? UniqVpcId { get; set; }

        [Input("userName")]
        public Input<string>? UserName { get; set; }

        public DatahubTaskSourceResourceClickHouseParamArgs()
        {
        }
        public static new DatahubTaskSourceResourceClickHouseParamArgs Empty => new DatahubTaskSourceResourceClickHouseParamArgs();
    }
}