// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Ci.Inputs
{

    public sealed class MediaVideoProcessTemplateMsSharpenGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("enable")]
        public Input<string>? Enable { get; set; }

        [Input("sharpenLevel")]
        public Input<string>? SharpenLevel { get; set; }

        public MediaVideoProcessTemplateMsSharpenGetArgs()
        {
        }
        public static new MediaVideoProcessTemplateMsSharpenGetArgs Empty => new MediaVideoProcessTemplateMsSharpenGetArgs();
    }
}
