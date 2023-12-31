// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Dcdb.Outputs
{

    [OutputType]
    public sealed class GetProjectSecurityGroupsGroupResult
    {
        public readonly string CreateTime;
        public readonly ImmutableArray<Outputs.GetProjectSecurityGroupsGroupInboundResult> Inbounds;
        public readonly ImmutableArray<Outputs.GetProjectSecurityGroupsGroupOutboundResult> Outbounds;
        public readonly int ProjectId;
        public readonly string SecurityGroupId;
        public readonly string SecurityGroupName;
        public readonly string SecurityGroupRemark;

        [OutputConstructor]
        private GetProjectSecurityGroupsGroupResult(
            string createTime,

            ImmutableArray<Outputs.GetProjectSecurityGroupsGroupInboundResult> inbounds,

            ImmutableArray<Outputs.GetProjectSecurityGroupsGroupOutboundResult> outbounds,

            int projectId,

            string securityGroupId,

            string securityGroupName,

            string securityGroupRemark)
        {
            CreateTime = createTime;
            Inbounds = inbounds;
            Outbounds = outbounds;
            ProjectId = projectId;
            SecurityGroupId = securityGroupId;
            SecurityGroupName = securityGroupName;
            SecurityGroupRemark = securityGroupRemark;
        }
    }
}
