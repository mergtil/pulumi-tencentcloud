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
    public sealed class GetDatahubTaskTaskListTargetResourceEsParamDropDlqResult
    {
        public readonly string DlqType;
        public readonly ImmutableArray<Outputs.GetDatahubTaskTaskListTargetResourceEsParamDropDlqKafkaParamResult> KafkaParams;
        public readonly int MaxRetryAttempts;
        public readonly int RetryInterval;
        public readonly ImmutableArray<Outputs.GetDatahubTaskTaskListTargetResourceEsParamDropDlqTopicParamResult> TopicParams;
        public readonly string Type;

        [OutputConstructor]
        private GetDatahubTaskTaskListTargetResourceEsParamDropDlqResult(
            string dlqType,

            ImmutableArray<Outputs.GetDatahubTaskTaskListTargetResourceEsParamDropDlqKafkaParamResult> kafkaParams,

            int maxRetryAttempts,

            int retryInterval,

            ImmutableArray<Outputs.GetDatahubTaskTaskListTargetResourceEsParamDropDlqTopicParamResult> topicParams,

            string type)
        {
            DlqType = dlqType;
            KafkaParams = kafkaParams;
            MaxRetryAttempts = maxRetryAttempts;
            RetryInterval = retryInterval;
            TopicParams = topicParams;
            Type = type;
        }
    }
}
