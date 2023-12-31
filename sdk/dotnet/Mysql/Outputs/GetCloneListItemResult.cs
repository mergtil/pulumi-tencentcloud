// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Mysql.Outputs
{

    [OutputType]
    public sealed class GetCloneListItemResult
    {
        public readonly int CloneJobId;
        public readonly string DstInstanceId;
        public readonly string EndTime;
        public readonly int NewRegionId;
        public readonly string RollbackStrategy;
        public readonly string RollbackTargetTime;
        public readonly string SrcInstanceId;
        public readonly int SrcRegionId;
        public readonly string StartTime;
        public readonly string TaskStatus;

        [OutputConstructor]
        private GetCloneListItemResult(
            int cloneJobId,

            string dstInstanceId,

            string endTime,

            int newRegionId,

            string rollbackStrategy,

            string rollbackTargetTime,

            string srcInstanceId,

            int srcRegionId,

            string startTime,

            string taskStatus)
        {
            CloneJobId = cloneJobId;
            DstInstanceId = dstInstanceId;
            EndTime = endTime;
            NewRegionId = newRegionId;
            RollbackStrategy = rollbackStrategy;
            RollbackTargetTime = rollbackTargetTime;
            SrcInstanceId = srcInstanceId;
            SrcRegionId = srcRegionId;
            StartTime = startTime;
            TaskStatus = taskStatus;
        }
    }
}
