// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Reserved
{
    public static class GetInstanceConfigs
    {
        public static Task<GetInstanceConfigsResult> InvokeAsync(GetInstanceConfigsArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetInstanceConfigsResult>("tencentcloud:Reserved/getInstanceConfigs:getInstanceConfigs", args ?? new GetInstanceConfigsArgs(), options.WithDefaults());

        public static Output<GetInstanceConfigsResult> Invoke(GetInstanceConfigsInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetInstanceConfigsResult>("tencentcloud:Reserved/getInstanceConfigs:getInstanceConfigs", args ?? new GetInstanceConfigsInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetInstanceConfigsArgs : global::Pulumi.InvokeArgs
    {
        [Input("availabilityZone")]
        public string? AvailabilityZone { get; set; }

        [Input("duration")]
        public int? Duration { get; set; }

        [Input("instanceType")]
        public string? InstanceType { get; set; }

        [Input("offeringType")]
        public string? OfferingType { get; set; }

        [Input("productDescription")]
        public string? ProductDescription { get; set; }

        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetInstanceConfigsArgs()
        {
        }
        public static new GetInstanceConfigsArgs Empty => new GetInstanceConfigsArgs();
    }

    public sealed class GetInstanceConfigsInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("availabilityZone")]
        public Input<string>? AvailabilityZone { get; set; }

        [Input("duration")]
        public Input<int>? Duration { get; set; }

        [Input("instanceType")]
        public Input<string>? InstanceType { get; set; }

        [Input("offeringType")]
        public Input<string>? OfferingType { get; set; }

        [Input("productDescription")]
        public Input<string>? ProductDescription { get; set; }

        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetInstanceConfigsInvokeArgs()
        {
        }
        public static new GetInstanceConfigsInvokeArgs Empty => new GetInstanceConfigsInvokeArgs();
    }


    [OutputType]
    public sealed class GetInstanceConfigsResult
    {
        public readonly string? AvailabilityZone;
        public readonly ImmutableArray<Outputs.GetInstanceConfigsConfigListResult> ConfigLists;
        public readonly int? Duration;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string? InstanceType;
        public readonly string? OfferingType;
        public readonly string? ProductDescription;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetInstanceConfigsResult(
            string? availabilityZone,

            ImmutableArray<Outputs.GetInstanceConfigsConfigListResult> configLists,

            int? duration,

            string id,

            string? instanceType,

            string? offeringType,

            string? productDescription,

            string? resultOutputFile)
        {
            AvailabilityZone = availabilityZone;
            ConfigLists = configLists;
            Duration = duration;
            Id = id;
            InstanceType = instanceType;
            OfferingType = offeringType;
            ProductDescription = productDescription;
            ResultOutputFile = resultOutputFile;
        }
    }
}
