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
    'InstanceDataDisk',
    'GetTypesFilterResult',
    'GetTypesInstanceTypeResult',
]

@pulumi.output_type
class InstanceDataDisk(dict):
    @staticmethod
    def __key_warning(key: str):
        suggest = None
        if key == "dataDiskSize":
            suggest = "data_disk_size"
        elif key == "dataDiskType":
            suggest = "data_disk_type"
        elif key == "dataDiskId":
            suggest = "data_disk_id"
        elif key == "dataDiskSnapshotId":
            suggest = "data_disk_snapshot_id"
        elif key == "deleteWithInstance":
            suggest = "delete_with_instance"
        elif key == "throughputPerformance":
            suggest = "throughput_performance"

        if suggest:
            pulumi.log.warn(f"Key '{key}' not found in InstanceDataDisk. Access the value via the '{suggest}' property getter instead.")

    def __getitem__(self, key: str) -> Any:
        InstanceDataDisk.__key_warning(key)
        return super().__getitem__(key)

    def get(self, key: str, default = None) -> Any:
        InstanceDataDisk.__key_warning(key)
        return super().get(key, default)

    def __init__(__self__, *,
                 data_disk_size: int,
                 data_disk_type: str,
                 data_disk_id: Optional[str] = None,
                 data_disk_snapshot_id: Optional[str] = None,
                 delete_with_instance: Optional[bool] = None,
                 encrypt: Optional[bool] = None,
                 throughput_performance: Optional[int] = None):
        pulumi.set(__self__, "data_disk_size", data_disk_size)
        pulumi.set(__self__, "data_disk_type", data_disk_type)
        if data_disk_id is not None:
            pulumi.set(__self__, "data_disk_id", data_disk_id)
        if data_disk_snapshot_id is not None:
            pulumi.set(__self__, "data_disk_snapshot_id", data_disk_snapshot_id)
        if delete_with_instance is not None:
            pulumi.set(__self__, "delete_with_instance", delete_with_instance)
        if encrypt is not None:
            pulumi.set(__self__, "encrypt", encrypt)
        if throughput_performance is not None:
            pulumi.set(__self__, "throughput_performance", throughput_performance)

    @property
    @pulumi.getter(name="dataDiskSize")
    def data_disk_size(self) -> int:
        return pulumi.get(self, "data_disk_size")

    @property
    @pulumi.getter(name="dataDiskType")
    def data_disk_type(self) -> str:
        return pulumi.get(self, "data_disk_type")

    @property
    @pulumi.getter(name="dataDiskId")
    def data_disk_id(self) -> Optional[str]:
        return pulumi.get(self, "data_disk_id")

    @property
    @pulumi.getter(name="dataDiskSnapshotId")
    def data_disk_snapshot_id(self) -> Optional[str]:
        return pulumi.get(self, "data_disk_snapshot_id")

    @property
    @pulumi.getter(name="deleteWithInstance")
    def delete_with_instance(self) -> Optional[bool]:
        return pulumi.get(self, "delete_with_instance")

    @property
    @pulumi.getter
    def encrypt(self) -> Optional[bool]:
        return pulumi.get(self, "encrypt")

    @property
    @pulumi.getter(name="throughputPerformance")
    def throughput_performance(self) -> Optional[int]:
        return pulumi.get(self, "throughput_performance")


@pulumi.output_type
class GetTypesFilterResult(dict):
    def __init__(__self__, *,
                 name: str,
                 values: Sequence[str]):
        pulumi.set(__self__, "name", name)
        pulumi.set(__self__, "values", values)

    @property
    @pulumi.getter
    def name(self) -> str:
        return pulumi.get(self, "name")

    @property
    @pulumi.getter
    def values(self) -> Sequence[str]:
        return pulumi.get(self, "values")


@pulumi.output_type
class GetTypesInstanceTypeResult(dict):
    def __init__(__self__, *,
                 availability_zone: str,
                 cpu_core_count: int,
                 family: str,
                 gpu_core_count: int,
                 instance_charge_type: str,
                 instance_type: str,
                 memory_size: int,
                 status: str):
        pulumi.set(__self__, "availability_zone", availability_zone)
        pulumi.set(__self__, "cpu_core_count", cpu_core_count)
        pulumi.set(__self__, "family", family)
        pulumi.set(__self__, "gpu_core_count", gpu_core_count)
        pulumi.set(__self__, "instance_charge_type", instance_charge_type)
        pulumi.set(__self__, "instance_type", instance_type)
        pulumi.set(__self__, "memory_size", memory_size)
        pulumi.set(__self__, "status", status)

    @property
    @pulumi.getter(name="availabilityZone")
    def availability_zone(self) -> str:
        return pulumi.get(self, "availability_zone")

    @property
    @pulumi.getter(name="cpuCoreCount")
    def cpu_core_count(self) -> int:
        return pulumi.get(self, "cpu_core_count")

    @property
    @pulumi.getter
    def family(self) -> str:
        return pulumi.get(self, "family")

    @property
    @pulumi.getter(name="gpuCoreCount")
    def gpu_core_count(self) -> int:
        return pulumi.get(self, "gpu_core_count")

    @property
    @pulumi.getter(name="instanceChargeType")
    def instance_charge_type(self) -> str:
        return pulumi.get(self, "instance_charge_type")

    @property
    @pulumi.getter(name="instanceType")
    def instance_type(self) -> str:
        return pulumi.get(self, "instance_type")

    @property
    @pulumi.getter(name="memorySize")
    def memory_size(self) -> int:
        return pulumi.get(self, "memory_size")

    @property
    @pulumi.getter
    def status(self) -> str:
        return pulumi.get(self, "status")

