// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Mongodb
{
    public static class GetInstanceParams
    {
        public static Task<GetInstanceParamsResult> InvokeAsync(GetInstanceParamsArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetInstanceParamsResult>("tencentcloud:Mongodb/getInstanceParams:getInstanceParams", args ?? new GetInstanceParamsArgs(), options.WithDefaults());

        public static Output<GetInstanceParamsResult> Invoke(GetInstanceParamsInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetInstanceParamsResult>("tencentcloud:Mongodb/getInstanceParams:getInstanceParams", args ?? new GetInstanceParamsInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetInstanceParamsArgs : global::Pulumi.InvokeArgs
    {
        [Input("instanceId", required: true)]
        public string InstanceId { get; set; } = null!;

        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetInstanceParamsArgs()
        {
        }
        public static new GetInstanceParamsArgs Empty => new GetInstanceParamsArgs();
    }

    public sealed class GetInstanceParamsInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("instanceId", required: true)]
        public Input<string> InstanceId { get; set; } = null!;

        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetInstanceParamsInvokeArgs()
        {
        }
        public static new GetInstanceParamsInvokeArgs Empty => new GetInstanceParamsInvokeArgs();
    }


    [OutputType]
    public sealed class GetInstanceParamsResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly ImmutableArray<Outputs.GetInstanceParamsInstanceEnumParamResult> InstanceEnumParams;
        public readonly string InstanceId;
        public readonly ImmutableArray<Outputs.GetInstanceParamsInstanceIntegerParamResult> InstanceIntegerParams;
        public readonly ImmutableArray<Outputs.GetInstanceParamsInstanceMultiParamResult> InstanceMultiParams;
        public readonly ImmutableArray<Outputs.GetInstanceParamsInstanceTextParamResult> InstanceTextParams;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetInstanceParamsResult(
            string id,

            ImmutableArray<Outputs.GetInstanceParamsInstanceEnumParamResult> instanceEnumParams,

            string instanceId,

            ImmutableArray<Outputs.GetInstanceParamsInstanceIntegerParamResult> instanceIntegerParams,

            ImmutableArray<Outputs.GetInstanceParamsInstanceMultiParamResult> instanceMultiParams,

            ImmutableArray<Outputs.GetInstanceParamsInstanceTextParamResult> instanceTextParams,

            string? resultOutputFile)
        {
            Id = id;
            InstanceEnumParams = instanceEnumParams;
            InstanceId = instanceId;
            InstanceIntegerParams = instanceIntegerParams;
            InstanceMultiParams = instanceMultiParams;
            InstanceTextParams = instanceTextParams;
            ResultOutputFile = resultOutputFile;
        }
    }
}