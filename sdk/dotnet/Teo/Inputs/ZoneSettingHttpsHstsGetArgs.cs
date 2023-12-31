// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Teo.Inputs
{

    public sealed class ZoneSettingHttpsHstsGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("includeSubDomains")]
        public Input<string>? IncludeSubDomains { get; set; }

        [Input("maxAge")]
        public Input<int>? MaxAge { get; set; }

        [Input("preload")]
        public Input<string>? Preload { get; set; }

        [Input("switch", required: true)]
        public Input<string> Switch { get; set; } = null!;

        public ZoneSettingHttpsHstsGetArgs()
        {
        }
        public static new ZoneSettingHttpsHstsGetArgs Empty => new ZoneSettingHttpsHstsGetArgs();
    }
}
