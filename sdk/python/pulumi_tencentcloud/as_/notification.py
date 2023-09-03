# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = ['NotificationArgs', 'Notification']

@pulumi.input_type
class NotificationArgs:
    def __init__(__self__, *,
                 notification_types: pulumi.Input[Sequence[pulumi.Input[str]]],
                 notification_user_group_ids: pulumi.Input[Sequence[pulumi.Input[str]]],
                 scaling_group_id: pulumi.Input[str]):
        """
        The set of arguments for constructing a Notification resource.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] notification_types: A list of Notification Types that trigger notifications. Acceptable values are `SCALE_OUT_FAILED`,
               `SCALE_IN_SUCCESSFUL`, `SCALE_IN_FAILED`, `REPLACE_UNHEALTHY_INSTANCE_SUCCESSFUL` and
               `REPLACE_UNHEALTHY_INSTANCE_FAILED`.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] notification_user_group_ids: A group of user IDs to be notified.
        :param pulumi.Input[str] scaling_group_id: ID of a scaling group.
        """
        pulumi.set(__self__, "notification_types", notification_types)
        pulumi.set(__self__, "notification_user_group_ids", notification_user_group_ids)
        pulumi.set(__self__, "scaling_group_id", scaling_group_id)

    @property
    @pulumi.getter(name="notificationTypes")
    def notification_types(self) -> pulumi.Input[Sequence[pulumi.Input[str]]]:
        """
        A list of Notification Types that trigger notifications. Acceptable values are `SCALE_OUT_FAILED`,
        `SCALE_IN_SUCCESSFUL`, `SCALE_IN_FAILED`, `REPLACE_UNHEALTHY_INSTANCE_SUCCESSFUL` and
        `REPLACE_UNHEALTHY_INSTANCE_FAILED`.
        """
        return pulumi.get(self, "notification_types")

    @notification_types.setter
    def notification_types(self, value: pulumi.Input[Sequence[pulumi.Input[str]]]):
        pulumi.set(self, "notification_types", value)

    @property
    @pulumi.getter(name="notificationUserGroupIds")
    def notification_user_group_ids(self) -> pulumi.Input[Sequence[pulumi.Input[str]]]:
        """
        A group of user IDs to be notified.
        """
        return pulumi.get(self, "notification_user_group_ids")

    @notification_user_group_ids.setter
    def notification_user_group_ids(self, value: pulumi.Input[Sequence[pulumi.Input[str]]]):
        pulumi.set(self, "notification_user_group_ids", value)

    @property
    @pulumi.getter(name="scalingGroupId")
    def scaling_group_id(self) -> pulumi.Input[str]:
        """
        ID of a scaling group.
        """
        return pulumi.get(self, "scaling_group_id")

    @scaling_group_id.setter
    def scaling_group_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "scaling_group_id", value)


@pulumi.input_type
class _NotificationState:
    def __init__(__self__, *,
                 notification_types: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 notification_user_group_ids: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 scaling_group_id: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering Notification resources.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] notification_types: A list of Notification Types that trigger notifications. Acceptable values are `SCALE_OUT_FAILED`,
               `SCALE_IN_SUCCESSFUL`, `SCALE_IN_FAILED`, `REPLACE_UNHEALTHY_INSTANCE_SUCCESSFUL` and
               `REPLACE_UNHEALTHY_INSTANCE_FAILED`.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] notification_user_group_ids: A group of user IDs to be notified.
        :param pulumi.Input[str] scaling_group_id: ID of a scaling group.
        """
        if notification_types is not None:
            pulumi.set(__self__, "notification_types", notification_types)
        if notification_user_group_ids is not None:
            pulumi.set(__self__, "notification_user_group_ids", notification_user_group_ids)
        if scaling_group_id is not None:
            pulumi.set(__self__, "scaling_group_id", scaling_group_id)

    @property
    @pulumi.getter(name="notificationTypes")
    def notification_types(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        A list of Notification Types that trigger notifications. Acceptable values are `SCALE_OUT_FAILED`,
        `SCALE_IN_SUCCESSFUL`, `SCALE_IN_FAILED`, `REPLACE_UNHEALTHY_INSTANCE_SUCCESSFUL` and
        `REPLACE_UNHEALTHY_INSTANCE_FAILED`.
        """
        return pulumi.get(self, "notification_types")

    @notification_types.setter
    def notification_types(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "notification_types", value)

    @property
    @pulumi.getter(name="notificationUserGroupIds")
    def notification_user_group_ids(self) -> Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]:
        """
        A group of user IDs to be notified.
        """
        return pulumi.get(self, "notification_user_group_ids")

    @notification_user_group_ids.setter
    def notification_user_group_ids(self, value: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]]):
        pulumi.set(self, "notification_user_group_ids", value)

    @property
    @pulumi.getter(name="scalingGroupId")
    def scaling_group_id(self) -> Optional[pulumi.Input[str]]:
        """
        ID of a scaling group.
        """
        return pulumi.get(self, "scaling_group_id")

    @scaling_group_id.setter
    def scaling_group_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "scaling_group_id", value)


class Notification(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 notification_types: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 notification_user_group_ids: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 scaling_group_id: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Create a Notification resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] notification_types: A list of Notification Types that trigger notifications. Acceptable values are `SCALE_OUT_FAILED`,
               `SCALE_IN_SUCCESSFUL`, `SCALE_IN_FAILED`, `REPLACE_UNHEALTHY_INSTANCE_SUCCESSFUL` and
               `REPLACE_UNHEALTHY_INSTANCE_FAILED`.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] notification_user_group_ids: A group of user IDs to be notified.
        :param pulumi.Input[str] scaling_group_id: ID of a scaling group.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: NotificationArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a Notification resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param NotificationArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(NotificationArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 notification_types: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 notification_user_group_ids: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
                 scaling_group_id: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = NotificationArgs.__new__(NotificationArgs)

            if notification_types is None and not opts.urn:
                raise TypeError("Missing required property 'notification_types'")
            __props__.__dict__["notification_types"] = notification_types
            if notification_user_group_ids is None and not opts.urn:
                raise TypeError("Missing required property 'notification_user_group_ids'")
            __props__.__dict__["notification_user_group_ids"] = notification_user_group_ids
            if scaling_group_id is None and not opts.urn:
                raise TypeError("Missing required property 'scaling_group_id'")
            __props__.__dict__["scaling_group_id"] = scaling_group_id
        super(Notification, __self__).__init__(
            'tencentcloud:As/notification:Notification',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            notification_types: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
            notification_user_group_ids: Optional[pulumi.Input[Sequence[pulumi.Input[str]]]] = None,
            scaling_group_id: Optional[pulumi.Input[str]] = None) -> 'Notification':
        """
        Get an existing Notification resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] notification_types: A list of Notification Types that trigger notifications. Acceptable values are `SCALE_OUT_FAILED`,
               `SCALE_IN_SUCCESSFUL`, `SCALE_IN_FAILED`, `REPLACE_UNHEALTHY_INSTANCE_SUCCESSFUL` and
               `REPLACE_UNHEALTHY_INSTANCE_FAILED`.
        :param pulumi.Input[Sequence[pulumi.Input[str]]] notification_user_group_ids: A group of user IDs to be notified.
        :param pulumi.Input[str] scaling_group_id: ID of a scaling group.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _NotificationState.__new__(_NotificationState)

        __props__.__dict__["notification_types"] = notification_types
        __props__.__dict__["notification_user_group_ids"] = notification_user_group_ids
        __props__.__dict__["scaling_group_id"] = scaling_group_id
        return Notification(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="notificationTypes")
    def notification_types(self) -> pulumi.Output[Sequence[str]]:
        """
        A list of Notification Types that trigger notifications. Acceptable values are `SCALE_OUT_FAILED`,
        `SCALE_IN_SUCCESSFUL`, `SCALE_IN_FAILED`, `REPLACE_UNHEALTHY_INSTANCE_SUCCESSFUL` and
        `REPLACE_UNHEALTHY_INSTANCE_FAILED`.
        """
        return pulumi.get(self, "notification_types")

    @property
    @pulumi.getter(name="notificationUserGroupIds")
    def notification_user_group_ids(self) -> pulumi.Output[Sequence[str]]:
        """
        A group of user IDs to be notified.
        """
        return pulumi.get(self, "notification_user_group_ids")

    @property
    @pulumi.getter(name="scalingGroupId")
    def scaling_group_id(self) -> pulumi.Output[str]:
        """
        ID of a scaling group.
        """
        return pulumi.get(self, "scaling_group_id")
