// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Cynosdb.Inputs
{

    public sealed class ClusterRwGroupAddrArgs : global::Pulumi.ResourceArgs
    {
        [Input("ip")]
        public Input<string>? Ip { get; set; }

        [Input("port")]
        public Input<int>? Port { get; set; }

        public ClusterRwGroupAddrArgs()
        {
        }
        public static new ClusterRwGroupAddrArgs Empty => new ClusterRwGroupAddrArgs();
    }
}
