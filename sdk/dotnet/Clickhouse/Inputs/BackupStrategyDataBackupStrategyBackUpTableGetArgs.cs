// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Clickhouse.Inputs
{

    public sealed class BackupStrategyDataBackupStrategyBackUpTableGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("database", required: true)]
        public Input<string> Database { get; set; } = null!;

        [Input("ips")]
        public Input<string>? Ips { get; set; }

        [Input("rip")]
        public Input<string>? Rip { get; set; }

        [Input("table", required: true)]
        public Input<string> Table { get; set; } = null!;

        [Input("totalBytes", required: true)]
        public Input<int> TotalBytes { get; set; } = null!;

        [Input("vCluster")]
        public Input<string>? VCluster { get; set; }

        [Input("zooPath")]
        public Input<string>? ZooPath { get; set; }

        public BackupStrategyDataBackupStrategyBackUpTableGetArgs()
        {
        }
        public static new BackupStrategyDataBackupStrategyBackUpTableGetArgs Empty => new BackupStrategyDataBackupStrategyBackUpTableGetArgs();
    }
}