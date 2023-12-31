// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Postgresql
{
    public static class GetDefaultParameters
    {
        public static Task<GetDefaultParametersResult> InvokeAsync(GetDefaultParametersArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetDefaultParametersResult>("tencentcloud:Postgresql/getDefaultParameters:getDefaultParameters", args ?? new GetDefaultParametersArgs(), options.WithDefaults());

        public static Output<GetDefaultParametersResult> Invoke(GetDefaultParametersInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetDefaultParametersResult>("tencentcloud:Postgresql/getDefaultParameters:getDefaultParameters", args ?? new GetDefaultParametersInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetDefaultParametersArgs : global::Pulumi.InvokeArgs
    {
        [Input("dbEngine", required: true)]
        public string DbEngine { get; set; } = null!;

        [Input("dbMajorVersion", required: true)]
        public string DbMajorVersion { get; set; } = null!;

        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetDefaultParametersArgs()
        {
        }
        public static new GetDefaultParametersArgs Empty => new GetDefaultParametersArgs();
    }

    public sealed class GetDefaultParametersInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("dbEngine", required: true)]
        public Input<string> DbEngine { get; set; } = null!;

        [Input("dbMajorVersion", required: true)]
        public Input<string> DbMajorVersion { get; set; } = null!;

        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetDefaultParametersInvokeArgs()
        {
        }
        public static new GetDefaultParametersInvokeArgs Empty => new GetDefaultParametersInvokeArgs();
    }


    [OutputType]
    public sealed class GetDefaultParametersResult
    {
        public readonly string DbEngine;
        public readonly string DbMajorVersion;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly ImmutableArray<Outputs.GetDefaultParametersParamInfoSetResult> ParamInfoSets;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetDefaultParametersResult(
            string dbEngine,

            string dbMajorVersion,

            string id,

            ImmutableArray<Outputs.GetDefaultParametersParamInfoSetResult> paramInfoSets,

            string? resultOutputFile)
        {
            DbEngine = dbEngine;
            DbMajorVersion = dbMajorVersion;
            Id = id;
            ParamInfoSets = paramInfoSets;
            ResultOutputFile = resultOutputFile;
        }
    }
}
