// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Vod
{
    public static class GetSuperPlayerConfigs
    {
        public static Task<GetSuperPlayerConfigsResult> InvokeAsync(GetSuperPlayerConfigsArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetSuperPlayerConfigsResult>("tencentcloud:Vod/getSuperPlayerConfigs:getSuperPlayerConfigs", args ?? new GetSuperPlayerConfigsArgs(), options.WithDefaults());

        public static Output<GetSuperPlayerConfigsResult> Invoke(GetSuperPlayerConfigsInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetSuperPlayerConfigsResult>("tencentcloud:Vod/getSuperPlayerConfigs:getSuperPlayerConfigs", args ?? new GetSuperPlayerConfigsInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetSuperPlayerConfigsArgs : global::Pulumi.InvokeArgs
    {
        [Input("name")]
        public string? Name { get; set; }

        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        [Input("subAppId")]
        public int? SubAppId { get; set; }

        [Input("type")]
        public string? Type { get; set; }

        public GetSuperPlayerConfigsArgs()
        {
        }
        public static new GetSuperPlayerConfigsArgs Empty => new GetSuperPlayerConfigsArgs();
    }

    public sealed class GetSuperPlayerConfigsInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        [Input("subAppId")]
        public Input<int>? SubAppId { get; set; }

        [Input("type")]
        public Input<string>? Type { get; set; }

        public GetSuperPlayerConfigsInvokeArgs()
        {
        }
        public static new GetSuperPlayerConfigsInvokeArgs Empty => new GetSuperPlayerConfigsInvokeArgs();
    }


    [OutputType]
    public sealed class GetSuperPlayerConfigsResult
    {
        public readonly ImmutableArray<Outputs.GetSuperPlayerConfigsConfigListResult> ConfigLists;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string? Name;
        public readonly string? ResultOutputFile;
        public readonly int? SubAppId;
        public readonly string? Type;

        [OutputConstructor]
        private GetSuperPlayerConfigsResult(
            ImmutableArray<Outputs.GetSuperPlayerConfigsConfigListResult> configLists,

            string id,

            string? name,

            string? resultOutputFile,

            int? subAppId,

            string? type)
        {
            ConfigLists = configLists;
            Id = id;
            Name = name;
            ResultOutputFile = resultOutputFile;
            SubAppId = subAppId;
            Type = type;
        }
    }
}
