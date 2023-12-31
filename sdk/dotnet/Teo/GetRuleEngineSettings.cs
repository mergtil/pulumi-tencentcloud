// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Teo
{
    public static class GetRuleEngineSettings
    {
        public static Task<GetRuleEngineSettingsResult> InvokeAsync(GetRuleEngineSettingsArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetRuleEngineSettingsResult>("tencentcloud:Teo/getRuleEngineSettings:getRuleEngineSettings", args ?? new GetRuleEngineSettingsArgs(), options.WithDefaults());

        public static Output<GetRuleEngineSettingsResult> Invoke(GetRuleEngineSettingsInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetRuleEngineSettingsResult>("tencentcloud:Teo/getRuleEngineSettings:getRuleEngineSettings", args ?? new GetRuleEngineSettingsInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetRuleEngineSettingsArgs : global::Pulumi.InvokeArgs
    {
        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetRuleEngineSettingsArgs()
        {
        }
        public static new GetRuleEngineSettingsArgs Empty => new GetRuleEngineSettingsArgs();
    }

    public sealed class GetRuleEngineSettingsInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetRuleEngineSettingsInvokeArgs()
        {
        }
        public static new GetRuleEngineSettingsInvokeArgs Empty => new GetRuleEngineSettingsInvokeArgs();
    }


    [OutputType]
    public sealed class GetRuleEngineSettingsResult
    {
        public readonly ImmutableArray<Outputs.GetRuleEngineSettingsActionResult> Actions;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetRuleEngineSettingsResult(
            ImmutableArray<Outputs.GetRuleEngineSettingsActionResult> actions,

            string id,

            string? resultOutputFile)
        {
            Actions = actions;
            Id = id;
            ResultOutputFile = resultOutputFile;
        }
    }
}
