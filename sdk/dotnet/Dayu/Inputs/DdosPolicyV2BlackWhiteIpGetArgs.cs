// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Dayu.Inputs
{

    public sealed class DdosPolicyV2BlackWhiteIpGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("ip", required: true)]
        public Input<string> Ip { get; set; } = null!;

        [Input("ipType", required: true)]
        public Input<string> IpType { get; set; } = null!;

        public DdosPolicyV2BlackWhiteIpGetArgs()
        {
        }
        public static new DdosPolicyV2BlackWhiteIpGetArgs Empty => new DdosPolicyV2BlackWhiteIpGetArgs();
    }
}
