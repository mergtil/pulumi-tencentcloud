// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Elasticsearch.Outputs
{

    [OutputType]
    public sealed class InstanceEsAcl
    {
        public readonly ImmutableArray<string> BlackLists;
        public readonly ImmutableArray<string> WhiteLists;

        [OutputConstructor]
        private InstanceEsAcl(
            ImmutableArray<string> blackLists,

            ImmutableArray<string> whiteLists)
        {
            BlackLists = blackLists;
            WhiteLists = whiteLists;
        }
    }
}
