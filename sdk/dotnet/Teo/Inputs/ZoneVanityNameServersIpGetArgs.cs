// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Teo.Inputs
{

    public sealed class ZoneVanityNameServersIpGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("ipv4")]
        public Input<string>? Ipv4 { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        public ZoneVanityNameServersIpGetArgs()
        {
        }
        public static new ZoneVanityNameServersIpGetArgs Empty => new ZoneVanityNameServersIpGetArgs();
    }
}