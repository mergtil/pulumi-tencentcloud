// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Teo
{
    [TencentcloudResourceType("tencentcloud:Teo/ruleEngine:RuleEngine")]
    public partial class RuleEngine : global::Pulumi.CustomResource
    {
        /// <summary>
        /// Rule ID.
        /// </summary>
        [Output("ruleId")]
        public Output<string> RuleId { get; private set; } = null!;

        /// <summary>
        /// Rule name.
        /// </summary>
        [Output("ruleName")]
        public Output<string> RuleName { get; private set; } = null!;

        /// <summary>
        /// Rule items list.
        /// </summary>
        [Output("rules")]
        public Output<ImmutableArray<Outputs.RuleEngineRule>> Rules { get; private set; } = null!;

        /// <summary>
        /// Status of the rule, valid value can be `enable` or `disable`.
        /// </summary>
        [Output("status")]
        public Output<string> Status { get; private set; } = null!;

        /// <summary>
        /// rule tag list.
        /// </summary>
        [Output("tags")]
        public Output<ImmutableArray<string>> Tags { get; private set; } = null!;

        /// <summary>
        /// Site ID.
        /// </summary>
        [Output("zoneId")]
        public Output<string> ZoneId { get; private set; } = null!;


        /// <summary>
        /// Create a RuleEngine resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public RuleEngine(string name, RuleEngineArgs args, CustomResourceOptions? options = null)
            : base("tencentcloud:Teo/ruleEngine:RuleEngine", name, args ?? new RuleEngineArgs(), MakeResourceOptions(options, ""))
        {
        }

        private RuleEngine(string name, Input<string> id, RuleEngineState? state = null, CustomResourceOptions? options = null)
            : base("tencentcloud:Teo/ruleEngine:RuleEngine", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing RuleEngine resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static RuleEngine Get(string name, Input<string> id, RuleEngineState? state = null, CustomResourceOptions? options = null)
        {
            return new RuleEngine(name, id, state, options);
        }
    }

    public sealed class RuleEngineArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Rule name.
        /// </summary>
        [Input("ruleName", required: true)]
        public Input<string> RuleName { get; set; } = null!;

        [Input("rules", required: true)]
        private InputList<Inputs.RuleEngineRuleArgs>? _rules;

        /// <summary>
        /// Rule items list.
        /// </summary>
        public InputList<Inputs.RuleEngineRuleArgs> Rules
        {
            get => _rules ?? (_rules = new InputList<Inputs.RuleEngineRuleArgs>());
            set => _rules = value;
        }

        /// <summary>
        /// Status of the rule, valid value can be `enable` or `disable`.
        /// </summary>
        [Input("status", required: true)]
        public Input<string> Status { get; set; } = null!;

        [Input("tags")]
        private InputList<string>? _tags;

        /// <summary>
        /// rule tag list.
        /// </summary>
        public InputList<string> Tags
        {
            get => _tags ?? (_tags = new InputList<string>());
            set => _tags = value;
        }

        /// <summary>
        /// Site ID.
        /// </summary>
        [Input("zoneId", required: true)]
        public Input<string> ZoneId { get; set; } = null!;

        public RuleEngineArgs()
        {
        }
        public static new RuleEngineArgs Empty => new RuleEngineArgs();
    }

    public sealed class RuleEngineState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// Rule ID.
        /// </summary>
        [Input("ruleId")]
        public Input<string>? RuleId { get; set; }

        /// <summary>
        /// Rule name.
        /// </summary>
        [Input("ruleName")]
        public Input<string>? RuleName { get; set; }

        [Input("rules")]
        private InputList<Inputs.RuleEngineRuleGetArgs>? _rules;

        /// <summary>
        /// Rule items list.
        /// </summary>
        public InputList<Inputs.RuleEngineRuleGetArgs> Rules
        {
            get => _rules ?? (_rules = new InputList<Inputs.RuleEngineRuleGetArgs>());
            set => _rules = value;
        }

        /// <summary>
        /// Status of the rule, valid value can be `enable` or `disable`.
        /// </summary>
        [Input("status")]
        public Input<string>? Status { get; set; }

        [Input("tags")]
        private InputList<string>? _tags;

        /// <summary>
        /// rule tag list.
        /// </summary>
        public InputList<string> Tags
        {
            get => _tags ?? (_tags = new InputList<string>());
            set => _tags = value;
        }

        /// <summary>
        /// Site ID.
        /// </summary>
        [Input("zoneId")]
        public Input<string>? ZoneId { get; set; }

        public RuleEngineState()
        {
        }
        public static new RuleEngineState Empty => new RuleEngineState();
    }
}