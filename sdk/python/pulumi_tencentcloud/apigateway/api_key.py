# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = ['ApiKeyArgs', 'ApiKey']

@pulumi.input_type
class ApiKeyArgs:
    def __init__(__self__, *,
                 secret_name: pulumi.Input[str],
                 access_key_id: Optional[pulumi.Input[str]] = None,
                 access_key_secret: Optional[pulumi.Input[str]] = None,
                 access_key_type: Optional[pulumi.Input[str]] = None,
                 status: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a ApiKey resource.
        :param pulumi.Input[str] secret_name: Custom key name.
        :param pulumi.Input[str] access_key_id: User defined key ID, required when access_key_type is manual. The length is 5-50 characters, consisting of letters,
               numbers, and English underscores.
        :param pulumi.Input[str] access_key_secret: The user-defined key must be passed when the access_key_type is manual. The length is 10-50 characters, consisting of
               letters, numbers, and English underscores.
        :param pulumi.Input[str] access_key_type: Key type, supports both auto and manual (custom keys), defaults to auto.
        :param pulumi.Input[str] status: Key status. Valid values: `on`, `off`.
        """
        pulumi.set(__self__, "secret_name", secret_name)
        if access_key_id is not None:
            pulumi.set(__self__, "access_key_id", access_key_id)
        if access_key_secret is not None:
            pulumi.set(__self__, "access_key_secret", access_key_secret)
        if access_key_type is not None:
            pulumi.set(__self__, "access_key_type", access_key_type)
        if status is not None:
            pulumi.set(__self__, "status", status)

    @property
    @pulumi.getter(name="secretName")
    def secret_name(self) -> pulumi.Input[str]:
        """
        Custom key name.
        """
        return pulumi.get(self, "secret_name")

    @secret_name.setter
    def secret_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "secret_name", value)

    @property
    @pulumi.getter(name="accessKeyId")
    def access_key_id(self) -> Optional[pulumi.Input[str]]:
        """
        User defined key ID, required when access_key_type is manual. The length is 5-50 characters, consisting of letters,
        numbers, and English underscores.
        """
        return pulumi.get(self, "access_key_id")

    @access_key_id.setter
    def access_key_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "access_key_id", value)

    @property
    @pulumi.getter(name="accessKeySecret")
    def access_key_secret(self) -> Optional[pulumi.Input[str]]:
        """
        The user-defined key must be passed when the access_key_type is manual. The length is 10-50 characters, consisting of
        letters, numbers, and English underscores.
        """
        return pulumi.get(self, "access_key_secret")

    @access_key_secret.setter
    def access_key_secret(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "access_key_secret", value)

    @property
    @pulumi.getter(name="accessKeyType")
    def access_key_type(self) -> Optional[pulumi.Input[str]]:
        """
        Key type, supports both auto and manual (custom keys), defaults to auto.
        """
        return pulumi.get(self, "access_key_type")

    @access_key_type.setter
    def access_key_type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "access_key_type", value)

    @property
    @pulumi.getter
    def status(self) -> Optional[pulumi.Input[str]]:
        """
        Key status. Valid values: `on`, `off`.
        """
        return pulumi.get(self, "status")

    @status.setter
    def status(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "status", value)


@pulumi.input_type
class _ApiKeyState:
    def __init__(__self__, *,
                 access_key_id: Optional[pulumi.Input[str]] = None,
                 access_key_secret: Optional[pulumi.Input[str]] = None,
                 access_key_type: Optional[pulumi.Input[str]] = None,
                 create_time: Optional[pulumi.Input[str]] = None,
                 modify_time: Optional[pulumi.Input[str]] = None,
                 secret_name: Optional[pulumi.Input[str]] = None,
                 status: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering ApiKey resources.
        :param pulumi.Input[str] access_key_id: User defined key ID, required when access_key_type is manual. The length is 5-50 characters, consisting of letters,
               numbers, and English underscores.
        :param pulumi.Input[str] access_key_secret: The user-defined key must be passed when the access_key_type is manual. The length is 10-50 characters, consisting of
               letters, numbers, and English underscores.
        :param pulumi.Input[str] access_key_type: Key type, supports both auto and manual (custom keys), defaults to auto.
        :param pulumi.Input[str] create_time: Creation time in the format of YYYY-MM-DDThh:mm:ssZ according to ISO 8601 standard. UTC time is used.
        :param pulumi.Input[str] modify_time: Last modified time in the format of YYYY-MM-DDThh:mm:ssZ according to ISO 8601 standard. UTC time is used.
        :param pulumi.Input[str] secret_name: Custom key name.
        :param pulumi.Input[str] status: Key status. Valid values: `on`, `off`.
        """
        if access_key_id is not None:
            pulumi.set(__self__, "access_key_id", access_key_id)
        if access_key_secret is not None:
            pulumi.set(__self__, "access_key_secret", access_key_secret)
        if access_key_type is not None:
            pulumi.set(__self__, "access_key_type", access_key_type)
        if create_time is not None:
            pulumi.set(__self__, "create_time", create_time)
        if modify_time is not None:
            pulumi.set(__self__, "modify_time", modify_time)
        if secret_name is not None:
            pulumi.set(__self__, "secret_name", secret_name)
        if status is not None:
            pulumi.set(__self__, "status", status)

    @property
    @pulumi.getter(name="accessKeyId")
    def access_key_id(self) -> Optional[pulumi.Input[str]]:
        """
        User defined key ID, required when access_key_type is manual. The length is 5-50 characters, consisting of letters,
        numbers, and English underscores.
        """
        return pulumi.get(self, "access_key_id")

    @access_key_id.setter
    def access_key_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "access_key_id", value)

    @property
    @pulumi.getter(name="accessKeySecret")
    def access_key_secret(self) -> Optional[pulumi.Input[str]]:
        """
        The user-defined key must be passed when the access_key_type is manual. The length is 10-50 characters, consisting of
        letters, numbers, and English underscores.
        """
        return pulumi.get(self, "access_key_secret")

    @access_key_secret.setter
    def access_key_secret(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "access_key_secret", value)

    @property
    @pulumi.getter(name="accessKeyType")
    def access_key_type(self) -> Optional[pulumi.Input[str]]:
        """
        Key type, supports both auto and manual (custom keys), defaults to auto.
        """
        return pulumi.get(self, "access_key_type")

    @access_key_type.setter
    def access_key_type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "access_key_type", value)

    @property
    @pulumi.getter(name="createTime")
    def create_time(self) -> Optional[pulumi.Input[str]]:
        """
        Creation time in the format of YYYY-MM-DDThh:mm:ssZ according to ISO 8601 standard. UTC time is used.
        """
        return pulumi.get(self, "create_time")

    @create_time.setter
    def create_time(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "create_time", value)

    @property
    @pulumi.getter(name="modifyTime")
    def modify_time(self) -> Optional[pulumi.Input[str]]:
        """
        Last modified time in the format of YYYY-MM-DDThh:mm:ssZ according to ISO 8601 standard. UTC time is used.
        """
        return pulumi.get(self, "modify_time")

    @modify_time.setter
    def modify_time(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "modify_time", value)

    @property
    @pulumi.getter(name="secretName")
    def secret_name(self) -> Optional[pulumi.Input[str]]:
        """
        Custom key name.
        """
        return pulumi.get(self, "secret_name")

    @secret_name.setter
    def secret_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "secret_name", value)

    @property
    @pulumi.getter
    def status(self) -> Optional[pulumi.Input[str]]:
        """
        Key status. Valid values: `on`, `off`.
        """
        return pulumi.get(self, "status")

    @status.setter
    def status(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "status", value)


class ApiKey(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 access_key_id: Optional[pulumi.Input[str]] = None,
                 access_key_secret: Optional[pulumi.Input[str]] = None,
                 access_key_type: Optional[pulumi.Input[str]] = None,
                 secret_name: Optional[pulumi.Input[str]] = None,
                 status: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Create a ApiKey resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] access_key_id: User defined key ID, required when access_key_type is manual. The length is 5-50 characters, consisting of letters,
               numbers, and English underscores.
        :param pulumi.Input[str] access_key_secret: The user-defined key must be passed when the access_key_type is manual. The length is 10-50 characters, consisting of
               letters, numbers, and English underscores.
        :param pulumi.Input[str] access_key_type: Key type, supports both auto and manual (custom keys), defaults to auto.
        :param pulumi.Input[str] secret_name: Custom key name.
        :param pulumi.Input[str] status: Key status. Valid values: `on`, `off`.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: ApiKeyArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a ApiKey resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param ApiKeyArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(ApiKeyArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 access_key_id: Optional[pulumi.Input[str]] = None,
                 access_key_secret: Optional[pulumi.Input[str]] = None,
                 access_key_type: Optional[pulumi.Input[str]] = None,
                 secret_name: Optional[pulumi.Input[str]] = None,
                 status: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = ApiKeyArgs.__new__(ApiKeyArgs)

            __props__.__dict__["access_key_id"] = access_key_id
            __props__.__dict__["access_key_secret"] = access_key_secret
            __props__.__dict__["access_key_type"] = access_key_type
            if secret_name is None and not opts.urn:
                raise TypeError("Missing required property 'secret_name'")
            __props__.__dict__["secret_name"] = secret_name
            __props__.__dict__["status"] = status
            __props__.__dict__["create_time"] = None
            __props__.__dict__["modify_time"] = None
        super(ApiKey, __self__).__init__(
            'tencentcloud:ApiGateway/apiKey:ApiKey',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            access_key_id: Optional[pulumi.Input[str]] = None,
            access_key_secret: Optional[pulumi.Input[str]] = None,
            access_key_type: Optional[pulumi.Input[str]] = None,
            create_time: Optional[pulumi.Input[str]] = None,
            modify_time: Optional[pulumi.Input[str]] = None,
            secret_name: Optional[pulumi.Input[str]] = None,
            status: Optional[pulumi.Input[str]] = None) -> 'ApiKey':
        """
        Get an existing ApiKey resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] access_key_id: User defined key ID, required when access_key_type is manual. The length is 5-50 characters, consisting of letters,
               numbers, and English underscores.
        :param pulumi.Input[str] access_key_secret: The user-defined key must be passed when the access_key_type is manual. The length is 10-50 characters, consisting of
               letters, numbers, and English underscores.
        :param pulumi.Input[str] access_key_type: Key type, supports both auto and manual (custom keys), defaults to auto.
        :param pulumi.Input[str] create_time: Creation time in the format of YYYY-MM-DDThh:mm:ssZ according to ISO 8601 standard. UTC time is used.
        :param pulumi.Input[str] modify_time: Last modified time in the format of YYYY-MM-DDThh:mm:ssZ according to ISO 8601 standard. UTC time is used.
        :param pulumi.Input[str] secret_name: Custom key name.
        :param pulumi.Input[str] status: Key status. Valid values: `on`, `off`.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _ApiKeyState.__new__(_ApiKeyState)

        __props__.__dict__["access_key_id"] = access_key_id
        __props__.__dict__["access_key_secret"] = access_key_secret
        __props__.__dict__["access_key_type"] = access_key_type
        __props__.__dict__["create_time"] = create_time
        __props__.__dict__["modify_time"] = modify_time
        __props__.__dict__["secret_name"] = secret_name
        __props__.__dict__["status"] = status
        return ApiKey(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="accessKeyId")
    def access_key_id(self) -> pulumi.Output[str]:
        """
        User defined key ID, required when access_key_type is manual. The length is 5-50 characters, consisting of letters,
        numbers, and English underscores.
        """
        return pulumi.get(self, "access_key_id")

    @property
    @pulumi.getter(name="accessKeySecret")
    def access_key_secret(self) -> pulumi.Output[str]:
        """
        The user-defined key must be passed when the access_key_type is manual. The length is 10-50 characters, consisting of
        letters, numbers, and English underscores.
        """
        return pulumi.get(self, "access_key_secret")

    @property
    @pulumi.getter(name="accessKeyType")
    def access_key_type(self) -> pulumi.Output[Optional[str]]:
        """
        Key type, supports both auto and manual (custom keys), defaults to auto.
        """
        return pulumi.get(self, "access_key_type")

    @property
    @pulumi.getter(name="createTime")
    def create_time(self) -> pulumi.Output[str]:
        """
        Creation time in the format of YYYY-MM-DDThh:mm:ssZ according to ISO 8601 standard. UTC time is used.
        """
        return pulumi.get(self, "create_time")

    @property
    @pulumi.getter(name="modifyTime")
    def modify_time(self) -> pulumi.Output[str]:
        """
        Last modified time in the format of YYYY-MM-DDThh:mm:ssZ according to ISO 8601 standard. UTC time is used.
        """
        return pulumi.get(self, "modify_time")

    @property
    @pulumi.getter(name="secretName")
    def secret_name(self) -> pulumi.Output[str]:
        """
        Custom key name.
        """
        return pulumi.get(self, "secret_name")

    @property
    @pulumi.getter
    def status(self) -> pulumi.Output[Optional[str]]:
        """
        Key status. Valid values: `on`, `off`.
        """
        return pulumi.get(self, "status")
