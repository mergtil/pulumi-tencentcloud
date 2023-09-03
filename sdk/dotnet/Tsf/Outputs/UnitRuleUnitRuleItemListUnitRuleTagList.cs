// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Tsf.Outputs
{

    [OutputType]
    public sealed class UnitRuleUnitRuleItemListUnitRuleTagList
    {
        public readonly string? RuleId;
        public readonly string TagField;
        public readonly string TagOperator;
        public readonly string TagType;
        public readonly string TagValue;
        public readonly string? UnitRuleItemId;

        [OutputConstructor]
        private UnitRuleUnitRuleItemListUnitRuleTagList(
            string? ruleId,

            string tagField,

            string tagOperator,

            string tagType,

            string tagValue,

            string? unitRuleItemId)
        {
            RuleId = ruleId;
            TagField = tagField;
            TagOperator = tagOperator;
            TagType = tagType;
            TagValue = tagValue;
            UnitRuleItemId = unitRuleItemId;
        }
    }
}