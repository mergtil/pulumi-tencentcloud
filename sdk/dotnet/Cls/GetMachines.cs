// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Cls
{
    public static class GetMachines
    {
        public static Task<GetMachinesResult> InvokeAsync(GetMachinesArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetMachinesResult>("tencentcloud:Cls/getMachines:getMachines", args ?? new GetMachinesArgs(), options.WithDefaults());

        public static Output<GetMachinesResult> Invoke(GetMachinesInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetMachinesResult>("tencentcloud:Cls/getMachines:getMachines", args ?? new GetMachinesInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetMachinesArgs : global::Pulumi.InvokeArgs
    {
        [Input("groupId", required: true)]
        public string GroupId { get; set; } = null!;

        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetMachinesArgs()
        {
        }
        public static new GetMachinesArgs Empty => new GetMachinesArgs();
    }

    public sealed class GetMachinesInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("groupId", required: true)]
        public Input<string> GroupId { get; set; } = null!;

        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetMachinesInvokeArgs()
        {
        }
        public static new GetMachinesInvokeArgs Empty => new GetMachinesInvokeArgs();
    }


    [OutputType]
    public sealed class GetMachinesResult
    {
        public readonly string GroupId;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly ImmutableArray<Outputs.GetMachinesMachineResult> ClsMachines;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetMachinesResult(
            string groupId,

            string id,

            ImmutableArray<Outputs.GetMachinesMachineResult> machines,

            string? resultOutputFile)
        {
            GroupId = groupId;
            Id = id;
            ClsMachines = machines;
            ResultOutputFile = resultOutputFile;
        }
    }
}
