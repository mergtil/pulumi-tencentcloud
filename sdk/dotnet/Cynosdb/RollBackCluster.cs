// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Cynosdb
{
    [TencentcloudResourceType("tencentcloud:Cynosdb/rollBackCluster:RollBackCluster")]
    public partial class RollBackCluster : global::Pulumi.CustomResource
    {
        /// <summary>
        /// The ID of cluster.
        /// </summary>
        [Output("clusterId")]
        public Output<string> ClusterId { get; private set; } = null!;

        /// <summary>
        /// Expected rollback Time.
        /// </summary>
        [Output("expectTime")]
        public Output<string?> ExpectTime { get; private set; } = null!;

        /// <summary>
        /// Expected Threshold (Obsolete).
        /// </summary>
        [Output("expectTimeThresh")]
        public Output<int?> ExpectTimeThresh { get; private set; } = null!;

        /// <summary>
        /// Database list.
        /// </summary>
        [Output("rollbackDatabases")]
        public Output<ImmutableArray<Outputs.RollBackClusterRollbackDatabase>> RollbackDatabases { get; private set; } = null!;

        /// <summary>
        /// Rollback ID.
        /// </summary>
        [Output("rollbackId")]
        public Output<int> RollbackId { get; private set; } = null!;

        /// <summary>
        /// Rollback mode by time point, full: normal; Db: fast; Table: Extreme speed (default is normal).
        /// </summary>
        [Output("rollbackMode")]
        public Output<string?> RollbackMode { get; private set; } = null!;

        /// <summary>
        /// Backfile policy timeRollback - Backfile by point in time snapRollback - Backfile by backup file.
        /// </summary>
        [Output("rollbackStrategy")]
        public Output<string> RollbackStrategy { get; private set; } = null!;

        /// <summary>
        /// Table list.
        /// </summary>
        [Output("rollbackTables")]
        public Output<ImmutableArray<Outputs.RollBackClusterRollbackTable>> RollbackTables { get; private set; } = null!;


        /// <summary>
        /// Create a RollBackCluster resource with the given unique name, arguments, and options.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resource</param>
        /// <param name="args">The arguments used to populate this resource's properties</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public RollBackCluster(string name, RollBackClusterArgs args, CustomResourceOptions? options = null)
            : base("tencentcloud:Cynosdb/rollBackCluster:RollBackCluster", name, args ?? new RollBackClusterArgs(), MakeResourceOptions(options, ""))
        {
        }

        private RollBackCluster(string name, Input<string> id, RollBackClusterState? state = null, CustomResourceOptions? options = null)
            : base("tencentcloud:Cynosdb/rollBackCluster:RollBackCluster", name, state, MakeResourceOptions(options, id))
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
        /// Get an existing RollBackCluster resource's state with the given name, ID, and optional extra
        /// properties used to qualify the lookup.
        /// </summary>
        ///
        /// <param name="name">The unique name of the resulting resource.</param>
        /// <param name="id">The unique provider ID of the resource to lookup.</param>
        /// <param name="state">Any extra arguments used during the lookup.</param>
        /// <param name="options">A bag of options that control this resource's behavior</param>
        public static RollBackCluster Get(string name, Input<string> id, RollBackClusterState? state = null, CustomResourceOptions? options = null)
        {
            return new RollBackCluster(name, id, state, options);
        }
    }

    public sealed class RollBackClusterArgs : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The ID of cluster.
        /// </summary>
        [Input("clusterId", required: true)]
        public Input<string> ClusterId { get; set; } = null!;

        /// <summary>
        /// Expected rollback Time.
        /// </summary>
        [Input("expectTime")]
        public Input<string>? ExpectTime { get; set; }

        /// <summary>
        /// Expected Threshold (Obsolete).
        /// </summary>
        [Input("expectTimeThresh")]
        public Input<int>? ExpectTimeThresh { get; set; }

        [Input("rollbackDatabases")]
        private InputList<Inputs.RollBackClusterRollbackDatabaseArgs>? _rollbackDatabases;

        /// <summary>
        /// Database list.
        /// </summary>
        public InputList<Inputs.RollBackClusterRollbackDatabaseArgs> RollbackDatabases
        {
            get => _rollbackDatabases ?? (_rollbackDatabases = new InputList<Inputs.RollBackClusterRollbackDatabaseArgs>());
            set => _rollbackDatabases = value;
        }

        /// <summary>
        /// Rollback ID.
        /// </summary>
        [Input("rollbackId", required: true)]
        public Input<int> RollbackId { get; set; } = null!;

        /// <summary>
        /// Rollback mode by time point, full: normal; Db: fast; Table: Extreme speed (default is normal).
        /// </summary>
        [Input("rollbackMode")]
        public Input<string>? RollbackMode { get; set; }

        /// <summary>
        /// Backfile policy timeRollback - Backfile by point in time snapRollback - Backfile by backup file.
        /// </summary>
        [Input("rollbackStrategy", required: true)]
        public Input<string> RollbackStrategy { get; set; } = null!;

        [Input("rollbackTables")]
        private InputList<Inputs.RollBackClusterRollbackTableArgs>? _rollbackTables;

        /// <summary>
        /// Table list.
        /// </summary>
        public InputList<Inputs.RollBackClusterRollbackTableArgs> RollbackTables
        {
            get => _rollbackTables ?? (_rollbackTables = new InputList<Inputs.RollBackClusterRollbackTableArgs>());
            set => _rollbackTables = value;
        }

        public RollBackClusterArgs()
        {
        }
        public static new RollBackClusterArgs Empty => new RollBackClusterArgs();
    }

    public sealed class RollBackClusterState : global::Pulumi.ResourceArgs
    {
        /// <summary>
        /// The ID of cluster.
        /// </summary>
        [Input("clusterId")]
        public Input<string>? ClusterId { get; set; }

        /// <summary>
        /// Expected rollback Time.
        /// </summary>
        [Input("expectTime")]
        public Input<string>? ExpectTime { get; set; }

        /// <summary>
        /// Expected Threshold (Obsolete).
        /// </summary>
        [Input("expectTimeThresh")]
        public Input<int>? ExpectTimeThresh { get; set; }

        [Input("rollbackDatabases")]
        private InputList<Inputs.RollBackClusterRollbackDatabaseGetArgs>? _rollbackDatabases;

        /// <summary>
        /// Database list.
        /// </summary>
        public InputList<Inputs.RollBackClusterRollbackDatabaseGetArgs> RollbackDatabases
        {
            get => _rollbackDatabases ?? (_rollbackDatabases = new InputList<Inputs.RollBackClusterRollbackDatabaseGetArgs>());
            set => _rollbackDatabases = value;
        }

        /// <summary>
        /// Rollback ID.
        /// </summary>
        [Input("rollbackId")]
        public Input<int>? RollbackId { get; set; }

        /// <summary>
        /// Rollback mode by time point, full: normal; Db: fast; Table: Extreme speed (default is normal).
        /// </summary>
        [Input("rollbackMode")]
        public Input<string>? RollbackMode { get; set; }

        /// <summary>
        /// Backfile policy timeRollback - Backfile by point in time snapRollback - Backfile by backup file.
        /// </summary>
        [Input("rollbackStrategy")]
        public Input<string>? RollbackStrategy { get; set; }

        [Input("rollbackTables")]
        private InputList<Inputs.RollBackClusterRollbackTableGetArgs>? _rollbackTables;

        /// <summary>
        /// Table list.
        /// </summary>
        public InputList<Inputs.RollBackClusterRollbackTableGetArgs> RollbackTables
        {
            get => _rollbackTables ?? (_rollbackTables = new InputList<Inputs.RollBackClusterRollbackTableGetArgs>());
            set => _rollbackTables = value;
        }

        public RollBackClusterState()
        {
        }
        public static new RollBackClusterState Empty => new RollBackClusterState();
    }
}