// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Tsf.Outputs
{

    [OutputType]
    public sealed class GetDeliveryConfigsResultContentResult
    {
        public readonly ImmutableArray<string> CollectPaths;
        public readonly string ConfigId;
        public readonly string ConfigName;
        public readonly string CreateTime;
        public readonly string CustomRule;
        public readonly bool EnableAuth;
        public readonly bool EnableGlobalLineRule;
        public readonly ImmutableArray<Outputs.GetDeliveryConfigsResultContentGroupResult> Groups;
        public readonly string KafkaAddress;
        public readonly ImmutableArray<Outputs.GetDeliveryConfigsResultContentKafkaInfoResult> KafkaInfos;
        public readonly string KafkaVIp;
        public readonly string KafkaVPort;
        public readonly string LineRule;
        public readonly string Password;
        public readonly string Topic;
        public readonly string Username;

        [OutputConstructor]
        private GetDeliveryConfigsResultContentResult(
            ImmutableArray<string> collectPaths,

            string configId,

            string configName,

            string createTime,

            string customRule,

            bool enableAuth,

            bool enableGlobalLineRule,

            ImmutableArray<Outputs.GetDeliveryConfigsResultContentGroupResult> groups,

            string kafkaAddress,

            ImmutableArray<Outputs.GetDeliveryConfigsResultContentKafkaInfoResult> kafkaInfos,

            string kafkaVIp,

            string kafkaVPort,

            string lineRule,

            string password,

            string topic,

            string username)
        {
            CollectPaths = collectPaths;
            ConfigId = configId;
            ConfigName = configName;
            CreateTime = createTime;
            CustomRule = customRule;
            EnableAuth = enableAuth;
            EnableGlobalLineRule = enableGlobalLineRule;
            Groups = groups;
            KafkaAddress = kafkaAddress;
            KafkaInfos = kafkaInfos;
            KafkaVIp = kafkaVIp;
            KafkaVPort = kafkaVPort;
            LineRule = lineRule;
            Password = password;
            Topic = topic;
            Username = username;
        }
    }
}
