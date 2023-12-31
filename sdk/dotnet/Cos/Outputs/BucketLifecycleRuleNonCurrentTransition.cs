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
    public sealed class BucketLifecycleRuleNonCurrentTransition
    {
        public readonly int? NonCurrentDays;
        public readonly string StorageClass;

        [OutputConstructor]
        private BucketLifecycleRuleNonCurrentTransition(
            int? nonCurrentDays,

            string storageClass)
        {
            NonCurrentDays = nonCurrentDays;
            StorageClass = storageClass;
        }
    }
}
