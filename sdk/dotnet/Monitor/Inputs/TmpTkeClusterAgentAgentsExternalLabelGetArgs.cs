// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Monitor.Inputs
{

    public sealed class TmpTkeClusterAgentAgentsExternalLabelGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("value")]
        public Input<string>? Value { get; set; }

        public TmpTkeClusterAgentAgentsExternalLabelGetArgs()
        {
        }
        public static new TmpTkeClusterAgentAgentsExternalLabelGetArgs Empty => new TmpTkeClusterAgentAgentsExternalLabelGetArgs();
    }
}
