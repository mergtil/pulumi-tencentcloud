// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Postgresql.Outputs
{

    [OutputType]
    public sealed class GetDefaultParametersParamInfoSetVersionRelationSetResult
    {
        public readonly string DbKernelVersion;
        public readonly ImmutableArray<string> EnumValues;
        public readonly double Max;
        public readonly double Min;
        public readonly string Name;
        public readonly string Unit;
        public readonly string Value;

        [OutputConstructor]
        private GetDefaultParametersParamInfoSetVersionRelationSetResult(
            string dbKernelVersion,

            ImmutableArray<string> enumValues,

            double max,

            double min,

            string name,

            string unit,

            string value)
        {
            DbKernelVersion = dbKernelVersion;
            EnumValues = enumValues;
            Max = max;
            Min = min;
            Name = name;
            Unit = unit;
            Value = value;
        }
    }
}
