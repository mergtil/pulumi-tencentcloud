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
    public sealed class DatahubTaskTransformsParamFieldChainAnalyseResultValueOperate
    {
        public readonly Outputs.DatahubTaskTransformsParamFieldChainAnalyseResultValueOperateDate? Date;
        public readonly Outputs.DatahubTaskTransformsParamFieldChainAnalyseResultValueOperateJsonPathReplace? JsonPathReplace;
        public readonly Outputs.DatahubTaskTransformsParamFieldChainAnalyseResultValueOperateKV? KV;
        public readonly Outputs.DatahubTaskTransformsParamFieldChainAnalyseResultValueOperateRegexReplace? RegexReplace;
        public readonly Outputs.DatahubTaskTransformsParamFieldChainAnalyseResultValueOperateReplace? Replace;
        public readonly string? Result;
        public readonly Outputs.DatahubTaskTransformsParamFieldChainAnalyseResultValueOperateSplit? Split;
        public readonly Outputs.DatahubTaskTransformsParamFieldChainAnalyseResultValueOperateSubstr? Substr;
        public readonly string Type;
        public readonly Outputs.DatahubTaskTransformsParamFieldChainAnalyseResultValueOperateUrlDecode? UrlDecode;

        [OutputConstructor]
        private DatahubTaskTransformsParamFieldChainAnalyseResultValueOperate(
            Outputs.DatahubTaskTransformsParamFieldChainAnalyseResultValueOperateDate? date,

            Outputs.DatahubTaskTransformsParamFieldChainAnalyseResultValueOperateJsonPathReplace? jsonPathReplace,

            Outputs.DatahubTaskTransformsParamFieldChainAnalyseResultValueOperateKV? kV,

            Outputs.DatahubTaskTransformsParamFieldChainAnalyseResultValueOperateRegexReplace? regexReplace,

            Outputs.DatahubTaskTransformsParamFieldChainAnalyseResultValueOperateReplace? replace,

            string? result,

            Outputs.DatahubTaskTransformsParamFieldChainAnalyseResultValueOperateSplit? split,

            Outputs.DatahubTaskTransformsParamFieldChainAnalyseResultValueOperateSubstr? substr,

            string type,

            Outputs.DatahubTaskTransformsParamFieldChainAnalyseResultValueOperateUrlDecode? urlDecode)
        {
            Date = date;
            JsonPathReplace = jsonPathReplace;
            KV = kV;
            RegexReplace = regexReplace;
            Replace = replace;
            Result = result;
            Split = split;
            Substr = substr;
            Type = type;
            UrlDecode = urlDecode;
        }
    }
}
