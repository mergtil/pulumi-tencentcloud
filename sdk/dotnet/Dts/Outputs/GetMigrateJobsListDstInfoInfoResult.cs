// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Dts.Outputs
{

    [OutputType]
    public sealed class GetMigrateJobsListDstInfoInfoResult
    {
        public readonly string Account;
        public readonly string AccountMode;
        public readonly string AccountRole;
        public readonly string CcnGwId;
        public readonly string CvmInstanceId;
        public readonly string DbKernel;
        public readonly string EngineVersion;
        public readonly string Host;
        public readonly string InstanceId;
        public readonly string Password;
        public readonly int Port;
        public readonly string Role;
        public readonly string SubnetId;
        public readonly string TmpSecretId;
        public readonly string TmpSecretKey;
        public readonly string TmpToken;
        public readonly string UniqVpnGwId;
        public readonly string User;
        public readonly string VpcId;

        [OutputConstructor]
        private GetMigrateJobsListDstInfoInfoResult(
            string account,

            string accountMode,

            string accountRole,

            string ccnGwId,

            string cvmInstanceId,

            string dbKernel,

            string engineVersion,

            string host,

            string instanceId,

            string password,

            int port,

            string role,

            string subnetId,

            string tmpSecretId,

            string tmpSecretKey,

            string tmpToken,

            string uniqVpnGwId,

            string user,

            string vpcId)
        {
            Account = account;
            AccountMode = accountMode;
            AccountRole = accountRole;
            CcnGwId = ccnGwId;
            CvmInstanceId = cvmInstanceId;
            DbKernel = dbKernel;
            EngineVersion = engineVersion;
            Host = host;
            InstanceId = instanceId;
            Password = password;
            Port = port;
            Role = role;
            SubnetId = subnetId;
            TmpSecretId = tmpSecretId;
            TmpSecretKey = tmpSecretKey;
            TmpToken = tmpToken;
            UniqVpnGwId = uniqVpnGwId;
            User = user;
            VpcId = vpcId;
        }
    }
}
