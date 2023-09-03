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
    'TemplateTemplateContent',
]

@pulumi.output_type
class TemplateTemplateContent(dict):
    def __init__(__self__, *,
                 html: Optional[str] = None,
                 text: Optional[str] = None):
        if html is not None:
            pulumi.set(__self__, "html", html)
        if text is not None:
            pulumi.set(__self__, "text", text)

    @property
    @pulumi.getter
    def html(self) -> Optional[str]:
        return pulumi.get(self, "html")

    @property
    @pulumi.getter
    def text(self) -> Optional[str]:
        return pulumi.get(self, "text")

