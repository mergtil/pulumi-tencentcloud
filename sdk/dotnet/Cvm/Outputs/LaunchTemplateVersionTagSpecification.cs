// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Cvm.Outputs
{

    [OutputType]
    public sealed class LaunchTemplateVersionTagSpecification
    {
        public readonly string ResourceType;
        public readonly ImmutableArray<Outputs.LaunchTemplateVersionTagSpecificationTag> Tags;

        [OutputConstructor]
        private LaunchTemplateVersionTagSpecification(
            string resourceType,

            ImmutableArray<Outputs.LaunchTemplateVersionTagSpecificationTag> tags)
        {
            ResourceType = resourceType;
            Tags = tags;
        }
    }
}