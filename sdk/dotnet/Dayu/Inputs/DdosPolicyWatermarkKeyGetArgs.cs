// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Dayu.Inputs
{

    public sealed class DdosPolicyWatermarkKeyGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("content")]
        public Input<string>? Content { get; set; }

        [Input("createTime")]
        public Input<string>? CreateTime { get; set; }

        [Input("id")]
        public Input<string>? Id { get; set; }

        [Input("openSwitch")]
        public Input<bool>? OpenSwitch { get; set; }

        public DdosPolicyWatermarkKeyGetArgs()
        {
        }
        public static new DdosPolicyWatermarkKeyGetArgs Empty => new DdosPolicyWatermarkKeyGetArgs();
    }
}
