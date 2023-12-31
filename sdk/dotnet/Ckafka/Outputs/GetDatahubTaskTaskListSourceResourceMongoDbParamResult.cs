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
    public sealed class GetDatahubTaskTaskListSourceResourceMongoDbParamResult
    {
        public readonly string Collection;
        public readonly bool CopyExisting;
        public readonly string Database;
        public readonly string Ip;
        public readonly string ListeningEvent;
        public readonly string Password;
        public readonly string Pipeline;
        public readonly int Port;
        public readonly string ReadPreference;
        public readonly string Resource;
        public readonly bool SelfBuilt;
        public readonly string UserName;

        [OutputConstructor]
        private GetDatahubTaskTaskListSourceResourceMongoDbParamResult(
            string collection,

            bool copyExisting,

            string database,

            string ip,

            string listeningEvent,

            string password,

            string pipeline,

            int port,

            string readPreference,

            string resource,

            bool selfBuilt,

            string userName)
        {
            Collection = collection;
            CopyExisting = copyExisting;
            Database = database;
            Ip = ip;
            ListeningEvent = listeningEvent;
            Password = password;
            Pipeline = pipeline;
            Port = port;
            ReadPreference = readPreference;
            Resource = resource;
            SelfBuilt = selfBuilt;
            UserName = userName;
        }
    }
}
