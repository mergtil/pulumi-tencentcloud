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
    'BusinessIntelligenceInstanceResourceTagArgs',
    'ConfigInstanceParamParamListArgs',
    'ConfigInstanceRoGroupWeightPairArgs',
    'GeneralCloudInstanceResourceTagArgs',
    'MigrationMigrateDbSetArgs',
    'MigrationRenameRestoreArgs',
    'MigrationSourceArgs',
    'MigrationTargetArgs',
    'PublishSubscribeDatabaseTupleArgs',
    'RestoreInstanceEncryptionArgs',
    'RestoreInstanceRenameRestoreArgs',
    'RollbackInstanceEncryptionArgs',
    'RollbackInstanceRenameRestoreArgs',
    'StartXeventEventConfigArgs',
]

@pulumi.input_type
class BusinessIntelligenceInstanceResourceTagArgs:
    def __init__(__self__, *,
                 tag_key: Optional[pulumi.Input[str]] = None,
                 tag_value: Optional[pulumi.Input[str]] = None):
        if tag_key is not None:
            pulumi.set(__self__, "tag_key", tag_key)
        if tag_value is not None:
            pulumi.set(__self__, "tag_value", tag_value)

    @property
    @pulumi.getter(name="tagKey")
    def tag_key(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "tag_key")

    @tag_key.setter
    def tag_key(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "tag_key", value)

    @property
    @pulumi.getter(name="tagValue")
    def tag_value(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "tag_value")

    @tag_value.setter
    def tag_value(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "tag_value", value)


@pulumi.input_type
class ConfigInstanceParamParamListArgs:
    def __init__(__self__, *,
                 current_value: Optional[pulumi.Input[str]] = None,
                 name: Optional[pulumi.Input[str]] = None):
        if current_value is not None:
            pulumi.set(__self__, "current_value", current_value)
        if name is not None:
            pulumi.set(__self__, "name", name)

    @property
    @pulumi.getter(name="currentValue")
    def current_value(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "current_value")

    @current_value.setter
    def current_value(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "current_value", value)

    @property
    @pulumi.getter
    def name(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "name")

    @name.setter
    def name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "name", value)


@pulumi.input_type
class ConfigInstanceRoGroupWeightPairArgs:
    def __init__(__self__, *,
                 read_only_instance_id: pulumi.Input[str],
                 read_only_weight: pulumi.Input[int]):
        pulumi.set(__self__, "read_only_instance_id", read_only_instance_id)
        pulumi.set(__self__, "read_only_weight", read_only_weight)

    @property
    @pulumi.getter(name="readOnlyInstanceId")
    def read_only_instance_id(self) -> pulumi.Input[str]:
        return pulumi.get(self, "read_only_instance_id")

    @read_only_instance_id.setter
    def read_only_instance_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "read_only_instance_id", value)

    @property
    @pulumi.getter(name="readOnlyWeight")
    def read_only_weight(self) -> pulumi.Input[int]:
        return pulumi.get(self, "read_only_weight")

    @read_only_weight.setter
    def read_only_weight(self, value: pulumi.Input[int]):
        pulumi.set(self, "read_only_weight", value)


@pulumi.input_type
class GeneralCloudInstanceResourceTagArgs:
    def __init__(__self__, *,
                 tag_key: Optional[pulumi.Input[str]] = None,
                 tag_value: Optional[pulumi.Input[str]] = None):
        if tag_key is not None:
            pulumi.set(__self__, "tag_key", tag_key)
        if tag_value is not None:
            pulumi.set(__self__, "tag_value", tag_value)

    @property
    @pulumi.getter(name="tagKey")
    def tag_key(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "tag_key")

    @tag_key.setter
    def tag_key(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "tag_key", value)

    @property
    @pulumi.getter(name="tagValue")
    def tag_value(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "tag_value")

    @tag_value.setter
    def tag_value(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "tag_value", value)


@pulumi.input_type
class MigrationMigrateDbSetArgs:
    def __init__(__self__, *,
                 db_name: Optional[pulumi.Input[str]] = None):
        if db_name is not None:
            pulumi.set(__self__, "db_name", db_name)

    @property
    @pulumi.getter(name="dbName")
    def db_name(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "db_name")

    @db_name.setter
    def db_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "db_name", value)


@pulumi.input_type
class MigrationRenameRestoreArgs:
    def __init__(__self__, *,
                 new_name: Optional[pulumi.Input[str]] = None,
                 old_name: Optional[pulumi.Input[str]] = None):
        if new_name is not None:
            pulumi.set(__self__, "new_name", new_name)
        if old_name is not None:
            pulumi.set(__self__, "old_name", old_name)

    @property
    @pulumi.getter(name="newName")
    def new_name(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "new_name")

    @new_name.setter
    def new_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "new_name", value)

    @property
    @pulumi.getter(name="oldName")
    def old_name(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "old_name")

    @old_name.setter
    def old_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "old_name", value)


@pulumi.input_type
class MigrationSourceArgs:
    def __init__(__self__, *,
                 cvm_id: Optional[pulumi.Input[str]] = None,
                 instance_id: Optional[pulumi.Input[str]] = None,
                 ip: Optional[pulumi.Input[str]] = None,
                 password: Optional[pulumi.Input[str]] = None,
                 port: Optional[pulumi.Input[int]] = None,
                 subnet_id: Optional[pulumi.Input[str]] = None,
                 url_password: Optional[pulumi.Input[str]] = None,
                 urls: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 user_name: Optional[pulumi.Input[str]] = None,
                 vpc_id: Optional[pulumi.Input[str]] = None):
        if cvm_id is not None:
            pulumi.set(__self__, "cvm_id", cvm_id)
        if instance_id is not None:
            pulumi.set(__self__, "instance_id", instance_id)
        if ip is not None:
            pulumi.set(__self__, "ip", ip)
        if password is not None:
            pulumi.set(__self__, "password", password)
        if port is not None:
            pulumi.set(__self__, "port", port)
        if subnet_id is not None:
            pulumi.set(__self__, "subnet_id", subnet_id)
        if url_password is not None:
            pulumi.set(__self__, "url_password", url_password)
        if urls is not None:
            pulumi.set(__self__, "urls", urls)
        if user_name is not None:
            pulumi.set(__self__, "user_name", user_name)
        if vpc_id is not None:
            pulumi.set(__self__, "vpc_id", vpc_id)

    @property
    @pulumi.getter(name="cvmId")
    def cvm_id(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "cvm_id")

    @cvm_id.setter
    def cvm_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "cvm_id", value)

    @property
    @pulumi.getter(name="instanceId")
    def instance_id(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "instance_id")

    @instance_id.setter
    def instance_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "instance_id", value)

    @property
    @pulumi.getter
    def ip(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "ip")

    @ip.setter
    def ip(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "ip", value)

    @property
    @pulumi.getter
    def password(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "password")

    @password.setter
    def password(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "password", value)

    @property
    @pulumi.getter
    def port(self) -> Optional[pulumi.Input[int]]:
        return pulumi.get(self, "port")

    @port.setter
    def port(self, value: Optional[pulumi.Input[int]]):
        pulumi.set(self, "port", value)

    @property
    @pulumi.getter(name="subnetId")
    def subnet_id(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "subnet_id")

    @subnet_id.setter
    def subnet_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "subnet_id", value)

    @property
    @pulumi.getter(name="urlPassword")
    def url_password(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "url_password")

    @url_password.setter
    def url_password(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "url_password", value)

    @property
    @pulumi.getter
    def urls(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        return pulumi.get(self, "urls")

    @urls.setter
    def urls(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "urls", value)

    @property
    @pulumi.getter(name="userName")
    def user_name(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "user_name")

    @user_name.setter
    def user_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "user_name", value)

    @property
    @pulumi.getter(name="vpcId")
    def vpc_id(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "vpc_id")

    @vpc_id.setter
    def vpc_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "vpc_id", value)


@pulumi.input_type
class MigrationTargetArgs:
    def __init__(__self__, *,
                 instance_id: Optional[pulumi.Input[str]] = None,
                 password: Optional[pulumi.Input[str]] = None,
                 user_name: Optional[pulumi.Input[str]] = None):
        if instance_id is not None:
            pulumi.set(__self__, "instance_id", instance_id)
        if password is not None:
            pulumi.set(__self__, "password", password)
        if user_name is not None:
            pulumi.set(__self__, "user_name", user_name)

    @property
    @pulumi.getter(name="instanceId")
    def instance_id(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "instance_id")

    @instance_id.setter
    def instance_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "instance_id", value)

    @property
    @pulumi.getter
    def password(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "password")

    @password.setter
    def password(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "password", value)

    @property
    @pulumi.getter(name="userName")
    def user_name(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "user_name")

    @user_name.setter
    def user_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "user_name", value)


@pulumi.input_type
class PublishSubscribeDatabaseTupleArgs:
    def __init__(__self__, *,
                 publish_database: pulumi.Input[str],
                 subscribe_database: pulumi.Input[str]):
        pulumi.set(__self__, "publish_database", publish_database)
        pulumi.set(__self__, "subscribe_database", subscribe_database)

    @property
    @pulumi.getter(name="publishDatabase")
    def publish_database(self) -> pulumi.Input[str]:
        return pulumi.get(self, "publish_database")

    @publish_database.setter
    def publish_database(self, value: pulumi.Input[str]):
        pulumi.set(self, "publish_database", value)

    @property
    @pulumi.getter(name="subscribeDatabase")
    def subscribe_database(self) -> pulumi.Input[str]:
        return pulumi.get(self, "subscribe_database")

    @subscribe_database.setter
    def subscribe_database(self, value: pulumi.Input[str]):
        pulumi.set(self, "subscribe_database", value)


@pulumi.input_type
class RestoreInstanceEncryptionArgs:
    def __init__(__self__, *,
                 db_name: Optional[pulumi.Input[str]] = None,
                 status: Optional[pulumi.Input[str]] = None):
        if db_name is not None:
            pulumi.set(__self__, "db_name", db_name)
        if status is not None:
            pulumi.set(__self__, "status", status)

    @property
    @pulumi.getter(name="dbName")
    def db_name(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "db_name")

    @db_name.setter
    def db_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "db_name", value)

    @property
    @pulumi.getter
    def status(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "status")

    @status.setter
    def status(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "status", value)


@pulumi.input_type
class RestoreInstanceRenameRestoreArgs:
    def __init__(__self__, *,
                 new_name: pulumi.Input[str],
                 old_name: pulumi.Input[str]):
        pulumi.set(__self__, "new_name", new_name)
        pulumi.set(__self__, "old_name", old_name)

    @property
    @pulumi.getter(name="newName")
    def new_name(self) -> pulumi.Input[str]:
        return pulumi.get(self, "new_name")

    @new_name.setter
    def new_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "new_name", value)

    @property
    @pulumi.getter(name="oldName")
    def old_name(self) -> pulumi.Input[str]:
        return pulumi.get(self, "old_name")

    @old_name.setter
    def old_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "old_name", value)


@pulumi.input_type
class RollbackInstanceEncryptionArgs:
    def __init__(__self__, *,
                 db_name: Optional[pulumi.Input[str]] = None,
                 status: Optional[pulumi.Input[str]] = None):
        if db_name is not None:
            pulumi.set(__self__, "db_name", db_name)
        if status is not None:
            pulumi.set(__self__, "status", status)

    @property
    @pulumi.getter(name="dbName")
    def db_name(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "db_name")

    @db_name.setter
    def db_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "db_name", value)

    @property
    @pulumi.getter
    def status(self) -> Optional[pulumi.Input[str]]:
        return pulumi.get(self, "status")

    @status.setter
    def status(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "status", value)


@pulumi.input_type
class RollbackInstanceRenameRestoreArgs:
    def __init__(__self__, *,
                 new_name: pulumi.Input[str],
                 old_name: pulumi.Input[str]):
        pulumi.set(__self__, "new_name", new_name)
        pulumi.set(__self__, "old_name", old_name)

    @property
    @pulumi.getter(name="newName")
    def new_name(self) -> pulumi.Input[str]:
        return pulumi.get(self, "new_name")

    @new_name.setter
    def new_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "new_name", value)

    @property
    @pulumi.getter(name="oldName")
    def old_name(self) -> pulumi.Input[str]:
        return pulumi.get(self, "old_name")

    @old_name.setter
    def old_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "old_name", value)


@pulumi.input_type
class StartXeventEventConfigArgs:
    def __init__(__self__, *,
                 event_type: pulumi.Input[str],
                 threshold: pulumi.Input[int]):
        pulumi.set(__self__, "event_type", event_type)
        pulumi.set(__self__, "threshold", threshold)

    @property
    @pulumi.getter(name="eventType")
    def event_type(self) -> pulumi.Input[str]:
        return pulumi.get(self, "event_type")

    @event_type.setter
    def event_type(self, value: pulumi.Input[str]):
        pulumi.set(self, "event_type", value)

    @property
    @pulumi.getter
    def threshold(self) -> pulumi.Input[int]:
        return pulumi.get(self, "threshold")

    @threshold.setter
    def threshold(self, value: pulumi.Input[int]):
        pulumi.set(self, "threshold", value)

