// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Deprecatedeks.Inputs
{

    public sealed class ClusterDnsServerGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("domain")]
        public Input<string>? Domain { get; set; }

        [Input("servers")]
        private InputList<string>? _servers;
        public InputList<string> Servers
        {
            get => _servers ?? (_servers = new InputList<string>());
            set => _servers = value;
        }

        public ClusterDnsServerGetArgs()
        {
        }
        public static new ClusterDnsServerGetArgs Empty => new ClusterDnsServerGetArgs();
    }
}
