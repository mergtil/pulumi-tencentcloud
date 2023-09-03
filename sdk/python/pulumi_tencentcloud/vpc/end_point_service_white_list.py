# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = ['EndPointServiceWhiteListArgs', 'EndPointServiceWhiteList']

@pulumi.input_type
class EndPointServiceWhiteListArgs:
    def __init__(__self__, *,
                 end_point_service_id: pulumi.Input[str],
                 user_uin: pulumi.Input[str],
                 description: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a EndPointServiceWhiteList resource.
        :param pulumi.Input[str] end_point_service_id: ID of endpoint service.
        :param pulumi.Input[str] user_uin: UIN.
        :param pulumi.Input[str] description: Description of white list.
        """
        pulumi.set(__self__, "end_point_service_id", end_point_service_id)
        pulumi.set(__self__, "user_uin", user_uin)
        if description is not None:
            pulumi.set(__self__, "description", description)

    @property
    @pulumi.getter(name="endPointServiceId")
    def end_point_service_id(self) -> pulumi.Input[str]:
        """
        ID of endpoint service.
        """
        return pulumi.get(self, "end_point_service_id")

    @end_point_service_id.setter
    def end_point_service_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "end_point_service_id", value)

    @property
    @pulumi.getter(name="userUin")
    def user_uin(self) -> pulumi.Input[str]:
        """
        UIN.
        """
        return pulumi.get(self, "user_uin")

    @user_uin.setter
    def user_uin(self, value: pulumi.Input[str]):
        pulumi.set(self, "user_uin", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        Description of white list.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)


@pulumi.input_type
class _EndPointServiceWhiteListState:
    def __init__(__self__, *,
                 create_time: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 end_point_service_id: Optional[pulumi.Input[str]] = None,
                 owner: Optional[pulumi.Input[str]] = None,
                 user_uin: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering EndPointServiceWhiteList resources.
        :param pulumi.Input[str] create_time: Create Time.
        :param pulumi.Input[str] description: Description of white list.
        :param pulumi.Input[str] end_point_service_id: ID of endpoint service.
        :param pulumi.Input[str] owner: APPID.
        :param pulumi.Input[str] user_uin: UIN.
        """
        if create_time is not None:
            pulumi.set(__self__, "create_time", create_time)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if end_point_service_id is not None:
            pulumi.set(__self__, "end_point_service_id", end_point_service_id)
        if owner is not None:
            pulumi.set(__self__, "owner", owner)
        if user_uin is not None:
            pulumi.set(__self__, "user_uin", user_uin)

    @property
    @pulumi.getter(name="createTime")
    def create_time(self) -> Optional[pulumi.Input[str]]:
        """
        Create Time.
        """
        return pulumi.get(self, "create_time")

    @create_time.setter
    def create_time(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "create_time", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        Description of white list.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter(name="endPointServiceId")
    def end_point_service_id(self) -> Optional[pulumi.Input[str]]:
        """
        ID of endpoint service.
        """
        return pulumi.get(self, "end_point_service_id")

    @end_point_service_id.setter
    def end_point_service_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "end_point_service_id", value)

    @property
    @pulumi.getter
    def owner(self) -> Optional[pulumi.Input[str]]:
        """
        APPID.
        """
        return pulumi.get(self, "owner")

    @owner.setter
    def owner(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "owner", value)

    @property
    @pulumi.getter(name="userUin")
    def user_uin(self) -> Optional[pulumi.Input[str]]:
        """
        UIN.
        """
        return pulumi.get(self, "user_uin")

    @user_uin.setter
    def user_uin(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "user_uin", value)


class EndPointServiceWhiteList(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 end_point_service_id: Optional[pulumi.Input[str]] = None,
                 user_uin: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Create a EndPointServiceWhiteList resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] description: Description of white list.
        :param pulumi.Input[str] end_point_service_id: ID of endpoint service.
        :param pulumi.Input[str] user_uin: UIN.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: EndPointServiceWhiteListArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a EndPointServiceWhiteList resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param EndPointServiceWhiteListArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(EndPointServiceWhiteListArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 end_point_service_id: Optional[pulumi.Input[str]] = None,
                 user_uin: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = EndPointServiceWhiteListArgs.__new__(EndPointServiceWhiteListArgs)

            __props__.__dict__["description"] = description
            if end_point_service_id is None and not opts.urn:
                raise TypeError("Missing required property 'end_point_service_id'")
            __props__.__dict__["end_point_service_id"] = end_point_service_id
            if user_uin is None and not opts.urn:
                raise TypeError("Missing required property 'user_uin'")
            __props__.__dict__["user_uin"] = user_uin
            __props__.__dict__["create_time"] = None
            __props__.__dict__["owner"] = None
        super(EndPointServiceWhiteList, __self__).__init__(
            'tencentcloud:Vpc/endPointServiceWhiteList:EndPointServiceWhiteList',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            create_time: Optional[pulumi.Input[str]] = None,
            description: Optional[pulumi.Input[str]] = None,
            end_point_service_id: Optional[pulumi.Input[str]] = None,
            owner: Optional[pulumi.Input[str]] = None,
            user_uin: Optional[pulumi.Input[str]] = None) -> 'EndPointServiceWhiteList':
        """
        Get an existing EndPointServiceWhiteList resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] create_time: Create Time.
        :param pulumi.Input[str] description: Description of white list.
        :param pulumi.Input[str] end_point_service_id: ID of endpoint service.
        :param pulumi.Input[str] owner: APPID.
        :param pulumi.Input[str] user_uin: UIN.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _EndPointServiceWhiteListState.__new__(_EndPointServiceWhiteListState)

        __props__.__dict__["create_time"] = create_time
        __props__.__dict__["description"] = description
        __props__.__dict__["end_point_service_id"] = end_point_service_id
        __props__.__dict__["owner"] = owner
        __props__.__dict__["user_uin"] = user_uin
        return EndPointServiceWhiteList(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="createTime")
    def create_time(self) -> pulumi.Output[str]:
        """
        Create Time.
        """
        return pulumi.get(self, "create_time")

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        """
        Description of white list.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter(name="endPointServiceId")
    def end_point_service_id(self) -> pulumi.Output[str]:
        """
        ID of endpoint service.
        """
        return pulumi.get(self, "end_point_service_id")

    @property
    @pulumi.getter
    def owner(self) -> pulumi.Output[str]:
        """
        APPID.
        """
        return pulumi.get(self, "owner")

    @property
    @pulumi.getter(name="userUin")
    def user_uin(self) -> pulumi.Output[str]:
        """
        UIN.
        """
        return pulumi.get(self, "user_uin")
