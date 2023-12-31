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
    public sealed class GetDatahubTaskTaskListResult
    {
        public readonly string CreateTime;
        public readonly string DatahubId;
        public readonly string ErrorMessage;
        public readonly ImmutableArray<Outputs.GetDatahubTaskTaskListSourceResourceResult> SourceResources;
        public readonly int Status;
        public readonly ImmutableArray<string> StepLists;
        public readonly ImmutableArray<Outputs.GetDatahubTaskTaskListTargetResourceResult> TargetResources;
        public readonly string TaskCurrentStep;
        public readonly string TaskId;
        public readonly string TaskName;
        public readonly double TaskProgress;
        public readonly string TaskType;

        [OutputConstructor]
        private GetDatahubTaskTaskListResult(
            string createTime,

            string datahubId,

            string errorMessage,

            ImmutableArray<Outputs.GetDatahubTaskTaskListSourceResourceResult> sourceResources,

            int status,

            ImmutableArray<string> stepLists,

            ImmutableArray<Outputs.GetDatahubTaskTaskListTargetResourceResult> targetResources,

            string taskCurrentStep,

            string taskId,

            string taskName,

            double taskProgress,

            string taskType)
        {
            CreateTime = createTime;
            DatahubId = datahubId;
            ErrorMessage = errorMessage;
            SourceResources = sourceResources;
            Status = status;
            StepLists = stepLists;
            TargetResources = targetResources;
            TaskCurrentStep = taskCurrentStep;
            TaskId = taskId;
            TaskName = taskName;
            TaskProgress = taskProgress;
            TaskType = taskType;
        }
    }
}
