// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.As
{
    public static class GetLimits
    {
        public static Task<GetLimitsResult> InvokeAsync(GetLimitsArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetLimitsResult>("tencentcloud:As/getLimits:getLimits", args ?? new GetLimitsArgs(), options.WithDefaults());

        public static Output<GetLimitsResult> Invoke(GetLimitsInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetLimitsResult>("tencentcloud:As/getLimits:getLimits", args ?? new GetLimitsInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetLimitsArgs : global::Pulumi.InvokeArgs
    {
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetLimitsArgs()
        {
        }
        public static new GetLimitsArgs Empty => new GetLimitsArgs();
    }

    public sealed class GetLimitsInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetLimitsInvokeArgs()
        {
        }
        public static new GetLimitsInvokeArgs Empty => new GetLimitsInvokeArgs();
    }


    [OutputType]
    public sealed class GetLimitsResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly int MaxNumberOfAutoScalingGroups;
        public readonly int MaxNumberOfLaunchConfigurations;
        public readonly int NumberOfAutoScalingGroups;
        public readonly int NumberOfLaunchConfigurations;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetLimitsResult(
            string id,

            int maxNumberOfAutoScalingGroups,

            int maxNumberOfLaunchConfigurations,

            int numberOfAutoScalingGroups,

            int numberOfLaunchConfigurations,

            string? resultOutputFile)
        {
            Id = id;
            MaxNumberOfAutoScalingGroups = maxNumberOfAutoScalingGroups;
            MaxNumberOfLaunchConfigurations = maxNumberOfLaunchConfigurations;
            NumberOfAutoScalingGroups = numberOfAutoScalingGroups;
            NumberOfLaunchConfigurations = numberOfLaunchConfigurations;
            ResultOutputFile = resultOutputFile;
        }
    }
}
