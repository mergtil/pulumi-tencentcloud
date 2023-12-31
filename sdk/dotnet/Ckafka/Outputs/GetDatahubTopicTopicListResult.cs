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
    public sealed class GetDatahubTopicTopicListResult
    {
        public readonly string Name;
        public readonly string Note;
        public readonly int PartitionNum;
        public readonly int RetentionMs;
        public readonly int Status;
        public readonly string TopicId;
        public readonly string TopicName;

        [OutputConstructor]
        private GetDatahubTopicTopicListResult(
            string name,

            string note,

            int partitionNum,

            int retentionMs,

            int status,

            string topicId,

            string topicName)
        {
            Name = name;
            Note = note;
            PartitionNum = partitionNum;
            RetentionMs = retentionMs;
            Status = status;
            TopicId = topicId;
            TopicName = topicName;
        }
    }
}
