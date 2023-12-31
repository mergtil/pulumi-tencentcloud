// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Tsf
{
    public static class GetApplicationFileConfig
    {
        public static Task<GetApplicationFileConfigResult> InvokeAsync(GetApplicationFileConfigArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetApplicationFileConfigResult>("tencentcloud:Tsf/getApplicationFileConfig:getApplicationFileConfig", args ?? new GetApplicationFileConfigArgs(), options.WithDefaults());

        public static Output<GetApplicationFileConfigResult> Invoke(GetApplicationFileConfigInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetApplicationFileConfigResult>("tencentcloud:Tsf/getApplicationFileConfig:getApplicationFileConfig", args ?? new GetApplicationFileConfigInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetApplicationFileConfigArgs : global::Pulumi.InvokeArgs
    {
        [Input("applicationId")]
        public string? ApplicationId { get; set; }

        [Input("configId")]
        public string? ConfigId { get; set; }

        [Input("configIdLists")]
        private List<string>? _configIdLists;
        public List<string> ConfigIdLists
        {
            get => _configIdLists ?? (_configIdLists = new List<string>());
            set => _configIdLists = value;
        }

        [Input("configName")]
        public string? ConfigName { get; set; }

        [Input("configVersion")]
        public string? ConfigVersion { get; set; }

        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetApplicationFileConfigArgs()
        {
        }
        public static new GetApplicationFileConfigArgs Empty => new GetApplicationFileConfigArgs();
    }

    public sealed class GetApplicationFileConfigInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("applicationId")]
        public Input<string>? ApplicationId { get; set; }

        [Input("configId")]
        public Input<string>? ConfigId { get; set; }

        [Input("configIdLists")]
        private InputList<string>? _configIdLists;
        public InputList<string> ConfigIdLists
        {
            get => _configIdLists ?? (_configIdLists = new InputList<string>());
            set => _configIdLists = value;
        }

        [Input("configName")]
        public Input<string>? ConfigName { get; set; }

        [Input("configVersion")]
        public Input<string>? ConfigVersion { get; set; }

        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetApplicationFileConfigInvokeArgs()
        {
        }
        public static new GetApplicationFileConfigInvokeArgs Empty => new GetApplicationFileConfigInvokeArgs();
    }


    [OutputType]
    public sealed class GetApplicationFileConfigResult
    {
        public readonly string? ApplicationId;
        public readonly string? ConfigId;
        public readonly ImmutableArray<string> ConfigIdLists;
        public readonly string? ConfigName;
        public readonly string? ConfigVersion;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string? ResultOutputFile;
        public readonly ImmutableArray<Outputs.GetApplicationFileConfigResultResult> Results;

        [OutputConstructor]
        private GetApplicationFileConfigResult(
            string? applicationId,

            string? configId,

            ImmutableArray<string> configIdLists,

            string? configName,

            string? configVersion,

            string id,

            string? resultOutputFile,

            ImmutableArray<Outputs.GetApplicationFileConfigResultResult> results)
        {
            ApplicationId = applicationId;
            ConfigId = configId;
            ConfigIdLists = configIdLists;
            ConfigName = configName;
            ConfigVersion = configVersion;
            Id = id;
            ResultOutputFile = resultOutputFile;
            Results = results;
        }
    }
}
