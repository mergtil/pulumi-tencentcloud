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
    'GetSlowLogsResult',
    'AwaitableGetSlowLogsResult',
    'get_slow_logs',
    'get_slow_logs_output',
]

@pulumi.output_type
class GetSlowLogsResult:
    """
    A collection of values returned by getSlowLogs.
    """
    def __init__(__self__, datas=None, db=None, end_time=None, id=None, instance_id=None, lock_time_sum=None, order_by=None, order_by_type=None, query_count=None, query_time_sum=None, result_output_file=None, shard_id=None, slave=None, start_time=None):
        if datas and not isinstance(datas, list):
            raise TypeError("Expected argument 'datas' to be a list")
        pulumi.set(__self__, "datas", datas)
        if db and not isinstance(db, str):
            raise TypeError("Expected argument 'db' to be a str")
        pulumi.set(__self__, "db", db)
        if end_time and not isinstance(end_time, str):
            raise TypeError("Expected argument 'end_time' to be a str")
        pulumi.set(__self__, "end_time", end_time)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if instance_id and not isinstance(instance_id, str):
            raise TypeError("Expected argument 'instance_id' to be a str")
        pulumi.set(__self__, "instance_id", instance_id)
        if lock_time_sum and not isinstance(lock_time_sum, float):
            raise TypeError("Expected argument 'lock_time_sum' to be a float")
        pulumi.set(__self__, "lock_time_sum", lock_time_sum)
        if order_by and not isinstance(order_by, str):
            raise TypeError("Expected argument 'order_by' to be a str")
        pulumi.set(__self__, "order_by", order_by)
        if order_by_type and not isinstance(order_by_type, str):
            raise TypeError("Expected argument 'order_by_type' to be a str")
        pulumi.set(__self__, "order_by_type", order_by_type)
        if query_count and not isinstance(query_count, int):
            raise TypeError("Expected argument 'query_count' to be a int")
        pulumi.set(__self__, "query_count", query_count)
        if query_time_sum and not isinstance(query_time_sum, float):
            raise TypeError("Expected argument 'query_time_sum' to be a float")
        pulumi.set(__self__, "query_time_sum", query_time_sum)
        if result_output_file and not isinstance(result_output_file, str):
            raise TypeError("Expected argument 'result_output_file' to be a str")
        pulumi.set(__self__, "result_output_file", result_output_file)
        if shard_id and not isinstance(shard_id, str):
            raise TypeError("Expected argument 'shard_id' to be a str")
        pulumi.set(__self__, "shard_id", shard_id)
        if slave and not isinstance(slave, int):
            raise TypeError("Expected argument 'slave' to be a int")
        pulumi.set(__self__, "slave", slave)
        if start_time and not isinstance(start_time, str):
            raise TypeError("Expected argument 'start_time' to be a str")
        pulumi.set(__self__, "start_time", start_time)

    @property
    @pulumi.getter
    def datas(self) -> Sequence['outputs.GetSlowLogsDataResult']:
        return pulumi.get(self, "datas")

    @property
    @pulumi.getter
    def db(self) -> Optional[str]:
        return pulumi.get(self, "db")

    @property
    @pulumi.getter(name="endTime")
    def end_time(self) -> Optional[str]:
        return pulumi.get(self, "end_time")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter(name="instanceId")
    def instance_id(self) -> str:
        return pulumi.get(self, "instance_id")

    @property
    @pulumi.getter(name="lockTimeSum")
    def lock_time_sum(self) -> float:
        return pulumi.get(self, "lock_time_sum")

    @property
    @pulumi.getter(name="orderBy")
    def order_by(self) -> Optional[str]:
        return pulumi.get(self, "order_by")

    @property
    @pulumi.getter(name="orderByType")
    def order_by_type(self) -> Optional[str]:
        return pulumi.get(self, "order_by_type")

    @property
    @pulumi.getter(name="queryCount")
    def query_count(self) -> int:
        return pulumi.get(self, "query_count")

    @property
    @pulumi.getter(name="queryTimeSum")
    def query_time_sum(self) -> float:
        return pulumi.get(self, "query_time_sum")

    @property
    @pulumi.getter(name="resultOutputFile")
    def result_output_file(self) -> Optional[str]:
        return pulumi.get(self, "result_output_file")

    @property
    @pulumi.getter(name="shardId")
    def shard_id(self) -> str:
        return pulumi.get(self, "shard_id")

    @property
    @pulumi.getter
    def slave(self) -> Optional[int]:
        return pulumi.get(self, "slave")

    @property
    @pulumi.getter(name="startTime")
    def start_time(self) -> str:
        return pulumi.get(self, "start_time")


class AwaitableGetSlowLogsResult(GetSlowLogsResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetSlowLogsResult(
            datas=self.datas,
            db=self.db,
            end_time=self.end_time,
            id=self.id,
            instance_id=self.instance_id,
            lock_time_sum=self.lock_time_sum,
            order_by=self.order_by,
            order_by_type=self.order_by_type,
            query_count=self.query_count,
            query_time_sum=self.query_time_sum,
            result_output_file=self.result_output_file,
            shard_id=self.shard_id,
            slave=self.slave,
            start_time=self.start_time)


def get_slow_logs(db: Optional[str] = None,
                  end_time: Optional[str] = None,
                  instance_id: Optional[str] = None,
                  order_by: Optional[str] = None,
                  order_by_type: Optional[str] = None,
                  result_output_file: Optional[str] = None,
                  shard_id: Optional[str] = None,
                  slave: Optional[int] = None,
                  start_time: Optional[str] = None,
                  opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetSlowLogsResult:
    """
    Use this data source to access information about an existing resource.
    """
    __args__ = dict()
    __args__['db'] = db
    __args__['endTime'] = end_time
    __args__['instanceId'] = instance_id
    __args__['orderBy'] = order_by
    __args__['orderByType'] = order_by_type
    __args__['resultOutputFile'] = result_output_file
    __args__['shardId'] = shard_id
    __args__['slave'] = slave
    __args__['startTime'] = start_time
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('tencentcloud:Dcdb/getSlowLogs:getSlowLogs', __args__, opts=opts, typ=GetSlowLogsResult).value

    return AwaitableGetSlowLogsResult(
        datas=pulumi.get(__ret__, 'datas'),
        db=pulumi.get(__ret__, 'db'),
        end_time=pulumi.get(__ret__, 'end_time'),
        id=pulumi.get(__ret__, 'id'),
        instance_id=pulumi.get(__ret__, 'instance_id'),
        lock_time_sum=pulumi.get(__ret__, 'lock_time_sum'),
        order_by=pulumi.get(__ret__, 'order_by'),
        order_by_type=pulumi.get(__ret__, 'order_by_type'),
        query_count=pulumi.get(__ret__, 'query_count'),
        query_time_sum=pulumi.get(__ret__, 'query_time_sum'),
        result_output_file=pulumi.get(__ret__, 'result_output_file'),
        shard_id=pulumi.get(__ret__, 'shard_id'),
        slave=pulumi.get(__ret__, 'slave'),
        start_time=pulumi.get(__ret__, 'start_time'))


@_utilities.lift_output_func(get_slow_logs)
def get_slow_logs_output(db: Optional[pulumi.Input[Optional[str]]] = None,
                         end_time: Optional[pulumi.Input[Optional[str]]] = None,
                         instance_id: Optional[pulumi.Input[str]] = None,
                         order_by: Optional[pulumi.Input[Optional[str]]] = None,
                         order_by_type: Optional[pulumi.Input[Optional[str]]] = None,
                         result_output_file: Optional[pulumi.Input[Optional[str]]] = None,
                         shard_id: Optional[pulumi.Input[str]] = None,
                         slave: Optional[pulumi.Input[Optional[int]]] = None,
                         start_time: Optional[pulumi.Input[str]] = None,
                         opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetSlowLogsResult]:
    """
    Use this data source to access information about an existing resource.
    """
    ...