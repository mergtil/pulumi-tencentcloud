// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Scf.Outputs
{

    [OutputType]
    public sealed class GetAccountInfoAccountUsageNamespaceResult
    {
        public readonly ImmutableArray<string> Functions;
        public readonly int FunctionsCount;
        public readonly string Namespace;
        public readonly int TotalAllocatedConcurrencyMem;
        public readonly int TotalAllocatedProvisionedMem;
        public readonly int TotalConcurrencyMem;

        [OutputConstructor]
        private GetAccountInfoAccountUsageNamespaceResult(
            ImmutableArray<string> functions,

            int functionsCount,

            string @namespace,

            int totalAllocatedConcurrencyMem,

            int totalAllocatedProvisionedMem,

            int totalConcurrencyMem)
        {
            Functions = functions;
            FunctionsCount = functionsCount;
            Namespace = @namespace;
            TotalAllocatedConcurrencyMem = totalAllocatedConcurrencyMem;
            TotalAllocatedProvisionedMem = totalAllocatedProvisionedMem;
            TotalConcurrencyMem = totalConcurrencyMem;
        }
    }
}