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
    public sealed class MediaTranscodeProTemplateVideo
    {
        public readonly string? Bitrate;
        public readonly string? Codec;
        public readonly string? Fps;
        public readonly string? Height;
        public readonly string? Interlaced;
        public readonly string? Profile;
        public readonly string? Rotate;
        public readonly string? Width;

        [OutputConstructor]
        private MediaTranscodeProTemplateVideo(
            string? bitrate,

            string? codec,

            string? fps,

            string? height,

            string? interlaced,

            string? profile,

            string? rotate,

            string? width)
        {
            Bitrate = bitrate;
            Codec = codec;
            Fps = fps;
            Height = height;
            Interlaced = interlaced;
            Profile = profile;
            Rotate = rotate;
            Width = width;
        }
    }
}
