// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Lighthouse
{
    public static class GetInstanceDiskNum
    {
        public static Task<GetInstanceDiskNumResult> InvokeAsync(GetInstanceDiskNumArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetInstanceDiskNumResult>("tencentcloud:Lighthouse/getInstanceDiskNum:getInstanceDiskNum", args ?? new GetInstanceDiskNumArgs(), options.WithDefaults());

        public static Output<GetInstanceDiskNumResult> Invoke(GetInstanceDiskNumInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetInstanceDiskNumResult>("tencentcloud:Lighthouse/getInstanceDiskNum:getInstanceDiskNum", args ?? new GetInstanceDiskNumInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetInstanceDiskNumArgs : global::Pulumi.InvokeArgs
    {
        [Input("instanceIds", required: true)]
        private List<string>? _instanceIds;
        public List<string> InstanceIds
        {
            get => _instanceIds ?? (_instanceIds = new List<string>());
            set => _instanceIds = value;
        }

        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetInstanceDiskNumArgs()
        {
        }
        public static new GetInstanceDiskNumArgs Empty => new GetInstanceDiskNumArgs();
    }

    public sealed class GetInstanceDiskNumInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("instanceIds", required: true)]
        private InputList<string>? _instanceIds;
        public InputList<string> InstanceIds
        {
            get => _instanceIds ?? (_instanceIds = new InputList<string>());
            set => _instanceIds = value;
        }

        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetInstanceDiskNumInvokeArgs()
        {
        }
        public static new GetInstanceDiskNumInvokeArgs Empty => new GetInstanceDiskNumInvokeArgs();
    }


    [OutputType]
    public sealed class GetInstanceDiskNumResult
    {
        public readonly ImmutableArray<Outputs.GetInstanceDiskNumAttachDetailSetResult> AttachDetailSets;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly ImmutableArray<string> InstanceIds;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetInstanceDiskNumResult(
            ImmutableArray<Outputs.GetInstanceDiskNumAttachDetailSetResult> attachDetailSets,

            string id,

            ImmutableArray<string> instanceIds,

            string? resultOutputFile)
        {
            AttachDetailSets = attachDetailSets;
            Id = id;
            InstanceIds = instanceIds;
            ResultOutputFile = resultOutputFile;
        }
    }
}
