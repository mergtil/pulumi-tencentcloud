// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Sqlserver.Outputs
{

    [OutputType]
    public sealed class ConfigInstanceRoGroupWeightPair
    {
        public readonly string ReadOnlyInstanceId;
        public readonly int ReadOnlyWeight;

        [OutputConstructor]
        private ConfigInstanceRoGroupWeightPair(
            string readOnlyInstanceId,

            int readOnlyWeight)
        {
            ReadOnlyInstanceId = readOnlyInstanceId;
            ReadOnlyWeight = readOnlyWeight;
        }
    }
}
