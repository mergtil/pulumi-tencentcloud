// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Sqlserver.Inputs
{

    public sealed class RestoreInstanceRenameRestoreArgs : global::Pulumi.ResourceArgs
    {
        [Input("newName", required: true)]
        public Input<string> NewName { get; set; } = null!;

        [Input("oldName", required: true)]
        public Input<string> OldName { get; set; } = null!;

        public RestoreInstanceRenameRestoreArgs()
        {
        }
        public static new RestoreInstanceRenameRestoreArgs Empty => new RestoreInstanceRenameRestoreArgs();
    }
}
