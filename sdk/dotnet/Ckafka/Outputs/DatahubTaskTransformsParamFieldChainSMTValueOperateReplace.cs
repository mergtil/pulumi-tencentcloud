// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Ckafka.Outputs
{

    [OutputType]
    public sealed class DatahubTaskTransformsParamFieldChainSMTValueOperateReplace
    {
        public readonly string NewValue;
        public readonly string OldValue;

        [OutputConstructor]
        private DatahubTaskTransformsParamFieldChainSMTValueOperateReplace(
            string newValue,

            string oldValue)
        {
            NewValue = newValue;
            OldValue = oldValue;
        }
    }
}