// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Cdn.Inputs
{

    public sealed class DomainAuthenticationArgs : global::Pulumi.ResourceArgs
    {
        [Input("switch")]
        public Input<string>? Switch { get; set; }

        [Input("typeA")]
        public Input<Inputs.DomainAuthenticationTypeAArgs>? TypeA { get; set; }

        [Input("typeB")]
        public Input<Inputs.DomainAuthenticationTypeBArgs>? TypeB { get; set; }

        [Input("typeC")]
        public Input<Inputs.DomainAuthenticationTypeCArgs>? TypeC { get; set; }

        [Input("typeD")]
        public Input<Inputs.DomainAuthenticationTypeDArgs>? TypeD { get; set; }

        public DomainAuthenticationArgs()
        {
        }
        public static new DomainAuthenticationArgs Empty => new DomainAuthenticationArgs();
    }
}