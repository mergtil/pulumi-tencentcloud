// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Tsf
{
    public static class GetApiDetail
    {
        public static Task<GetApiDetailResult> InvokeAsync(GetApiDetailArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetApiDetailResult>("tencentcloud:Tsf/getApiDetail:getApiDetail", args ?? new GetApiDetailArgs(), options.WithDefaults());

        public static Output<GetApiDetailResult> Invoke(GetApiDetailInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetApiDetailResult>("tencentcloud:Tsf/getApiDetail:getApiDetail", args ?? new GetApiDetailInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetApiDetailArgs : global::Pulumi.InvokeArgs
    {
        [Input("applicationId", required: true)]
        public string ApplicationId { get; set; } = null!;

        [Input("method", required: true)]
        public string Method { get; set; } = null!;

        [Input("microserviceId", required: true)]
        public string MicroserviceId { get; set; } = null!;

        [Input("path", required: true)]
        public string Path { get; set; } = null!;

        [Input("pkgVersion", required: true)]
        public string PkgVersion { get; set; } = null!;

        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetApiDetailArgs()
        {
        }
        public static new GetApiDetailArgs Empty => new GetApiDetailArgs();
    }

    public sealed class GetApiDetailInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("applicationId", required: true)]
        public Input<string> ApplicationId { get; set; } = null!;

        [Input("method", required: true)]
        public Input<string> Method { get; set; } = null!;

        [Input("microserviceId", required: true)]
        public Input<string> MicroserviceId { get; set; } = null!;

        [Input("path", required: true)]
        public Input<string> Path { get; set; } = null!;

        [Input("pkgVersion", required: true)]
        public Input<string> PkgVersion { get; set; } = null!;

        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetApiDetailInvokeArgs()
        {
        }
        public static new GetApiDetailInvokeArgs Empty => new GetApiDetailInvokeArgs();
    }


    [OutputType]
    public sealed class GetApiDetailResult
    {
        public readonly string ApplicationId;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string Method;
        public readonly string MicroserviceId;
        public readonly string Path;
        public readonly string PkgVersion;
        public readonly string? ResultOutputFile;
        public readonly ImmutableArray<Outputs.GetApiDetailResultResult> Results;

        [OutputConstructor]
        private GetApiDetailResult(
            string applicationId,

            string id,

            string method,

            string microserviceId,

            string path,

            string pkgVersion,

            string? resultOutputFile,

            ImmutableArray<Outputs.GetApiDetailResultResult> results)
        {
            ApplicationId = applicationId;
            Id = id;
            Method = method;
            MicroserviceId = microserviceId;
            Path = path;
            PkgVersion = pkgVersion;
            ResultOutputFile = resultOutputFile;
            Results = results;
        }
    }
}