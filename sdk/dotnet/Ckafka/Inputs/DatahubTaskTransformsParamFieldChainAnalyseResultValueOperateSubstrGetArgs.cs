// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Ckafka.Inputs
{

    public sealed class DatahubTaskTransformsParamFieldChainAnalyseResultValueOperateSubstrGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("end", required: true)]
        public Input<int> End { get; set; } = null!;

        [Input("start", required: true)]
        public Input<int> Start { get; set; } = null!;

        public DatahubTaskTransformsParamFieldChainAnalyseResultValueOperateSubstrGetArgs()
        {
        }
        public static new DatahubTaskTransformsParamFieldChainAnalyseResultValueOperateSubstrGetArgs Empty => new DatahubTaskTransformsParamFieldChainAnalyseResultValueOperateSubstrGetArgs();
    }
}
