// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Sqlserver
{
    public static class GetCrossRegionZone
    {
        public static Task<GetCrossRegionZoneResult> InvokeAsync(GetCrossRegionZoneArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetCrossRegionZoneResult>("tencentcloud:Sqlserver/getCrossRegionZone:getCrossRegionZone", args ?? new GetCrossRegionZoneArgs(), options.WithDefaults());

        public static Output<GetCrossRegionZoneResult> Invoke(GetCrossRegionZoneInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetCrossRegionZoneResult>("tencentcloud:Sqlserver/getCrossRegionZone:getCrossRegionZone", args ?? new GetCrossRegionZoneInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetCrossRegionZoneArgs : global::Pulumi.InvokeArgs
    {
        [Input("instanceId", required: true)]
        public string InstanceId { get; set; } = null!;

        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetCrossRegionZoneArgs()
        {
        }
        public static new GetCrossRegionZoneArgs Empty => new GetCrossRegionZoneArgs();
    }

    public sealed class GetCrossRegionZoneInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("instanceId", required: true)]
        public Input<string> InstanceId { get; set; } = null!;

        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetCrossRegionZoneInvokeArgs()
        {
        }
        public static new GetCrossRegionZoneInvokeArgs Empty => new GetCrossRegionZoneInvokeArgs();
    }


    [OutputType]
    public sealed class GetCrossRegionZoneResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string InstanceId;
        public readonly string Region;
        public readonly string? ResultOutputFile;
        public readonly string Zone;

        [OutputConstructor]
        private GetCrossRegionZoneResult(
            string id,

            string instanceId,

            string region,

            string? resultOutputFile,

            string zone)
        {
            Id = id;
            InstanceId = instanceId;
            Region = region;
            ResultOutputFile = resultOutputFile;
            Zone = zone;
        }
    }
}