// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Mysql
{
    public static class GetInstance
    {
        public static Task<GetInstanceResult> InvokeAsync(GetInstanceArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.InvokeAsync<GetInstanceResult>("tencentcloud:Mysql/getInstance:getInstance", args ?? new GetInstanceArgs(), options.WithDefaults());

        public static Output<GetInstanceResult> Invoke(GetInstanceInvokeArgs? args = null, InvokeOptions? options = null)
            => global::Pulumi.Deployment.Instance.Invoke<GetInstanceResult>("tencentcloud:Mysql/getInstance:getInstance", args ?? new GetInstanceInvokeArgs(), options.WithDefaults());
    }


    public sealed class GetInstanceArgs : global::Pulumi.InvokeArgs
    {
        [Input("chargeType")]
        public string? ChargeType { get; set; }

        [Input("engineVersion")]
        public string? EngineVersion { get; set; }

        [Input("initFlag")]
        public int? InitFlag { get; set; }

        [Input("instanceName")]
        public string? InstanceName { get; set; }

        [Input("instanceRole")]
        public string? InstanceRole { get; set; }

        [Input("limit")]
        public int? Limit { get; set; }

        [Input("mysqlId")]
        public string? MysqlId { get; set; }

        [Input("offset")]
        public int? Offset { get; set; }

        [Input("payType")]
        public int? PayType { get; set; }

        [Input("resultOutputFile")]
        public string? ResultOutputFile { get; set; }

        [Input("securityGroupId")]
        public string? SecurityGroupId { get; set; }

        [Input("status")]
        public int? Status { get; set; }

        [Input("withDr")]
        public int? WithDr { get; set; }

        [Input("withMaster")]
        public int? WithMaster { get; set; }

        [Input("withRo")]
        public int? WithRo { get; set; }

        public GetInstanceArgs()
        {
        }
        public static new GetInstanceArgs Empty => new GetInstanceArgs();
    }

    public sealed class GetInstanceInvokeArgs : global::Pulumi.InvokeArgs
    {
        [Input("chargeType")]
        public Input<string>? ChargeType { get; set; }

        [Input("engineVersion")]
        public Input<string>? EngineVersion { get; set; }

        [Input("initFlag")]
        public Input<int>? InitFlag { get; set; }

        [Input("instanceName")]
        public Input<string>? InstanceName { get; set; }

        [Input("instanceRole")]
        public Input<string>? InstanceRole { get; set; }

        [Input("limit")]
        public Input<int>? Limit { get; set; }

        [Input("mysqlId")]
        public Input<string>? MysqlId { get; set; }

        [Input("offset")]
        public Input<int>? Offset { get; set; }

        [Input("payType")]
        public Input<int>? PayType { get; set; }

        [Input("resultOutputFile")]
        public Input<string>? ResultOutputFile { get; set; }

        [Input("securityGroupId")]
        public Input<string>? SecurityGroupId { get; set; }

        [Input("status")]
        public Input<int>? Status { get; set; }

        [Input("withDr")]
        public Input<int>? WithDr { get; set; }

        [Input("withMaster")]
        public Input<int>? WithMaster { get; set; }

        [Input("withRo")]
        public Input<int>? WithRo { get; set; }

        public GetInstanceInvokeArgs()
        {
        }
        public static new GetInstanceInvokeArgs Empty => new GetInstanceInvokeArgs();
    }


    [OutputType]
    public sealed class GetInstanceResult
    {
        public readonly string? ChargeType;
        public readonly string? EngineVersion;
        /// <summary>
        /// The provider-assigned unique ID for this managed resource.
        /// </summary>
        public readonly string Id;
        public readonly int? InitFlag;
        public readonly ImmutableArray<Outputs.GetInstanceInstanceListResult> InstanceLists;
        public readonly string? InstanceName;
        public readonly string? InstanceRole;
        public readonly int? Limit;
        public readonly string? MysqlId;
        public readonly int? Offset;
        public readonly int? PayType;
        public readonly string? ResultOutputFile;
        public readonly string? SecurityGroupId;
        public readonly int? Status;
        public readonly int? WithDr;
        public readonly int? WithMaster;
        public readonly int? WithRo;

        [OutputConstructor]
        private GetInstanceResult(
            string? chargeType,

            string? engineVersion,

            string id,

            int? initFlag,

            ImmutableArray<Outputs.GetInstanceInstanceListResult> instanceLists,

            string? instanceName,

            string? instanceRole,

            int? limit,

            string? mysqlId,

            int? offset,

            int? payType,

            string? resultOutputFile,

            string? securityGroupId,

            int? status,

            int? withDr,

            int? withMaster,

            int? withRo)
        {
            ChargeType = chargeType;
            EngineVersion = engineVersion;
            Id = id;
            InitFlag = initFlag;
            InstanceLists = instanceLists;
            InstanceName = instanceName;
            InstanceRole = instanceRole;
            Limit = limit;
            MysqlId = mysqlId;
            Offset = offset;
            PayType = payType;
            ResultOutputFile = resultOutputFile;
            SecurityGroupId = securityGroupId;
            Status = status;
            WithDr = withDr;
            WithMaster = withMaster;
            WithRo = withRo;
        }
    }
}
