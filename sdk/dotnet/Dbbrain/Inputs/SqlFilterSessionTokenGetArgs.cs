// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Dbbrain.Inputs
{

    public sealed class SqlFilterSessionTokenGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("password", required: true)]
        public Input<string> Password { get; set; } = null!;

        [Input("user", required: true)]
        public Input<string> User { get; set; } = null!;

        public SqlFilterSessionTokenGetArgs()
        {
        }
        public static new SqlFilterSessionTokenGetArgs Empty => new SqlFilterSessionTokenGetArgs();
    }
}