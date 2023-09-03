// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Ckafka.Outputs
{

    [OutputType]
    public sealed class DatahubTaskSourceResourceEsParam
    {
        public readonly string? ContentKey;
        public readonly string? DatabasePrimaryKey;
        public readonly string? DateFormat;
        public readonly string? DocumentIdField;
        public readonly Outputs.DatahubTaskSourceResourceEsParamDropCls? DropCls;
        public readonly Outputs.DatahubTaskSourceResourceEsParamDropDlq? DropDlq;
        public readonly bool? DropInvalidJsonMessage;
        public readonly bool? DropInvalidMessage;
        public readonly string? Index;
        public readonly string? IndexType;
        public readonly string? Password;
        public readonly int? Port;
        public readonly string Resource;
        public readonly bool? SelfBuilt;
        public readonly string? ServiceVip;
        public readonly string? UniqVpcId;
        public readonly string? UserName;

        [OutputConstructor]
        private DatahubTaskSourceResourceEsParam(
            string? contentKey,

            string? databasePrimaryKey,

            string? dateFormat,

            string? documentIdField,

            Outputs.DatahubTaskSourceResourceEsParamDropCls? dropCls,

            Outputs.DatahubTaskSourceResourceEsParamDropDlq? dropDlq,

            bool? dropInvalidJsonMessage,

            bool? dropInvalidMessage,

            string? index,

            string? indexType,

            string? password,

            int? port,

            string resource,

            bool? selfBuilt,

            string? serviceVip,

            string? uniqVpcId,

            string? userName)
        {
            ContentKey = contentKey;
            DatabasePrimaryKey = databasePrimaryKey;
            DateFormat = dateFormat;
            DocumentIdField = documentIdField;
            DropCls = dropCls;
            DropDlq = dropDlq;
            DropInvalidJsonMessage = dropInvalidJsonMessage;
            DropInvalidMessage = dropInvalidMessage;
            Index = index;
            IndexType = indexType;
            Password = password;
            Port = port;
            Resource = resource;
            SelfBuilt = selfBuilt;
            ServiceVip = serviceVip;
            UniqVpcId = uniqVpcId;
            UserName = userName;
        }
    }
}