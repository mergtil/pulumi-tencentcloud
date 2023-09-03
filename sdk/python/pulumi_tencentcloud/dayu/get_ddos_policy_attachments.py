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

__all__ = [
    'GetDdosPolicyAttachmentsResult',
    'AwaitableGetDdosPolicyAttachmentsResult',
    'get_ddos_policy_attachments',
    'get_ddos_policy_attachments_output',
]

@pulumi.output_type
class GetDdosPolicyAttachmentsResult:
    """
    A collection of values returned by getDdosPolicyAttachments.
    """
    def __init__(__self__, dayu_ddos_policy_attachment_lists=None, id=None, policy_id=None, resource_id=None, resource_type=None, result_output_file=None):
        if dayu_ddos_policy_attachment_lists and not isinstance(dayu_ddos_policy_attachment_lists, list):
            raise TypeError("Expected argument 'dayu_ddos_policy_attachment_lists' to be a list")
        pulumi.set(__self__, "dayu_ddos_policy_attachment_lists", dayu_ddos_policy_attachment_lists)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if policy_id and not isinstance(policy_id, str):
            raise TypeError("Expected argument 'policy_id' to be a str")
        pulumi.set(__self__, "policy_id", policy_id)
        if resource_id and not isinstance(resource_id, str):
            raise TypeError("Expected argument 'resource_id' to be a str")
        pulumi.set(__self__, "resource_id", resource_id)
        if resource_type and not isinstance(resource_type, str):
            raise TypeError("Expected argument 'resource_type' to be a str")
        pulumi.set(__self__, "resource_type", resource_type)
        if result_output_file and not isinstance(result_output_file, str):
            raise TypeError("Expected argument 'result_output_file' to be a str")
        pulumi.set(__self__, "result_output_file", result_output_file)

    @property
    @pulumi.getter(name="dayuDdosPolicyAttachmentLists")
    def dayu_ddos_policy_attachment_lists(self) -> Sequence['outputs.GetDdosPolicyAttachmentsDayuDdosPolicyAttachmentListResult']:
        return pulumi.get(self, "dayu_ddos_policy_attachment_lists")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter(name="policyId")
    def policy_id(self) -> Optional[str]:
        return pulumi.get(self, "policy_id")

    @property
    @pulumi.getter(name="resourceId")
    def resource_id(self) -> Optional[str]:
        return pulumi.get(self, "resource_id")

    @property
    @pulumi.getter(name="resourceType")
    def resource_type(self) -> str:
        return pulumi.get(self, "resource_type")

    @property
    @pulumi.getter(name="resultOutputFile")
    def result_output_file(self) -> Optional[str]:
        return pulumi.get(self, "result_output_file")


class AwaitableGetDdosPolicyAttachmentsResult(GetDdosPolicyAttachmentsResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetDdosPolicyAttachmentsResult(
            dayu_ddos_policy_attachment_lists=self.dayu_ddos_policy_attachment_lists,
            id=self.id,
            policy_id=self.policy_id,
            resource_id=self.resource_id,
            resource_type=self.resource_type,
            result_output_file=self.result_output_file)


def get_ddos_policy_attachments(policy_id: Optional[str] = None,
                                resource_id: Optional[str] = None,
                                resource_type: Optional[str] = None,
                                result_output_file: Optional[str] = None,
                                opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetDdosPolicyAttachmentsResult:
    """
    Use this data source to access information about an existing resource.
    """
    __args__ = dict()
    __args__['policyId'] = policy_id
    __args__['resourceId'] = resource_id
    __args__['resourceType'] = resource_type
    __args__['resultOutputFile'] = result_output_file
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('tencentcloud:Dayu/getDdosPolicyAttachments:getDdosPolicyAttachments', __args__, opts=opts, typ=GetDdosPolicyAttachmentsResult).value

    return AwaitableGetDdosPolicyAttachmentsResult(
        dayu_ddos_policy_attachment_lists=pulumi.get(__ret__, 'dayu_ddos_policy_attachment_lists'),
        id=pulumi.get(__ret__, 'id'),
        policy_id=pulumi.get(__ret__, 'policy_id'),
        resource_id=pulumi.get(__ret__, 'resource_id'),
        resource_type=pulumi.get(__ret__, 'resource_type'),
        result_output_file=pulumi.get(__ret__, 'result_output_file'))


@_utilities.lift_output_func(get_ddos_policy_attachments)
def get_ddos_policy_attachments_output(policy_id: Optional[pulumi.Input[Optional[str]]] = None,
                                       resource_id: Optional[pulumi.Input[Optional[str]]] = None,
                                       resource_type: Optional[pulumi.Input[str]] = None,
                                       result_output_file: Optional[pulumi.Input[Optional[str]]] = None,
                                       opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetDdosPolicyAttachmentsResult]:
    """
    Use this data source to access information about an existing resource.
    """
    ...