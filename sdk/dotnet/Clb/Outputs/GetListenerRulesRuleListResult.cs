// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Clb.Outputs
{

    [OutputType]
    public sealed class GetListenerRulesRuleListResult
    {
        public readonly string CertificateCaId;
        public readonly string CertificateId;
        public readonly string CertificateSslMode;
        public readonly string ClbId;
        public readonly string? Domain;
        public readonly int HealthCheckHealthNum;
        public readonly int HealthCheckHttpCode;
        public readonly string HealthCheckHttpDomain;
        public readonly string HealthCheckHttpMethod;
        public readonly string HealthCheckHttpPath;
        public readonly int HealthCheckIntervalTime;
        public readonly bool HealthCheckSwitch;
        public readonly int HealthCheckUnhealthNum;
        public readonly bool Http2Switch;
        public readonly string ListenerId;
        public readonly string RuleId;
        public readonly string Scheduler;
        public readonly int SessionExpireTime;
        public readonly string? Url;

        [OutputConstructor]
        private GetListenerRulesRuleListResult(
            string certificateCaId,

            string certificateId,

            string certificateSslMode,

            string clbId,

            string? domain,

            int healthCheckHealthNum,

            int healthCheckHttpCode,

            string healthCheckHttpDomain,

            string healthCheckHttpMethod,

            string healthCheckHttpPath,

            int healthCheckIntervalTime,

            bool healthCheckSwitch,

            int healthCheckUnhealthNum,

            bool http2Switch,

            string listenerId,

            string ruleId,

            string scheduler,

            int sessionExpireTime,

            string? url)
        {
            CertificateCaId = certificateCaId;
            CertificateId = certificateId;
            CertificateSslMode = certificateSslMode;
            ClbId = clbId;
            Domain = domain;
            HealthCheckHealthNum = healthCheckHealthNum;
            HealthCheckHttpCode = healthCheckHttpCode;
            HealthCheckHttpDomain = healthCheckHttpDomain;
            HealthCheckHttpMethod = healthCheckHttpMethod;
            HealthCheckHttpPath = healthCheckHttpPath;
            HealthCheckIntervalTime = healthCheckIntervalTime;
            HealthCheckSwitch = healthCheckSwitch;
            HealthCheckUnhealthNum = healthCheckUnhealthNum;
            Http2Switch = http2Switch;
            ListenerId = listenerId;
            RuleId = ruleId;
            Scheduler = scheduler;
            SessionExpireTime = sessionExpireTime;
            Url = url;
        }
    }
}
