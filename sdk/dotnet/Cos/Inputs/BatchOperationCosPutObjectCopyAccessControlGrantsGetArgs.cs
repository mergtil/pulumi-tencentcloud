// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Cos.Inputs
{

    public sealed class BatchOperationCosPutObjectCopyAccessControlGrantsGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("displayName")]
        public Input<string>? DisplayName { get; set; }

        [Input("identifier", required: true)]
        public Input<string> Identifier { get; set; } = null!;

        [Input("permission", required: true)]
        public Input<string> Permission { get; set; } = null!;

        [Input("typeIdentifier", required: true)]
        public Input<string> TypeIdentifier { get; set; } = null!;

        public BatchOperationCosPutObjectCopyAccessControlGrantsGetArgs()
        {
        }
        public static new BatchOperationCosPutObjectCopyAccessControlGrantsGetArgs Empty => new BatchOperationCosPutObjectCopyAccessControlGrantsGetArgs();
    }
}
