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

__all__ = ['EventConnectorArgs', 'EventConnector']

@pulumi.input_type
class EventConnectorArgs:
    def __init__(__self__, *,
                 connection_description: pulumi.Input['EventConnectorConnectionDescriptionArgs'],
                 connection_name: pulumi.Input[str],
                 event_bus_id: pulumi.Input[str],
                 description: Optional[pulumi.Input[str]] = None,
                 enable: Optional[pulumi.Input[bool]] = None,
                 type: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a EventConnector resource.
        :param pulumi.Input['EventConnectorConnectionDescriptionArgs'] connection_description: Connector description.
        :param pulumi.Input[str] connection_name: connector name.
        :param pulumi.Input[str] event_bus_id: event bus Id.
        :param pulumi.Input[str] description: description.
        :param pulumi.Input[bool] enable: switch.
        :param pulumi.Input[str] type: type.
        """
        pulumi.set(__self__, "connection_description", connection_description)
        pulumi.set(__self__, "connection_name", connection_name)
        pulumi.set(__self__, "event_bus_id", event_bus_id)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if enable is not None:
            pulumi.set(__self__, "enable", enable)
        if type is not None:
            pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter(name="connectionDescription")
    def connection_description(self) -> pulumi.Input['EventConnectorConnectionDescriptionArgs']:
        """
        Connector description.
        """
        return pulumi.get(self, "connection_description")

    @connection_description.setter
    def connection_description(self, value: pulumi.Input['EventConnectorConnectionDescriptionArgs']):
        pulumi.set(self, "connection_description", value)

    @property
    @pulumi.getter(name="connectionName")
    def connection_name(self) -> pulumi.Input[str]:
        """
        connector name.
        """
        return pulumi.get(self, "connection_name")

    @connection_name.setter
    def connection_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "connection_name", value)

    @property
    @pulumi.getter(name="eventBusId")
    def event_bus_id(self) -> pulumi.Input[str]:
        """
        event bus Id.
        """
        return pulumi.get(self, "event_bus_id")

    @event_bus_id.setter
    def event_bus_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "event_bus_id", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        description.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter
    def enable(self) -> Optional[pulumi.Input[bool]]:
        """
        switch.
        """
        return pulumi.get(self, "enable")

    @enable.setter
    def enable(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "enable", value)

    @property
    @pulumi.getter
    def type(self) -> Optional[pulumi.Input[str]]:
        """
        type.
        """
        return pulumi.get(self, "type")

    @type.setter
    def type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "type", value)


@pulumi.input_type
class _EventConnectorState:
    def __init__(__self__, *,
                 connection_description: Optional[pulumi.Input['EventConnectorConnectionDescriptionArgs']] = None,
                 connection_name: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 enable: Optional[pulumi.Input[bool]] = None,
                 event_bus_id: Optional[pulumi.Input[str]] = None,
                 type: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering EventConnector resources.
        :param pulumi.Input['EventConnectorConnectionDescriptionArgs'] connection_description: Connector description.
        :param pulumi.Input[str] connection_name: connector name.
        :param pulumi.Input[str] description: description.
        :param pulumi.Input[bool] enable: switch.
        :param pulumi.Input[str] event_bus_id: event bus Id.
        :param pulumi.Input[str] type: type.
        """
        if connection_description is not None:
            pulumi.set(__self__, "connection_description", connection_description)
        if connection_name is not None:
            pulumi.set(__self__, "connection_name", connection_name)
        if description is not None:
            pulumi.set(__self__, "description", description)
        if enable is not None:
            pulumi.set(__self__, "enable", enable)
        if event_bus_id is not None:
            pulumi.set(__self__, "event_bus_id", event_bus_id)
        if type is not None:
            pulumi.set(__self__, "type", type)

    @property
    @pulumi.getter(name="connectionDescription")
    def connection_description(self) -> Optional[pulumi.Input['EventConnectorConnectionDescriptionArgs']]:
        """
        Connector description.
        """
        return pulumi.get(self, "connection_description")

    @connection_description.setter
    def connection_description(self, value: Optional[pulumi.Input['EventConnectorConnectionDescriptionArgs']]):
        pulumi.set(self, "connection_description", value)

    @property
    @pulumi.getter(name="connectionName")
    def connection_name(self) -> Optional[pulumi.Input[str]]:
        """
        connector name.
        """
        return pulumi.get(self, "connection_name")

    @connection_name.setter
    def connection_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "connection_name", value)

    @property
    @pulumi.getter
    def description(self) -> Optional[pulumi.Input[str]]:
        """
        description.
        """
        return pulumi.get(self, "description")

    @description.setter
    def description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "description", value)

    @property
    @pulumi.getter
    def enable(self) -> Optional[pulumi.Input[bool]]:
        """
        switch.
        """
        return pulumi.get(self, "enable")

    @enable.setter
    def enable(self, value: Optional[pulumi.Input[bool]]):
        pulumi.set(self, "enable", value)

    @property
    @pulumi.getter(name="eventBusId")
    def event_bus_id(self) -> Optional[pulumi.Input[str]]:
        """
        event bus Id.
        """
        return pulumi.get(self, "event_bus_id")

    @event_bus_id.setter
    def event_bus_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "event_bus_id", value)

    @property
    @pulumi.getter
    def type(self) -> Optional[pulumi.Input[str]]:
        """
        type.
        """
        return pulumi.get(self, "type")

    @type.setter
    def type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "type", value)


class EventConnector(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 connection_description: Optional[pulumi.Input[pulumi.InputType['EventConnectorConnectionDescriptionArgs']]] = None,
                 connection_name: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 enable: Optional[pulumi.Input[bool]] = None,
                 event_bus_id: Optional[pulumi.Input[str]] = None,
                 type: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Create a EventConnector resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[pulumi.InputType['EventConnectorConnectionDescriptionArgs']] connection_description: Connector description.
        :param pulumi.Input[str] connection_name: connector name.
        :param pulumi.Input[str] description: description.
        :param pulumi.Input[bool] enable: switch.
        :param pulumi.Input[str] event_bus_id: event bus Id.
        :param pulumi.Input[str] type: type.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: EventConnectorArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a EventConnector resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param EventConnectorArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(EventConnectorArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 connection_description: Optional[pulumi.Input[pulumi.InputType['EventConnectorConnectionDescriptionArgs']]] = None,
                 connection_name: Optional[pulumi.Input[str]] = None,
                 description: Optional[pulumi.Input[str]] = None,
                 enable: Optional[pulumi.Input[bool]] = None,
                 event_bus_id: Optional[pulumi.Input[str]] = None,
                 type: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = EventConnectorArgs.__new__(EventConnectorArgs)

            if connection_description is None and not opts.urn:
                raise TypeError("Missing required property 'connection_description'")
            __props__.__dict__["connection_description"] = connection_description
            if connection_name is None and not opts.urn:
                raise TypeError("Missing required property 'connection_name'")
            __props__.__dict__["connection_name"] = connection_name
            __props__.__dict__["description"] = description
            __props__.__dict__["enable"] = enable
            if event_bus_id is None and not opts.urn:
                raise TypeError("Missing required property 'event_bus_id'")
            __props__.__dict__["event_bus_id"] = event_bus_id
            __props__.__dict__["type"] = type
        super(EventConnector, __self__).__init__(
            'tencentcloud:Eb/eventConnector:EventConnector',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            connection_description: Optional[pulumi.Input[pulumi.InputType['EventConnectorConnectionDescriptionArgs']]] = None,
            connection_name: Optional[pulumi.Input[str]] = None,
            description: Optional[pulumi.Input[str]] = None,
            enable: Optional[pulumi.Input[bool]] = None,
            event_bus_id: Optional[pulumi.Input[str]] = None,
            type: Optional[pulumi.Input[str]] = None) -> 'EventConnector':
        """
        Get an existing EventConnector resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[pulumi.InputType['EventConnectorConnectionDescriptionArgs']] connection_description: Connector description.
        :param pulumi.Input[str] connection_name: connector name.
        :param pulumi.Input[str] description: description.
        :param pulumi.Input[bool] enable: switch.
        :param pulumi.Input[str] event_bus_id: event bus Id.
        :param pulumi.Input[str] type: type.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _EventConnectorState.__new__(_EventConnectorState)

        __props__.__dict__["connection_description"] = connection_description
        __props__.__dict__["connection_name"] = connection_name
        __props__.__dict__["description"] = description
        __props__.__dict__["enable"] = enable
        __props__.__dict__["event_bus_id"] = event_bus_id
        __props__.__dict__["type"] = type
        return EventConnector(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="connectionDescription")
    def connection_description(self) -> pulumi.Output['outputs.EventConnectorConnectionDescription']:
        """
        Connector description.
        """
        return pulumi.get(self, "connection_description")

    @property
    @pulumi.getter(name="connectionName")
    def connection_name(self) -> pulumi.Output[str]:
        """
        connector name.
        """
        return pulumi.get(self, "connection_name")

    @property
    @pulumi.getter
    def description(self) -> pulumi.Output[Optional[str]]:
        """
        description.
        """
        return pulumi.get(self, "description")

    @property
    @pulumi.getter
    def enable(self) -> pulumi.Output[Optional[bool]]:
        """
        switch.
        """
        return pulumi.get(self, "enable")

    @property
    @pulumi.getter(name="eventBusId")
    def event_bus_id(self) -> pulumi.Output[str]:
        """
        event bus Id.
        """
        return pulumi.get(self, "event_bus_id")

    @property
    @pulumi.getter
    def type(self) -> pulumi.Output[Optional[str]]:
        """
        type.
        """
        return pulumi.get(self, "type")
