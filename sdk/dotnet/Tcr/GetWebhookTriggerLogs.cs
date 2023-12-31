// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Tcr
{
    public static class GetWebhookTriggerLogs
    {
        public static Task<GetWebhookTriggerLogsResult> InvokeAsync(GetWebhookTriggerLogsArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetWebhookTriggerLogsResult>("tencentcloud:Tcr/getWebhookTriggerLogs:getWebhookTriggerLogs", args ?? new GetWebhookTriggerLogsArgs(), options.WithDefaults());

        public static Output<GetWebhookTriggerLogsResult> Invoke(GetWebhookTriggerLogsInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetWebhookTriggerLogsResult>("tencentcloud:Tcr/getWebhookTriggerLogs:getWebhookTriggerLogs", args ?? new GetWebhookTriggerLogsInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetWebhookTriggerLogsArgs : global::Pulumi.InvokeArgs
    {
        [Input("namespace", required: true)]
        public string Namespace { get; set; } = null!;

        [Input("registryId", required: true)]
        public string RegistryId { get; set; } = null!;

        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        [Input("tags")]
        private Dictionary<string, object>? _tags;
        public Dictionary<string, object> Tags
        {
            get => _tags ?? (_tags = new Dictionary<string, object>());
            set => _tags = value;
        }

        [Input("triggerId", required: true)]
        public int TriggerId { get; set; }

        public GetWebhookTriggerLogsArgs()
        {
        }
        public static new GetWebhookTriggerLogsArgs Empty => new GetWebhookTriggerLogsArgs();
    }

    public sealed class GetWebhookTriggerLogsInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("namespace", required: true)]
        public Input<string> Namespace { get; set; } = null!;

        [Input("registryId", required: true)]
        public Input<string> RegistryId { get; set; } = null!;

        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        [Input("tags")]
        private InputMap<object>? _tags;
        public InputMap<object> Tags
        {
            get => _tags ?? (_tags = new InputMap<object>());
            set => _tags = value;
        }

        [Input("triggerId", required: true)]
        public Input<int> TriggerId { get; set; } = null!;

        public GetWebhookTriggerLogsInvokeArgs()
        {
        }
        public static new GetWebhookTriggerLogsInvokeArgs Empty => new GetWebhookTriggerLogsInvokeArgs();
    }


    [OutputType]
    public sealed class GetWebhookTriggerLogsResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly ImmutableArray<Outputs.GetWebhookTriggerLogsLogResult> Logs;
        public readonly string Namespace;
        public readonly string RegistryId;
        public readonly string? ResultOutputFile;
        public readonly ImmutableDictionary<string, object>? Tags;
        public readonly int TriggerId;

        [OutputConstructor]
        private GetWebhookTriggerLogsResult(
            string id,

            ImmutableArray<Outputs.GetWebhookTriggerLogsLogResult> logs,

            string @namespace,

            string registryId,

            string? resultOutputFile,

            ImmutableDictionary<string, object>? tags,

            int triggerId)
        {
            Id = id;
            Logs = logs;
            Namespace = @namespace;
            RegistryId = registryId;
            ResultOutputFile = resultOutputFile;
            Tags = tags;
            TriggerId = triggerId;
        }
    }
}
