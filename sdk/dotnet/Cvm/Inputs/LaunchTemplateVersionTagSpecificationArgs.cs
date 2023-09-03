// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Cvm.Inputs
{

    public sealed class LaunchTemplateVersionTagSpecificationArgs : global::Pulumi.ResourceArgs
    {
        [Input("resourceType", required: true)]
        public Input<string> ResourceType { get; set; } = null!;

        [Input("tags", required: true)]
        private InputList<Inputs.LaunchTemplateVersionTagSpecificationTagArgs>? _tags;
        public InputList<Inputs.LaunchTemplateVersionTagSpecificationTagArgs> Tags
        {
            get => _tags ?? (_tags = new InputList<Inputs.LaunchTemplateVersionTagSpecificationTagArgs>());
            set => _tags = value;
        }

        public LaunchTemplateVersionTagSpecificationArgs()
        {
        }
        public static new LaunchTemplateVersionTagSpecificationArgs Empty => new LaunchTemplateVersionTagSpecificationArgs();
    }
}