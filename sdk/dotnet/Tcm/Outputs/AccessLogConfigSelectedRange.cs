// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Tcm.Outputs
{

    [OutputType]
    public sealed class AccessLogConfigSelectedRange
    {
        public readonly bool? All;
        public readonly ImmutableArray<Outputs.AccessLogConfigSelectedRangeItem> Items;

        [OutputConstructor]
        private AccessLogConfigSelectedRange(
            bool? all,

            ImmutableArray<Outputs.AccessLogConfigSelectedRangeItem> items)
        {
            All = all;
            Items = items;
        }
    }
}
