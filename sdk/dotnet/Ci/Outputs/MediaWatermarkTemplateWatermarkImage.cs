// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Ci.Outputs
{

    [OutputType]
    public sealed class MediaWatermarkTemplateWatermarkImage
    {
        public readonly string Background;
        public readonly string? Height;
        public readonly string Mode;
        public readonly string Transparency;
        public readonly string Url;
        public readonly string? Width;

        [OutputConstructor]
        private MediaWatermarkTemplateWatermarkImage(
            string background,

            string? height,

            string mode,

            string transparency,

            string url,

            string? width)
        {
            Background = background;
            Height = height;
            Mode = mode;
            Transparency = transparency;
            Url = url;
            Width = width;
        }
    }
}
