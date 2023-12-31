// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Dbbrain.Inputs
{

    public sealed class TdsqlAuditLogFilterGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("affectRows")]
        public Input<int>? AffectRows { get; set; }

        [Input("dbNames")]
        private InputList<string>? _dbNames;
        public InputList<string> DbNames
        {
            get => _dbNames ?? (_dbNames = new InputList<string>());
            set => _dbNames = value;
        }

        [Input("execTime")]
        public Input<int>? ExecTime { get; set; }

        [Input("hosts")]
        private InputList<string>? _hosts;
        public InputList<string> Hosts
        {
            get => _hosts ?? (_hosts = new InputList<string>());
            set => _hosts = value;
        }

        [Input("sentRows")]
        public Input<int>? SentRows { get; set; }

        [Input("users")]
        private InputList<string>? _users;
        public InputList<string> Users
        {
            get => _users ?? (_users = new InputList<string>());
            set => _users = value;
        }

        public TdsqlAuditLogFilterGetArgs()
        {
        }
        public static new TdsqlAuditLogFilterGetArgs Empty => new TdsqlAuditLogFilterGetArgs();
    }
}
