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
    public sealed class DatahubTaskTransformParamFailureParam
    {
        public readonly string? DlqType;
        public readonly Outputs.DatahubTaskTransformParamFailureParamKafkaParam? KafkaParam;
        public readonly int? MaxRetryAttempts;
        public readonly int? RetryInterval;
        public readonly Outputs.DatahubTaskTransformParamFailureParamTopicParam? TopicParam;
        public readonly string Type;

        [OutputConstructor]
        private DatahubTaskTransformParamFailureParam(
            string? dlqType,

            Outputs.DatahubTaskTransformParamFailureParamKafkaParam? kafkaParam,

            int? maxRetryAttempts,

            int? retryInterval,

            Outputs.DatahubTaskTransformParamFailureParamTopicParam? topicParam,

            string type)
        {
            DlqType = dlqType;
            KafkaParam = kafkaParam;
            MaxRetryAttempts = maxRetryAttempts;
            RetryInterval = retryInterval;
            TopicParam = topicParam;
            Type = type;
        }
    }
}