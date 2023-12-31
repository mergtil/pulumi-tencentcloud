// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Cos.Outputs
{

    [OutputType]
    public sealed class GetBucketInventorysInventoryDestinationResult
    {
        public readonly string AccountId;
        public readonly string Bucket;
        public readonly ImmutableArray<Outputs.GetBucketInventorysInventoryDestinationEncryptionResult> Encryptions;
        public readonly string Format;
        public readonly string Prefix;

        [OutputConstructor]
        private GetBucketInventorysInventoryDestinationResult(
            string accountId,

            string bucket,

            ImmutableArray<Outputs.GetBucketInventorysInventoryDestinationEncryptionResult> encryptions,

            string format,

            string prefix)
        {
            AccountId = accountId;
            Bucket = bucket;
            Encryptions = encryptions;
            Format = format;
            Prefix = prefix;
        }
    }
}
