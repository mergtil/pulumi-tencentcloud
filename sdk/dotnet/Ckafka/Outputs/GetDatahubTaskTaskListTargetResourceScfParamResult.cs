// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Ckafka.Outputs
{

    [OutputType]
    public sealed class GetDatahubTaskTaskListTargetResourceScfParamResult
    {
        public readonly int BatchSize;
        public readonly string FunctionName;
        public readonly int MaxRetries;
        public readonly string Namespace;
        public readonly string Qualifier;

        [OutputConstructor]
        private GetDatahubTaskTaskListTargetResourceScfParamResult(
            int batchSize,

            string functionName,

            int maxRetries,

            string @namespace,

            string qualifier)
        {
            BatchSize = batchSize;
            FunctionName = functionName;
            MaxRetries = maxRetries;
            Namespace = @namespace;
            Qualifier = qualifier;
        }
    }
}
