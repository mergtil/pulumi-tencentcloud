// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.ApiGateway.Outputs
{

    [OutputType]
    public sealed class GetCustomerDomainsListResult
    {
        public readonly string CertificateId;
        public readonly string DomainName;
        public readonly bool IsDefaultMapping;
        public readonly bool IsStatusOn;
        public readonly string NetType;
        public readonly ImmutableArray<Outputs.GetCustomerDomainsListPathMappingResult> PathMappings;
        public readonly string Protocol;

        [OutputConstructor]
        private GetCustomerDomainsListResult(
            string certificateId,

            string domainName,

            bool isDefaultMapping,

            bool isStatusOn,

            string netType,

            ImmutableArray<Outputs.GetCustomerDomainsListPathMappingResult> pathMappings,

            string protocol)
        {
            CertificateId = certificateId;
            DomainName = domainName;
            IsDefaultMapping = isDefaultMapping;
            IsStatusOn = isStatusOn;
            NetType = netType;
            PathMappings = pathMappings;
            Protocol = protocol;
        }
    }
}
