// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Kubernetes.Outputs
{

    [OutputType]
    public sealed class GetClusterCommonNamesListResult
    {
        public readonly string CommonNames;
        public readonly string SubaccountUin;

        [OutputConstructor]
        private GetClusterCommonNamesListResult(
            string commonNames,

            string subaccountUin)
        {
            CommonNames = commonNames;
            SubaccountUin = subaccountUin;
        }
    }
}
