// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Mysql.Outputs
{

    [OutputType]
    public sealed class GetProjectSecurityGroupGroupOutboundResult
    {
        public readonly string Action;
        public readonly string CidrIp;
        public readonly string Desc;
        public readonly string Dir;
        public readonly string IpProtocol;
        public readonly string PortRange;

        [OutputConstructor]
        private GetProjectSecurityGroupGroupOutboundResult(
            string action,

            string cidrIp,

            string desc,

            string dir,

            string ipProtocol,

            string portRange)
        {
            Action = action;
            CidrIp = cidrIp;
            Desc = desc;
            Dir = dir;
            IpProtocol = ipProtocol;
            PortRange = portRange;
        }
    }
}
