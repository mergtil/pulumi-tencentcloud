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
    public sealed class GetDatahubTaskTaskListTargetResourceTopicParamResult
    {
        public readonly string CompressionType;
        public readonly int MsgMultiple;
        public readonly string OffsetType;
        public readonly string Resource;
        public readonly int StartTime;
        public readonly string TopicId;
        public readonly bool UseAutoCreateTopic;

        [OutputConstructor]
        private GetDatahubTaskTaskListTargetResourceTopicParamResult(
            string compressionType,

            int msgMultiple,

            string offsetType,

            string resource,

            int startTime,

            string topicId,

            bool useAutoCreateTopic)
        {
            CompressionType = compressionType;
            MsgMultiple = msgMultiple;
            OffsetType = offsetType;
            Resource = resource;
            StartTime = startTime;
            TopicId = topicId;
            UseAutoCreateTopic = useAutoCreateTopic;
        }
    }
}