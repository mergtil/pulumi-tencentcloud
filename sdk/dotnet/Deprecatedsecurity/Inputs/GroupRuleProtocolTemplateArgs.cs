// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Deprecatedsecurity.Inputs
{

    public sealed class GroupRuleProtocolTemplateArgs : global::Pulumi.ResourceArgs
    {
        [Input("groupId")]
        public Input<string>? GroupId { get; set; }

        [Input("templateId")]
        public Input<string>? TemplateId { get; set; }

        public GroupRuleProtocolTemplateArgs()
        {
        }
        public static new GroupRuleProtocolTemplateArgs Empty => new GroupRuleProtocolTemplateArgs();
    }
}
