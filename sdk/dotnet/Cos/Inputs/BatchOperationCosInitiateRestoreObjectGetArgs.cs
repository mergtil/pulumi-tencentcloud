// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Cos.Inputs
{

    public sealed class BatchOperationCosInitiateRestoreObjectGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("expirationInDays", required: true)]
        public Input<int> ExpirationInDays { get; set; } = null!;

        [Input("jobTier", required: true)]
        public Input<string> JobTier { get; set; } = null!;

        public BatchOperationCosInitiateRestoreObjectGetArgs()
        {
        }
        public static new BatchOperationCosInitiateRestoreObjectGetArgs Empty => new BatchOperationCosInitiateRestoreObjectGetArgs();
    }
}
