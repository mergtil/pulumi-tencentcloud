// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Cynosdb.Inputs
{

    public sealed class ParamTemplateParamListGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("currentValue")]
        public Input<string>? CurrentValue { get; set; }

        [Input("paramName")]
        public Input<string>? ParamName { get; set; }

        public ParamTemplateParamListGetArgs()
        {
        }
        public static new ParamTemplateParamListGetArgs Empty => new ParamTemplateParamListGetArgs();
    }
}
