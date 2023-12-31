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
    public sealed class GetGatewayAllGroupApisResultGroupResult
    {
        public readonly string GatewayInstanceId;
        public readonly string GatewayInstanceType;
        public readonly int GroupApiCount;
        public readonly ImmutableArray<Outputs.GetGatewayAllGroupApisResultGroupGroupApiResult> GroupApis;
        public readonly string GroupId;
        public readonly string GroupName;

        [OutputConstructor]
        private GetGatewayAllGroupApisResultGroupResult(
            string gatewayInstanceId,

            string gatewayInstanceType,

            int groupApiCount,

            ImmutableArray<Outputs.GetGatewayAllGroupApisResultGroupGroupApiResult> groupApis,

            string groupId,

            string groupName)
        {
            GatewayInstanceId = gatewayInstanceId;
            GatewayInstanceType = gatewayInstanceType;
            GroupApiCount = groupApiCount;
            GroupApis = groupApis;
            GroupId = groupId;
            GroupName = groupName;
        }
    }
}
