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
    public sealed class GetClusterInstanceGroupsInstanceGrpInfoListInstanceSetTaskResult
    {
        public readonly string ObjectId;
        public readonly string ObjectType;
        public readonly int TaskId;
        public readonly string TaskStatus;
        public readonly string TaskType;

        [OutputConstructor]
        private GetClusterInstanceGroupsInstanceGrpInfoListInstanceSetTaskResult(
            string objectId,

            string objectType,

            int taskId,

            string taskStatus,

            string taskType)
        {
            ObjectId = objectId;
            ObjectType = objectType;
            TaskId = taskId;
            TaskStatus = taskStatus;
            TaskType = taskType;
        }
    }
}