// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Teo.Outputs
{

    [OutputType]
    public sealed class ZoneSettingCachePrefresh
    {
        public readonly int? Percent;
        public readonly string Switch;

        [OutputConstructor]
        private ZoneSettingCachePrefresh(
            int? percent,

            string @switch)
        {
            Percent = percent;
            Switch = @switch;
        }
    }
}