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
    public sealed class GetPolicyConditionsListMetricResult
    {
        public readonly ImmutableArray<int> CalcTypeKeys;
        public readonly bool CalcTypeNeed;
        public readonly string CalcValueDefault;
        public readonly string CalcValueFixed;
        public readonly string CalcValueMax;
        public readonly string CalcValueMin;
        public readonly bool CalcValueNeed;
        public readonly int ContinueTimeDefault;
        public readonly ImmutableArray<int> ContinueTimeKeys;
        public readonly bool ContinueTimeNeed;
        public readonly int MetricId;
        public readonly string MetricShowName;
        public readonly string MetricUnit;
        public readonly int PeriodDefault;
        public readonly ImmutableArray<int> PeriodKeys;
        public readonly bool PeriodNeed;
        public readonly int PeriodNumDefault;
        public readonly ImmutableArray<int> PeriodNumKeys;
        public readonly bool PeriodNumNeed;
        public readonly string StatTypeP10;
        public readonly string StatTypeP1800;
        public readonly string StatTypeP300;
        public readonly string StatTypeP3600;
        public readonly string StatTypeP5;
        public readonly string StatTypeP60;
        public readonly string StatTypeP600;
        public readonly string StatTypeP86400;

        [OutputConstructor]
        private GetPolicyConditionsListMetricResult(
            ImmutableArray<int> calcTypeKeys,

            bool calcTypeNeed,

            string calcValueDefault,

            string calcValueFixed,

            string calcValueMax,

            string calcValueMin,

            bool calcValueNeed,

            int continueTimeDefault,

            ImmutableArray<int> continueTimeKeys,

            bool continueTimeNeed,

            int metricId,

            string metricShowName,

            string metricUnit,

            int periodDefault,

            ImmutableArray<int> periodKeys,

            bool periodNeed,

            int periodNumDefault,

            ImmutableArray<int> periodNumKeys,

            bool periodNumNeed,

            string statTypeP10,

            string statTypeP1800,

            string statTypeP300,

            string statTypeP3600,

            string statTypeP5,

            string statTypeP60,

            string statTypeP600,

            string statTypeP86400)
        {
            CalcTypeKeys = calcTypeKeys;
            CalcTypeNeed = calcTypeNeed;
            CalcValueDefault = calcValueDefault;
            CalcValueFixed = calcValueFixed;
            CalcValueMax = calcValueMax;
            CalcValueMin = calcValueMin;
            CalcValueNeed = calcValueNeed;
            ContinueTimeDefault = continueTimeDefault;
            ContinueTimeKeys = continueTimeKeys;
            ContinueTimeNeed = continueTimeNeed;
            MetricId = metricId;
            MetricShowName = metricShowName;
            MetricUnit = metricUnit;
            PeriodDefault = periodDefault;
            PeriodKeys = periodKeys;
            PeriodNeed = periodNeed;
            PeriodNumDefault = periodNumDefault;
            PeriodNumKeys = periodNumKeys;
            PeriodNumNeed = periodNumNeed;
            StatTypeP10 = statTypeP10;
            StatTypeP1800 = statTypeP1800;
            StatTypeP300 = statTypeP300;
            StatTypeP3600 = statTypeP3600;
            StatTypeP5 = statTypeP5;
            StatTypeP60 = statTypeP60;
            StatTypeP600 = statTypeP600;
            StatTypeP86400 = statTypeP86400;
        }
    }
}
