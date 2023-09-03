// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Tsf
{
    [TencentcloudResourceType("tencentcloud:Tsf/laneRule:LaneRule")]
    public partial class LaneRule : global::Pulumi.CustomResource
    {
        /// <summary>
        /// creation time.
        /// </summary>
        [Output("createTime")]
        public Output<int> CreateTime { get; private set; } = null!;

        /// <summary>
        /// open state, true/false, default: false.
        /// </summary>
        [Output("enable")]
        public Output<bool> Enable { get; private set; } = null!;

        /// <summary>
        /// lane ID.
        /// </summary>
        [Output("laneId")]
        public Output<string> LaneId { get; private set; } = null!;

        /// <summary>
        /// Priority.
        /// </summary>
        [Output("priority")]
        public Output<int> Priority { get; private set; } = null!;

        /// <summary>
        /// Program id list.
        /// </summary>
        [Output("programIdLists")]
        public Output<ImmutableArray<string>> ProgramIdLists { get; private set; } = null!;

        /// <summary>
        /// Lane rule notes.
        /// </summary>
        [Output("remark")]
        public Output<string> Remark { get; private set; } = null!;

        /// <summary>
        /// Rule id.
        /// </summary>
        [Output("ruleId")]
        public Output<string> RuleId { get; private set; } = null!;

        /// <summary>
        /// lane rule name.
        /// </summary>
        [Output("ruleName")]
        public Output<string> RuleName { get; private set; } = null!;

        /// <summary>
        /// list of swimlane rule labels.
        /// </summary>
        [Output("ruleTagLists")]
        public Output<ImmutableArray<Outputs.LaneRuleRuleTagList>> RuleTagLists { get; private set; } = null!;

        /// <summary>
        /// lane rule label relationship.
        /// </summary>
        [Output("ruleTagRelationship")]
        public Output<string> RuleTagRelationship { get; private set; } = null!;

        /// <summary>
        /// update time.
        /// </summary>
        [Output("updateTime")]
        public Output<int> UpdateTime { get; private set; } = null!;


        /// <summary>
        /// Create a LaneRule resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public LaneRule(string name, LaneRuleArgs args, CustomResourceOptions? options = null)
            : base("tencentcloud:Tsf/laneRule:LaneRule", name, args ?? new LaneRuleArgs(), MakeResourceOptions(options, ""))
        {
        }

        private LaneRule(string name, Input<string> id, LaneRuleState? state = null, CustomResourceOptions? options = null)
            : base("tencentcloud:Tsf/laneRule:LaneRule", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing LaneRule resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static LaneRule Get(string name, Input<string> id, LaneRuleState? state = null, CustomResourceOptions? options = null)
        {
            return new LaneRule(name, id, state, options);
        }
    }

    public sealed class LaneRuleArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// open state, true/false, default: false.
        /// </summary>
        [Input("enable", required: true)]
        public Input<bool> Enable { get; set; } = null!;

        /// <summary>
        /// lane ID.
        /// </summary>
        [Input("laneId", required: true)]
        public Input<string> LaneId { get; set; } = null!;

        [Input("programIdLists")]
        private InputList<string>? _programIdLists;

        /// <summary>
        /// Program id list.
        /// </summary>
        public InputList<string> ProgramIdLists
        {
            get => _programIdLists ?? (_programIdLists = new InputList<string>());
            set => _programIdLists = value;
        }

        /// <summary>
        /// Lane rule notes.
        /// </summary>
        [Input("remark", required: true)]
        public Input<string> Remark { get; set; } = null!;

        /// <summary>
        /// lane rule name.
        /// </summary>
        [Input("ruleName", required: true)]
        public Input<string> RuleName { get; set; } = null!;

        [Input("ruleTagLists", required: true)]
        private InputList<Inputs.LaneRuleRuleTagListArgs>? _ruleTagLists;

        /// <summary>
        /// list of swimlane rule labels.
        /// </summary>
        public InputList<Inputs.LaneRuleRuleTagListArgs> RuleTagLists
        {
            get => _ruleTagLists ?? (_ruleTagLists = new InputList<Inputs.LaneRuleRuleTagListArgs>());
            set => _ruleTagLists = value;
        }

        /// <summary>
        /// lane rule label relationship.
        /// </summary>
        [Input("ruleTagRelationship", required: true)]
        public Input<string> RuleTagRelationship { get; set; } = null!;

        public LaneRuleArgs()
        {
        }
        public static new LaneRuleArgs Empty => new LaneRuleArgs();
    }

    public sealed class LaneRuleState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// creation time.
        /// </summary>
        [Input("createTime")]
        public Input<int>? CreateTime { get; set; }

        /// <summary>
        /// open state, true/false, default: false.
        /// </summary>
        [Input("enable")]
        public Input<bool>? Enable { get; set; }

        /// <summary>
        /// lane ID.
        /// </summary>
        [Input("laneId")]
        public Input<string>? LaneId { get; set; }

        /// <summary>
        /// Priority.
        /// </summary>
        [Input("priority")]
        public Input<int>? Priority { get; set; }

        [Input("programIdLists")]
        private InputList<string>? _programIdLists;

        /// <summary>
        /// Program id list.
        /// </summary>
        public InputList<string> ProgramIdLists
        {
            get => _programIdLists ?? (_programIdLists = new InputList<string>());
            set => _programIdLists = value;
        }

        /// <summary>
        /// Lane rule notes.
        /// </summary>
        [Input("remark")]
        public Input<string>? Remark { get; set; }

        /// <summary>
        /// Rule id.
        /// </summary>
        [Input("ruleId")]
        public Input<string>? RuleId { get; set; }

        /// <summary>
        /// lane rule name.
        /// </summary>
        [Input("ruleName")]
        public Input<string>? RuleName { get; set; }

        [Input("ruleTagLists")]
        private InputList<Inputs.LaneRuleRuleTagListGetArgs>? _ruleTagLists;

        /// <summary>
        /// list of swimlane rule labels.
        /// </summary>
        public InputList<Inputs.LaneRuleRuleTagListGetArgs> RuleTagLists
        {
            get => _ruleTagLists ?? (_ruleTagLists = new InputList<Inputs.LaneRuleRuleTagListGetArgs>());
            set => _ruleTagLists = value;
        }

        /// <summary>
        /// lane rule label relationship.
        /// </summary>
        [Input("ruleTagRelationship")]
        public Input<string>? RuleTagRelationship { get; set; }

        /// <summary>
        /// update time.
        /// </summary>
        [Input("updateTime")]
        public Input<int>? UpdateTime { get; set; }

        public LaneRuleState()
        {
        }
        public static new LaneRuleState Empty => new LaneRuleState();
    }
}