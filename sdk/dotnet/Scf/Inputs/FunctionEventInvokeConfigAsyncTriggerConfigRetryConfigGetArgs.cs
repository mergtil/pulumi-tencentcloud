// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Scf.Inputs
{

    public sealed class FunctionEventInvokeConfigAsyncTriggerConfigRetryConfigGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("retryNum", required: true)]
        public Input<int> RetryNum { get; set; } = null!;

        public FunctionEventInvokeConfigAsyncTriggerConfigRetryConfigGetArgs()
        {
        }
        public static new FunctionEventInvokeConfigAsyncTriggerConfigRetryConfigGetArgs Empty => new FunctionEventInvokeConfigAsyncTriggerConfigRetryConfigGetArgs();
    }
}
