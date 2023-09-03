# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = ['SendRocketmqMessageArgs', 'SendRocketmqMessage']

@pulumi.input_type
class SendRocketmqMessageArgs:
    def __init__(__self__, *,
                 cluster_id: pulumi.Input[str],
                 msg_body: pulumi.Input[str],
                 namespace_id: pulumi.Input[str],
                 topic_name: pulumi.Input[str],
                 msg_key: Optional[pulumi.Input[str]] = None,
                 msg_tag: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a SendRocketmqMessage resource.
        :param pulumi.Input[str] cluster_id: Cluster id.
        :param pulumi.Input[str] msg_body: Information.
        :param pulumi.Input[str] namespace_id: Namespaces.
        :param pulumi.Input[str] topic_name: topic name.
        :param pulumi.Input[str] msg_key: Message key information.
        :param pulumi.Input[str] msg_tag: Message tag information.
        """
        pulumi.set(__self__, "cluster_id", cluster_id)
        pulumi.set(__self__, "msg_body", msg_body)
        pulumi.set(__self__, "namespace_id", namespace_id)
        pulumi.set(__self__, "topic_name", topic_name)
        if msg_key is not None:
            pulumi.set(__self__, "msg_key", msg_key)
        if msg_tag is not None:
            pulumi.set(__self__, "msg_tag", msg_tag)

    @property
    @pulumi.getter(name="clusterId")
    def cluster_id(self) -> pulumi.Input[str]:
        """
        Cluster id.
        """
        return pulumi.get(self, "cluster_id")

    @cluster_id.setter
    def cluster_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "cluster_id", value)

    @property
    @pulumi.getter(name="msgBody")
    def msg_body(self) -> pulumi.Input[str]:
        """
        Information.
        """
        return pulumi.get(self, "msg_body")

    @msg_body.setter
    def msg_body(self, value: pulumi.Input[str]):
        pulumi.set(self, "msg_body", value)

    @property
    @pulumi.getter(name="namespaceId")
    def namespace_id(self) -> pulumi.Input[str]:
        """
        Namespaces.
        """
        return pulumi.get(self, "namespace_id")

    @namespace_id.setter
    def namespace_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "namespace_id", value)

    @property
    @pulumi.getter(name="topicName")
    def topic_name(self) -> pulumi.Input[str]:
        """
        topic name.
        """
        return pulumi.get(self, "topic_name")

    @topic_name.setter
    def topic_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "topic_name", value)

    @property
    @pulumi.getter(name="msgKey")
    def msg_key(self) -> Optional[pulumi.Input[str]]:
        """
        Message key information.
        """
        return pulumi.get(self, "msg_key")

    @msg_key.setter
    def msg_key(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "msg_key", value)

    @property
    @pulumi.getter(name="msgTag")
    def msg_tag(self) -> Optional[pulumi.Input[str]]:
        """
        Message tag information.
        """
        return pulumi.get(self, "msg_tag")

    @msg_tag.setter
    def msg_tag(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "msg_tag", value)


@pulumi.input_type
class _SendRocketmqMessageState:
    def __init__(__self__, *,
                 cluster_id: Optional[pulumi.Input[str]] = None,
                 msg_body: Optional[pulumi.Input[str]] = None,
                 msg_key: Optional[pulumi.Input[str]] = None,
                 msg_tag: Optional[pulumi.Input[str]] = None,
                 namespace_id: Optional[pulumi.Input[str]] = None,
                 topic_name: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering SendRocketmqMessage resources.
        :param pulumi.Input[str] cluster_id: Cluster id.
        :param pulumi.Input[str] msg_body: Information.
        :param pulumi.Input[str] msg_key: Message key information.
        :param pulumi.Input[str] msg_tag: Message tag information.
        :param pulumi.Input[str] namespace_id: Namespaces.
        :param pulumi.Input[str] topic_name: topic name.
        """
        if cluster_id is not None:
            pulumi.set(__self__, "cluster_id", cluster_id)
        if msg_body is not None:
            pulumi.set(__self__, "msg_body", msg_body)
        if msg_key is not None:
            pulumi.set(__self__, "msg_key", msg_key)
        if msg_tag is not None:
            pulumi.set(__self__, "msg_tag", msg_tag)
        if namespace_id is not None:
            pulumi.set(__self__, "namespace_id", namespace_id)
        if topic_name is not None:
            pulumi.set(__self__, "topic_name", topic_name)

    @property
    @pulumi.getter(name="clusterId")
    def cluster_id(self) -> Optional[pulumi.Input[str]]:
        """
        Cluster id.
        """
        return pulumi.get(self, "cluster_id")

    @cluster_id.setter
    def cluster_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "cluster_id", value)

    @property
    @pulumi.getter(name="msgBody")
    def msg_body(self) -> Optional[pulumi.Input[str]]:
        """
        Information.
        """
        return pulumi.get(self, "msg_body")

    @msg_body.setter
    def msg_body(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "msg_body", value)

    @property
    @pulumi.getter(name="msgKey")
    def msg_key(self) -> Optional[pulumi.Input[str]]:
        """
        Message key information.
        """
        return pulumi.get(self, "msg_key")

    @msg_key.setter
    def msg_key(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "msg_key", value)

    @property
    @pulumi.getter(name="msgTag")
    def msg_tag(self) -> Optional[pulumi.Input[str]]:
        """
        Message tag information.
        """
        return pulumi.get(self, "msg_tag")

    @msg_tag.setter
    def msg_tag(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "msg_tag", value)

    @property
    @pulumi.getter(name="namespaceId")
    def namespace_id(self) -> Optional[pulumi.Input[str]]:
        """
        Namespaces.
        """
        return pulumi.get(self, "namespace_id")

    @namespace_id.setter
    def namespace_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "namespace_id", value)

    @property
    @pulumi.getter(name="topicName")
    def topic_name(self) -> Optional[pulumi.Input[str]]:
        """
        topic name.
        """
        return pulumi.get(self, "topic_name")

    @topic_name.setter
    def topic_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "topic_name", value)


class SendRocketmqMessage(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 cluster_id: Optional[pulumi.Input[str]] = None,
                 msg_body: Optional[pulumi.Input[str]] = None,
                 msg_key: Optional[pulumi.Input[str]] = None,
                 msg_tag: Optional[pulumi.Input[str]] = None,
                 namespace_id: Optional[pulumi.Input[str]] = None,
                 topic_name: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Create a SendRocketmqMessage resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] cluster_id: Cluster id.
        :param pulumi.Input[str] msg_body: Information.
        :param pulumi.Input[str] msg_key: Message key information.
        :param pulumi.Input[str] msg_tag: Message tag information.
        :param pulumi.Input[str] namespace_id: Namespaces.
        :param pulumi.Input[str] topic_name: topic name.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: SendRocketmqMessageArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a SendRocketmqMessage resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param SendRocketmqMessageArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(SendRocketmqMessageArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 cluster_id: Optional[pulumi.Input[str]] = None,
                 msg_body: Optional[pulumi.Input[str]] = None,
                 msg_key: Optional[pulumi.Input[str]] = None,
                 msg_tag: Optional[pulumi.Input[str]] = None,
                 namespace_id: Optional[pulumi.Input[str]] = None,
                 topic_name: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = SendRocketmqMessageArgs.__new__(SendRocketmqMessageArgs)

            if cluster_id is None and not opts.urn:
                raise TypeError("Missing required property 'cluster_id'")
            __props__.__dict__["cluster_id"] = cluster_id
            if msg_body is None and not opts.urn:
                raise TypeError("Missing required property 'msg_body'")
            __props__.__dict__["msg_body"] = msg_body
            __props__.__dict__["msg_key"] = msg_key
            __props__.__dict__["msg_tag"] = msg_tag
            if namespace_id is None and not opts.urn:
                raise TypeError("Missing required property 'namespace_id'")
            __props__.__dict__["namespace_id"] = namespace_id
            if topic_name is None and not opts.urn:
                raise TypeError("Missing required property 'topic_name'")
            __props__.__dict__["topic_name"] = topic_name
        super(SendRocketmqMessage, __self__).__init__(
            'tencentcloud:Tdmq/sendRocketmqMessage:SendRocketmqMessage',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            cluster_id: Optional[pulumi.Input[str]] = None,
            msg_body: Optional[pulumi.Input[str]] = None,
            msg_key: Optional[pulumi.Input[str]] = None,
            msg_tag: Optional[pulumi.Input[str]] = None,
            namespace_id: Optional[pulumi.Input[str]] = None,
            topic_name: Optional[pulumi.Input[str]] = None) -> 'SendRocketmqMessage':
        """
        Get an existing SendRocketmqMessage resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] cluster_id: Cluster id.
        :param pulumi.Input[str] msg_body: Information.
        :param pulumi.Input[str] msg_key: Message key information.
        :param pulumi.Input[str] msg_tag: Message tag information.
        :param pulumi.Input[str] namespace_id: Namespaces.
        :param pulumi.Input[str] topic_name: topic name.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _SendRocketmqMessageState.__new__(_SendRocketmqMessageState)

        __props__.__dict__["cluster_id"] = cluster_id
        __props__.__dict__["msg_body"] = msg_body
        __props__.__dict__["msg_key"] = msg_key
        __props__.__dict__["msg_tag"] = msg_tag
        __props__.__dict__["namespace_id"] = namespace_id
        __props__.__dict__["topic_name"] = topic_name
        return SendRocketmqMessage(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="clusterId")
    def cluster_id(self) -> pulumi.Output[str]:
        """
        Cluster id.
        """
        return pulumi.get(self, "cluster_id")

    @property
    @pulumi.getter(name="msgBody")
    def msg_body(self) -> pulumi.Output[str]:
        """
        Information.
        """
        return pulumi.get(self, "msg_body")

    @property
    @pulumi.getter(name="msgKey")
    def msg_key(self) -> pulumi.Output[Optional[str]]:
        """
        Message key information.
        """
        return pulumi.get(self, "msg_key")

    @property
    @pulumi.getter(name="msgTag")
    def msg_tag(self) -> pulumi.Output[Optional[str]]:
        """
        Message tag information.
        """
        return pulumi.get(self, "msg_tag")

    @property
    @pulumi.getter(name="namespaceId")
    def namespace_id(self) -> pulumi.Output[str]:
        """
        Namespaces.
        """
        return pulumi.get(self, "namespace_id")

    @property
    @pulumi.getter(name="topicName")
    def topic_name(self) -> pulumi.Output[str]:
        """
        topic name.
        """
        return pulumi.get(self, "topic_name")
