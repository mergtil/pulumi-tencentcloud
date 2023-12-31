// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Projects
{
    public static class GetInstance
    {
        public static Task<GetInstanceResult> InvokeAsync(GetInstanceArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetInstanceResult>("tencentcloud:Projects/getInstance:getInstance", args ?? new GetInstanceArgs(), options.WithDefaults());

        public static Output<GetInstanceResult> Invoke(GetInstanceInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetInstanceResult>("tencentcloud:Projects/getInstance:getInstance", args ?? new GetInstanceInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetInstanceArgs : global::Pulumi.InvokeArgs
    {
        [Input("allList", required: true)]
        public int AllList { get; set; }

        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetInstanceArgs()
        {
        }
        public static new GetInstanceArgs Empty => new GetInstanceArgs();
    }

    public sealed class GetInstanceInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("allList", required: true)]
        public Input<int> AllList { get; set; } = null!;

        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetInstanceInvokeArgs()
        {
        }
        public static new GetInstanceInvokeArgs Empty => new GetInstanceInvokeArgs();
    }


    [OutputType]
    public sealed class GetInstanceResult
    {
        public readonly int AllList;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly ImmutableArray<Outputs.GetInstanceProjectResult> Projects;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetInstanceResult(
            int allList,

            string id,

            ImmutableArray<Outputs.GetInstanceProjectResult> projects,

            string? resultOutputFile)
        {
            AllList = allList;
            Id = id;
            Projects = projects;
            ResultOutputFile = resultOutputFile;
        }
    }
}
