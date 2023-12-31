// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Dts.Outputs
{

    [OutputType]
    public sealed class GetSyncJobsListResult
    {
        public readonly ImmutableArray<string> Actions;
        public readonly ImmutableArray<string> AllActions;
        public readonly string CreateTime;
        public readonly ImmutableArray<Outputs.GetSyncJobsListDetailResult> Details;
        public readonly string DstAccessType;
        public readonly string DstDatabaseType;
        public readonly ImmutableArray<Outputs.GetSyncJobsListDstInfoResult> DstInfos;
        public readonly string DstRegion;
        public readonly string EndTime;
        public readonly string ExpectRunTime;
        public readonly string ExpireTime;
        public readonly string JobId;
        public readonly string JobName;
        public readonly ImmutableArray<Outputs.GetSyncJobsListObjectResult> Objects;
        public readonly ImmutableArray<Outputs.GetSyncJobsListOptionResult> Options;
        public readonly string PayMode;
        public readonly string RunMode;
        public readonly string Specification;
        public readonly string SrcAccessType;
        public readonly string SrcDatabaseType;
        public readonly ImmutableArray<Outputs.GetSyncJobsListSrcInfoResult> SrcInfos;
        public readonly string SrcRegion;
        public readonly string StartTime;
        public readonly string Status;
        public readonly ImmutableArray<Outputs.GetSyncJobsListTagResult> Tags;

        [OutputConstructor]
        private GetSyncJobsListResult(
            ImmutableArray<string> actions,

            ImmutableArray<string> allActions,

            string createTime,

            ImmutableArray<Outputs.GetSyncJobsListDetailResult> details,

            string dstAccessType,

            string dstDatabaseType,

            ImmutableArray<Outputs.GetSyncJobsListDstInfoResult> dstInfos,

            string dstRegion,

            string endTime,

            string expectRunTime,

            string expireTime,

            string jobId,

            string jobName,

            ImmutableArray<Outputs.GetSyncJobsListObjectResult> objects,

            ImmutableArray<Outputs.GetSyncJobsListOptionResult> options,

            string payMode,

            string runMode,

            string specification,

            string srcAccessType,

            string srcDatabaseType,

            ImmutableArray<Outputs.GetSyncJobsListSrcInfoResult> srcInfos,

            string srcRegion,

            string startTime,

            string status,

            ImmutableArray<Outputs.GetSyncJobsListTagResult> tags)
        {
            Actions = actions;
            AllActions = allActions;
            CreateTime = createTime;
            Details = details;
            DstAccessType = dstAccessType;
            DstDatabaseType = dstDatabaseType;
            DstInfos = dstInfos;
            DstRegion = dstRegion;
            EndTime = endTime;
            ExpectRunTime = expectRunTime;
            ExpireTime = expireTime;
            JobId = jobId;
            JobName = jobName;
            Objects = objects;
            Options = options;
            PayMode = payMode;
            RunMode = runMode;
            Specification = specification;
            SrcAccessType = srcAccessType;
            SrcDatabaseType = srcDatabaseType;
            SrcInfos = srcInfos;
            SrcRegion = srcRegion;
            StartTime = startTime;
            Status = status;
            Tags = tags;
        }
    }
}
