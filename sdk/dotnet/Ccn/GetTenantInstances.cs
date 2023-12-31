// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Ccn
{
    public static class GetTenantInstances
    {
        public static Task<GetTenantInstancesResult> InvokeAsync(GetTenantInstancesArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetTenantInstancesResult>("tencentcloud:Ccn/getTenantInstances:getTenantInstances", args ?? new GetTenantInstancesArgs(), options.WithDefaults());

        public static Output<GetTenantInstancesResult> Invoke(GetTenantInstancesInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetTenantInstancesResult>("tencentcloud:Ccn/getTenantInstances:getTenantInstances", args ?? new GetTenantInstancesInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetTenantInstancesArgs : global::Pulumi.InvokeArgs
    {
        [Input("ccnIds")]
        private List<string>? _ccnIds;
        public List<string> CcnIds
        {
            get => _ccnIds ?? (_ccnIds = new List<string>());
            set => _ccnIds = value;
        }

        [Input("isSecurityLocks")]
        private List<string>? _isSecurityLocks;
        public List<string> IsSecurityLocks
        {
            get => _isSecurityLocks ?? (_isSecurityLocks = new List<string>());
            set => _isSecurityLocks = value;
        }

        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        [Input("userAccountIds")]
        private List<string>? _userAccountIds;
        public List<string> UserAccountIds
        {
            get => _userAccountIds ?? (_userAccountIds = new List<string>());
            set => _userAccountIds = value;
        }

        public GetTenantInstancesArgs()
        {
        }
        public static new GetTenantInstancesArgs Empty => new GetTenantInstancesArgs();
    }

    public sealed class GetTenantInstancesInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("ccnIds")]
        private InputList<string>? _ccnIds;
        public InputList<string> CcnIds
        {
            get => _ccnIds ?? (_ccnIds = new InputList<string>());
            set => _ccnIds = value;
        }

        [Input("isSecurityLocks")]
        private InputList<string>? _isSecurityLocks;
        public InputList<string> IsSecurityLocks
        {
            get => _isSecurityLocks ?? (_isSecurityLocks = new InputList<string>());
            set => _isSecurityLocks = value;
        }

        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        [Input("userAccountIds")]
        private InputList<string>? _userAccountIds;
        public InputList<string> UserAccountIds
        {
            get => _userAccountIds ?? (_userAccountIds = new InputList<string>());
            set => _userAccountIds = value;
        }

        public GetTenantInstancesInvokeArgs()
        {
        }
        public static new GetTenantInstancesInvokeArgs Empty => new GetTenantInstancesInvokeArgs();
    }


    [OutputType]
    public sealed class GetTenantInstancesResult
    {
        public readonly ImmutableArray<string> CcnIds;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly ImmutableArray<string> IsSecurityLocks;
        public readonly string? ResultOutputFile;
        public readonly ImmutableArray<string> UserAccountIds;

        [OutputConstructor]
        private GetTenantInstancesResult(
            ImmutableArray<string> ccnIds,

            string id,

            ImmutableArray<string> isSecurityLocks,

            string? resultOutputFile,

            ImmutableArray<string> userAccountIds)
        {
            CcnIds = ccnIds;
            Id = id;
            IsSecurityLocks = isSecurityLocks;
            ResultOutputFile = resultOutputFile;
            UserAccountIds = userAccountIds;
        }
    }
}
