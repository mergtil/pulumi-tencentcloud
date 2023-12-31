// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Scf
{
    public static class GetTriggers
    {
        public static Task<GetTriggersResult> InvokeAsync(GetTriggersArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetTriggersResult>("tencentcloud:Scf/getTriggers:getTriggers", args ?? new GetTriggersArgs(), options.WithDefaults());

        public static Output<GetTriggersResult> Invoke(GetTriggersInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetTriggersResult>("tencentcloud:Scf/getTriggers:getTriggers", args ?? new GetTriggersInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetTriggersArgs : global::Pulumi.InvokeArgs
    {
        [Input("filters")]
        private List<Inputs.GetTriggersFilterArgs>? _filters;
        public List<Inputs.GetTriggersFilterArgs> Filters
        {
            get => _filters ?? (_filters = new List<Inputs.GetTriggersFilterArgs>());
            set => _filters = value;
        }

        [Input("functionName", required: true)]
        public string FunctionName { get; set; } = null!;

        [Input("namespace")]
        public string? Namespace { get; set; }

        [Input("order")]
        public string? Order { get; set; }

        [Input("orderBy")]
        public string? OrderBy { get; set; }

        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetTriggersArgs()
        {
        }
        public static new GetTriggersArgs Empty => new GetTriggersArgs();
    }

    public sealed class GetTriggersInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("filters")]
        private InputList<Inputs.GetTriggersFilterInputArgs>? _filters;
        public InputList<Inputs.GetTriggersFilterInputArgs> Filters
        {
            get => _filters ?? (_filters = new InputList<Inputs.GetTriggersFilterInputArgs>());
            set => _filters = value;
        }

        [Input("functionName", required: true)]
        public Input<string> FunctionName { get; set; } = null!;

        [Input("namespace")]
        public Input<string>? Namespace { get; set; }

        [Input("order")]
        public Input<string>? Order { get; set; }

        [Input("orderBy")]
        public Input<string>? OrderBy { get; set; }

        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetTriggersInvokeArgs()
        {
        }
        public static new GetTriggersInvokeArgs Empty => new GetTriggersInvokeArgs();
    }


    [OutputType]
    public sealed class GetTriggersResult
    {
        public readonly ImmutableArray<Outputs.GetTriggersFilterResult> Filters;
        public readonly string FunctionName;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string? Namespace;
        public readonly string? Order;
        public readonly string? OrderBy;
        public readonly string? ResultOutputFile;
        public readonly ImmutableArray<Outputs.GetTriggersTriggerResult> ScfTriggers;

        [OutputConstructor]
        private GetTriggersResult(
            ImmutableArray<Outputs.GetTriggersFilterResult> filters,

            string functionName,

            string id,

            string? @namespace,

            string? order,

            string? orderBy,

            string? resultOutputFile,

            ImmutableArray<Outputs.GetTriggersTriggerResult> triggers)
        {
            Filters = filters;
            FunctionName = functionName;
            Id = id;
            Namespace = @namespace;
            Order = order;
            OrderBy = orderBy;
            ResultOutputFile = resultOutputFile;
            ScfTriggers = triggers;
        }
    }
}
