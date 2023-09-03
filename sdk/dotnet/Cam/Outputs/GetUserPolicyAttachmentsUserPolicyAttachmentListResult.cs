// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Cam.Outputs
{

    [OutputType]
    public sealed class GetUserPolicyAttachmentsUserPolicyAttachmentListResult
    {
        public readonly int CreateMode;
        public readonly string CreateTime;
        public readonly string PolicyId;
        public readonly string PolicyName;
        public readonly string PolicyType;
        public readonly string UserId;
        public readonly string UserName;

        [OutputConstructor]
        private GetUserPolicyAttachmentsUserPolicyAttachmentListResult(
            int createMode,

            string createTime,

            string policyId,

            string policyName,

            string policyType,

            string userId,

            string userName)
        {
            CreateMode = createMode;
            CreateTime = createTime;
            PolicyId = policyId;
            PolicyName = policyName;
            PolicyType = policyType;
            UserId = userId;
            UserName = userName;
        }
    }
}