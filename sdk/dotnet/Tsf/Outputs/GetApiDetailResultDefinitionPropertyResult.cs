// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Tsf.Outputs
{

    [OutputType]
    public sealed class GetApiDetailResultDefinitionPropertyResult
    {
        public readonly string Description;
        public readonly string Name;
        public readonly string Type;

        [OutputConstructor]
        private GetApiDetailResultDefinitionPropertyResult(
            string description,

            string name,

            string type)
        {
            Description = description;
            Name = name;
            Type = type;
        }
    }
}