// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Clb.Inputs
{

    public sealed class GetListenersByTargetsBackendInputArgs : global::Pulumi.ResourceArgs
    {
        [Input("privateIp", required: true)]
        public Input<string> PrivateIp { get; set; } = null!;

        [Input("vpcId", required: true)]
        public Input<string> VpcId { get; set; } = null!;

        public GetListenersByTargetsBackendInputArgs()
        {
        }
        public static new GetListenersByTargetsBackendInputArgs Empty => new GetListenersByTargetsBackendInputArgs();
    }
}
