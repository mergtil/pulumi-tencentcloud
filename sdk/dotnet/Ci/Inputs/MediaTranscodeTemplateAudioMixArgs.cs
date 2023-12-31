// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Ci.Inputs
{

    public sealed class MediaTranscodeTemplateAudioMixArgs : global::Pulumi.ResourceArgs
    {
        [Input("audioSource", required: true)]
        public Input<string> AudioSource { get; set; } = null!;

        [Input("effectConfig")]
        public Input<Inputs.MediaTranscodeTemplateAudioMixEffectConfigArgs>? EffectConfig { get; set; }

        [Input("mixMode")]
        public Input<string>? MixMode { get; set; }

        [Input("replace")]
        public Input<string>? Replace { get; set; }

        public MediaTranscodeTemplateAudioMixArgs()
        {
        }
        public static new MediaTranscodeTemplateAudioMixArgs Empty => new MediaTranscodeTemplateAudioMixArgs();
    }
}
