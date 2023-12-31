// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Ci.Inputs
{

    public sealed class MediaTranscodeTemplateVideoArgs : global::Pulumi.ResourceArgs
    {
        [Input("bitrate")]
        public Input<string>? Bitrate { get; set; }

        [Input("bufsize")]
        public Input<string>? Bufsize { get; set; }

        [Input("codec")]
        public Input<string>? Codec { get; set; }

        [Input("crf")]
        public Input<string>? Crf { get; set; }

        [Input("fps")]
        public Input<string>? Fps { get; set; }

        [Input("gop")]
        public Input<string>? Gop { get; set; }

        [Input("height")]
        public Input<string>? Height { get; set; }

        [Input("longShortMode")]
        public Input<string>? LongShortMode { get; set; }

        [Input("maxrate")]
        public Input<string>? Maxrate { get; set; }

        [Input("pixfmt")]
        public Input<string>? Pixfmt { get; set; }

        [Input("preset")]
        public Input<string>? Preset { get; set; }

        [Input("profile")]
        public Input<string>? Profile { get; set; }

        [Input("remove")]
        public Input<string>? Remove { get; set; }

        [Input("rotate")]
        public Input<string>? Rotate { get; set; }

        [Input("width")]
        public Input<string>? Width { get; set; }

        public MediaTranscodeTemplateVideoArgs()
        {
        }
        public static new MediaTranscodeTemplateVideoArgs Empty => new MediaTranscodeTemplateVideoArgs();
    }
}
