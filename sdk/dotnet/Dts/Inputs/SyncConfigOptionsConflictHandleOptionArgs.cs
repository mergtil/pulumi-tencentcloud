// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Dts.Inputs
{

    public sealed class SyncConfigOptionsConflictHandleOptionArgs : global::Pulumi.ResourceArgs
    {
        [Input("conditionColumn")]
        public Input<string>? ConditionColumn { get; set; }

        [Input("conditionOperator")]
        public Input<string>? ConditionOperator { get; set; }

        [Input("conditionOrderInSrcAndDst")]
        public Input<string>? ConditionOrderInSrcAndDst { get; set; }

        public SyncConfigOptionsConflictHandleOptionArgs()
        {
        }
        public static new SyncConfigOptionsConflictHandleOptionArgs Empty => new SyncConfigOptionsConflictHandleOptionArgs();
    }
}
