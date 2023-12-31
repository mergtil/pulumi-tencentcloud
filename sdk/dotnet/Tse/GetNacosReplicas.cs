// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Tse
{
    public static class GetNacosReplicas
    {
        public static Task<GetNacosReplicasResult> InvokeAsync(GetNacosReplicasArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetNacosReplicasResult>("tencentcloud:Tse/getNacosReplicas:getNacosReplicas", args ?? new GetNacosReplicasArgs(), options.WithDefaults());

        public static Output<GetNacosReplicasResult> Invoke(GetNacosReplicasInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetNacosReplicasResult>("tencentcloud:Tse/getNacosReplicas:getNacosReplicas", args ?? new GetNacosReplicasInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetNacosReplicasArgs : global::Pulumi.InvokeArgs
    {
        [Input("instanceId", required: true)]
        public string InstanceId { get; set; } = null!;

        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetNacosReplicasArgs()
        {
        }
        public static new GetNacosReplicasArgs Empty => new GetNacosReplicasArgs();
    }

    public sealed class GetNacosReplicasInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("instanceId", required: true)]
        public Input<string> InstanceId { get; set; } = null!;

        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetNacosReplicasInvokeArgs()
        {
        }
        public static new GetNacosReplicasInvokeArgs Empty => new GetNacosReplicasInvokeArgs();
    }


    [OutputType]
    public sealed class GetNacosReplicasResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string InstanceId;
        public readonly ImmutableArray<Outputs.GetNacosReplicasReplicaResult> Replicas;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetNacosReplicasResult(
            string id,

            string instanceId,

            ImmutableArray<Outputs.GetNacosReplicasReplicaResult> replicas,

            string? resultOutputFile)
        {
            Id = id;
            InstanceId = instanceId;
            Replicas = replicas;
            ResultOutputFile = resultOutputFile;
        }
    }
}
