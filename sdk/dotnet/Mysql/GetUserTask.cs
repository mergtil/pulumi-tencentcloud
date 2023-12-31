// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Mysql
{
    public static class GetUserTask
    {
        public static Task<GetUserTaskResult> InvokeAsync(GetUserTaskArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetUserTaskResult>("tencentcloud:Mysql/getUserTask:getUserTask", args ?? new GetUserTaskArgs(), options.WithDefaults());

        public static Output<GetUserTaskResult> Invoke(GetUserTaskInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetUserTaskResult>("tencentcloud:Mysql/getUserTask:getUserTask", args ?? new GetUserTaskInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetUserTaskArgs : global::Pulumi.InvokeArgs
    {
        [Input("asyncRequestId")]
        public string? AsyncRequestId { get; set; }

        [Input("instanceId")]
        public string? InstanceId { get; set; }

        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        [Input("startTimeBegin")]
        public string? StartTimeBegin { get; set; }

        [Input("startTimeEnd")]
        public string? StartTimeEnd { get; set; }

        [Input("taskStatuses")]
        private List<string>? _taskStatuses;
        public List<string> TaskStatuses
        {
            get => _taskStatuses ?? (_taskStatuses = new List<string>());
            set => _taskStatuses = value;
        }

        [Input("taskTypes")]
        private List<string>? _taskTypes;
        public List<string> TaskTypes
        {
            get => _taskTypes ?? (_taskTypes = new List<string>());
            set => _taskTypes = value;
        }

        public GetUserTaskArgs()
        {
        }
        public static new GetUserTaskArgs Empty => new GetUserTaskArgs();
    }

    public sealed class GetUserTaskInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("asyncRequestId")]
        public Input<string>? AsyncRequestId { get; set; }

        [Input("instanceId")]
        public Input<string>? InstanceId { get; set; }

        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        [Input("startTimeBegin")]
        public Input<string>? StartTimeBegin { get; set; }

        [Input("startTimeEnd")]
        public Input<string>? StartTimeEnd { get; set; }

        [Input("taskStatuses")]
        private InputList<string>? _taskStatuses;
        public InputList<string> TaskStatuses
        {
            get => _taskStatuses ?? (_taskStatuses = new InputList<string>());
            set => _taskStatuses = value;
        }

        [Input("taskTypes")]
        private InputList<string>? _taskTypes;
        public InputList<string> TaskTypes
        {
            get => _taskTypes ?? (_taskTypes = new InputList<string>());
            set => _taskTypes = value;
        }

        public GetUserTaskInvokeArgs()
        {
        }
        public static new GetUserTaskInvokeArgs Empty => new GetUserTaskInvokeArgs();
    }


    [OutputType]
    public sealed class GetUserTaskResult
    {
        public readonly string? AsyncRequestId;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string? InstanceId;
        public readonly ImmutableArray<Outputs.GetUserTaskItemResult> Items;
        public readonly string? ResultOutputFile;
        public readonly string? StartTimeBegin;
        public readonly string? StartTimeEnd;
        public readonly ImmutableArray<string> TaskStatuses;
        public readonly ImmutableArray<string> TaskTypes;

        [OutputConstructor]
        private GetUserTaskResult(
            string? asyncRequestId,

            string id,

            string? instanceId,

            ImmutableArray<Outputs.GetUserTaskItemResult> items,

            string? resultOutputFile,

            string? startTimeBegin,

            string? startTimeEnd,

            ImmutableArray<string> taskStatuses,

            ImmutableArray<string> taskTypes)
        {
            AsyncRequestId = asyncRequestId;
            Id = id;
            InstanceId = instanceId;
            Items = items;
            ResultOutputFile = resultOutputFile;
            StartTimeBegin = startTimeBegin;
            StartTimeEnd = startTimeEnd;
            TaskStatuses = taskStatuses;
            TaskTypes = taskTypes;
        }
    }
}
