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
    public sealed class GetApiDetailResultRequestResult
    {
        public readonly string DefaultValue;
        public readonly string Description;
        public readonly string In;
        public readonly string Name;
        public readonly bool Required;
        public readonly string Type;

        [OutputConstructor]
        private GetApiDetailResultRequestResult(
            string defaultValue,

            string description,

            string @in,

            string name,

            bool required,

            string type)
        {
            DefaultValue = defaultValue;
            Description = description;
            In = @in;
            Name = name;
            Required = required;
            Type = type;
        }
    }
}
