// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Scf
{
    public static class GetFunctions
    {
        public static Task<GetFunctionsResult> InvokeAsync(GetFunctionsArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetFunctionsResult>("tencentcloud:Scf/getFunctions:getFunctions", args ?? new GetFunctionsArgs(), options.WithDefaults());

        public static Output<GetFunctionsResult> Invoke(GetFunctionsInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetFunctionsResult>("tencentcloud:Scf/getFunctions:getFunctions", args ?? new GetFunctionsInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetFunctionsArgs : global::Pulumi.InvokeArgs
    {
        [Input("description")]
        public string? Description { get; set; }

        [Input("name")]
        public string? Name { get; set; }

        [Input("namespace")]
        public string? Namespace { get; set; }

        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        [Input("tags")]
        private Dictionary<string, object>? _tags;
        public Dictionary<string, object> Tags
        {
            get => _tags ?? (_tags = new Dictionary<string, object>());
            set => _tags = value;
        }

        public GetFunctionsArgs()
        {
        }
        public static new GetFunctionsArgs Empty => new GetFunctionsArgs();
    }

    public sealed class GetFunctionsInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("description")]
        public Input<string>? Description { get; set; }

        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("namespace")]
        public Input<string>? Namespace { get; set; }

        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        [Input("tags")]
        private InputMap<object>? _tags;
        public InputMap<object> Tags
        {
            get => _tags ?? (_tags = new InputMap<object>());
            set => _tags = value;
        }

        public GetFunctionsInvokeArgs()
        {
        }
        public static new GetFunctionsInvokeArgs Empty => new GetFunctionsInvokeArgs();
    }


    [OutputType]
    public sealed class GetFunctionsResult
    {
        public readonly string? Description;
        public readonly ImmutableArray<Outputs.GetFunctionsFunctionResult> ScfFunctions;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string? Name;
        public readonly string? Namespace;
        public readonly string? ResultOutputFile;
        public readonly ImmutableDictionary<string, object>? Tags;

        [OutputConstructor]
        private GetFunctionsResult(
            string? description,

            ImmutableArray<Outputs.GetFunctionsFunctionResult> functions,

            string id,

            string? name,

            string? @namespace,

            string? resultOutputFile,

            ImmutableDictionary<string, object>? tags)
        {
            Description = description;
            ScfFunctions = functions;
            Id = id;
            Name = name;
            Namespace = @namespace;
            ResultOutputFile = resultOutputFile;
            Tags = tags;
        }
    }
}
