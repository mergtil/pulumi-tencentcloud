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
    public sealed class SnapshotPolicyBackupPolicy
    {
        public readonly string BackupDay;
        public readonly string BackupTime;

        [OutputConstructor]
        private SnapshotPolicyBackupPolicy(
            string backupDay,

            string backupTime)
        {
            BackupDay = backupDay;
            BackupTime = backupTime;
        }
    }
}
