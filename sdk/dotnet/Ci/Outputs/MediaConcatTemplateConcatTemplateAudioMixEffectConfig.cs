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
    public sealed class MediaConcatTemplateConcatTemplateAudioMixEffectConfig
    {
        public readonly string? BgmFadeTime;
        public readonly string? EnableBgmFade;
        public readonly string? EnableEndFadeout;
        public readonly string? EnableStartFadein;
        public readonly string? EndFadeoutTime;
        public readonly string? StartFadeinTime;

        [OutputConstructor]
        private MediaConcatTemplateConcatTemplateAudioMixEffectConfig(
            string? bgmFadeTime,

            string? enableBgmFade,

            string? enableEndFadeout,

            string? enableStartFadein,

            string? endFadeoutTime,

            string? startFadeinTime)
        {
            BgmFadeTime = bgmFadeTime;
            EnableBgmFade = enableBgmFade;
            EnableEndFadeout = enableEndFadeout;
            EnableStartFadein = enableStartFadein;
            EndFadeoutTime = endFadeoutTime;
            StartFadeinTime = startFadeinTime;
        }
    }
}
