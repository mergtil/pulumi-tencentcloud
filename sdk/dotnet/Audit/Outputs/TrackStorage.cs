// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Audit.Outputs
{

    [OutputType]
    public sealed class TrackStorage
    {
        public readonly string StorageName;
        public readonly string StoragePrefix;
        public readonly string StorageRegion;
        public readonly string StorageType;

        [OutputConstructor]
        private TrackStorage(
            string storageName,

            string storagePrefix,

            string storageRegion,

            string storageType)
        {
            StorageName = storageName;
            StoragePrefix = storagePrefix;
            StorageRegion = storageRegion;
            StorageType = storageType;
        }
    }
}