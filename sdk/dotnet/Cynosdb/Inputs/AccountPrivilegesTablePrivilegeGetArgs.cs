// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Cynosdb.Inputs
{

    public sealed class AccountPrivilegesTablePrivilegeGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("db", required: true)]
        public Input<string> Db { get; set; } = null!;

        [Input("privileges", required: true)]
        private InputList<string>? _privileges;
        public InputList<string> Privileges
        {
            get => _privileges ?? (_privileges = new InputList<string>());
            set => _privileges = value;
        }

        [Input("tableName", required: true)]
        public Input<string> TableName { get; set; } = null!;

        public AccountPrivilegesTablePrivilegeGetArgs()
        {
        }
        public static new AccountPrivilegesTablePrivilegeGetArgs Empty => new AccountPrivilegesTablePrivilegeGetArgs();
    }
}
