// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Postgresql.Inputs
{

    public sealed class ParameterTemplateModifyParamEntrySetGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("expectedValue", required: true)]
        public Input<string> ExpectedValue { get; set; } = null!;

        [Input("name", required: true)]
        public Input<string> Name { get; set; } = null!;

        public ParameterTemplateModifyParamEntrySetGetArgs()
        {
        }
        public static new ParameterTemplateModifyParamEntrySetGetArgs Empty => new ParameterTemplateModifyParamEntrySetGetArgs();
    }
}
