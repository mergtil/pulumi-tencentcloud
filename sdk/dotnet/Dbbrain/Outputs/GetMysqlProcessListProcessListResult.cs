// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Dbbrain.Outputs
{

    [OutputType]
    public sealed class GetMysqlProcessListProcessListResult
    {
        public readonly string Command;
        public readonly string Db;
        public readonly string Host;
        public readonly string Id;
        public readonly string Info;
        public readonly string State;
        public readonly string Time;
        public readonly string User;

        [OutputConstructor]
        private GetMysqlProcessListProcessListResult(
            string command,

            string db,

            string host,

            string id,

            string info,

            string state,

            string time,

            string user)
        {
            Command = command;
            Db = db;
            Host = host;
            Id = id;
            Info = info;
            State = state;
            Time = time;
            User = user;
        }
    }
}
