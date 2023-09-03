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

__all__ = ['FlowLogArgs', 'FlowLog']

@pulumi.input_type
class FlowLogArgs:
    def __init__(__self__, *,
                 flow_log_name: pulumi.Input[str],
                 resource_id: pulumi.Input[str],
                 resource_type: pulumi.Input[str],
                 traffic_type: pulumi.Input[str],
                 cloud_log_id: Optional[pulumi.Input[str]] = None,
                 cloud_log_region: Optional[pulumi.Input[str]] = None,
                 flow_log_description: Optional[pulumi.Input[str]] = None,
                 flow_log_storage: Optional[pulumi.Input['FlowLogFlowLogStorageArgs']] = None,
                 storage_type: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, Any]]] = None,
                 vpc_id: Optional[pulumi.Input[str]] = None):
        """
        The set of arguments for constructing a FlowLog resource.
        :param pulumi.Input[str] flow_log_name: Specify flow log name.
        :param pulumi.Input[str] resource_id: Specify resource unique Id of `resource_type` configured.
        :param pulumi.Input[str] resource_type: Specify resource type. NOTE: Only support `NETWORKINTERFACE` for now. Values: `VPC`, `SUBNET`, `NETWORKINTERFACE`,
               `CCN`, `NAT`, `DCG`.
        :param pulumi.Input[str] traffic_type: Specify log traffic type, values: `ACCEPT`, `REJECT`, `ALL`.
        :param pulumi.Input[str] cloud_log_id: Specify flow log storage id, just set cls topic id.
        :param pulumi.Input[str] cloud_log_region: Specify flow log storage region, default using current.
        :param pulumi.Input[str] flow_log_description: Specify flow Log description.
        :param pulumi.Input['FlowLogFlowLogStorageArgs'] flow_log_storage: Specify consumer detail, required while `storage_type` is `ckafka`.
        :param pulumi.Input[str] storage_type: Specify consumer type, values: `cls`, `ckafka`.
        :param pulumi.Input[Mapping[str, Any]] tags: Tag description list.
        :param pulumi.Input[str] vpc_id: Specify vpc Id, ignore while `resource_type` is `CCN` (unsupported) but required while other types.
        """
        pulumi.set(__self__, "flow_log_name", flow_log_name)
        pulumi.set(__self__, "resource_id", resource_id)
        pulumi.set(__self__, "resource_type", resource_type)
        pulumi.set(__self__, "traffic_type", traffic_type)
        if cloud_log_id is not None:
            pulumi.set(__self__, "cloud_log_id", cloud_log_id)
        if cloud_log_region is not None:
            pulumi.set(__self__, "cloud_log_region", cloud_log_region)
        if flow_log_description is not None:
            pulumi.set(__self__, "flow_log_description", flow_log_description)
        if flow_log_storage is not None:
            pulumi.set(__self__, "flow_log_storage", flow_log_storage)
        if storage_type is not None:
            pulumi.set(__self__, "storage_type", storage_type)
        if tags is not None:
            pulumi.set(__self__, "tags", tags)
        if vpc_id is not None:
            pulumi.set(__self__, "vpc_id", vpc_id)

    @property
    @pulumi.getter(name="flowLogName")
    def flow_log_name(self) -> pulumi.Input[str]:
        """
        Specify flow log name.
        """
        return pulumi.get(self, "flow_log_name")

    @flow_log_name.setter
    def flow_log_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "flow_log_name", value)

    @property
    @pulumi.getter(name="resourceId")
    def resource_id(self) -> pulumi.Input[str]:
        """
        Specify resource unique Id of `resource_type` configured.
        """
        return pulumi.get(self, "resource_id")

    @resource_id.setter
    def resource_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "resource_id", value)

    @property
    @pulumi.getter(name="resourceType")
    def resource_type(self) -> pulumi.Input[str]:
        """
        Specify resource type. NOTE: Only support `NETWORKINTERFACE` for now. Values: `VPC`, `SUBNET`, `NETWORKINTERFACE`,
        `CCN`, `NAT`, `DCG`.
        """
        return pulumi.get(self, "resource_type")

    @resource_type.setter
    def resource_type(self, value: pulumi.Input[str]):
        pulumi.set(self, "resource_type", value)

    @property
    @pulumi.getter(name="trafficType")
    def traffic_type(self) -> pulumi.Input[str]:
        """
        Specify log traffic type, values: `ACCEPT`, `REJECT`, `ALL`.
        """
        return pulumi.get(self, "traffic_type")

    @traffic_type.setter
    def traffic_type(self, value: pulumi.Input[str]):
        pulumi.set(self, "traffic_type", value)

    @property
    @pulumi.getter(name="cloudLogId")
    def cloud_log_id(self) -> Optional[pulumi.Input[str]]:
        """
        Specify flow log storage id, just set cls topic id.
        """
        return pulumi.get(self, "cloud_log_id")

    @cloud_log_id.setter
    def cloud_log_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "cloud_log_id", value)

    @property
    @pulumi.getter(name="cloudLogRegion")
    def cloud_log_region(self) -> Optional[pulumi.Input[str]]:
        """
        Specify flow log storage region, default using current.
        """
        return pulumi.get(self, "cloud_log_region")

    @cloud_log_region.setter
    def cloud_log_region(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "cloud_log_region", value)

    @property
    @pulumi.getter(name="flowLogDescription")
    def flow_log_description(self) -> Optional[pulumi.Input[str]]:
        """
        Specify flow Log description.
        """
        return pulumi.get(self, "flow_log_description")

    @flow_log_description.setter
    def flow_log_description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "flow_log_description", value)

    @property
    @pulumi.getter(name="flowLogStorage")
    def flow_log_storage(self) -> Optional[pulumi.Input['FlowLogFlowLogStorageArgs']]:
        """
        Specify consumer detail, required while `storage_type` is `ckafka`.
        """
        return pulumi.get(self, "flow_log_storage")

    @flow_log_storage.setter
    def flow_log_storage(self, value: Optional[pulumi.Input['FlowLogFlowLogStorageArgs']]):
        pulumi.set(self, "flow_log_storage", value)

    @property
    @pulumi.getter(name="storageType")
    def storage_type(self) -> Optional[pulumi.Input[str]]:
        """
        Specify consumer type, values: `cls`, `ckafka`.
        """
        return pulumi.get(self, "storage_type")

    @storage_type.setter
    def storage_type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "storage_type", value)

    @property
    @pulumi.getter
    def tags(self) -> Optional[pulumi.Input[Mapping[str, Any]]]:
        """
        Tag description list.
        """
        return pulumi.get(self, "tags")

    @tags.setter
    def tags(self, value: Optional[pulumi.Input[Mapping[str, Any]]]):
        pulumi.set(self, "tags", value)

    @property
    @pulumi.getter(name="vpcId")
    def vpc_id(self) -> Optional[pulumi.Input[str]]:
        """
        Specify vpc Id, ignore while `resource_type` is `CCN` (unsupported) but required while other types.
        """
        return pulumi.get(self, "vpc_id")

    @vpc_id.setter
    def vpc_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "vpc_id", value)


@pulumi.input_type
class _FlowLogState:
    def __init__(__self__, *,
                 cloud_log_id: Optional[pulumi.Input[str]] = None,
                 cloud_log_region: Optional[pulumi.Input[str]] = None,
                 flow_log_description: Optional[pulumi.Input[str]] = None,
                 flow_log_name: Optional[pulumi.Input[str]] = None,
                 flow_log_storage: Optional[pulumi.Input['FlowLogFlowLogStorageArgs']] = None,
                 resource_id: Optional[pulumi.Input[str]] = None,
                 resource_type: Optional[pulumi.Input[str]] = None,
                 storage_type: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, Any]]] = None,
                 traffic_type: Optional[pulumi.Input[str]] = None,
                 vpc_id: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering FlowLog resources.
        :param pulumi.Input[str] cloud_log_id: Specify flow log storage id, just set cls topic id.
        :param pulumi.Input[str] cloud_log_region: Specify flow log storage region, default using current.
        :param pulumi.Input[str] flow_log_description: Specify flow Log description.
        :param pulumi.Input[str] flow_log_name: Specify flow log name.
        :param pulumi.Input['FlowLogFlowLogStorageArgs'] flow_log_storage: Specify consumer detail, required while `storage_type` is `ckafka`.
        :param pulumi.Input[str] resource_id: Specify resource unique Id of `resource_type` configured.
        :param pulumi.Input[str] resource_type: Specify resource type. NOTE: Only support `NETWORKINTERFACE` for now. Values: `VPC`, `SUBNET`, `NETWORKINTERFACE`,
               `CCN`, `NAT`, `DCG`.
        :param pulumi.Input[str] storage_type: Specify consumer type, values: `cls`, `ckafka`.
        :param pulumi.Input[Mapping[str, Any]] tags: Tag description list.
        :param pulumi.Input[str] traffic_type: Specify log traffic type, values: `ACCEPT`, `REJECT`, `ALL`.
        :param pulumi.Input[str] vpc_id: Specify vpc Id, ignore while `resource_type` is `CCN` (unsupported) but required while other types.
        """
        if cloud_log_id is not None:
            pulumi.set(__self__, "cloud_log_id", cloud_log_id)
        if cloud_log_region is not None:
            pulumi.set(__self__, "cloud_log_region", cloud_log_region)
        if flow_log_description is not None:
            pulumi.set(__self__, "flow_log_description", flow_log_description)
        if flow_log_name is not None:
            pulumi.set(__self__, "flow_log_name", flow_log_name)
        if flow_log_storage is not None:
            pulumi.set(__self__, "flow_log_storage", flow_log_storage)
        if resource_id is not None:
            pulumi.set(__self__, "resource_id", resource_id)
        if resource_type is not None:
            pulumi.set(__self__, "resource_type", resource_type)
        if storage_type is not None:
            pulumi.set(__self__, "storage_type", storage_type)
        if tags is not None:
            pulumi.set(__self__, "tags", tags)
        if traffic_type is not None:
            pulumi.set(__self__, "traffic_type", traffic_type)
        if vpc_id is not None:
            pulumi.set(__self__, "vpc_id", vpc_id)

    @property
    @pulumi.getter(name="cloudLogId")
    def cloud_log_id(self) -> Optional[pulumi.Input[str]]:
        """
        Specify flow log storage id, just set cls topic id.
        """
        return pulumi.get(self, "cloud_log_id")

    @cloud_log_id.setter
    def cloud_log_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "cloud_log_id", value)

    @property
    @pulumi.getter(name="cloudLogRegion")
    def cloud_log_region(self) -> Optional[pulumi.Input[str]]:
        """
        Specify flow log storage region, default using current.
        """
        return pulumi.get(self, "cloud_log_region")

    @cloud_log_region.setter
    def cloud_log_region(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "cloud_log_region", value)

    @property
    @pulumi.getter(name="flowLogDescription")
    def flow_log_description(self) -> Optional[pulumi.Input[str]]:
        """
        Specify flow Log description.
        """
        return pulumi.get(self, "flow_log_description")

    @flow_log_description.setter
    def flow_log_description(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "flow_log_description", value)

    @property
    @pulumi.getter(name="flowLogName")
    def flow_log_name(self) -> Optional[pulumi.Input[str]]:
        """
        Specify flow log name.
        """
        return pulumi.get(self, "flow_log_name")

    @flow_log_name.setter
    def flow_log_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "flow_log_name", value)

    @property
    @pulumi.getter(name="flowLogStorage")
    def flow_log_storage(self) -> Optional[pulumi.Input['FlowLogFlowLogStorageArgs']]:
        """
        Specify consumer detail, required while `storage_type` is `ckafka`.
        """
        return pulumi.get(self, "flow_log_storage")

    @flow_log_storage.setter
    def flow_log_storage(self, value: Optional[pulumi.Input['FlowLogFlowLogStorageArgs']]):
        pulumi.set(self, "flow_log_storage", value)

    @property
    @pulumi.getter(name="resourceId")
    def resource_id(self) -> Optional[pulumi.Input[str]]:
        """
        Specify resource unique Id of `resource_type` configured.
        """
        return pulumi.get(self, "resource_id")

    @resource_id.setter
    def resource_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "resource_id", value)

    @property
    @pulumi.getter(name="resourceType")
    def resource_type(self) -> Optional[pulumi.Input[str]]:
        """
        Specify resource type. NOTE: Only support `NETWORKINTERFACE` for now. Values: `VPC`, `SUBNET`, `NETWORKINTERFACE`,
        `CCN`, `NAT`, `DCG`.
        """
        return pulumi.get(self, "resource_type")

    @resource_type.setter
    def resource_type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "resource_type", value)

    @property
    @pulumi.getter(name="storageType")
    def storage_type(self) -> Optional[pulumi.Input[str]]:
        """
        Specify consumer type, values: `cls`, `ckafka`.
        """
        return pulumi.get(self, "storage_type")

    @storage_type.setter
    def storage_type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "storage_type", value)

    @property
    @pulumi.getter
    def tags(self) -> Optional[pulumi.Input[Mapping[str, Any]]]:
        """
        Tag description list.
        """
        return pulumi.get(self, "tags")

    @tags.setter
    def tags(self, value: Optional[pulumi.Input[Mapping[str, Any]]]):
        pulumi.set(self, "tags", value)

    @property
    @pulumi.getter(name="trafficType")
    def traffic_type(self) -> Optional[pulumi.Input[str]]:
        """
        Specify log traffic type, values: `ACCEPT`, `REJECT`, `ALL`.
        """
        return pulumi.get(self, "traffic_type")

    @traffic_type.setter
    def traffic_type(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "traffic_type", value)

    @property
    @pulumi.getter(name="vpcId")
    def vpc_id(self) -> Optional[pulumi.Input[str]]:
        """
        Specify vpc Id, ignore while `resource_type` is `CCN` (unsupported) but required while other types.
        """
        return pulumi.get(self, "vpc_id")

    @vpc_id.setter
    def vpc_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "vpc_id", value)


class FlowLog(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 cloud_log_id: Optional[pulumi.Input[str]] = None,
                 cloud_log_region: Optional[pulumi.Input[str]] = None,
                 flow_log_description: Optional[pulumi.Input[str]] = None,
                 flow_log_name: Optional[pulumi.Input[str]] = None,
                 flow_log_storage: Optional[pulumi.Input[pulumi.InputType['FlowLogFlowLogStorageArgs']]] = None,
                 resource_id: Optional[pulumi.Input[str]] = None,
                 resource_type: Optional[pulumi.Input[str]] = None,
                 storage_type: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, Any]]] = None,
                 traffic_type: Optional[pulumi.Input[str]] = None,
                 vpc_id: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Create a FlowLog resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] cloud_log_id: Specify flow log storage id, just set cls topic id.
        :param pulumi.Input[str] cloud_log_region: Specify flow log storage region, default using current.
        :param pulumi.Input[str] flow_log_description: Specify flow Log description.
        :param pulumi.Input[str] flow_log_name: Specify flow log name.
        :param pulumi.Input[pulumi.InputType['FlowLogFlowLogStorageArgs']] flow_log_storage: Specify consumer detail, required while `storage_type` is `ckafka`.
        :param pulumi.Input[str] resource_id: Specify resource unique Id of `resource_type` configured.
        :param pulumi.Input[str] resource_type: Specify resource type. NOTE: Only support `NETWORKINTERFACE` for now. Values: `VPC`, `SUBNET`, `NETWORKINTERFACE`,
               `CCN`, `NAT`, `DCG`.
        :param pulumi.Input[str] storage_type: Specify consumer type, values: `cls`, `ckafka`.
        :param pulumi.Input[Mapping[str, Any]] tags: Tag description list.
        :param pulumi.Input[str] traffic_type: Specify log traffic type, values: `ACCEPT`, `REJECT`, `ALL`.
        :param pulumi.Input[str] vpc_id: Specify vpc Id, ignore while `resource_type` is `CCN` (unsupported) but required while other types.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: FlowLogArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a FlowLog resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param FlowLogArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(FlowLogArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 cloud_log_id: Optional[pulumi.Input[str]] = None,
                 cloud_log_region: Optional[pulumi.Input[str]] = None,
                 flow_log_description: Optional[pulumi.Input[str]] = None,
                 flow_log_name: Optional[pulumi.Input[str]] = None,
                 flow_log_storage: Optional[pulumi.Input[pulumi.InputType['FlowLogFlowLogStorageArgs']]] = None,
                 resource_id: Optional[pulumi.Input[str]] = None,
                 resource_type: Optional[pulumi.Input[str]] = None,
                 storage_type: Optional[pulumi.Input[str]] = None,
                 tags: Optional[pulumi.Input[Mapping[str, Any]]] = None,
                 traffic_type: Optional[pulumi.Input[str]] = None,
                 vpc_id: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = FlowLogArgs.__new__(FlowLogArgs)

            __props__.__dict__["cloud_log_id"] = cloud_log_id
            __props__.__dict__["cloud_log_region"] = cloud_log_region
            __props__.__dict__["flow_log_description"] = flow_log_description
            if flow_log_name is None and not opts.urn:
                raise TypeError("Missing required property 'flow_log_name'")
            __props__.__dict__["flow_log_name"] = flow_log_name
            __props__.__dict__["flow_log_storage"] = flow_log_storage
            if resource_id is None and not opts.urn:
                raise TypeError("Missing required property 'resource_id'")
            __props__.__dict__["resource_id"] = resource_id
            if resource_type is None and not opts.urn:
                raise TypeError("Missing required property 'resource_type'")
            __props__.__dict__["resource_type"] = resource_type
            __props__.__dict__["storage_type"] = storage_type
            __props__.__dict__["tags"] = tags
            if traffic_type is None and not opts.urn:
                raise TypeError("Missing required property 'traffic_type'")
            __props__.__dict__["traffic_type"] = traffic_type
            __props__.__dict__["vpc_id"] = vpc_id
        super(FlowLog, __self__).__init__(
            'tencentcloud:Vpc/flowLog:FlowLog',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            cloud_log_id: Optional[pulumi.Input[str]] = None,
            cloud_log_region: Optional[pulumi.Input[str]] = None,
            flow_log_description: Optional[pulumi.Input[str]] = None,
            flow_log_name: Optional[pulumi.Input[str]] = None,
            flow_log_storage: Optional[pulumi.Input[pulumi.InputType['FlowLogFlowLogStorageArgs']]] = None,
            resource_id: Optional[pulumi.Input[str]] = None,
            resource_type: Optional[pulumi.Input[str]] = None,
            storage_type: Optional[pulumi.Input[str]] = None,
            tags: Optional[pulumi.Input[Mapping[str, Any]]] = None,
            traffic_type: Optional[pulumi.Input[str]] = None,
            vpc_id: Optional[pulumi.Input[str]] = None) -> 'FlowLog':
        """
        Get an existing FlowLog resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] cloud_log_id: Specify flow log storage id, just set cls topic id.
        :param pulumi.Input[str] cloud_log_region: Specify flow log storage region, default using current.
        :param pulumi.Input[str] flow_log_description: Specify flow Log description.
        :param pulumi.Input[str] flow_log_name: Specify flow log name.
        :param pulumi.Input[pulumi.InputType['FlowLogFlowLogStorageArgs']] flow_log_storage: Specify consumer detail, required while `storage_type` is `ckafka`.
        :param pulumi.Input[str] resource_id: Specify resource unique Id of `resource_type` configured.
        :param pulumi.Input[str] resource_type: Specify resource type. NOTE: Only support `NETWORKINTERFACE` for now. Values: `VPC`, `SUBNET`, `NETWORKINTERFACE`,
               `CCN`, `NAT`, `DCG`.
        :param pulumi.Input[str] storage_type: Specify consumer type, values: `cls`, `ckafka`.
        :param pulumi.Input[Mapping[str, Any]] tags: Tag description list.
        :param pulumi.Input[str] traffic_type: Specify log traffic type, values: `ACCEPT`, `REJECT`, `ALL`.
        :param pulumi.Input[str] vpc_id: Specify vpc Id, ignore while `resource_type` is `CCN` (unsupported) but required while other types.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _FlowLogState.__new__(_FlowLogState)

        __props__.__dict__["cloud_log_id"] = cloud_log_id
        __props__.__dict__["cloud_log_region"] = cloud_log_region
        __props__.__dict__["flow_log_description"] = flow_log_description
        __props__.__dict__["flow_log_name"] = flow_log_name
        __props__.__dict__["flow_log_storage"] = flow_log_storage
        __props__.__dict__["resource_id"] = resource_id
        __props__.__dict__["resource_type"] = resource_type
        __props__.__dict__["storage_type"] = storage_type
        __props__.__dict__["tags"] = tags
        __props__.__dict__["traffic_type"] = traffic_type
        __props__.__dict__["vpc_id"] = vpc_id
        return FlowLog(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="cloudLogId")
    def cloud_log_id(self) -> pulumi.Output[Optional[str]]:
        """
        Specify flow log storage id, just set cls topic id.
        """
        return pulumi.get(self, "cloud_log_id")

    @property
    @pulumi.getter(name="cloudLogRegion")
    def cloud_log_region(self) -> pulumi.Output[str]:
        """
        Specify flow log storage region, default using current.
        """
        return pulumi.get(self, "cloud_log_region")

    @property
    @pulumi.getter(name="flowLogDescription")
    def flow_log_description(self) -> pulumi.Output[Optional[str]]:
        """
        Specify flow Log description.
        """
        return pulumi.get(self, "flow_log_description")

    @property
    @pulumi.getter(name="flowLogName")
    def flow_log_name(self) -> pulumi.Output[str]:
        """
        Specify flow log name.
        """
        return pulumi.get(self, "flow_log_name")

    @property
    @pulumi.getter(name="flowLogStorage")
    def flow_log_storage(self) -> pulumi.Output['outputs.FlowLogFlowLogStorage']:
        """
        Specify consumer detail, required while `storage_type` is `ckafka`.
        """
        return pulumi.get(self, "flow_log_storage")

    @property
    @pulumi.getter(name="resourceId")
    def resource_id(self) -> pulumi.Output[str]:
        """
        Specify resource unique Id of `resource_type` configured.
        """
        return pulumi.get(self, "resource_id")

    @property
    @pulumi.getter(name="resourceType")
    def resource_type(self) -> pulumi.Output[str]:
        """
        Specify resource type. NOTE: Only support `NETWORKINTERFACE` for now. Values: `VPC`, `SUBNET`, `NETWORKINTERFACE`,
        `CCN`, `NAT`, `DCG`.
        """
        return pulumi.get(self, "resource_type")

    @property
    @pulumi.getter(name="storageType")
    def storage_type(self) -> pulumi.Output[Optional[str]]:
        """
        Specify consumer type, values: `cls`, `ckafka`.
        """
        return pulumi.get(self, "storage_type")

    @property
    @pulumi.getter
    def tags(self) -> pulumi.Output[Optional[Mapping[str, Any]]]:
        """
        Tag description list.
        """
        return pulumi.get(self, "tags")

    @property
    @pulumi.getter(name="trafficType")
    def traffic_type(self) -> pulumi.Output[str]:
        """
        Specify log traffic type, values: `ACCEPT`, `REJECT`, `ALL`.
        """
        return pulumi.get(self, "traffic_type")

    @property
    @pulumi.getter(name="vpcId")
    def vpc_id(self) -> pulumi.Output[Optional[str]]:
        """
        Specify vpc Id, ignore while `resource_type` is `CCN` (unsupported) but required while other types.
        """
        return pulumi.get(self, "vpc_id")
