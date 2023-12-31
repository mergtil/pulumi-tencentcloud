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
    public sealed class DatahubTaskTargetResource
    {
        public readonly Outputs.DatahubTaskTargetResourceClickHouseParam? ClickHouseParam;
        public readonly Outputs.DatahubTaskTargetResourceClsParam? ClsParam;
        public readonly Outputs.DatahubTaskTargetResourceCosParam? CosParam;
        public readonly Outputs.DatahubTaskTargetResourceCtsdbParam? CtsdbParam;
        public readonly Outputs.DatahubTaskTargetResourceDtsParam? DtsParam;
        public readonly Outputs.DatahubTaskTargetResourceEsParam? EsParam;
        public readonly Outputs.DatahubTaskTargetResourceEventBusParam? EventBusParam;
        public readonly Outputs.DatahubTaskTargetResourceKafkaParam? KafkaParam;
        public readonly Outputs.DatahubTaskTargetResourceMariaDbParam? MariaDbParam;
        public readonly Outputs.DatahubTaskTargetResourceMongoDbParam? MongoDbParam;
        public readonly Outputs.DatahubTaskTargetResourceMySqlParam? MySqlParam;
        public readonly Outputs.DatahubTaskTargetResourcePostgreSqlParam? PostgreSqlParam;
        public readonly Outputs.DatahubTaskTargetResourceScfParam? ScfParam;
        public readonly Outputs.DatahubTaskTargetResourceSqlServerParam? SqlServerParam;
        public readonly Outputs.DatahubTaskTargetResourceTdwParam? TdwParam;
        public readonly Outputs.DatahubTaskTargetResourceTopicParam? TopicParam;
        public readonly string Type;

        [OutputConstructor]
        private DatahubTaskTargetResource(
            Outputs.DatahubTaskTargetResourceClickHouseParam? clickHouseParam,

            Outputs.DatahubTaskTargetResourceClsParam? clsParam,

            Outputs.DatahubTaskTargetResourceCosParam? cosParam,

            Outputs.DatahubTaskTargetResourceCtsdbParam? ctsdbParam,

            Outputs.DatahubTaskTargetResourceDtsParam? dtsParam,

            Outputs.DatahubTaskTargetResourceEsParam? esParam,

            Outputs.DatahubTaskTargetResourceEventBusParam? eventBusParam,

            Outputs.DatahubTaskTargetResourceKafkaParam? kafkaParam,

            Outputs.DatahubTaskTargetResourceMariaDbParam? mariaDbParam,

            Outputs.DatahubTaskTargetResourceMongoDbParam? mongoDbParam,

            Outputs.DatahubTaskTargetResourceMySqlParam? mySqlParam,

            Outputs.DatahubTaskTargetResourcePostgreSqlParam? postgreSqlParam,

            Outputs.DatahubTaskTargetResourceScfParam? scfParam,

            Outputs.DatahubTaskTargetResourceSqlServerParam? sqlServerParam,

            Outputs.DatahubTaskTargetResourceTdwParam? tdwParam,

            Outputs.DatahubTaskTargetResourceTopicParam? topicParam,

            string type)
        {
            ClickHouseParam = clickHouseParam;
            ClsParam = clsParam;
            CosParam = cosParam;
            CtsdbParam = ctsdbParam;
            DtsParam = dtsParam;
            EsParam = esParam;
            EventBusParam = eventBusParam;
            KafkaParam = kafkaParam;
            MariaDbParam = mariaDbParam;
            MongoDbParam = mongoDbParam;
            MySqlParam = mySqlParam;
            PostgreSqlParam = postgreSqlParam;
            ScfParam = scfParam;
            SqlServerParam = sqlServerParam;
            TdwParam = tdwParam;
            TopicParam = topicParam;
            Type = type;
        }
    }
}
