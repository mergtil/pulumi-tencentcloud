// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Monitor.Outputs
{

    [OutputType]
    public sealed class AlarmPolicyConditionsRule
    {
        public readonly int? ContinuePeriod;
        public readonly string? Description;
        public readonly Outputs.AlarmPolicyConditionsRuleFilter? Filter;
        public readonly int? IsPowerNotice;
        public readonly string? MetricName;
        public readonly int? NoticeFrequency;
        public readonly string? Operator;
        public readonly int? Period;
        public readonly string? RuleType;
        public readonly string? Unit;
        public readonly string? Value;

        [OutputConstructor]
        private AlarmPolicyConditionsRule(
            int? continuePeriod,

            string? description,

            Outputs.AlarmPolicyConditionsRuleFilter? filter,

            int? isPowerNotice,

            string? metricName,

            int? noticeFrequency,

            string? @operator,

            int? period,

            string? ruleType,

            string? unit,

            string? value)
        {
            ContinuePeriod = continuePeriod;
            Description = description;
            Filter = filter;
            IsPowerNotice = isPowerNotice;
            MetricName = metricName;
            NoticeFrequency = noticeFrequency;
            Operator = @operator;
            Period = period;
            RuleType = ruleType;
            Unit = unit;
            Value = value;
        }
    }
}
