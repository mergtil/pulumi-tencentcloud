// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Vod.Inputs
{

    public sealed class ProcedureTemplateMediaProcessTaskCoverBySnapshotTaskListArgs : global::Pulumi.ResourceArgs
    {
        [Input("definition", required: true)]
        public Input<string> Definition { get; set; } = null!;

        [Input("positionType", required: true)]
        public Input<string> PositionType { get; set; } = null!;

        [Input("positionValue", required: true)]
        public Input<double> PositionValue { get; set; } = null!;

        [Input("watermarkLists")]
        private InputList<Inputs.ProcedureTemplateMediaProcessTaskCoverBySnapshotTaskListWatermarkListArgs>? _watermarkLists;
        public InputList<Inputs.ProcedureTemplateMediaProcessTaskCoverBySnapshotTaskListWatermarkListArgs> WatermarkLists
        {
            get => _watermarkLists ?? (_watermarkLists = new InputList<Inputs.ProcedureTemplateMediaProcessTaskCoverBySnapshotTaskListWatermarkListArgs>());
            set => _watermarkLists = value;
        }

        public ProcedureTemplateMediaProcessTaskCoverBySnapshotTaskListArgs()
        {
        }
        public static new ProcedureTemplateMediaProcessTaskCoverBySnapshotTaskListArgs Empty => new ProcedureTemplateMediaProcessTaskCoverBySnapshotTaskListArgs();
    }
}
