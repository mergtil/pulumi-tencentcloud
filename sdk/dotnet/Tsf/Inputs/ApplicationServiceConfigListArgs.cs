// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Tsf.Inputs
{

    public sealed class ApplicationServiceConfigListArgs : global::Pulumi.ResourceArgs
    {
        [Input("healthCheck")]
        public Input<Inputs.ApplicationServiceConfigListHealthCheckArgs>? HealthCheck { get; set; }

        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        [Input("ports", required: true)]
        private InputList<Inputs.ApplicationServiceConfigListPortArgs>? _ports;
        public InputList<Inputs.ApplicationServiceConfigListPortArgs> Ports
        {
            get => _ports ?? (_ports = new InputList<Inputs.ApplicationServiceConfigListPortArgs>());
            set => _ports = value;
        }

        public ApplicationServiceConfigListArgs()
        {
        }
        public static new ApplicationServiceConfigListArgs Empty => new ApplicationServiceConfigListArgs();
    }
}
