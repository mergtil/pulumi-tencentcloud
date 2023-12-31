// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Gaap
{
    public static class GetLayer4Listeners
    {
        public static Task<GetLayer4ListenersResult> InvokeAsync(GetLayer4ListenersArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetLayer4ListenersResult>("tencentcloud:Gaap/getLayer4Listeners:getLayer4Listeners", args ?? new GetLayer4ListenersArgs(), options.WithDefaults());

        public static Output<GetLayer4ListenersResult> Invoke(GetLayer4ListenersInvokeArgs args, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetLayer4ListenersResult>("tencentcloud:Gaap/getLayer4Listeners:getLayer4Listeners", args ?? new GetLayer4ListenersInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetLayer4ListenersArgs : global::Pulumi.InvokeArgs
    {
        [Input("listenerId")]
        public string? ListenerId { get; set; }

        [Input("listenerName")]
        public string? ListenerName { get; set; }

        [Input("port")]
        public int? Port { get; set; }

        [Input("protocol", required: true)]
        public string Protocol { get; set; } = null!;

        [Input("proxyId")]
        public string? ProxyId { get; set; }

        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        public GetLayer4ListenersArgs()
        {
        }
        public static new GetLayer4ListenersArgs Empty => new GetLayer4ListenersArgs();
    }

    public sealed class GetLayer4ListenersInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("listenerId")]
        public Input<string>? ListenerId { get; set; }

        [Input("listenerName")]
        public Input<string>? ListenerName { get; set; }

        [Input("port")]
        public Input<int>? Port { get; set; }

        [Input("protocol", required: true)]
        public Input<string> Protocol { get; set; } = null!;

        [Input("proxyId")]
        public Input<string>? ProxyId { get; set; }

        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        public GetLayer4ListenersInvokeArgs()
        {
        }
        public static new GetLayer4ListenersInvokeArgs Empty => new GetLayer4ListenersInvokeArgs();
    }


    [OutputType]
    public sealed class GetLayer4ListenersResult
    {
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly string? ListenerId;
        public readonly string? ListenerName;
        public readonly ImmutableArray<Outputs.GetLayer4ListenersListenerResult> Listeners;
        public readonly int? Port;
        public readonly string Protocol;
        public readonly string? ProxyId;
        public readonly string? ResultOutputFile;

        [OutputConstructor]
        private GetLayer4ListenersResult(
            string id,

            string? listenerId,

            string? listenerName,

            ImmutableArray<Outputs.GetLayer4ListenersListenerResult> listeners,

            int? port,

            string protocol,

            string? proxyId,

            string? resultOutputFile)
        {
            Id = id;
            ListenerId = listenerId;
            ListenerName = listenerName;
            Listeners = listeners;
            Port = port;
            Protocol = protocol;
            ProxyId = proxyId;
            ResultOutputFile = resultOutputFile;
        }
    }
}
