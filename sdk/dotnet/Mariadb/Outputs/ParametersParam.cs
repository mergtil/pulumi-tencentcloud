// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Mariadb.Outputs
{

    [OutputType]
    public sealed class ParametersParam
    {
        public readonly string Param;
        public readonly string Value;

        [OutputConstructor]
        private ParametersParam(
            string param,

            string value)
        {
            Param = param;
            Value = value;
        }
    }
}
