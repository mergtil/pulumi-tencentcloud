// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Deprecatedeks.Outputs
{

    [OutputType]
    public sealed class ContainerInstanceImageRegistryCredential
    {
        public readonly string? Name;
        public readonly string? Password;
        public readonly string? Server;
        public readonly string? Username;

        [OutputConstructor]
        private ContainerInstanceImageRegistryCredential(
            string? name,

            string? password,

            string? server,

            string? username)
        {
            Name = name;
            Password = password;
            Server = server;
            Username = username;
        }
    }
}
