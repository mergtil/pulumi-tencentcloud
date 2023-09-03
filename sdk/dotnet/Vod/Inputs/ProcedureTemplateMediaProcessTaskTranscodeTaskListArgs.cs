// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Vod.Inputs
{

    public sealed class ProcedureTemplateMediaProcessTaskTranscodeTaskListArgs : global::Pulumi.ResourceArgs
    {
        [Input("definition", required: true)]
        public Input<string> Definition { get; set; } = null!;

        [Input("mosaicLists")]
        private InputList<Inputs.ProcedureTemplateMediaProcessTaskTranscodeTaskListMosaicListArgs>? _mosaicLists;
        public InputList<Inputs.ProcedureTemplateMediaProcessTaskTranscodeTaskListMosaicListArgs> MosaicLists
        {
            get => _mosaicLists ?? (_mosaicLists = new InputList<Inputs.ProcedureTemplateMediaProcessTaskTranscodeTaskListMosaicListArgs>());
            set => _mosaicLists = value;
        }

        [Input("watermarkLists")]
        private InputList<Inputs.ProcedureTemplateMediaProcessTaskTranscodeTaskListWatermarkListArgs>? _watermarkLists;
        public InputList<Inputs.ProcedureTemplateMediaProcessTaskTranscodeTaskListWatermarkListArgs> WatermarkLists
        {
            get => _watermarkLists ?? (_watermarkLists = new InputList<Inputs.ProcedureTemplateMediaProcessTaskTranscodeTaskListWatermarkListArgs>());
            set => _watermarkLists = value;
        }

        public ProcedureTemplateMediaProcessTaskTranscodeTaskListArgs()
        {
        }
        public static new ProcedureTemplateMediaProcessTaskTranscodeTaskListArgs Empty => new ProcedureTemplateMediaProcessTaskTranscodeTaskListArgs();
    }
}