// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Ssl.Inputs
{

    public sealed class FreeCertificateDvAuthGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("dvAuthKey")]
        public Input<string>? DvAuthKey { get; set; }

        [Input("dvAuthValue")]
        public Input<string>? DvAuthValue { get; set; }

        [Input("dvAuthVerifyType")]
        public Input<string>? DvAuthVerifyType { get; set; }

        public FreeCertificateDvAuthGetArgs()
        {
        }
        public static new FreeCertificateDvAuthGetArgs Empty => new FreeCertificateDvAuthGetArgs();
    }
}
