// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Monitor
{
    public static class GetPolicyGroups
    {
        public static Task<GetPolicyGroupsResult> InvokeAsync(GetPolicyGroupsArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetPolicyGroupsResult>("tencentcloud:Monitor/getPolicyGroups:getPolicyGroups", args ?? new GetPolicyGroupsArgs(), options.WithDefaults());

        public static Output<GetPolicyGroupsResult> Invoke(GetPolicyGroupsInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetPolicyGroupsResult>("tencentcloud:Monitor/getPolicyGroups:getPolicyGroups", args ?? new GetPolicyGroupsInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetPolicyGroupsArgs : global::Pulumi.InvokeArgs
    {
        [Input("name")]
        public string? Name { get; set; }

        [Input("policyViewNames")]
        private List<string>? _policyViewNames;
        public List<string> PolicyViewNames
        {
            get => _policyViewNames ?? (_policyViewNames = new List<string>());
            set => _policyViewNames = value;
        }

        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetPolicyGroupsArgs()
        {
        }
        public static new GetPolicyGroupsArgs Empty => new GetPolicyGroupsArgs();
    }

    public sealed class GetPolicyGroupsInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("name")]
        public Input<string>? Name { get; set; }

        [Input("policyViewNames")]
        private InputList<string>? _policyViewNames;
        public InputList<string> PolicyViewNames
        {
            get => _policyViewNames ?? (_policyViewNames = new InputList<string>());
            set => _policyViewNames = value;
        }

        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetPolicyGroupsInvokeArgs()
        {
        }
        public static new GetPolicyGroupsInvokeArgs Empty => new GetPolicyGroupsInvokeArgs();
    }


    [OutputType]
    public sealed class GetPolicyGroupsResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly ImmutableArray<Outputs.GetPolicyGroupsListResult> Lists;
        public readonly string? Name;
        public readonly ImmutableArray<string> PolicyViewNames;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetPolicyGroupsResult(
            string id,

            ImmutableArray<Outputs.GetPolicyGroupsListResult> lists,

            string? name,

            ImmutableArray<string> policyViewNames,

            string? resultOutputFile)
        {
            Id = id;
            Lists = lists;
            Name = name;
            PolicyViewNames = policyViewNames;
            ResultOutputFile = resultOutputFile;
        }
    }
}