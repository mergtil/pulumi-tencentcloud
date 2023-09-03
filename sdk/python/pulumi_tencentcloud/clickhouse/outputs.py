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
    'BackupStrategyDataBackupStrategy',
    'BackupStrategyDataBackupStrategyBackUpTable',
    'BackupStrategyMetaBackupStrategy',
    'InstanceCommonSpec',
    'InstanceDataSpec',
    'GetBackupJobDetailTableContentResult',
    'GetBackupJobsBackUpJobResult',
]

@pulumi.output_type
class BackupStrategyDataBackupStrategy(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "backUpTables":
            suggest = "back_up_tables"
        elif key == "executeHour":
            suggest = "execute_hour"
        elif key == "retainDays":
            suggest = "retain_days"
        elif key == "weekDays":
            suggest = "week_days"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in BackupStrategyDataBackupStrategy. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        BackupStrategyDataBackupStrategy.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        BackupStrategyDataBackupStrategy.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 back_up_tables: Sequence['outputs.BackupStrategyDataBackupStrategyBackUpTable'],
                 execute_hour: int,
                 retain_days: int,
                 week_days: str):
        pulumi.set(__self__, "back_up_tables", back_up_tables)
        pulumi.set(__self__, "execute_hour", execute_hour)
        pulumi.set(__self__, "retain_days", retain_days)
        pulumi.set(__self__, "week_days", week_days)

    @property
    @pulumi.getter(name="backUpTables")
    def back_up_tables(self) -> Sequence['outputs.BackupStrategyDataBackupStrategyBackUpTable']:
        return pulumi.get(self, "back_up_tables")

    @property
    @pulumi.getter(name="executeHour")
    def execute_hour(self) -> int:
        return pulumi.get(self, "execute_hour")

    @property
    @pulumi.getter(name="retainDays")
    def retain_days(self) -> int:
        return pulumi.get(self, "retain_days")

    @property
    @pulumi.getter(name="weekDays")
    def week_days(self) -> str:
        return pulumi.get(self, "week_days")


@pulumi.output_type
class BackupStrategyDataBackupStrategyBackUpTable(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "totalBytes":
            suggest = "total_bytes"
        elif key == "vCluster":
            suggest = "v_cluster"
        elif key == "zooPath":
            suggest = "zoo_path"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in BackupStrategyDataBackupStrategyBackUpTable. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        BackupStrategyDataBackupStrategyBackUpTable.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        BackupStrategyDataBackupStrategyBackUpTable.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 database: str,
                 table: str,
                 total_bytes: int,
                 ips: Optional[str] = None,
                 rip: Optional[str] = None,
                 v_cluster: Optional[str] = None,
                 zoo_path: Optional[str] = None):
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
    def database(self) -> str:
        return pulumi.get(self, "database")

    @property
    @pulumi.getter
    def table(self) -> str:
        return pulumi.get(self, "table")

    @property
    @pulumi.getter(name="totalBytes")
    def total_bytes(self) -> int:
        return pulumi.get(self, "total_bytes")

    @property
    @pulumi.getter
    def ips(self) -> Optional[str]:
        return pulumi.get(self, "ips")

    @property
    @pulumi.getter
    def rip(self) -> Optional[str]:
        return pulumi.get(self, "rip")

    @property
    @pulumi.getter(name="vCluster")
    def v_cluster(self) -> Optional[str]:
        return pulumi.get(self, "v_cluster")

    @property
    @pulumi.getter(name="zooPath")
    def zoo_path(self) -> Optional[str]:
        return pulumi.get(self, "zoo_path")


@pulumi.output_type
class BackupStrategyMetaBackupStrategy(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "executeHour":
            suggest = "execute_hour"
        elif key == "retainDays":
            suggest = "retain_days"
        elif key == "weekDays":
            suggest = "week_days"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in BackupStrategyMetaBackupStrategy. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        BackupStrategyMetaBackupStrategy.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        BackupStrategyMetaBackupStrategy.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 execute_hour: Optional[int] = None,
                 retain_days: Optional[int] = None,
                 week_days: Optional[str] = None):
        if execute_hour is not None:
            pulumi.set(__self__, "execute_hour", execute_hour)
        if retain_days is not None:
            pulumi.set(__self__, "retain_days", retain_days)
        if week_days is not None:
            pulumi.set(__self__, "week_days", week_days)

    @property
    @pulumi.getter(name="executeHour")
    def execute_hour(self) -> Optional[int]:
        return pulumi.get(self, "execute_hour")

    @property
    @pulumi.getter(name="retainDays")
    def retain_days(self) -> Optional[int]:
        return pulumi.get(self, "retain_days")

    @property
    @pulumi.getter(name="weekDays")
    def week_days(self) -> Optional[str]:
        return pulumi.get(self, "week_days")


@pulumi.output_type
class InstanceCommonSpec(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "diskSize":
            suggest = "disk_size"
        elif key == "specName":
            suggest = "spec_name"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in InstanceCommonSpec. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        InstanceCommonSpec.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        InstanceCommonSpec.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 count: int,
                 disk_size: int,
                 spec_name: str):
        pulumi.set(__self__, "count", count)
        pulumi.set(__self__, "disk_size", disk_size)
        pulumi.set(__self__, "spec_name", spec_name)

    @property
    @pulumi.getter
    def count(self) -> int:
        return pulumi.get(self, "count")

    @property
    @pulumi.getter(name="diskSize")
    def disk_size(self) -> int:
        return pulumi.get(self, "disk_size")

    @property
    @pulumi.getter(name="specName")
    def spec_name(self) -> str:
        return pulumi.get(self, "spec_name")


@pulumi.output_type
class InstanceDataSpec(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "diskSize":
            suggest = "disk_size"
        elif key == "specName":
            suggest = "spec_name"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in InstanceDataSpec. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        InstanceDataSpec.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        InstanceDataSpec.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 count: int,
                 disk_size: int,
                 spec_name: str):
        pulumi.set(__self__, "count", count)
        pulumi.set(__self__, "disk_size", disk_size)
        pulumi.set(__self__, "spec_name", spec_name)

    @property
    @pulumi.getter
    def count(self) -> int:
        return pulumi.get(self, "count")

    @property
    @pulumi.getter(name="diskSize")
    def disk_size(self) -> int:
        return pulumi.get(self, "disk_size")

    @property
    @pulumi.getter(name="specName")
    def spec_name(self) -> str:
        return pulumi.get(self, "spec_name")


@pulumi.output_type
class GetBackupJobDetailTableContentResult(dict):
    def __init__(__self__, *,
                 database: str,
                 ips: str,
                 rip: str,
                 table: str,
                 total_bytes: int,
                 v_cluster: str,
                 zoo_path: str):
        pulumi.set(__self__, "database", database)
        pulumi.set(__self__, "ips", ips)
        pulumi.set(__self__, "rip", rip)
        pulumi.set(__self__, "table", table)
        pulumi.set(__self__, "total_bytes", total_bytes)
        pulumi.set(__self__, "v_cluster", v_cluster)
        pulumi.set(__self__, "zoo_path", zoo_path)

    @property
    @pulumi.getter
    def database(self) -> str:
        return pulumi.get(self, "database")

    @property
    @pulumi.getter
    def ips(self) -> str:
        return pulumi.get(self, "ips")

    @property
    @pulumi.getter
    def rip(self) -> str:
        return pulumi.get(self, "rip")

    @property
    @pulumi.getter
    def table(self) -> str:
        return pulumi.get(self, "table")

    @property
    @pulumi.getter(name="totalBytes")
    def total_bytes(self) -> int:
        return pulumi.get(self, "total_bytes")

    @property
    @pulumi.getter(name="vCluster")
    def v_cluster(self) -> str:
        return pulumi.get(self, "v_cluster")

    @property
    @pulumi.getter(name="zooPath")
    def zoo_path(self) -> str:
        return pulumi.get(self, "zoo_path")


@pulumi.output_type
class GetBackupJobsBackUpJobResult(dict):
    def __init__(__self__, *,
                 back_up_size: int,
                 back_up_time: str,
                 back_up_type: str,
                 expire_time: str,
                 job_id: int,
                 job_status: str,
                 snapshot: str):
        pulumi.set(__self__, "back_up_size", back_up_size)
        pulumi.set(__self__, "back_up_time", back_up_time)
        pulumi.set(__self__, "back_up_type", back_up_type)
        pulumi.set(__self__, "expire_time", expire_time)
        pulumi.set(__self__, "job_id", job_id)
        pulumi.set(__self__, "job_status", job_status)
        pulumi.set(__self__, "snapshot", snapshot)

    @property
    @pulumi.getter(name="backUpSize")
    def back_up_size(self) -> int:
        return pulumi.get(self, "back_up_size")

    @property
    @pulumi.getter(name="backUpTime")
    def back_up_time(self) -> str:
        return pulumi.get(self, "back_up_time")

    @property
    @pulumi.getter(name="backUpType")
    def back_up_type(self) -> str:
        return pulumi.get(self, "back_up_type")

    @property
    @pulumi.getter(name="expireTime")
    def expire_time(self) -> str:
        return pulumi.get(self, "expire_time")

    @property
    @pulumi.getter(name="jobId")
    def job_id(self) -> int:
        return pulumi.get(self, "job_id")

    @property
    @pulumi.getter(name="jobStatus")
    def job_status(self) -> str:
        return pulumi.get(self, "job_status")

    @property
    @pulumi.getter
    def snapshot(self) -> str:
        return pulumi.get(self, "snapshot")

