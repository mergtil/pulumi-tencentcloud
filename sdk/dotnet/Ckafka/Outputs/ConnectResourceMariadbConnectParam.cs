// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Ckafka.Outputs
{

    [OutputType]
    public sealed class ConnectResourceMariadbConnectParam
    {
        public readonly bool? IsUpdate;
        public readonly string Password;
        public readonly int Port;
        public readonly string Resource;
        public readonly string? ServiceVip;
        public readonly string? UniqVpcId;
        public readonly string UserName;

        [OutputConstructor]
        private ConnectResourceMariadbConnectParam(
            bool? isUpdate,

            string password,

            int port,

            string resource,

            string? serviceVip,

            string? uniqVpcId,

            string userName)
        {
            IsUpdate = isUpdate;
            Password = password;
            Port = port;
            Resource = resource;
            ServiceVip = serviceVip;
            UniqVpcId = uniqVpcId;
            UserName = userName;
        }
    }
}
