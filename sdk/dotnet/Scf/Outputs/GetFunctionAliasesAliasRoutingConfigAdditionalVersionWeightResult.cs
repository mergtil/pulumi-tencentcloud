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
    public sealed class GetFunctionAliasesAliasRoutingConfigAdditionalVersionWeightResult
    {
        public readonly string Version;
        public readonly double Weight;

        [OutputConstructor]
        private GetFunctionAliasesAliasRoutingConfigAdditionalVersionWeightResult(
            string version,

            double weight)
        {
            Version = version;
            Weight = weight;
        }
    }
}