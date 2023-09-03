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
from ._inputs import *

__all__ = ['InstanceBackupDownloadTaskArgs', 'InstanceBackupDownloadTask']

@pulumi.input_type
class InstanceBackupDownloadTaskArgs:
    def __init__(__self__, *,
                 backup_name: pulumi.Input[str],
                 backup_sets: pulumi.Input[Sequence[pulumi.Input['InstanceBackupDownloadTaskBackupSetArgs']]],
                 instance_id: pulumi.Input[str]):
        """
        The set of arguments for constructing a InstanceBackupDownloadTask resource.
        :param pulumi.Input[str] backup_name: The name of the backup file to be downloaded can be obtained through the DescribeDBBackups interface.
        :param pulumi.Input[Sequence[pulumi.Input['InstanceBackupDownloadTaskBackupSetArgs']]] backup_sets: Specifies the node names of replica sets to download or a list of shard names for sharded clusters.For example, the
               replica set cmgo-p8vnipr5, example (fixed value): BackupSets.0=cmgo-p8vnipr5_0, the full amount of data can be
               downloaded.For example, the sharded cluster cmgo-p8vnipr5, for example:
               BackupSets.0=cmgo-p8vnipr5_0&amp;amp;BackupSets.1=cmgo-p8vnipr5_1, that is, to download the data of shard 0 and 1. If
               the sharded cluster needs to be downloaded in full, please pass in the example. Full slice name.
        :param pulumi.Input[str] instance_id: Instance ID, the format is: cmgo-9d0p6umb.Same as the instance ID displayed in the cloud database console page.
        """
        pulumi.set(__self__, "backup_name", backup_name)
        pulumi.set(__self__, "backup_sets", backup_sets)
        pulumi.set(__self__, "instance_id", instance_id)

    @property
    @pulumi.getter(name="backupName")
    def backup_name(self) -> pulumi.Input[str]:
        """
        The name of the backup file to be downloaded can be obtained through the DescribeDBBackups interface.
        """
        return pulumi.get(self, "backup_name")

    @backup_name.setter
    def backup_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "backup_name", value)

    @property
    @pulumi.getter(name="backupSets")
    def backup_sets(self) -> pulumi.Input[Sequence[pulumi.Input['InstanceBackupDownloadTaskBackupSetArgs']]]:
        """
        Specifies the node names of replica sets to download or a list of shard names for sharded clusters.For example, the
        replica set cmgo-p8vnipr5, example (fixed value): BackupSets.0=cmgo-p8vnipr5_0, the full amount of data can be
        downloaded.For example, the sharded cluster cmgo-p8vnipr5, for example:
        BackupSets.0=cmgo-p8vnipr5_0&amp;amp;BackupSets.1=cmgo-p8vnipr5_1, that is, to download the data of shard 0 and 1. If
        the sharded cluster needs to be downloaded in full, please pass in the example. Full slice name.
        """
        return pulumi.get(self, "backup_sets")

    @backup_sets.setter
    def backup_sets(self, value: pulumi.Input[Sequence[pulumi.Input['InstanceBackupDownloadTaskBackupSetArgs']]]):
        pulumi.set(self, "backup_sets", value)

    @property
    @pulumi.getter(name="instanceId")
    def instance_id(self) -> pulumi.Input[str]:
        """
        Instance ID, the format is: cmgo-9d0p6umb.Same as the instance ID displayed in the cloud database console page.
        """
        return pulumi.get(self, "instance_id")

    @instance_id.setter
    def instance_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "instance_id", value)


@pulumi.input_type
class _InstanceBackupDownloadTaskState:
    def __init__(__self__, *,
                 backup_name: Optional[pulumi.Input[str]] = None,
                 backup_sets: Optional[pulumi.Input[Sequence[pulumi.Input['InstanceBackupDownloadTaskBackupSetArgs']]]] = None,
                 instance_id: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering InstanceBackupDownloadTask resources.
        :param pulumi.Input[str] backup_name: The name of the backup file to be downloaded can be obtained through the DescribeDBBackups interface.
        :param pulumi.Input[Sequence[pulumi.Input['InstanceBackupDownloadTaskBackupSetArgs']]] backup_sets: Specifies the node names of replica sets to download or a list of shard names for sharded clusters.For example, the
               replica set cmgo-p8vnipr5, example (fixed value): BackupSets.0=cmgo-p8vnipr5_0, the full amount of data can be
               downloaded.For example, the sharded cluster cmgo-p8vnipr5, for example:
               BackupSets.0=cmgo-p8vnipr5_0&amp;amp;BackupSets.1=cmgo-p8vnipr5_1, that is, to download the data of shard 0 and 1. If
               the sharded cluster needs to be downloaded in full, please pass in the example. Full slice name.
        :param pulumi.Input[str] instance_id: Instance ID, the format is: cmgo-9d0p6umb.Same as the instance ID displayed in the cloud database console page.
        """
        if backup_name is not None:
            pulumi.set(__self__, "backup_name", backup_name)
        if backup_sets is not None:
            pulumi.set(__self__, "backup_sets", backup_sets)
        if instance_id is not None:
            pulumi.set(__self__, "instance_id", instance_id)

    @property
    @pulumi.getter(name="backupName")
    def backup_name(self) -> Optional[pulumi.Input[str]]:
        """
        The name of the backup file to be downloaded can be obtained through the DescribeDBBackups interface.
        """
        return pulumi.get(self, "backup_name")

    @backup_name.setter
    def backup_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "backup_name", value)

    @property
    @pulumi.getter(name="backupSets")
    def backup_sets(self) -> Optional[pulumi.Input[Sequence[pulumi.Input['InstanceBackupDownloadTaskBackupSetArgs']]]]:
        """
        Specifies the node names of replica sets to download or a list of shard names for sharded clusters.For example, the
        replica set cmgo-p8vnipr5, example (fixed value): BackupSets.0=cmgo-p8vnipr5_0, the full amount of data can be
        downloaded.For example, the sharded cluster cmgo-p8vnipr5, for example:
        BackupSets.0=cmgo-p8vnipr5_0&amp;amp;BackupSets.1=cmgo-p8vnipr5_1, that is, to download the data of shard 0 and 1. If
        the sharded cluster needs to be downloaded in full, please pass in the example. Full slice name.
        """
        return pulumi.get(self, "backup_sets")

    @backup_sets.setter
    def backup_sets(self, value: Optional[pulumi.Input[Sequence[pulumi.Input['InstanceBackupDownloadTaskBackupSetArgs']]]]):
        pulumi.set(self, "backup_sets", value)

    @property
    @pulumi.getter(name="instanceId")
    def instance_id(self) -> Optional[pulumi.Input[str]]:
        """
        Instance ID, the format is: cmgo-9d0p6umb.Same as the instance ID displayed in the cloud database console page.
        """
        return pulumi.get(self, "instance_id")

    @instance_id.setter
    def instance_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "instance_id", value)


class InstanceBackupDownloadTask(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 backup_name: Optional[pulumi.Input[str]] = None,
                 backup_sets: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['InstanceBackupDownloadTaskBackupSetArgs']]]]] = None,
                 instance_id: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Create a InstanceBackupDownloadTask resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] backup_name: The name of the backup file to be downloaded can be obtained through the DescribeDBBackups interface.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['InstanceBackupDownloadTaskBackupSetArgs']]]] backup_sets: Specifies the node names of replica sets to download or a list of shard names for sharded clusters.For example, the
               replica set cmgo-p8vnipr5, example (fixed value): BackupSets.0=cmgo-p8vnipr5_0, the full amount of data can be
               downloaded.For example, the sharded cluster cmgo-p8vnipr5, for example:
               BackupSets.0=cmgo-p8vnipr5_0&amp;amp;BackupSets.1=cmgo-p8vnipr5_1, that is, to download the data of shard 0 and 1. If
               the sharded cluster needs to be downloaded in full, please pass in the example. Full slice name.
        :param pulumi.Input[str] instance_id: Instance ID, the format is: cmgo-9d0p6umb.Same as the instance ID displayed in the cloud database console page.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: InstanceBackupDownloadTaskArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a InstanceBackupDownloadTask resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param InstanceBackupDownloadTaskArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(InstanceBackupDownloadTaskArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 backup_name: Optional[pulumi.Input[str]] = None,
                 backup_sets: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['InstanceBackupDownloadTaskBackupSetArgs']]]]] = None,
                 instance_id: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = InstanceBackupDownloadTaskArgs.__new__(InstanceBackupDownloadTaskArgs)

            if backup_name is None and not opts.urn:
                raise TypeError("Missing required property 'backup_name'")
            __props__.__dict__["backup_name"] = backup_name
            if backup_sets is None and not opts.urn:
                raise TypeError("Missing required property 'backup_sets'")
            __props__.__dict__["backup_sets"] = backup_sets
            if instance_id is None and not opts.urn:
                raise TypeError("Missing required property 'instance_id'")
            __props__.__dict__["instance_id"] = instance_id
        super(InstanceBackupDownloadTask, __self__).__init__(
            'tencentcloud:Mongodb/instanceBackupDownloadTask:InstanceBackupDownloadTask',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            backup_name: Optional[pulumi.Input[str]] = None,
            backup_sets: Optional[pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['InstanceBackupDownloadTaskBackupSetArgs']]]]] = None,
            instance_id: Optional[pulumi.Input[str]] = None) -> 'InstanceBackupDownloadTask':
        """
        Get an existing InstanceBackupDownloadTask resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] backup_name: The name of the backup file to be downloaded can be obtained through the DescribeDBBackups interface.
        :param pulumi.Input[Sequence[pulumi.Input[pulumi.InputType['InstanceBackupDownloadTaskBackupSetArgs']]]] backup_sets: Specifies the node names of replica sets to download or a list of shard names for sharded clusters.For example, the
               replica set cmgo-p8vnipr5, example (fixed value): BackupSets.0=cmgo-p8vnipr5_0, the full amount of data can be
               downloaded.For example, the sharded cluster cmgo-p8vnipr5, for example:
               BackupSets.0=cmgo-p8vnipr5_0&amp;amp;BackupSets.1=cmgo-p8vnipr5_1, that is, to download the data of shard 0 and 1. If
               the sharded cluster needs to be downloaded in full, please pass in the example. Full slice name.
        :param pulumi.Input[str] instance_id: Instance ID, the format is: cmgo-9d0p6umb.Same as the instance ID displayed in the cloud database console page.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _InstanceBackupDownloadTaskState.__new__(_InstanceBackupDownloadTaskState)

        __props__.__dict__["backup_name"] = backup_name
        __props__.__dict__["backup_sets"] = backup_sets
        __props__.__dict__["instance_id"] = instance_id
        return InstanceBackupDownloadTask(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="backupName")
    def backup_name(self) -> pulumi.Output[str]:
        """
        The name of the backup file to be downloaded can be obtained through the DescribeDBBackups interface.
        """
        return pulumi.get(self, "backup_name")

    @property
    @pulumi.getter(name="backupSets")
    def backup_sets(self) -> pulumi.Output[Sequence['outputs.InstanceBackupDownloadTaskBackupSet']]:
        """
        Specifies the node names of replica sets to download or a list of shard names for sharded clusters.For example, the
        replica set cmgo-p8vnipr5, example (fixed value): BackupSets.0=cmgo-p8vnipr5_0, the full amount of data can be
        downloaded.For example, the sharded cluster cmgo-p8vnipr5, for example:
        BackupSets.0=cmgo-p8vnipr5_0&amp;amp;BackupSets.1=cmgo-p8vnipr5_1, that is, to download the data of shard 0 and 1. If
        the sharded cluster needs to be downloaded in full, please pass in the example. Full slice name.
        """
        return pulumi.get(self, "backup_sets")

    @property
    @pulumi.getter(name="instanceId")
    def instance_id(self) -> pulumi.Output[str]:
        """
        Instance ID, the format is: cmgo-9d0p6umb.Same as the instance ID displayed in the cloud database console page.
        """
        return pulumi.get(self, "instance_id")
