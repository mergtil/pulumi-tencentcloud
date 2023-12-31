// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Sqlserver
{
    public static class GetProjectSecurityGroups
    {
        public static Task<GetProjectSecurityGroupsResult> InvokeAsync(GetProjectSecurityGroupsArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetProjectSecurityGroupsResult>("tencentcloud:Sqlserver/getProjectSecurityGroups:getProjectSecurityGroups", args ?? new GetProjectSecurityGroupsArgs(), options.WithDefaults());

        public static Output<GetProjectSecurityGroupsResult> Invoke(GetProjectSecurityGroupsInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetProjectSecurityGroupsResult>("tencentcloud:Sqlserver/getProjectSecurityGroups:getProjectSecurityGroups", args ?? new GetProjectSecurityGroupsInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetProjectSecurityGroupsArgs : global::Pulumi.InvokeArgs
    {
        [Input("projectId", required: true)]
        public int ProjectId { get; set; }

        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetProjectSecurityGroupsArgs()
        {
        }
        public static new GetProjectSecurityGroupsArgs Empty => new GetProjectSecurityGroupsArgs();
    }

    public sealed class GetProjectSecurityGroupsInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("projectId", required: true)]
        public Input<int> ProjectId { get; set; } = null!;

        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetProjectSecurityGroupsInvokeArgs()
        {
        }
        public static new GetProjectSecurityGroupsInvokeArgs Empty => new GetProjectSecurityGroupsInvokeArgs();
    }


    [OutputType]
    public sealed class GetProjectSecurityGroupsResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly int ProjectId;
        public readonly string? ResultOutputFile;
        public readonly ImmutableArray<Outputs.GetProjectSecurityGroupsSecurityGroupSetResult> SecurityGroupSets;

        [OutputConstructor]
        private GetProjectSecurityGroupsResult(
            string id,

            int projectId,

            string? resultOutputFile,

            ImmutableArray<Outputs.GetProjectSecurityGroupsSecurityGroupSetResult> securityGroupSets)
        {
            Id = id;
            ProjectId = projectId;
            ResultOutputFile = resultOutputFile;
            SecurityGroupSets = securityGroupSets;
        }
    }
}
