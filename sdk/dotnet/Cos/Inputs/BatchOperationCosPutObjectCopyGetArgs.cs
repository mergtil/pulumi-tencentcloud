// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Cos.Inputs
{

    public sealed class BatchOperationCosPutObjectCopyGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("accessControlDirective")]
        public Input<string>? AccessControlDirective { get; set; }

        [Input("accessControlGrants")]
        public Input<Inputs.BatchOperationCosPutObjectCopyAccessControlGrantsGetArgs>? AccessControlGrants { get; set; }

        [Input("cannedAccessControlList")]
        public Input<string>? CannedAccessControlList { get; set; }

        [Input("metadataDirective")]
        public Input<string>? MetadataDirective { get; set; }

        [Input("modifiedSinceConstraint")]
        public Input<int>? ModifiedSinceConstraint { get; set; }

        [Input("newObjectMetadata")]
        public Input<Inputs.BatchOperationCosPutObjectCopyNewObjectMetadataGetArgs>? NewObjectMetadata { get; set; }

        [Input("newObjectTaggings")]
        private InputList<Inputs.BatchOperationCosPutObjectCopyNewObjectTaggingGetArgs>? _newObjectTaggings;
        public InputList<Inputs.BatchOperationCosPutObjectCopyNewObjectTaggingGetArgs> NewObjectTaggings
        {
            get => _newObjectTaggings ?? (_newObjectTaggings = new InputList<Inputs.BatchOperationCosPutObjectCopyNewObjectTaggingGetArgs>());
            set => _newObjectTaggings = value;
        }

        [Input("prefixReplace")]
        public Input<bool>? PrefixReplace { get; set; }

        [Input("resourcesPrefix")]
        public Input<string>? ResourcesPrefix { get; set; }

        [Input("storageClass")]
        public Input<string>? StorageClass { get; set; }

        [Input("taggingDirective")]
        public Input<string>? TaggingDirective { get; set; }

        [Input("targetKeyPrefix")]
        public Input<string>? TargetKeyPrefix { get; set; }

        [Input("targetResource", required: true)]
        public Input<string> TargetResource { get; set; } = null!;

        [Input("unmodifiedSinceConstraint")]
        public Input<int>? UnmodifiedSinceConstraint { get; set; }

        public BatchOperationCosPutObjectCopyGetArgs()
        {
        }
        public static new BatchOperationCosPutObjectCopyGetArgs Empty => new BatchOperationCosPutObjectCopyGetArgs();
    }
}
