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
    public sealed class DatahubTaskTransformsParamFieldChainAnalyseResult
    {
        public readonly string Key;
        public readonly string Operate;
        public readonly string? OriginalValue;
        public readonly string SchemeType;
        public readonly string? Value;
        public readonly Outputs.DatahubTaskTransformsParamFieldChainAnalyseResultValueOperate? ValueOperate;
        public readonly ImmutableArray<Outputs.DatahubTaskTransformsParamFieldChainAnalyseResultValueOperate> ValueOperates;

        [OutputConstructor]
        private DatahubTaskTransformsParamFieldChainAnalyseResult(
            string key,

            string operate,

            string? originalValue,

            string schemeType,

            string? value,

            Outputs.DatahubTaskTransformsParamFieldChainAnalyseResultValueOperate? valueOperate,

            ImmutableArray<Outputs.DatahubTaskTransformsParamFieldChainAnalyseResultValueOperate> valueOperates)
        {
            Key = key;
            Operate = operate;
            OriginalValue = originalValue;
            SchemeType = schemeType;
            Value = value;
            ValueOperate = valueOperate;
            ValueOperates = valueOperates;
        }
    }
}
