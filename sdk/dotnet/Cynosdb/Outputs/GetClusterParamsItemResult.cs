// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Cynosdb.Outputs
{

    [OutputType]
    public sealed class GetClusterParamsItemResult
    {
        public readonly string CurrentValue;
        public readonly string Default;
        public readonly string Description;
        public readonly ImmutableArray<string> EnumValues;
        public readonly string Func;
        public readonly bool IsFunc;
        public readonly int IsGlobal;
        public readonly string MatchType;
        public readonly string MatchValue;
        public readonly string Max;
        public readonly string Min;
        public readonly int NeedReboot;
        public readonly string ParamName;
        public readonly string ParamType;

        [OutputConstructor]
        private GetClusterParamsItemResult(
            string currentValue,

            string @default,

            string description,

            ImmutableArray<string> enumValues,

            string func,

            bool isFunc,

            int isGlobal,

            string matchType,

            string matchValue,

            string max,

            string min,

            int needReboot,

            string paramName,

            string paramType)
        {
            CurrentValue = currentValue;
            Default = @default;
            Description = description;
            EnumValues = enumValues;
            Func = func;
            IsFunc = isFunc;
            IsGlobal = isGlobal;
            MatchType = matchType;
            MatchValue = matchValue;
            Max = max;
            Min = min;
            NeedReboot = needReboot;
            ParamName = paramName;
            ParamType = paramType;
        }
    }
}
