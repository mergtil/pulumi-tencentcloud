// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Scf
{
    public static class GetLayerVersions
    {
        public static Task<GetLayerVersionsResult> InvokeAsync(GetLayerVersionsArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetLayerVersionsResult>("tencentcloud:Scf/getLayerVersions:getLayerVersions", args ?? new GetLayerVersionsArgs(), options.WithDefaults());

        public static Output<GetLayerVersionsResult> Invoke(GetLayerVersionsInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetLayerVersionsResult>("tencentcloud:Scf/getLayerVersions:getLayerVersions", args ?? new GetLayerVersionsInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetLayerVersionsArgs : global::Pulumi.InvokeArgs
    {
        [Input("compatibleRuntimes")]
        private List<string>? _compatibleRuntimes;
        public List<string> CompatibleRuntimes
        {
            get => _compatibleRuntimes ?? (_compatibleRuntimes = new List<string>());
            set => _compatibleRuntimes = value;
        }

        [Input("layerName", required: true)]
        public string LayerName { get; set; } = null!;

        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetLayerVersionsArgs()
        {
        }
        public static new GetLayerVersionsArgs Empty => new GetLayerVersionsArgs();
    }

    public sealed class GetLayerVersionsInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("compatibleRuntimes")]
        private InputList<string>? _compatibleRuntimes;
        public InputList<string> CompatibleRuntimes
        {
            get => _compatibleRuntimes ?? (_compatibleRuntimes = new InputList<string>());
            set => _compatibleRuntimes = value;
        }

        [Input("layerName", required: true)]
        public Input<string> LayerName { get; set; } = null!;

        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetLayerVersionsInvokeArgs()
        {
        }
        public static new GetLayerVersionsInvokeArgs Empty => new GetLayerVersionsInvokeArgs();
    }


    [OutputType]
    public sealed class GetLayerVersionsResult
    {
        public readonly ImmutableArray<string> CompatibleRuntimes;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string LayerName;
        public readonly ImmutableArray<Outputs.GetLayerVersionsLayerVersionResult> ScfLayerVersions;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetLayerVersionsResult(
            ImmutableArray<string> compatibleRuntimes,

            string id,

            string layerName,

            ImmutableArray<Outputs.GetLayerVersionsLayerVersionResult> layerVersions,

            string? resultOutputFile)
        {
            CompatibleRuntimes = compatibleRuntimes;
            Id = id;
            LayerName = layerName;
            ScfLayerVersions = layerVersions;
            ResultOutputFile = resultOutputFile;
        }
    }
}