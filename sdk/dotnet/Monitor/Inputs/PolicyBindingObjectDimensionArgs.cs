// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Monitor.Inputs
{

    public sealed class PolicyBindingObjectDimensionArgs : global::Pulumi.ResourceArgs
    {
        [Input("dimensionsJson", required: true)]
        public Input<string> DimensionsJson { get; set; } = null!;

        [Input("uniqueId")]
        public Input<string>? UniqueId { get; set; }

        public PolicyBindingObjectDimensionArgs()
        {
        }
        public static new PolicyBindingObjectDimensionArgs Empty => new PolicyBindingObjectDimensionArgs();
    }
}
