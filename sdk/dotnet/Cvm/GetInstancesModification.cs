// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Cvm
{
    public static class GetInstancesModification
    {
        public static Task<GetInstancesModificationResult> InvokeAsync(GetInstancesModificationArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetInstancesModificationResult>("tencentcloud:Cvm/getInstancesModification:getInstancesModification", args ?? new GetInstancesModificationArgs(), options.WithDefaults());

        public static Output<GetInstancesModificationResult> Invoke(GetInstancesModificationInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetInstancesModificationResult>("tencentcloud:Cvm/getInstancesModification:getInstancesModification", args ?? new GetInstancesModificationInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetInstancesModificationArgs : global::Pulumi.InvokeArgs
    {
        [Input("filters")]
        private List<Inputs.GetInstancesModificationFilterArgs>? _filters;
        public List<Inputs.GetInstancesModificationFilterArgs> Filters
        {
            get => _filters ?? (_filters = new List<Inputs.GetInstancesModificationFilterArgs>());
            set => _filters = value;
        }

        [Input("instanceIds")]
        private List<string>? _instanceIds;
        public List<string> InstanceIds
        {
            get => _instanceIds ?? (_instanceIds = new List<string>());
            set => _instanceIds = value;
        }

        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetInstancesModificationArgs()
        {
        }
        public static new GetInstancesModificationArgs Empty => new GetInstancesModificationArgs();
    }

    public sealed class GetInstancesModificationInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("filters")]
        private InputList<Inputs.GetInstancesModificationFilterInputArgs>? _filters;
        public InputList<Inputs.GetInstancesModificationFilterInputArgs> Filters
        {
            get => _filters ?? (_filters = new InputList<Inputs.GetInstancesModificationFilterInputArgs>());
            set => _filters = value;
        }

        [Input("instanceIds")]
        private InputList<string>? _instanceIds;
        public InputList<string> InstanceIds
        {
            get => _instanceIds ?? (_instanceIds = new InputList<string>());
            set => _instanceIds = value;
        }

        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetInstancesModificationInvokeArgs()
        {
        }
        public static new GetInstancesModificationInvokeArgs Empty => new GetInstancesModificationInvokeArgs();
    }


    [OutputType]
    public sealed class GetInstancesModificationResult
    {
        public readonly ImmutableArray<Outputs.GetInstancesModificationFilterResult> Filters;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly ImmutableArray<string> InstanceIds;
        public readonly ImmutableArray<Outputs.GetInstancesModificationInstanceTypeConfigStatusListResult> InstanceTypeConfigStatusLists;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetInstancesModificationResult(
            ImmutableArray<Outputs.GetInstancesModificationFilterResult> filters,

            string id,

            ImmutableArray<string> instanceIds,

            ImmutableArray<Outputs.GetInstancesModificationInstanceTypeConfigStatusListResult> instanceTypeConfigStatusLists,

            string? resultOutputFile)
        {
            Filters = filters;
            Id = id;
            InstanceIds = instanceIds;
            InstanceTypeConfigStatusLists = instanceTypeConfigStatusLists;
            ResultOutputFile = resultOutputFile;
        }
    }
}
