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
    public sealed class FunctionLayer
    {
        public readonly string LayerName;
        public readonly int LayerVersion;

        [OutputConstructor]
        private FunctionLayer(
            string layerName,

            int layerVersion)
        {
            LayerName = layerName;
            LayerVersion = layerVersion;
        }
    }
}
