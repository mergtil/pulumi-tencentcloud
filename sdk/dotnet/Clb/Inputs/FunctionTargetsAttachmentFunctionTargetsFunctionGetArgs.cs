// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Clb.Inputs
{

    public sealed class FunctionTargetsAttachmentFunctionTargetsFunctionGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("functionName", required: true)]
        public Input<string> FunctionName { get; set; } = null!;

        [Input("functionNamespace", required: true)]
        public Input<string> FunctionNamespace { get; set; } = null!;

        [Input("functionQualifier", required: true)]
        public Input<string> FunctionQualifier { get; set; } = null!;

        [Input("functionQualifierType")]
        public Input<string>? FunctionQualifierType { get; set; }

        public FunctionTargetsAttachmentFunctionTargetsFunctionGetArgs()
        {
        }
        public static new FunctionTargetsAttachmentFunctionTargetsFunctionGetArgs Empty => new FunctionTargetsAttachmentFunctionTargetsFunctionGetArgs();
    }
}
