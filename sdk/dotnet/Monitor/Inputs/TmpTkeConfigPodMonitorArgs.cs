// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Monitor.Inputs
{

    public sealed class TmpTkeConfigPodMonitorArgs : global::Pulumi.ResourceArgs
    {
        [Input("config", required: true)]
        public Input<string> Config { get; set; } = null!;

        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("templateId")]
        public Input<string>? TemplateId { get; set; }

        public TmpTkeConfigPodMonitorArgs()
        {
        }
        public static new TmpTkeConfigPodMonitorArgs Empty => new TmpTkeConfigPodMonitorArgs();
    }
}