// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Cdn.Inputs
{

    public sealed class DomainErrorPagePageRuleGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("redirectCode", required: true)]
        public Input<int> RedirectCode { get; set; } = null!;

        [Input("redirectUrl", required: true)]
        public Input<string> RedirectUrl { get; set; } = null!;

        [Input("statusCode", required: true)]
        public Input<int> StatusCode { get; set; } = null!;

        public DomainErrorPagePageRuleGetArgs()
        {
        }
        public static new DomainErrorPagePageRuleGetArgs Empty => new DomainErrorPagePageRuleGetArgs();
    }
}
