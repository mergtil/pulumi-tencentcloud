// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Dts.Inputs
{

    public sealed class SyncConfigOptionsGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("addAdditionalColumn")]
        public Input<bool>? AddAdditionalColumn { get; set; }

        [Input("conflictHandleOption")]
        public Input<Inputs.SyncConfigOptionsConflictHandleOptionGetArgs>? ConflictHandleOption { get; set; }

        [Input("conflictHandleType")]
        public Input<string>? ConflictHandleType { get; set; }

        [Input("ddlOptions")]
        private InputList<Inputs.SyncConfigOptionsDdlOptionGetArgs>? _ddlOptions;
        public InputList<Inputs.SyncConfigOptionsDdlOptionGetArgs> DdlOptions
        {
            get => _ddlOptions ?? (_ddlOptions = new InputList<Inputs.SyncConfigOptionsDdlOptionGetArgs>());
            set => _ddlOptions = value;
        }

        [Input("dealOfExistSameTable")]
        public Input<string>? DealOfExistSameTable { get; set; }

        [Input("initType")]
        public Input<string>? InitType { get; set; }

        [Input("opTypes")]
        private InputList<string>? _opTypes;
        public InputList<string> OpTypes
        {
            get => _opTypes ?? (_opTypes = new InputList<string>());
            set => _opTypes = value;
        }

        public SyncConfigOptionsGetArgs()
        {
        }
        public static new SyncConfigOptionsGetArgs Empty => new SyncConfigOptionsGetArgs();
    }
}
