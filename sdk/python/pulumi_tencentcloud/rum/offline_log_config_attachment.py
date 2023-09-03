# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = ['OfflineLogConfigAttachmentArgs', 'OfflineLogConfigAttachment']

@pulumi.input_type
class OfflineLogConfigAttachmentArgs:
    def __init__(__self__, *,
                 project_key: pulumi.Input[str],
                 unique_id: pulumi.Input[str]):
        """
        The set of arguments for constructing a OfflineLogConfigAttachment resource.
        :param pulumi.Input[str] project_key: Unique project key for reporting.
        :param pulumi.Input[str] unique_id: Unique identifier of the user to be listened on(aid or uin).
        """
        pulumi.set(__self__, "project_key", project_key)
        pulumi.set(__self__, "unique_id", unique_id)

    @property
    @pulumi.getter(name="projectKey")
    def project_key(self) -> pulumi.Input[str]:
        """
        Unique project key for reporting.
        """
        return pulumi.get(self, "project_key")

    @project_key.setter
    def project_key(self, value: pulumi.Input[str]):
        pulumi.set(self, "project_key", value)

    @property
    @pulumi.getter(name="uniqueId")
    def unique_id(self) -> pulumi.Input[str]:
        """
        Unique identifier of the user to be listened on(aid or uin).
        """
        return pulumi.get(self, "unique_id")

    @unique_id.setter
    def unique_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "unique_id", value)


@pulumi.input_type
class _OfflineLogConfigAttachmentState:
    def __init__(__self__, *,
                 msg: Optional[pulumi.Input[str]] = None,
                 project_key: Optional[pulumi.Input[str]] = None,
                 unique_id: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering OfflineLogConfigAttachment resources.
        :param pulumi.Input[str] msg: Interface call information.
        :param pulumi.Input[str] project_key: Unique project key for reporting.
        :param pulumi.Input[str] unique_id: Unique identifier of the user to be listened on(aid or uin).
        """
        if msg is not None:
            pulumi.set(__self__, "msg", msg)
        if project_key is not None:
            pulumi.set(__self__, "project_key", project_key)
        if unique_id is not None:
            pulumi.set(__self__, "unique_id", unique_id)

    @property
    @pulumi.getter
    def msg(self) -> Optional[pulumi.Input[str]]:
        """
        Interface call information.
        """
        return pulumi.get(self, "msg")

    @msg.setter
    def msg(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "msg", value)

    @property
    @pulumi.getter(name="projectKey")
    def project_key(self) -> Optional[pulumi.Input[str]]:
        """
        Unique project key for reporting.
        """
        return pulumi.get(self, "project_key")

    @project_key.setter
    def project_key(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "project_key", value)

    @property
    @pulumi.getter(name="uniqueId")
    def unique_id(self) -> Optional[pulumi.Input[str]]:
        """
        Unique identifier of the user to be listened on(aid or uin).
        """
        return pulumi.get(self, "unique_id")

    @unique_id.setter
    def unique_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "unique_id", value)


class OfflineLogConfigAttachment(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 project_key: Optional[pulumi.Input[str]] = None,
                 unique_id: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Create a OfflineLogConfigAttachment resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] project_key: Unique project key for reporting.
        :param pulumi.Input[str] unique_id: Unique identifier of the user to be listened on(aid or uin).
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: OfflineLogConfigAttachmentArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a OfflineLogConfigAttachment resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param OfflineLogConfigAttachmentArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(OfflineLogConfigAttachmentArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 project_key: Optional[pulumi.Input[str]] = None,
                 unique_id: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = OfflineLogConfigAttachmentArgs.__new__(OfflineLogConfigAttachmentArgs)

            if project_key is None and not opts.urn:
                raise TypeError("Missing required property 'project_key'")
            __props__.__dict__["project_key"] = project_key
            if unique_id is None and not opts.urn:
                raise TypeError("Missing required property 'unique_id'")
            __props__.__dict__["unique_id"] = unique_id
            __props__.__dict__["msg"] = None
        super(OfflineLogConfigAttachment, __self__).__init__(
            'tencentcloud:Rum/offlineLogConfigAttachment:OfflineLogConfigAttachment',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            msg: Optional[pulumi.Input[str]] = None,
            project_key: Optional[pulumi.Input[str]] = None,
            unique_id: Optional[pulumi.Input[str]] = None) -> 'OfflineLogConfigAttachment':
        """
        Get an existing OfflineLogConfigAttachment resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] msg: Interface call information.
        :param pulumi.Input[str] project_key: Unique project key for reporting.
        :param pulumi.Input[str] unique_id: Unique identifier of the user to be listened on(aid or uin).
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _OfflineLogConfigAttachmentState.__new__(_OfflineLogConfigAttachmentState)

        __props__.__dict__["msg"] = msg
        __props__.__dict__["project_key"] = project_key
        __props__.__dict__["unique_id"] = unique_id
        return OfflineLogConfigAttachment(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter
    def msg(self) -> pulumi.Output[str]:
        """
        Interface call information.
        """
        return pulumi.get(self, "msg")

    @property
    @pulumi.getter(name="projectKey")
    def project_key(self) -> pulumi.Output[str]:
        """
        Unique project key for reporting.
        """
        return pulumi.get(self, "project_key")

    @property
    @pulumi.getter(name="uniqueId")
    def unique_id(self) -> pulumi.Output[str]:
        """
        Unique identifier of the user to be listened on(aid or uin).
        """
        return pulumi.get(self, "unique_id")
