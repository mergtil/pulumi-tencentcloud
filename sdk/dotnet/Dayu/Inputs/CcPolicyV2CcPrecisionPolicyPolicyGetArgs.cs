// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Dayu.Inputs
{

    public sealed class CcPolicyV2CcPrecisionPolicyPolicyGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("fieldName", required: true)]
        public Input<string> FieldName { get; set; } = null!;

        [Input("fieldType", required: true)]
        public Input<string> FieldType { get; set; } = null!;

        [Input("value", required: true)]
        public Input<string> Value { get; set; } = null!;

        [Input("valueOperator", required: true)]
        public Input<string> ValueOperator { get; set; } = null!;

        public CcPolicyV2CcPrecisionPolicyPolicyGetArgs()
        {
        }
        public static new CcPolicyV2CcPrecisionPolicyPolicyGetArgs Empty => new CcPolicyV2CcPrecisionPolicyPolicyGetArgs();
    }
}
