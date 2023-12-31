// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Gaap.Outputs
{

    [OutputType]
    public sealed class GetHttpRulesRuleResult
    {
        public readonly int ConnectTimeout;
        public readonly string Domain;
        public readonly string ForwardHost;
        public readonly bool HealthCheck;
        public readonly string HealthCheckMethod;
        public readonly string HealthCheckPath;
        public readonly ImmutableArray<int> HealthCheckStatusCodes;
        public readonly string Id;
        public readonly int Interval;
        public readonly string ListenerId;
        public readonly string Path;
        public readonly string RealserverType;
        public readonly ImmutableArray<Outputs.GetHttpRulesRuleRealserverResult> Realservers;
        public readonly string Scheduler;
        public readonly string Sni;
        public readonly string SniSwitch;

        [OutputConstructor]
        private GetHttpRulesRuleResult(
            int connectTimeout,

            string domain,

            string forwardHost,

            bool healthCheck,

            string healthCheckMethod,

            string healthCheckPath,

            ImmutableArray<int> healthCheckStatusCodes,

            string id,

            int interval,

            string listenerId,

            string path,

            string realserverType,

            ImmutableArray<Outputs.GetHttpRulesRuleRealserverResult> realservers,

            string scheduler,

            string sni,

            string sniSwitch)
        {
            ConnectTimeout = connectTimeout;
            Domain = domain;
            ForwardHost = forwardHost;
            HealthCheck = healthCheck;
            HealthCheckMethod = healthCheckMethod;
            HealthCheckPath = healthCheckPath;
            HealthCheckStatusCodes = healthCheckStatusCodes;
            Id = id;
            Interval = interval;
            ListenerId = listenerId;
            Path = path;
            RealserverType = realserverType;
            Realservers = realservers;
            Scheduler = scheduler;
            Sni = sni;
            SniSwitch = sniSwitch;
        }
    }
}
