// *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
// *** Do not edit by hand unless you're certain you know what you are doing! ***

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Threading.Tasks;
using Pulumi.Serialization;

namespace Pulumi.Tencentcloud.Tsf.Outputs
{

    [OutputType]
    public sealed class GetContainerGroupResultContentResult
    {
        public readonly string Alias;
        public readonly string ClusterId;
        public readonly string ClusterName;
        public readonly string CpuLimit;
        public readonly string CpuRequest;
        public readonly string CreateTime;
        public readonly string GroupId;
        public readonly string GroupName;
        public readonly bool KubeInjectEnable;
        public readonly string MemLimit;
        public readonly string MemRequest;
        public readonly string NamespaceId;
        public readonly string NamespaceName;
        public readonly string RepoName;
        public readonly string Server;
        public readonly string TagName;
        public readonly string UpdatedTime;

        [OutputConstructor]
        private GetContainerGroupResultContentResult(
            string alias,

            string clusterId,

            string clusterName,

            string cpuLimit,

            string cpuRequest,

            string createTime,

            string groupId,

            string groupName,

            bool kubeInjectEnable,

            string memLimit,

            string memRequest,

            string namespaceId,

            string namespaceName,

            string repoName,

            string server,

            string tagName,

            string updatedTime)
        {
            Alias = alias;
            ClusterId = clusterId;
            ClusterName = clusterName;
            CpuLimit = cpuLimit;
            CpuRequest = cpuRequest;
            CreateTime = createTime;
            GroupId = groupId;
            GroupName = groupName;
            KubeInjectEnable = kubeInjectEnable;
            MemLimit = memLimit;
            MemRequest = memRequest;
            NamespaceId = namespaceId;
            NamespaceName = namespaceName;
            RepoName = repoName;
            Server = server;
            TagName = tagName;
            UpdatedTime = updatedTime;
        }
    }
}
