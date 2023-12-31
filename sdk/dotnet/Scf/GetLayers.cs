// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Scf
{
    public static class GetLayers
    {
        public static Task<GetLayersResult> InvokeAsync(GetLayersArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetLayersResult>("tencentcloud:Scf/getLayers:getLayers", args ?? new GetLayersArgs(), options.WithDefaults());

        public static Output<GetLayersResult> Invoke(GetLayersInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetLayersResult>("tencentcloud:Scf/getLayers:getLayers", args ?? new GetLayersInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetLayersArgs : global::Pulumi.InvokeArgs
    {
        [Input("compatibleRuntime")]
        public string? CompatibleRuntime { get; set; }

        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        [Input("searchKey")]
        public string? SearchKey { get; set; }

        public GetLayersArgs()
        {
        }
        public static new GetLayersArgs Empty => new GetLayersArgs();
    }

    public sealed class GetLayersInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("compatibleRuntime")]
        public Input<string>? CompatibleRuntime { get; set; }

        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        [Input("searchKey")]
        public Input<string>? SearchKey { get; set; }

        public GetLayersInvokeArgs()
        {
        }
        public static new GetLayersInvokeArgs Empty => new GetLayersInvokeArgs();
    }


    [OutputType]
    public sealed class GetLayersResult
    {
        public readonly string? CompatibleRuntime;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly ImmutableArray<Outputs.GetLayersLayerResult> ScfLayers;
        public readonly string? ResultOutputFile;
        public readonly string? SearchKey;

        [OutputConstructor]
        private GetLayersResult(
            string? compatibleRuntime,

            string id,

            ImmutableArray<Outputs.GetLayersLayerResult> layers,

            string? resultOutputFile,

            string? searchKey)
        {
            CompatibleRuntime = compatibleRuntime;
            Id = id;
            ScfLayers = layers;
            ResultOutputFile = resultOutputFile;
            SearchKey = searchKey;
        }
    }
}
