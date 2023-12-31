// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Postgresql
{
    public static class GetSpecinfos
    {
        public static Task<GetSpecinfosResult> InvokeAsync(GetSpecinfosArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetSpecinfosResult>("tencentcloud:Postgresql/getSpecinfos:getSpecinfos", args ?? new GetSpecinfosArgs(), options.WithDefaults());

        public static Output<GetSpecinfosResult> Invoke(GetSpecinfosInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetSpecinfosResult>("tencentcloud:Postgresql/getSpecinfos:getSpecinfos", args ?? new GetSpecinfosInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetSpecinfosArgs : global::Pulumi.InvokeArgs
    {
        [Input("availabilityZone", required: true)]
        public string AvailabilityZone { get; set; } = null!;

        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetSpecinfosArgs()
        {
        }
        public static new GetSpecinfosArgs Empty => new GetSpecinfosArgs();
    }

    public sealed class GetSpecinfosInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("availabilityZone", required: true)]
        public Input<string> AvailabilityZone { get; set; } = null!;

        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetSpecinfosInvokeArgs()
        {
        }
        public static new GetSpecinfosInvokeArgs Empty => new GetSpecinfosInvokeArgs();
    }


    [OutputType]
    public sealed class GetSpecinfosResult
    {
        public readonly string AvailabilityZone;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly ImmutableArray<Outputs.GetSpecinfosListResult> Lists;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetSpecinfosResult(
            string availabilityZone,

            string id,

            ImmutableArray<Outputs.GetSpecinfosListResult> lists,

            string? resultOutputFile)
        {
            AvailabilityZone = availabilityZone;
            Id = id;
            Lists = lists;
            ResultOutputFile = resultOutputFile;
        }
    }
}
