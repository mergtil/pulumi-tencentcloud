// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Monitor.Inputs
{

    public sealed class GrafanaSsoAccountRoleArgs : global::Pulumi.ResourceArgs
    {
        [Input("organization", required: true)]
        public Input<string> Organization { get; set; } = null!;

        [Input("role", required: true)]
        public Input<string> Role { get; set; } = null!;

        public GrafanaSsoAccountRoleArgs()
        {
        }
        public static new GrafanaSsoAccountRoleArgs Empty => new GrafanaSsoAccountRoleArgs();
    }
}
