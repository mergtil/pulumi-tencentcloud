// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Cdn.Inputs
{

    public sealed class DomainOriginPullTimeoutArgs : global::Pulumi.ResourceArgs
    {
        [Input("connectTimeout", required: true)]
        public Input<int> ConnectTimeout { get; set; } = null!;

        [Input("receiveTimeout", required: true)]
        public Input<int> ReceiveTimeout { get; set; } = null!;

        public DomainOriginPullTimeoutArgs()
        {
        }
        public static new DomainOriginPullTimeoutArgs Empty => new DomainOriginPullTimeoutArgs();
    }
}
