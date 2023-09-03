# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = [
    'GetDomainVerifierResult',
    'AwaitableGetDomainVerifierResult',
    'get_domain_verifier',
    'get_domain_verifier_output',
]

@pulumi.output_type
class GetDomainVerifierResult:
    """
    A collection of values returned by getDomainVerifier.
    """
    def __init__(__self__, auto_verify=None, domain=None, failed_reason=None, file_verify_domains=None, file_verify_name=None, file_verify_url=None, freeze_record=None, id=None, record=None, record_type=None, result_output_file=None, sub_domain=None, verify_result=None, verify_type=None):
        if auto_verify and not isinstance(auto_verify, bool):
            raise TypeError("Expected argument 'auto_verify' to be a bool")
        pulumi.set(__self__, "auto_verify", auto_verify)
        if domain and not isinstance(domain, str):
            raise TypeError("Expected argument 'domain' to be a str")
        pulumi.set(__self__, "domain", domain)
        if failed_reason and not isinstance(failed_reason, str):
            raise TypeError("Expected argument 'failed_reason' to be a str")
        pulumi.set(__self__, "failed_reason", failed_reason)
        if file_verify_domains and not isinstance(file_verify_domains, list):
            raise TypeError("Expected argument 'file_verify_domains' to be a list")
        pulumi.set(__self__, "file_verify_domains", file_verify_domains)
        if file_verify_name and not isinstance(file_verify_name, str):
            raise TypeError("Expected argument 'file_verify_name' to be a str")
        pulumi.set(__self__, "file_verify_name", file_verify_name)
        if file_verify_url and not isinstance(file_verify_url, str):
            raise TypeError("Expected argument 'file_verify_url' to be a str")
        pulumi.set(__self__, "file_verify_url", file_verify_url)
        if freeze_record and not isinstance(freeze_record, bool):
            raise TypeError("Expected argument 'freeze_record' to be a bool")
        pulumi.set(__self__, "freeze_record", freeze_record)
        if id and not isinstance(id, str):
            raise TypeError("Expected argument 'id' to be a str")
        pulumi.set(__self__, "id", id)
        if record and not isinstance(record, str):
            raise TypeError("Expected argument 'record' to be a str")
        pulumi.set(__self__, "record", record)
        if record_type and not isinstance(record_type, str):
            raise TypeError("Expected argument 'record_type' to be a str")
        pulumi.set(__self__, "record_type", record_type)
        if result_output_file and not isinstance(result_output_file, str):
            raise TypeError("Expected argument 'result_output_file' to be a str")
        pulumi.set(__self__, "result_output_file", result_output_file)
        if sub_domain and not isinstance(sub_domain, str):
            raise TypeError("Expected argument 'sub_domain' to be a str")
        pulumi.set(__self__, "sub_domain", sub_domain)
        if verify_result and not isinstance(verify_result, bool):
            raise TypeError("Expected argument 'verify_result' to be a bool")
        pulumi.set(__self__, "verify_result", verify_result)
        if verify_type and not isinstance(verify_type, str):
            raise TypeError("Expected argument 'verify_type' to be a str")
        pulumi.set(__self__, "verify_type", verify_type)

    @property
    @pulumi.getter(name="autoVerify")
    def auto_verify(self) -> Optional[bool]:
        return pulumi.get(self, "auto_verify")

    @property
    @pulumi.getter
    def domain(self) -> str:
        return pulumi.get(self, "domain")

    @property
    @pulumi.getter(name="failedReason")
    def failed_reason(self) -> Optional[str]:
        return pulumi.get(self, "failed_reason")

    @property
    @pulumi.getter(name="fileVerifyDomains")
    def file_verify_domains(self) -> Sequence[str]:
        return pulumi.get(self, "file_verify_domains")

    @property
    @pulumi.getter(name="fileVerifyName")
    def file_verify_name(self) -> str:
        return pulumi.get(self, "file_verify_name")

    @property
    @pulumi.getter(name="fileVerifyUrl")
    def file_verify_url(self) -> str:
        return pulumi.get(self, "file_verify_url")

    @property
    @pulumi.getter(name="freezeRecord")
    def freeze_record(self) -> Optional[bool]:
        return pulumi.get(self, "freeze_record")

    @property
    @pulumi.getter
    def id(self) -> str:
        """
        The provider-assigned unique ID for this managed resource.
        """
        return pulumi.get(self, "id")

    @property
    @pulumi.getter
    def record(self) -> str:
        return pulumi.get(self, "record")

    @property
    @pulumi.getter(name="recordType")
    def record_type(self) -> str:
        return pulumi.get(self, "record_type")

    @property
    @pulumi.getter(name="resultOutputFile")
    def result_output_file(self) -> Optional[str]:
        return pulumi.get(self, "result_output_file")

    @property
    @pulumi.getter(name="subDomain")
    def sub_domain(self) -> str:
        return pulumi.get(self, "sub_domain")

    @property
    @pulumi.getter(name="verifyResult")
    def verify_result(self) -> bool:
        return pulumi.get(self, "verify_result")

    @property
    @pulumi.getter(name="verifyType")
    def verify_type(self) -> Optional[str]:
        return pulumi.get(self, "verify_type")


class AwaitableGetDomainVerifierResult(GetDomainVerifierResult):
    # pylint: disable=using-constant-test
    def __await__(self):
        if False:
            yield self
        return GetDomainVerifierResult(
            auto_verify=self.auto_verify,
            domain=self.domain,
            failed_reason=self.failed_reason,
            file_verify_domains=self.file_verify_domains,
            file_verify_name=self.file_verify_name,
            file_verify_url=self.file_verify_url,
            freeze_record=self.freeze_record,
            id=self.id,
            record=self.record,
            record_type=self.record_type,
            result_output_file=self.result_output_file,
            sub_domain=self.sub_domain,
            verify_result=self.verify_result,
            verify_type=self.verify_type)


def get_domain_verifier(auto_verify: Optional[bool] = None,
                        domain: Optional[str] = None,
                        failed_reason: Optional[str] = None,
                        freeze_record: Optional[bool] = None,
                        result_output_file: Optional[str] = None,
                        verify_type: Optional[str] = None,
                        opts: Optional[pulumi.InvokeOptions] = None) -> AwaitableGetDomainVerifierResult:
    """
    Use this data source to access information about an existing resource.
    """
    __args__ = dict()
    __args__['autoVerify'] = auto_verify
    __args__['domain'] = domain
    __args__['failedReason'] = failed_reason
    __args__['freezeRecord'] = freeze_record
    __args__['resultOutputFile'] = result_output_file
    __args__['verifyType'] = verify_type
    opts = pulumi.InvokeOptions.merge(_utilities.get_invoke_opts_defaults(), opts)
    __ret__ = pulumi.runtime.invoke('tencentcloud:Cdn/getDomainVerifier:getDomainVerifier', __args__, opts=opts, typ=GetDomainVerifierResult).value

    return AwaitableGetDomainVerifierResult(
        auto_verify=pulumi.get(__ret__, 'auto_verify'),
        domain=pulumi.get(__ret__, 'domain'),
        failed_reason=pulumi.get(__ret__, 'failed_reason'),
        file_verify_domains=pulumi.get(__ret__, 'file_verify_domains'),
        file_verify_name=pulumi.get(__ret__, 'file_verify_name'),
        file_verify_url=pulumi.get(__ret__, 'file_verify_url'),
        freeze_record=pulumi.get(__ret__, 'freeze_record'),
        id=pulumi.get(__ret__, 'id'),
        record=pulumi.get(__ret__, 'record'),
        record_type=pulumi.get(__ret__, 'record_type'),
        result_output_file=pulumi.get(__ret__, 'result_output_file'),
        sub_domain=pulumi.get(__ret__, 'sub_domain'),
        verify_result=pulumi.get(__ret__, 'verify_result'),
        verify_type=pulumi.get(__ret__, 'verify_type'))


@_utilities.lift_output_func(get_domain_verifier)
def get_domain_verifier_output(auto_verify: Optional[pulumi.Input[Optional[bool]]] = None,
                               domain: Optional[pulumi.Input[str]] = None,
                               failed_reason: Optional[pulumi.Input[Optional[str]]] = None,
                               freeze_record: Optional[pulumi.Input[Optional[bool]]] = None,
                               result_output_file: Optional[pulumi.Input[Optional[str]]] = None,
                               verify_type: Optional[pulumi.Input[Optional[str]]] = None,
                               opts: Optional[pulumi.InvokeOptions] = None) -> pulumi.Output[GetDomainVerifierResult]:
    """
    Use this data source to access information about an existing resource.
    """
    ...