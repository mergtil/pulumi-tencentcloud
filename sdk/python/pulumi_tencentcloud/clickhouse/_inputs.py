# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = [
    'BackupStrategyDataBackupStrategyArgs',
    'BackupStrategyDataBackupStrategyBackUpTableArgs',
    'BackupStrategyMetaBackupStrategyArgs',
    'InstanceCommonSpecArgs',
    'InstanceDataSpecArgs',
]

@pulumi.input_type
class BackupStrategyDataBackupStrategyArgs:
    def __init__(__self__, *,
                 back_up_tables: pulumi.Input[Sequence[pulumi.Input['BackupStrategyDataBackupStrategyBackUpTableArgs']]],
                 execute_hour: pulumi.Input[int],
                 retain_days: pulumi.Input[int],
                 week_days: pulumi.Input[str]):
        pulumi.set(__self__, "back_up_tables", back_up_tables)
        pulumi.set(__self__, "execute_hour", execute_hour)
        pulumi.set(__self__, "retain_days", retain_days)
        pulumi.set(__self__, "week_days", week_days)

    @property
    @pulumi.getter(name="backUpTables")
    def back_up_tables(self) -> pulumi.Input[Sequence[pulumi.Input['BackupStrategyDataBackupStrategyBackUpTableArgs']]]:
        return pulumi.get(self, "back_up_tables")

    @back_up_tables.setter
    def back_up_tables(self, value: pulumi.Input[Sequence[pulumi.Input['BackupStrategyDataBackupStrategyBackUpTableArgs']]]):
        pulumi.set(self, "back_up_tables", value)

    @property
    @pulumi.getter(name="executeHour")
    def execute_hour(self) -> pulumi.Input[int]:
        return pulumi.get(self, "execute_hour")

    @execute_hour.setter
    def execute_hour(self, value: pulumi.Input[int]):
        pulumi.set(self, "execute_hour", value)

    @property
    @pulumi.getter(name="retainDays")
    def retain_days(self) -> pulumi.Input[int]:
        return pulumi.get(self, "retain_days")

    @retain_days.setter
    def retain_days(self, value: pulumi.Input[int]):
        pulumi.set(self, "retain_days", value)

    @property
    @pulumi.getter(name="weekDays")
    def week_days(self) -> pulumi.Input[str]:
        return pulumi.get(self, "week_days")

    @week_days.setter
    def week_days(self, value: pulumi.Input[str]):
        pulumi.set(self, "week_days", value)


@pulumi.input_type
class BackupStrategyDataBackupStrategyBackUpTableArgs:
    def __init__(__self__, *,
                 database: pulumi.Input[str],
                 table: pulumi.Input[str],
                 total_bytes: pulumi.Input[int],
                 ips: Optional[pulumi.Input[str]] = None,
                 rip: Optional[pulumi.Input[str]] = None,
                 v_cluster: Optional[pulumi.Input[str]] = None,
                 zoo_path: Optional[pulumi.Input[str]] = None):
        pulumi.set(__self__, "database", database)
        pulumi.set(__self__, "table", table)
        pulumi.set(__self__, "total_bytes", total_bytes)
        if ips is not None:
            pulumi.set(__self__, "ips", ips)
        if rip is not None:
            pulumi.set(__self__, "rip", rip)
        if v_cluster is not None:
            pulumi.set(__self__, "v_cluster", v_cluster)
        if zoo_path is not None:
            pulumi.set(__self__, "zoo_path", zoo_path)

    @property
    @pulumi.getter
    def database(self) -> pulumi.Input[str]:
        return pulumi.get(self, "database")

    @database.setter
    def database(self, value: pulumi.Input[str]):
        pulumi.set(self, "database", value)

    @property
    @pulumi.getter
    def table(self) -> pulumi.Input[str]:
        return pulumi.get(self, "table")

    @table.setter
    def table(self, value: pulumi.Input[str]):
        pulumi.set(self, "table", value)

    @property
    @pulumi.getter(name="totalBytes")
    def total_bytes(self) -> pulumi.Input[int]:
        return pulumi.get(self, "total_bytes")

    @total_bytes.setter
    def total_bytes(self, value: pulumi.Input[int]):
        pulumi.set(self, "total_bytes", value)

    @property
    @pulumi.getter
    def ips(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "ips")

    @ips.setter
    def ips(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "ips", value)

    @property
    @pulumi.getter
    def rip(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "rip")

    @rip.setter
    def rip(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "rip", value)

    @property
    @pulumi.getter(name="vCluster")
    def v_cluster(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "v_cluster")

    @v_cluster.setter
    def v_cluster(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "v_cluster", value)

    @property
    @pulumi.getter(name="zooPath")
    def zoo_path(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "zoo_path")

    @zoo_path.setter
    def zoo_path(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "zoo_path", value)


@pulumi.input_type
class BackupStrategyMetaBackupStrategyArgs:
    def __init__(__self__, *,
                 execute_hour: Optional[pulumi.Input[int]] = None,
                 retain_days: Optional[pulumi.Input[int]] = None,
                 week_days: Optional[pulumi.Input[str]] = None):
        if execute_hour is not None:
            pulumi.set(__self__, "execute_hour", execute_hour)
        if retain_days is not None:
            pulumi.set(__self__, "retain_days", retain_days)
        if week_days is not None:
            pulumi.set(__self__, "week_days", week_days)

    @property
    @pulumi.getter(name="executeHour")
    def execute_hour(self) -> Optional[pulumi.Input[int]]:
        return pulumi.get(self, "execute_hour")

    @execute_hour.setter
    def execute_hour(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "execute_hour", value)

    @property
    @pulumi.getter(name="retainDays")
    def retain_days(self) -> Optional[pulumi.Input[int]]:
        return pulumi.get(self, "retain_days")

    @retain_days.setter
    def retain_days(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "retain_days", value)

    @property
    @pulumi.getter(name="weekDays")
    def week_days(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "week_days")

    @week_days.setter
    def week_days(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "week_days", value)


@pulumi.input_type
class InstanceCommonSpecArgs:
    def __init__(__self__, *,
                 count: pulumi.Input[int],
                 disk_size: pulumi.Input[int],
                 spec_name: pulumi.Input[str]):
        pulumi.set(__self__, "count", count)
        pulumi.set(__self__, "disk_size", disk_size)
        pulumi.set(__self__, "spec_name", spec_name)

    @property
    @pulumi.getter
    def count(self) -> pulumi.Input[int]:
        return pulumi.get(self, "count")

    @count.setter
    def count(self, value: pulumi.Input[int]):
        pulumi.set(self, "count", value)

    @property
    @pulumi.getter(name="diskSize")
    def disk_size(self) -> pulumi.Input[int]:
        return pulumi.get(self, "disk_size")

    @disk_size.setter
    def disk_size(self, value: pulumi.Input[int]):
        pulumi.set(self, "disk_size", value)

    @property
    @pulumi.getter(name="specName")
    def spec_name(self) -> pulumi.Input[str]:
        return pulumi.get(self, "spec_name")

    @spec_name.setter
    def spec_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "spec_name", value)


@pulumi.input_type
class InstanceDataSpecArgs:
    def __init__(__self__, *,
                 count: pulumi.Input[int],
                 disk_size: pulumi.Input[int],
                 spec_name: pulumi.Input[str]):
        pulumi.set(__self__, "count", count)
        pulumi.set(__self__, "disk_size", disk_size)
        pulumi.set(__self__, "spec_name", spec_name)

    @property
    @pulumi.getter
    def count(self) -> pulumi.Input[int]:
        return pulumi.get(self, "count")

    @count.setter
    def count(self, value: pulumi.Input[int]):
        pulumi.set(self, "count", value)

    @property
    @pulumi.getter(name="diskSize")
    def disk_size(self) -> pulumi.Input[int]:
        return pulumi.get(self, "disk_size")

    @disk_size.setter
    def disk_size(self, value: pulumi.Input[int]):
        pulumi.set(self, "disk_size", value)

    @property
    @pulumi.getter(name="specName")
    def spec_name(self) -> pulumi.Input[str]:
        return pulumi.get(self, "spec_name")

    @spec_name.setter
    def spec_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "spec_name", value)


