// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Tem.Outputs
{

    [OutputType]
    public sealed class WorkloadStorageConf
    {
        public readonly string StorageVolIp;
        public readonly string StorageVolName;
        public readonly string StorageVolPath;

        [OutputConstructor]
        private WorkloadStorageConf(
            string storageVolIp,

            string storageVolName,

            string storageVolPath)
        {
            StorageVolIp = storageVolIp;
            StorageVolName = storageVolName;
            StorageVolPath = storageVolPath;
        }
    }
}
