// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Cos.Inputs
{

    public sealed class BucketInventoryFilterArgs : global::Pulumi.ResourceArgs
    {
        [Input("period")]
        public Input<Inputs.BucketInventoryFilterPeriodArgs>? Period { get; set; }

        [Input("prefix")]
        public Input<string>? Prefix { get; set; }

        public BucketInventoryFilterArgs()
        {
        }
        public static new BucketInventoryFilterArgs Empty => new BucketInventoryFilterArgs();
    }
}
