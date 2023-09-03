// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Dcdb.Inputs
{

    public sealed class AccountPrivilegesColumnPrivilegesArgs : global::Pulumi.ResourceArgs
    {
        [Input("column", required: true)]
        public Input<string> Column { get; set; } = null!;

        [Input("database", required: true)]
        public Input<string> Database { get; set; } = null!;

        [Input("privileges", required: true)]
        private InputList<string>? _privileges;
        public InputList<string> Privileges
        {
            get => _privileges ?? (_privileges = new InputList<string>());
            set => _privileges = value;
        }

        [Input("table", required: true)]
        public Input<string> Table { get; set; } = null!;

        public AccountPrivilegesColumnPrivilegesArgs()
        {
        }
        public static new AccountPrivilegesColumnPrivilegesArgs Empty => new AccountPrivilegesColumnPrivilegesArgs();
    }
}