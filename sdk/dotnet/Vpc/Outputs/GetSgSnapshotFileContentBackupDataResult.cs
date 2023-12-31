// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Vpc.Outputs
{

    [OutputType]
    public sealed class GetSgSnapshotFileContentBackupDataResult
    {
        public readonly string Action;
        public readonly ImmutableArray<Outputs.GetSgSnapshotFileContentBackupDataAddressTemplateResult> AddressTemplates;
        public readonly string CidrBlock;
        public readonly string Ipv6CidrBlock;
        public readonly string ModifyTime;
        public readonly string PolicyDescription;
        public readonly int PolicyIndex;
        public readonly string Port;
        public readonly string Protocol;
        public readonly string SecurityGroupId;
        public readonly ImmutableArray<Outputs.GetSgSnapshotFileContentBackupDataServiceTemplateResult> ServiceTemplates;

        [OutputConstructor]
        private GetSgSnapshotFileContentBackupDataResult(
            string action,

            ImmutableArray<Outputs.GetSgSnapshotFileContentBackupDataAddressTemplateResult> addressTemplates,

            string cidrBlock,

            string ipv6CidrBlock,

            string modifyTime,

            string policyDescription,

            int policyIndex,

            string port,

            string protocol,

            string securityGroupId,

            ImmutableArray<Outputs.GetSgSnapshotFileContentBackupDataServiceTemplateResult> serviceTemplates)
        {
            Action = action;
            AddressTemplates = addressTemplates;
            CidrBlock = cidrBlock;
            Ipv6CidrBlock = ipv6CidrBlock;
            ModifyTime = modifyTime;
            PolicyDescription = policyDescription;
            PolicyIndex = policyIndex;
            Port = port;
            Protocol = protocol;
            SecurityGroupId = securityGroupId;
            ServiceTemplates = serviceTemplates;
        }
    }
}
