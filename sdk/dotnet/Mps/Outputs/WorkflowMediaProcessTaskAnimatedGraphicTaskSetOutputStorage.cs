// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Mps.Outputs
{

    [OutputType]
    public sealed class WorkflowMediaProcessTaskAnimatedGraphicTaskSetOutputStorage
    {
        public readonly Outputs.WorkflowMediaProcessTaskAnimatedGraphicTaskSetOutputStorageCosOutputStorage? CosOutputStorage;
        public readonly string Type;

        [OutputConstructor]
        private WorkflowMediaProcessTaskAnimatedGraphicTaskSetOutputStorage(
            Outputs.WorkflowMediaProcessTaskAnimatedGraphicTaskSetOutputStorageCosOutputStorage? cosOutputStorage,

            string type)
        {
            CosOutputStorage = cosOutputStorage;
            Type = type;
        }
    }
}
