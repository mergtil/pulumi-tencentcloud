// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Cynosdb.Inputs
{

    public sealed class RollBackClusterRollbackTableTableGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("newTable", required: true)]
        public Input<string> NewTable { get; set; } = null!;

        [Input("oldTable", required: true)]
        public Input<string> OldTable { get; set; } = null!;

        public RollBackClusterRollbackTableTableGetArgs()
        {
        }
        public static new RollBackClusterRollbackTableTableGetArgs Empty => new RollBackClusterRollbackTableTableGetArgs();
    }
}