// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Cdn.Inputs
{

    public sealed class DomainAuthenticationGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("switch")]
        public Input<string>? Switch { get; set; }

        [Input("typeA")]
        public Input<Inputs.DomainAuthenticationTypeAGetArgs>? TypeA { get; set; }

        [Input("typeB")]
        public Input<Inputs.DomainAuthenticationTypeBGetArgs>? TypeB { get; set; }

        [Input("typeC")]
        public Input<Inputs.DomainAuthenticationTypeCGetArgs>? TypeC { get; set; }

        [Input("typeD")]
        public Input<Inputs.DomainAuthenticationTypeDGetArgs>? TypeD { get; set; }

        public DomainAuthenticationGetArgs()
        {
        }
        public static new DomainAuthenticationGetArgs Empty => new DomainAuthenticationGetArgs();
    }
}
