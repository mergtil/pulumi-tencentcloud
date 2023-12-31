// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Tcmq.Outputs
{

    [OutputType]
    public sealed class GetSubscribeSubscriptionListResult
    {
        public readonly ImmutableArray<string> BindingKeys;
        public readonly int CreateTime;
        public readonly string Endpoint;
        public readonly ImmutableArray<string> FilterTags;
        public readonly int LastModifyTime;
        public readonly int MsgCount;
        public readonly string NotifyContentFormat;
        public readonly string NotifyStrategy;
        public readonly string Protocol;
        public readonly string SubscriptionId;
        public readonly string SubscriptionName;
        public readonly int TopicOwner;

        [OutputConstructor]
        private GetSubscribeSubscriptionListResult(
            ImmutableArray<string> bindingKeys,

            int createTime,

            string endpoint,

            ImmutableArray<string> filterTags,

            int lastModifyTime,

            int msgCount,

            string notifyContentFormat,

            string notifyStrategy,

            string protocol,

            string subscriptionId,

            string subscriptionName,

            int topicOwner)
        {
            BindingKeys = bindingKeys;
            CreateTime = createTime;
            Endpoint = endpoint;
            FilterTags = filterTags;
            LastModifyTime = lastModifyTime;
            MsgCount = msgCount;
            NotifyContentFormat = notifyContentFormat;
            NotifyStrategy = notifyStrategy;
            Protocol = protocol;
            SubscriptionId = subscriptionId;
            SubscriptionName = subscriptionName;
            TopicOwner = topicOwner;
        }
    }
}
