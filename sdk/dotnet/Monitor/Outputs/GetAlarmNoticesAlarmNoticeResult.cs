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
    public sealed class GetAlarmNoticesAlarmNoticeResult
    {
        public readonly string AmpConsumerId;
        public readonly ImmutableArray<Outputs.GetAlarmNoticesAlarmNoticeClsNoticeResult> ClsNotices;
        public readonly string Id;
        public readonly int IsPreset;
        public readonly string Name;
        public readonly string NoticeLanguage;
        public readonly string NoticeType;
        public readonly ImmutableArray<string> PolicyIds;
        public readonly string UpdatedAt;
        public readonly string UpdatedBy;
        public readonly ImmutableArray<Outputs.GetAlarmNoticesAlarmNoticeUrlNoticeResult> UrlNotices;
        public readonly ImmutableArray<Outputs.GetAlarmNoticesAlarmNoticeUserNoticeResult> UserNotices;

        [OutputConstructor]
        private GetAlarmNoticesAlarmNoticeResult(
            string ampConsumerId,

            ImmutableArray<Outputs.GetAlarmNoticesAlarmNoticeClsNoticeResult> clsNotices,

            string id,

            int isPreset,

            string name,

            string noticeLanguage,

            string noticeType,

            ImmutableArray<string> policyIds,

            string updatedAt,

            string updatedBy,

            ImmutableArray<Outputs.GetAlarmNoticesAlarmNoticeUrlNoticeResult> urlNotices,

            ImmutableArray<Outputs.GetAlarmNoticesAlarmNoticeUserNoticeResult> userNotices)
        {
            AmpConsumerId = ampConsumerId;
            ClsNotices = clsNotices;
            Id = id;
            IsPreset = isPreset;
            Name = name;
            NoticeLanguage = noticeLanguage;
            NoticeType = noticeType;
            PolicyIds = policyIds;
            UpdatedAt = updatedAt;
            UpdatedBy = updatedBy;
            UrlNotices = urlNotices;
            UserNotices = userNotices;
        }
    }
}