// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Tse.Outputs
{

    [OutputType]
    public sealed class GetGatewayRoutesResultRouteListResult
    {
        public readonly string CreatedTime;
        public readonly ImmutableArray<int> DestinationPorts;
        public readonly bool ForceHttps;
        public readonly ImmutableArray<Outputs.GetGatewayRoutesResultRouteListHeaderResult> Headers;
        public readonly ImmutableArray<string> Hosts;
        public readonly int HttpsRedirectStatusCode;
        public readonly string Id;
        public readonly ImmutableArray<string> Methods;
        public readonly string Name;
        public readonly ImmutableArray<string> Paths;
        public readonly bool PreserveHost;
        public readonly ImmutableArray<string> Protocols;
        public readonly string ServiceId;
        public readonly string ServiceName;
        public readonly bool StripPath;

        [OutputConstructor]
        private GetGatewayRoutesResultRouteListResult(
            string createdTime,

            ImmutableArray<int> destinationPorts,

            bool forceHttps,

            ImmutableArray<Outputs.GetGatewayRoutesResultRouteListHeaderResult> headers,

            ImmutableArray<string> hosts,

            int httpsRedirectStatusCode,

            string id,

            ImmutableArray<string> methods,

            string name,

            ImmutableArray<string> paths,

            bool preserveHost,

            ImmutableArray<string> protocols,

            string serviceId,

            string serviceName,

            bool stripPath)
        {
            CreatedTime = createdTime;
            DestinationPorts = destinationPorts;
            ForceHttps = forceHttps;
            Headers = headers;
            Hosts = hosts;
            HttpsRedirectStatusCode = httpsRedirectStatusCode;
            Id = id;
            Methods = methods;
            Name = name;
            Paths = paths;
            PreserveHost = preserveHost;
            Protocols = protocols;
            ServiceId = serviceId;
            ServiceName = serviceName;
            StripPath = stripPath;
        }
    }
}