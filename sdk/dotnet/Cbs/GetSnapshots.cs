// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Cbs
{
    public static class GetSnapshots
    {
        public static Task<GetSnapshotsResult> InvokeAsync(GetSnapshotsArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetSnapshotsResult>("tencentcloud:Cbs/getSnapshots:getSnapshots", args ?? new GetSnapshotsArgs(), options.WithDefaults());

        public static Output<GetSnapshotsResult> Invoke(GetSnapshotsInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetSnapshotsResult>("tencentcloud:Cbs/getSnapshots:getSnapshots", args ?? new GetSnapshotsInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetSnapshotsArgs : global::Pulumi.InvokeArgs
    {
        [Input("availabilityZone")]
        public string? AvailabilityZone { get; set; }

        [Input("projectId")]
        public int? ProjectId { get; set; }

        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        [Input("snapshotId")]
        public string? SnapshotId { get; set; }

        [Input("snapshotName")]
        public string? SnapshotName { get; set; }

        [Input("storageId")]
        public string? StorageId { get; set; }

        [Input("storageUsage")]
        public string? StorageUsage { get; set; }

        public GetSnapshotsArgs()
        {
        }
        public static new GetSnapshotsArgs Empty => new GetSnapshotsArgs();
    }

    public sealed class GetSnapshotsInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("availabilityZone")]
        public Input<string>? AvailabilityZone { get; set; }

        [Input("projectId")]
        public Input<int>? ProjectId { get; set; }

        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        [Input("snapshotId")]
        public Input<string>? SnapshotId { get; set; }

        [Input("snapshotName")]
        public Input<string>? SnapshotName { get; set; }

        [Input("storageId")]
        public Input<string>? StorageId { get; set; }

        [Input("storageUsage")]
        public Input<string>? StorageUsage { get; set; }

        public GetSnapshotsInvokeArgs()
        {
        }
        public static new GetSnapshotsInvokeArgs Empty => new GetSnapshotsInvokeArgs();
    }


    [OutputType]
    public sealed class GetSnapshotsResult
    {
        public readonly string? AvailabilityZone;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly int? ProjectId;
        public readonly string? ResultOutputFile;
        public readonly string? SnapshotId;
        public readonly ImmutableArray<Outputs.GetSnapshotsSnapshotListResult> SnapshotLists;
        public readonly string? SnapshotName;
        public readonly string? StorageId;
        public readonly string? StorageUsage;

        [OutputConstructor]
        private GetSnapshotsResult(
            string? availabilityZone,

            string id,

            int? projectId,

            string? resultOutputFile,

            string? snapshotId,

            ImmutableArray<Outputs.GetSnapshotsSnapshotListResult> snapshotLists,

            string? snapshotName,

            string? storageId,

            string? storageUsage)
        {
            AvailabilityZone = availabilityZone;
            Id = id;
            ProjectId = projectId;
            ResultOutputFile = resultOutputFile;
            SnapshotId = snapshotId;
            SnapshotLists = snapshotLists;
            SnapshotName = snapshotName;
            StorageId = storageId;
            StorageUsage = storageUsage;
        }
    }
}
