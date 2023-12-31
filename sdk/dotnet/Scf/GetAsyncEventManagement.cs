// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Scf
{
    public static class GetAsyncEventManagement
    {
        public static Task<GetAsyncEventManagementResult> InvokeAsync(GetAsyncEventManagementArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetAsyncEventManagementResult>("tencentcloud:Scf/getAsyncEventManagement:getAsyncEventManagement", args ?? new GetAsyncEventManagementArgs(), options.WithDefaults());

        public static Output<GetAsyncEventManagementResult> Invoke(GetAsyncEventManagementInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetAsyncEventManagementResult>("tencentcloud:Scf/getAsyncEventManagement:getAsyncEventManagement", args ?? new GetAsyncEventManagementInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetAsyncEventManagementArgs : global::Pulumi.InvokeArgs
    {
        [Input("functionName", required: true)]
        public string FunctionName { get; set; } = null!;

        [Input("invokeRequestId")]
        public string? InvokeRequestId { get; set; }

        [Input("invokeTypes")]
        private List<string>? _invokeTypes;
        public List<string> InvokeTypes
        {
            get => _invokeTypes ?? (_invokeTypes = new List<string>());
            set => _invokeTypes = value;
        }

        [Input("namespace")]
        public string? Namespace { get; set; }

        [Input("order")]
        public string? Order { get; set; }

        [Input("orderby")]
        public string? Orderby { get; set; }

        [Input("qualifier")]
        public string? Qualifier { get; set; }

        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        [Input("statuses")]
        private List<string>? _statuses;
        public List<string> Statuses
        {
            get => _statuses ?? (_statuses = new List<string>());
            set => _statuses = value;
        }

        public GetAsyncEventManagementArgs()
        {
        }
        public static new GetAsyncEventManagementArgs Empty => new GetAsyncEventManagementArgs();
    }

    public sealed class GetAsyncEventManagementInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("functionName", required: true)]
        public Input<string> FunctionName { get; set; } = null!;

        [Input("invokeRequestId")]
        public Input<string>? InvokeRequestId { get; set; }

        [Input("invokeTypes")]
        private InputList<string>? _invokeTypes;
        public InputList<string> InvokeTypes
        {
            get => _invokeTypes ?? (_invokeTypes = new InputList<string>());
            set => _invokeTypes = value;
        }

        [Input("namespace")]
        public Input<string>? Namespace { get; set; }

        [Input("order")]
        public Input<string>? Order { get; set; }

        [Input("orderby")]
        public Input<string>? Orderby { get; set; }

        [Input("qualifier")]
        public Input<string>? Qualifier { get; set; }

        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        [Input("statuses")]
        private InputList<string>? _statuses;
        public InputList<string> Statuses
        {
            get => _statuses ?? (_statuses = new InputList<string>());
            set => _statuses = value;
        }

        public GetAsyncEventManagementInvokeArgs()
        {
        }
        public static new GetAsyncEventManagementInvokeArgs Empty => new GetAsyncEventManagementInvokeArgs();
    }


    [OutputType]
    public sealed class GetAsyncEventManagementResult
    {
        public readonly ImmutableArray<Outputs.GetAsyncEventManagementEventListResult> EventLists;
        public readonly string FunctionName;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string? InvokeRequestId;
        public readonly ImmutableArray<string> InvokeTypes;
        public readonly string? Namespace;
        public readonly string? Order;
        public readonly string? Orderby;
        public readonly string? Qualifier;
        public readonly string? ResultOutputFile;
        public readonly ImmutableArray<string> Statuses;

        [OutputConstructor]
        private GetAsyncEventManagementResult(
            ImmutableArray<Outputs.GetAsyncEventManagementEventListResult> eventLists,

            string functionName,

            string id,

            string? invokeRequestId,

            ImmutableArray<string> invokeTypes,

            string? @namespace,

            string? order,

            string? orderby,

            string? qualifier,

            string? resultOutputFile,

            ImmutableArray<string> statuses)
        {
            EventLists = eventLists;
            FunctionName = functionName;
            Id = id;
            InvokeRequestId = invokeRequestId;
            InvokeTypes = invokeTypes;
            Namespace = @namespace;
            Order = order;
            Orderby = orderby;
            Qualifier = qualifier;
            ResultOutputFile = resultOutputFile;
            Statuses = statuses;
        }
    }
}
