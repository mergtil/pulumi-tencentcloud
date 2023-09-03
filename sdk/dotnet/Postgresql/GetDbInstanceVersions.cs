// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Postgresql
{
    public static class GetDbInstanceVersions
    {
        public static Task<GetDbInstanceVersionsResult> InvokeAsync(GetDbInstanceVersionsArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetDbInstanceVersionsResult>("tencentcloud:Postgresql/getDbInstanceVersions:getDbInstanceVersions", args ?? new GetDbInstanceVersionsArgs(), options.WithDefaults());

        public static Output<GetDbInstanceVersionsResult> Invoke(GetDbInstanceVersionsInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetDbInstanceVersionsResult>("tencentcloud:Postgresql/getDbInstanceVersions:getDbInstanceVersions", args ?? new GetDbInstanceVersionsInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetDbInstanceVersionsArgs : global::Pulumi.InvokeArgs
    {
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetDbInstanceVersionsArgs()
        {
        }
        public static new GetDbInstanceVersionsArgs Empty => new GetDbInstanceVersionsArgs();
    }

    public sealed class GetDbInstanceVersionsInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetDbInstanceVersionsInvokeArgs()
        {
        }
        public static new GetDbInstanceVersionsInvokeArgs Empty => new GetDbInstanceVersionsInvokeArgs();
    }


    [OutputType]
    public sealed class GetDbInstanceVersionsResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string? ResultOutputFile;
        public readonly ImmutableArray<Outputs.GetDbInstanceVersionsVersionSetResult> VersionSets;

        [OutputConstructor]
        private GetDbInstanceVersionsResult(
            string id,

            string? resultOutputFile,

            ImmutableArray<Outputs.GetDbInstanceVersionsVersionSetResult> versionSets)
        {
            Id = id;
            ResultOutputFile = resultOutputFile;
            VersionSets = versionSets;
        }
    }
}