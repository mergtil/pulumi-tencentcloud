// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Cls
{
    [TencentcloudResourceType("tencentcloud:Cls/dataTransform:DataTransform")]
    public partial class DataTransform : global::Pulumi.CustomResource
    {
        /// <summary>
        /// data transform des resources.
        /// </summary>
        [Output("dstResources")]
        public Output<ImmutableArray<Outputs.DataTransformDstResource>> DstResources { get; private set; } = null!;

        /// <summary>
        /// task enable flag.
        /// </summary>
        [Output("enableFlag")]
        public Output<int?> EnableFlag { get; private set; } = null!;

        /// <summary>
        /// data transform content.
        /// </summary>
        [Output("etlContent")]
        public Output<string> EtlContent { get; private set; } = null!;

        /// <summary>
        /// task type.
        /// </summary>
        [Output("funcType")]
        public Output<int> FuncType { get; private set; } = null!;

        /// <summary>
        /// task name.
        /// </summary>
        [Output("name")]
        public Output<string> Name { get; private set; } = null!;

        /// <summary>
        /// src topic id.
        /// </summary>
        [Output("srcTopicId")]
        public Output<string> SrcTopicId { get; private set; } = null!;

        /// <summary>
        /// task type.
        /// </summary>
        [Output("taskType")]
        public Output<int> TaskType { get; private set; } = null!;


        /// <summary>
        /// Create a DataTransform resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public DataTransform(string name, DataTransformArgs args, CustomResourceOptions? options = null)
            : base("tencentcloud:Cls/dataTransform:DataTransform", name, args ?? new DataTransformArgs(), MakeResourceOptions(options, ""))
        {
        }

        private DataTransform(string name, Input<string> id, DataTransformState? state = null, CustomResourceOptions? options = null)
            : base("tencentcloud:Cls/dataTransform:DataTransform", name, state, MakeResourceOptions(options, id))
        {
        }

        private static CustomResourceOptions MakeResourceOptions(CustomResourceOptions? options, Input<string>? id)
        {
            var defaultOptions = new CustomResourceOptions
            {
                Version = Utilities.Version,
            };
            var merged = CustomResourceOptions.Merge(defaultOptions, options);
            // Override the ID if one was specified for consistency with other language SDKs.
            merged.Id = id ?? merged.Id;
            return merged;
        }
        /// <summary>
        /// Get an existing DataTransform resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static DataTransform Get(string name, Input<string> id, DataTransformState? state = null, CustomResourceOptions? options = null)
        {
            return new DataTransform(name, id, state, options);
        }
    }

    public sealed class DataTransformArgs : global::Pulumi.ResourceArgs
    {
        [Input("dstResources")]
        private InputList<Inputs.DataTransformDstResourceArgs>? _dstResources;

        /// <summary>
        /// data transform des resources.
        /// </summary>
        public InputList<Inputs.DataTransformDstResourceArgs> DstResources
        {
            get => _dstResources ?? (_dstResources = new InputList<Inputs.DataTransformDstResourceArgs>());
            set => _dstResources = value;
        }

        /// <summary>
        /// task enable flag.
        /// </summary>
        [Input("enableFlag")]
        public Input<int>? EnableFlag { get; set; }

        /// <summary>
        /// data transform content.
        /// </summary>
        [Input("etlContent", required: true)]
        public Input<string> EtlContent { get; set; } = null!;

        /// <summary>
        /// task type.
        /// </summary>
        [Input("funcType", required: true)]
        public Input<int> FuncType { get; set; } = null!;

        /// <summary>
        /// task name.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// src topic id.
        /// </summary>
        [Input("srcTopicId", required: true)]
        public Input<string> SrcTopicId { get; set; } = null!;

        /// <summary>
        /// task type.
        /// </summary>
        [Input("taskType", required: true)]
        public Input<int> TaskType { get; set; } = null!;

        public DataTransformArgs()
        {
        }
        public static new DataTransformArgs Empty => new DataTransformArgs();
    }

    public sealed class DataTransformState : global::Pulumi.ResourceArgs
    {
        [Input("dstResources")]
        private InputList<Inputs.DataTransformDstResourceGetArgs>? _dstResources;

        /// <summary>
        /// data transform des resources.
        /// </summary>
        public InputList<Inputs.DataTransformDstResourceGetArgs> DstResources
        {
            get => _dstResources ?? (_dstResources = new InputList<Inputs.DataTransformDstResourceGetArgs>());
            set => _dstResources = value;
        }

        /// <summary>
        /// task enable flag.
        /// </summary>
        [Input("enableFlag")]
        public Input<int>? EnableFlag { get; set; }

        /// <summary>
        /// data transform content.
        /// </summary>
        [Input("etlContent")]
        public Input<string>? EtlContent { get; set; }

        /// <summary>
        /// task type.
        /// </summary>
        [Input("funcType")]
        public Input<int>? FuncType { get; set; }

        /// <summary>
        /// task name.
        /// </summary>
        [Input("name")]
        public Input<string>? Name { get; set; }

        /// <summary>
        /// src topic id.
        /// </summary>
        [Input("srcTopicId")]
        public Input<string>? SrcTopicId { get; set; }

        /// <summary>
        /// task type.
        /// </summary>
        [Input("taskType")]
        public Input<int>? TaskType { get; set; }

        public DataTransformState()
        {
        }
        public static new DataTransformState Empty => new DataTransformState();
    }
}