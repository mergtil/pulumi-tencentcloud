// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Lighthouse
{
    public static class GetScene
    {
        public static Task<GetSceneResult> InvokeAsync(GetSceneArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetSceneResult>("tencentcloud:Lighthouse/getScene:getScene", args ?? new GetSceneArgs(), options.WithDefaults());

        public static Output<GetSceneResult> Invoke(GetSceneInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetSceneResult>("tencentcloud:Lighthouse/getScene:getScene", args ?? new GetSceneInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetSceneArgs : global::Pulumi.InvokeArgs
    {
        [Input("limit")]
        public int? Limit { get; set; }

        [Input("offset")]
        public int? Offset { get; set; }

        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        [Input("sceneIds")]
        private List<string>? _sceneIds;
        public List<string> SceneIds
        {
            get => _sceneIds ?? (_sceneIds = new List<string>());
            set => _sceneIds = value;
        }

        public GetSceneArgs()
        {
        }
        public static new GetSceneArgs Empty => new GetSceneArgs();
    }

    public sealed class GetSceneInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("limit")]
        public Input<int>? Limit { get; set; }

        [Input("offset")]
        public Input<int>? Offset { get; set; }

        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        [Input("sceneIds")]
        private InputList<string>? _sceneIds;
        public InputList<string> SceneIds
        {
            get => _sceneIds ?? (_sceneIds = new InputList<string>());
            set => _sceneIds = value;
        }

        public GetSceneInvokeArgs()
        {
        }
        public static new GetSceneInvokeArgs Empty => new GetSceneInvokeArgs();
    }


    [OutputType]
    public sealed class GetSceneResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly int? Limit;
        public readonly int? Offset;
        public readonly string? ResultOutputFile;
        public readonly ImmutableArray<string> SceneIds;
        public readonly ImmutableArray<Outputs.GetSceneSceneSetResult> SceneSets;

        [OutputConstructor]
        private GetSceneResult(
            string id,

            int? limit,

            int? offset,

            string? resultOutputFile,

            ImmutableArray<string> sceneIds,

            ImmutableArray<Outputs.GetSceneSceneSetResult> sceneSets)
        {
            Id = id;
            Limit = limit;
            Offset = offset;
            ResultOutputFile = resultOutputFile;
            SceneIds = sceneIds;
            SceneSets = sceneSets;
        }
    }
}
