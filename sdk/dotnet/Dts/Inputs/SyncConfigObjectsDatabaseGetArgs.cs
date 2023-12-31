// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Dts.Inputs
{

    public sealed class SyncConfigObjectsDatabaseGetArgs : global::Pulumi.ResourceArgs
    {
        [Input("dbMode")]
        public Input<string>? DbMode { get; set; }

        [Input("dbName")]
        public Input<string>? DbName { get; set; }

        [Input("eventMode")]
        public Input<string>? EventMode { get; set; }

        [Input("events")]
        private InputList<string>? _events;
        public InputList<string> Events
        {
            get => _events ?? (_events = new InputList<string>());
            set => _events = value;
        }

        [Input("functionMode")]
        public Input<string>? FunctionMode { get; set; }

        [Input("functions")]
        private InputList<string>? _functions;
        public InputList<string> Functions
        {
            get => _functions ?? (_functions = new InputList<string>());
            set => _functions = value;
        }

        [Input("newDbName")]
        public Input<string>? NewDbName { get; set; }

        [Input("newSchemaName")]
        public Input<string>? NewSchemaName { get; set; }

        [Input("procedureMode")]
        public Input<string>? ProcedureMode { get; set; }

        [Input("procedures")]
        private InputList<string>? _procedures;
        public InputList<string> Procedures
        {
            get => _procedures ?? (_procedures = new InputList<string>());
            set => _procedures = value;
        }

        [Input("schemaName")]
        public Input<string>? SchemaName { get; set; }

        [Input("tableMode")]
        public Input<string>? TableMode { get; set; }

        [Input("tables")]
        private InputList<Inputs.SyncConfigObjectsDatabaseTableGetArgs>? _tables;
        public InputList<Inputs.SyncConfigObjectsDatabaseTableGetArgs> Tables
        {
            get => _tables ?? (_tables = new InputList<Inputs.SyncConfigObjectsDatabaseTableGetArgs>());
            set => _tables = value;
        }

        [Input("triggerMode")]
        public Input<string>? TriggerMode { get; set; }

        [Input("triggers")]
        private InputList<string>? _triggers;
        public InputList<string> Triggers
        {
            get => _triggers ?? (_triggers = new InputList<string>());
            set => _triggers = value;
        }

        [Input("viewMode")]
        public Input<string>? ViewMode { get; set; }

        [Input("views")]
        private InputList<Inputs.SyncConfigObjectsDatabaseViewGetArgs>? _views;
        public InputList<Inputs.SyncConfigObjectsDatabaseViewGetArgs> Views
        {
            get => _views ?? (_views = new InputList<Inputs.SyncConfigObjectsDatabaseViewGetArgs>());
            set => _views = value;
        }

        public SyncConfigObjectsDatabaseGetArgs()
        {
        }
        public static new SyncConfigObjectsDatabaseGetArgs Empty => new SyncConfigObjectsDatabaseGetArgs();
    }
}
