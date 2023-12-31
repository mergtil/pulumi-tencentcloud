// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Cvm.Inputs
{

    public sealed class LaunchTemplateVersionLoginSettingsArgs : global::Pulumi.ResourceArgs
    {
        [Input("keepImageLogin")]
        public Input<string>? KeepImageLogin { get; set; }

        [Input("keyIds")]
        private InputList<string>? _keyIds;
        public InputList<string> KeyIds
        {
            get => _keyIds ?? (_keyIds = new InputList<string>());
            set => _keyIds = value;
        }

        [Input("password")]
        public Input<string>? Password { get; set; }

        public LaunchTemplateVersionLoginSettingsArgs()
        {
        }
        public static new LaunchTemplateVersionLoginSettingsArgs Empty => new LaunchTemplateVersionLoginSettingsArgs();
    }
}
