// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Tcm.Outputs
{

    [OutputType]
    public sealed class GetMeshMeshListTagListResult
    {
        public readonly string Key;
        public readonly bool Passthrough;
        public readonly string Value;

        [OutputConstructor]
        private GetMeshMeshListTagListResult(
            string key,

            bool passthrough,

            string value)
        {
            Key = key;
            Passthrough = passthrough;
            Value = value;
        }
    }
}
