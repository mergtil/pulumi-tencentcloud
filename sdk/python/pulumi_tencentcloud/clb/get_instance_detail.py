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

__all__ = [
    'GetInstanceDetailResult',
    'AwaitableGetInstanceDetailResult',
    'get_instance_detail',
    'get_instance_detail_output',
]

@pulumi.output_type
class GetInstanceDetailResult:
    """
    A collection of values returned by getInstanceDetail.
    """
    def __init__(__self__, fields=None, filters=None, id=None, load_balancer_detail_sets=None, result_output_file=None, target_type=None):
        if fields and not isinstance(fields, list):
            raise TypeError("Expected argument 'fields' to be a list")
        pulumi.set(__self__, "fields", fields)
        if filters and not isinstance(filters, list):
            raise TypeError("Expected argument 'filters' to be a list")
        pulumi.set(__self__, "filters", filters)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if load_balancer_detail_sets and not isinstance(load_balancer_detail_sets, list):
            raise TypeError("Expected argument 'load_balancer_detail_sets' to be a list")
        pulumi.set(__self__, "load_balancer_detail_sets", load_balancer_detail_sets)
        if result_output_file and not isinstance(result_output_file, str):
            raise TypeError("Expected argument 'result_output_file' to be a str")
        pulumi.set(__self__, "result_output_file", result_output_file)
        if target_type and not isinstance(target_type, str):
            raise TypeError("Expected argument 'target_type' to be a str")
        pulumi.set(__self__, "target_type", target_type)

    @property
    @pulumi.getter
    def fields(self) -> Optional[Sequence[str]]:
        return pulumi.get(self, "fields")

    @property
    @pulumi.getter
    def filters(self) -> Optional[Sequence['outputs.GetInstanceDetailFilterResult']]:
        return pulumi.get(self, "filters")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter(name="loadBalancerDetailSets")
    def load_balancer_detail_sets(self) -> Sequence['outputs.GetInstanceDetailLoadBalancerDetailSetResult']:
        return pulumi.get(self, "load_balancer_detail_sets")

    @property
    @pulumi.getter(name="resultOutputFile")
    def result_output_file(self) -> Optional[str]:
        return pulumi.get(self, "result_output_file")

    @property
    @pulumi.getter(name="targetType")
    def target_type(self) -> Optional[str]:
        return pulumi.get(self, "target_type")


class AwaitableGetInstanceDetailResult(GetInstanceDetailResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetInstanceDetailResult(
            fields=self.fields,
            filters=self.filters,
            id=self.id,
            load_balancer_detail_sets=self.load_balancer_detail_sets,
            result_output_file=self.result_output_file,
            target_type=self.target_type)


def get_instance_detail(fields: Optional[Sequence[str]] = None,
                        filters: Optional[Sequence[pulumi.InputType['GetInstanceDetailFilterArgs']]] = None,
                        result_output_file: Optional[str] = None,
                        target_type: Optional[str] = None,
                        opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetInstanceDetailResult:
    """
    Use this data source to access information about an existing resource.
    """
    __args__ = dict()
    __args__['fields'] = fields
    __args__['filters'] = filters
    __args__['resultOutputFile'] = result_output_file
    __args__['targetType'] = target_type
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('tencentcloud:Clb/getInstanceDetail:getInstanceDetail', __args__, opts=opts, typ=GetInstanceDetailResult).value

    return AwaitableGetInstanceDetailResult(
        fields=pulumi.get(__ret__, 'fields'),
        filters=pulumi.get(__ret__, 'filters'),
        id=pulumi.get(__ret__, 'id'),
        load_balancer_detail_sets=pulumi.get(__ret__, 'load_balancer_detail_sets'),
        result_output_file=pulumi.get(__ret__, 'result_output_file'),
        target_type=pulumi.get(__ret__, 'target_type'))


@_utilities.lift_output_func(get_instance_detail)
def get_instance_detail_output(fields: Optional[pulumi.Input[Optional[Sequence[str]]]] = None,
                               filters: Optional[pulumi.Input[Optional[Sequence[pulumi.InputType['GetInstanceDetailFilterArgs']]]]] = None,
                               result_output_file: Optional[pulumi.Input[Optional[str]]] = None,
                               target_type: Optional[pulumi.Input[Optional[str]]] = None,
                               opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetInstanceDetailResult]:
    """
    Use this data source to access information about an existing resource.
    """
    ...
