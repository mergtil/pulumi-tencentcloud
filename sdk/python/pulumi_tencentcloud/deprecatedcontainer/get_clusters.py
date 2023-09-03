# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities
from . import outputs

__all__ = [
    'GetClustersResult',
    'AwaitableGetClustersResult',
    'get_clusters',
    'get_clusters_output',
]

@pulumi.output_type
class GetClustersResult:
    """
    A collection of values returned by getClusters.
    """
    def __init__(__self__, cluster_id=None, clusters=None, id=None, limit=None, total_count=None):
        if cluster_id and not isinstance(cluster_id, str):
            raise TypeError("Expected argument 'cluster_id' to be a str")
        pulumi.set(__self__, "cluster_id", cluster_id)
        if clusters and not isinstance(clusters, list):
            raise TypeError("Expected argument 'clusters' to be a list")
        pulumi.set(__self__, "clusters", clusters)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if limit and not isinstance(limit, int):
            raise TypeError("Expected argument 'limit' to be a int")
        pulumi.set(__self__, "limit", limit)
        if total_count and not isinstance(total_count, int):
            raise TypeError("Expected argument 'total_count' to be a int")
        pulumi.set(__self__, "total_count", total_count)

    @property
    @pulumi.getter(name="clusterId")
    def cluster_id(self) -> Optional[str]:
        return pulumi.get(self, "cluster_id")

    @property
    @pulumi.getter
    def clusters(self) -> Sequence['outputs.GetClustersClusterResult']:
        return pulumi.get(self, "clusters")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def limit(self) -> Optional[int]:
        return pulumi.get(self, "limit")

    @property
    @pulumi.getter(name="totalCount")
    def total_count(self) -> int:
        return pulumi.get(self, "total_count")


class AwaitableGetClustersResult(GetClustersResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetClustersResult(
            cluster_id=self.cluster_id,
            clusters=self.clusters,
            id=self.id,
            limit=self.limit,
            total_count=self.total_count)


def get_clusters(cluster_id: Optional[str] = None,
                 limit: Optional[int] = None,
                 opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetClustersResult:
    """
    Use this data source to access information about an existing resource.
    """
    __args__ = dict()
    __args__['clusterId'] = cluster_id
    __args__['limit'] = limit
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('tencentcloud:Deprecatedcontainer/getClusters:getClusters', __args__, opts=opts, typ=GetClustersResult).value

    return AwaitableGetClustersResult(
        cluster_id=pulumi.get(__ret__, 'cluster_id'),
        clusters=pulumi.get(__ret__, 'clusters'),
        id=pulumi.get(__ret__, 'id'),
        limit=pulumi.get(__ret__, 'limit'),
        total_count=pulumi.get(__ret__, 'total_count'))


@_utilities.lift_output_func(get_clusters)
def get_clusters_output(cluster_id: Optional[pulumi.Input[Optional[str]]] = None,
                        limit: Optional[pulumi.Input[Optional[int]]] = None,
                        opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetClustersResult]:
    """
    Use this data source to access information about an existing resource.
    """
    ...