// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Ckafka.Inputs
{

    public sealed class DatahubTaskTransformParamGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("analyseResults")]
        private InputList<Inputs.DatahubTaskTransformParamAnalyseResultGetArgs>? _analyseResults;
        public InputList<Inputs.DatahubTaskTransformParamAnalyseResultGetArgs> AnalyseResults
        {
            get => _analyseResults ?? (_analyseResults = new InputList<Inputs.DatahubTaskTransformParamAnalyseResultGetArgs>());
            set => _analyseResults = value;
        }

        [Input("analysisFormat", required: true)]
        public Input<string> AnalysisFormat { get; set; } = null!;

        [Input("content", required: true)]
        public Input<string> Content { get; set; } = null!;

        [Input("failureParam", required: true)]
        public Input<Inputs.DatahubTaskTransformParamFailureParamGetArgs> FailureParam { get; set; } = null!;

        [Input("filterParams")]
        private InputList<Inputs.DatahubTaskTransformParamFilterParamGetArgs>? _filterParams;
        public InputList<Inputs.DatahubTaskTransformParamFilterParamGetArgs> FilterParams
        {
            get => _filterParams ?? (_filterParams = new InputList<Inputs.DatahubTaskTransformParamFilterParamGetArgs>());
            set => _filterParams = value;
        }

        [Input("mapParams")]
        private InputList<Inputs.DatahubTaskTransformParamMapParamGetArgs>? _mapParams;
        public InputList<Inputs.DatahubTaskTransformParamMapParamGetArgs> MapParams
        {
            get => _mapParams ?? (_mapParams = new InputList<Inputs.DatahubTaskTransformParamMapParamGetArgs>());
            set => _mapParams = value;
        }

        [Input("outputFormat", required: true)]
        public Input<string> OutputFormat { get; set; } = null!;

        [Input("regex")]
        public Input<string>? Regex { get; set; }

        [Input("result")]
        public Input<string>? Result { get; set; }

        [Input("sourceType", required: true)]
        public Input<string> SourceType { get; set; } = null!;

        [Input("useEventBus")]
        public Input<bool>? UseEventBus { get; set; }

        public DatahubTaskTransformParamGetArgs()
        {
        }
        public static new DatahubTaskTransformParamGetArgs Empty => new DatahubTaskTransformParamGetArgs();
    }
}