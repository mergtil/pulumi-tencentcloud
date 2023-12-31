// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Cos.Inputs
{

    public sealed class BatchOperationCosPutObjectCopyNewObjectMetadataGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("cacheControl")]
        public Input<string>? CacheControl { get; set; }

        [Input("contentDisposition")]
        public Input<string>? ContentDisposition { get; set; }

        [Input("contentEncoding")]
        public Input<string>? ContentEncoding { get; set; }

        [Input("contentType")]
        public Input<string>? ContentType { get; set; }

        [Input("httpExpiresDate")]
        public Input<string>? HttpExpiresDate { get; set; }

        [Input("sseAlgorithm")]
        public Input<string>? SseAlgorithm { get; set; }

        [Input("userMetadatas")]
        private InputList<Inputs.BatchOperationCosPutObjectCopyNewObjectMetadataUserMetadataGetArgs>? _userMetadatas;
        public InputList<Inputs.BatchOperationCosPutObjectCopyNewObjectMetadataUserMetadataGetArgs> UserMetadatas
        {
            get => _userMetadatas ?? (_userMetadatas = new InputList<Inputs.BatchOperationCosPutObjectCopyNewObjectMetadataUserMetadataGetArgs>());
            set => _userMetadatas = value;
        }

        public BatchOperationCosPutObjectCopyNewObjectMetadataGetArgs()
        {
        }
        public static new BatchOperationCosPutObjectCopyNewObjectMetadataGetArgs Empty => new BatchOperationCosPutObjectCopyNewObjectMetadataGetArgs();
    }
}
