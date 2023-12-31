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
    'GetRecordsRecordCountInfoResult',
    'GetRecordsResultResult',
]

@pulumi.output_type
class GetRecordsRecordCountInfoResult(dict):
    def __init__(__self__, *,
                 list_count: int,
                 subdomain_count: int,
                 total_count: int):
        pulumi.set(__self__, "list_count", list_count)
        pulumi.set(__self__, "subdomain_count", subdomain_count)
        pulumi.set(__self__, "total_count", total_count)

    @property
    @pulumi.getter(name="listCount")
    def list_count(self) -> int:
        return pulumi.get(self, "list_count")

    @property
    @pulumi.getter(name="subdomainCount")
    def subdomain_count(self) -> int:
        return pulumi.get(self, "subdomain_count")

    @property
    @pulumi.getter(name="totalCount")
    def total_count(self) -> int:
        return pulumi.get(self, "total_count")


@pulumi.output_type
class GetRecordsResultResult(dict):
    def __init__(__self__, *,
                 line: str,
                 line_id: str,
                 monitor_status: str,
                 mx: int,
                 name: str,
                 record_id: int,
                 remark: str,
                 status: str,
                 ttl: int,
                 type: str,
                 updated_on: str,
                 value: str,
                 weight: int):
        pulumi.set(__self__, "line", line)
        pulumi.set(__self__, "line_id", line_id)
        pulumi.set(__self__, "monitor_status", monitor_status)
        pulumi.set(__self__, "mx", mx)
        pulumi.set(__self__, "name", name)
        pulumi.set(__self__, "record_id", record_id)
        pulumi.set(__self__, "remark", remark)
        pulumi.set(__self__, "status", status)
        pulumi.set(__self__, "ttl", ttl)
        pulumi.set(__self__, "type", type)
        pulumi.set(__self__, "updated_on", updated_on)
        pulumi.set(__self__, "value", value)
        pulumi.set(__self__, "weight", weight)

    @property
    @pulumi.getter
    def line(self) -> str:
        return pulumi.get(self, "line")

    @property
    @pulumi.getter(name="lineId")
    def line_id(self) -> str:
        return pulumi.get(self, "line_id")

    @property
    @pulumi.getter(name="monitorStatus")
    def monitor_status(self) -> str:
        return pulumi.get(self, "monitor_status")

    @property
    @pulumi.getter
    def mx(self) -> int:
        return pulumi.get(self, "mx")

    @property
    @pulumi.getter
    def name(self) -> str:
        return pulumi.get(self, "name")

    @property
    @pulumi.getter(name="recordId")
    def record_id(self) -> int:
        return pulumi.get(self, "record_id")

    @property
    @pulumi.getter
    def remark(self) -> str:
        return pulumi.get(self, "remark")

    @property
    @pulumi.getter
    def status(self) -> str:
        return pulumi.get(self, "status")

    @property
    @pulumi.getter
    def ttl(self) -> int:
        return pulumi.get(self, "ttl")

    @property
    @pulumi.getter
    def type(self) -> str:
        return pulumi.get(self, "type")

    @property
    @pulumi.getter(name="updatedOn")
    def updated_on(self) -> str:
        return pulumi.get(self, "updated_on")

    @property
    @pulumi.getter
    def value(self) -> str:
        return pulumi.get(self, "value")

    @property
    @pulumi.getter
    def weight(self) -> int:
        return pulumi.get(self, "weight")


