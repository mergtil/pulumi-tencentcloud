// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Teo.Outputs
{

    [OutputType]
    public sealed class ZoneResource
    {
        public readonly string? Area;
        public readonly int? AutoRenewFlag;
        public readonly string? CreateTime;
        public readonly string? EnableTime;
        public readonly string? ExpireTime;
        public readonly string? Id;
        public readonly int? PayMode;
        public readonly string? PlanId;
        public readonly string? Status;
        public readonly ImmutableArray<Outputs.ZoneResourceSv> Svs;

        [OutputConstructor]
        private ZoneResource(
            string? area,

            int? autoRenewFlag,

            string? createTime,

            string? enableTime,

            string? expireTime,

            string? id,

            int? payMode,

            string? planId,

            string? status,

            ImmutableArray<Outputs.ZoneResourceSv> svs)
        {
            Area = area;
            AutoRenewFlag = autoRenewFlag;
            CreateTime = createTime;
            EnableTime = enableTime;
            ExpireTime = expireTime;
            Id = id;
            PayMode = payMode;
            PlanId = planId;
            Status = status;
            Svs = svs;
        }
    }
}