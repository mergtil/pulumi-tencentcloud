# coding=utf-8
# *** WARNING: this file was generated by the Pulumi Terraform Bridge (tfgen) Tool. ***
# *** Do not edit by hand unless you're certain you know what you are doing! ***

import copy
import warnings
import pulumi
import pulumi.runtime
from typing import Any, Mapping, Optional, Sequence, Union, overload
from .. import _utilities

__all__ = ['DeleteImageOperationArgs', 'DeleteImageOperation']

@pulumi.input_type
class DeleteImageOperationArgs:
    def __init__(__self__, *,
                 image_version: pulumi.Input[str],
                 namespace_name: pulumi.Input[str],
                 registry_id: pulumi.Input[str],
                 repository_name: pulumi.Input[str]):
        """
        The set of arguments for constructing a DeleteImageOperation resource.
        :param pulumi.Input[str] image_version: image version name.
        :param pulumi.Input[str] namespace_name: namespace name.
        :param pulumi.Input[str] registry_id: instance id.
        :param pulumi.Input[str] repository_name: repository name.
        """
        pulumi.set(__self__, "image_version", image_version)
        pulumi.set(__self__, "namespace_name", namespace_name)
        pulumi.set(__self__, "registry_id", registry_id)
        pulumi.set(__self__, "repository_name", repository_name)

    @property
    @pulumi.getter(name="imageVersion")
    def image_version(self) -> pulumi.Input[str]:
        """
        image version name.
        """
        return pulumi.get(self, "image_version")

    @image_version.setter
    def image_version(self, value: pulumi.Input[str]):
        pulumi.set(self, "image_version", value)

    @property
    @pulumi.getter(name="namespaceName")
    def namespace_name(self) -> pulumi.Input[str]:
        """
        namespace name.
        """
        return pulumi.get(self, "namespace_name")

    @namespace_name.setter
    def namespace_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "namespace_name", value)

    @property
    @pulumi.getter(name="registryId")
    def registry_id(self) -> pulumi.Input[str]:
        """
        instance id.
        """
        return pulumi.get(self, "registry_id")

    @registry_id.setter
    def registry_id(self, value: pulumi.Input[str]):
        pulumi.set(self, "registry_id", value)

    @property
    @pulumi.getter(name="repositoryName")
    def repository_name(self) -> pulumi.Input[str]:
        """
        repository name.
        """
        return pulumi.get(self, "repository_name")

    @repository_name.setter
    def repository_name(self, value: pulumi.Input[str]):
        pulumi.set(self, "repository_name", value)


@pulumi.input_type
class _DeleteImageOperationState:
    def __init__(__self__, *,
                 image_version: Optional[pulumi.Input[str]] = None,
                 namespace_name: Optional[pulumi.Input[str]] = None,
                 registry_id: Optional[pulumi.Input[str]] = None,
                 repository_name: Optional[pulumi.Input[str]] = None):
        """
        Input properties used for looking up and filtering DeleteImageOperation resources.
        :param pulumi.Input[str] image_version: image version name.
        :param pulumi.Input[str] namespace_name: namespace name.
        :param pulumi.Input[str] registry_id: instance id.
        :param pulumi.Input[str] repository_name: repository name.
        """
        if image_version is not None:
            pulumi.set(__self__, "image_version", image_version)
        if namespace_name is not None:
            pulumi.set(__self__, "namespace_name", namespace_name)
        if registry_id is not None:
            pulumi.set(__self__, "registry_id", registry_id)
        if repository_name is not None:
            pulumi.set(__self__, "repository_name", repository_name)

    @property
    @pulumi.getter(name="imageVersion")
    def image_version(self) -> Optional[pulumi.Input[str]]:
        """
        image version name.
        """
        return pulumi.get(self, "image_version")

    @image_version.setter
    def image_version(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "image_version", value)

    @property
    @pulumi.getter(name="namespaceName")
    def namespace_name(self) -> Optional[pulumi.Input[str]]:
        """
        namespace name.
        """
        return pulumi.get(self, "namespace_name")

    @namespace_name.setter
    def namespace_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "namespace_name", value)

    @property
    @pulumi.getter(name="registryId")
    def registry_id(self) -> Optional[pulumi.Input[str]]:
        """
        instance id.
        """
        return pulumi.get(self, "registry_id")

    @registry_id.setter
    def registry_id(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "registry_id", value)

    @property
    @pulumi.getter(name="repositoryName")
    def repository_name(self) -> Optional[pulumi.Input[str]]:
        """
        repository name.
        """
        return pulumi.get(self, "repository_name")

    @repository_name.setter
    def repository_name(self, value: Optional[pulumi.Input[str]]):
        pulumi.set(self, "repository_name", value)


class DeleteImageOperation(pulumi.CustomResource):
    @overload
    def __init__(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 image_version: Optional[pulumi.Input[str]] = None,
                 namespace_name: Optional[pulumi.Input[str]] = None,
                 registry_id: Optional[pulumi.Input[str]] = None,
                 repository_name: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        """
        Create a DeleteImageOperation resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] image_version: image version name.
        :param pulumi.Input[str] namespace_name: namespace name.
        :param pulumi.Input[str] registry_id: instance id.
        :param pulumi.Input[str] repository_name: repository name.
        """
        ...
    @overload
    def __init__(__self__,
                 resource_name: str,
                 args: DeleteImageOperationArgs,
                 opts: Optional[pulumi.ResourceOptions] = None):
        """
        Create a DeleteImageOperation resource with the given unique name, props, and options.
        :param str resource_name: The name of the resource.
        :param DeleteImageOperationArgs args: The arguments to use to populate this resource's properties.
        :param pulumi.ResourceOptions opts: Options for the resource.
        """
        ...
    def __init__(__self__, resource_name: str, *args, **kwargs):
        resource_args, opts = _utilities.get_resource_args_opts(DeleteImageOperationArgs, pulumi.ResourceOptions, *args, **kwargs)
        if resource_args is not None:
            __self__._internal_init(resource_name, opts, **resource_args.__dict__)
        else:
            __self__._internal_init(resource_name, *args, **kwargs)

    def _internal_init(__self__,
                 resource_name: str,
                 opts: Optional[pulumi.ResourceOptions] = None,
                 image_version: Optional[pulumi.Input[str]] = None,
                 namespace_name: Optional[pulumi.Input[str]] = None,
                 registry_id: Optional[pulumi.Input[str]] = None,
                 repository_name: Optional[pulumi.Input[str]] = None,
                 __props__=None):
        opts = pulumi.ResourceOptions.merge(_utilities.get_resource_opts_defaults(), opts)
        if not isinstance(opts, pulumi.ResourceOptions):
            raise TypeError('Expected resource options to be a ResourceOptions instance')
        if opts.id is None:
            if __props__ is not None:
                raise TypeError('__props__ is only valid when passed in combination with a valid opts.id to get an existing resource')
            __props__ = DeleteImageOperationArgs.__new__(DeleteImageOperationArgs)

            if image_version is None and not opts.urn:
                raise TypeError("Missing required property 'image_version'")
            __props__.__dict__["image_version"] = image_version
            if namespace_name is None and not opts.urn:
                raise TypeError("Missing required property 'namespace_name'")
            __props__.__dict__["namespace_name"] = namespace_name
            if registry_id is None and not opts.urn:
                raise TypeError("Missing required property 'registry_id'")
            __props__.__dict__["registry_id"] = registry_id
            if repository_name is None and not opts.urn:
                raise TypeError("Missing required property 'repository_name'")
            __props__.__dict__["repository_name"] = repository_name
        super(DeleteImageOperation, __self__).__init__(
            'tencentcloud:Tcr/deleteImageOperation:DeleteImageOperation',
            resource_name,
            __props__,
            opts)

    @staticmethod
    def get(resource_name: str,
            id: pulumi.Input[str],
            opts: Optional[pulumi.ResourceOptions] = None,
            image_version: Optional[pulumi.Input[str]] = None,
            namespace_name: Optional[pulumi.Input[str]] = None,
            registry_id: Optional[pulumi.Input[str]] = None,
            repository_name: Optional[pulumi.Input[str]] = None) -> 'DeleteImageOperation':
        """
        Get an existing DeleteImageOperation resource's state with the given name, id, and optional extra
        properties used to qualify the lookup.

        :param str resource_name: The unique name of the resulting resource.
        :param pulumi.Input[str] id: The unique provider ID of the resource to lookup.
        :param pulumi.ResourceOptions opts: Options for the resource.
        :param pulumi.Input[str] image_version: image version name.
        :param pulumi.Input[str] namespace_name: namespace name.
        :param pulumi.Input[str] registry_id: instance id.
        :param pulumi.Input[str] repository_name: repository name.
        """
        opts = pulumi.ResourceOptions.merge(opts, pulumi.ResourceOptions(id=id))

        __props__ = _DeleteImageOperationState.__new__(_DeleteImageOperationState)

        __props__.__dict__["image_version"] = image_version
        __props__.__dict__["namespace_name"] = namespace_name
        __props__.__dict__["registry_id"] = registry_id
        __props__.__dict__["repository_name"] = repository_name
        return DeleteImageOperation(resource_name, opts=opts, __props__=__props__)

    @property
    @pulumi.getter(name="imageVersion")
    def image_version(self) -> pulumi.Output[str]:
        """
        image version name.
        """
        return pulumi.get(self, "image_version")

    @property
    @pulumi.getter(name="namespaceName")
    def namespace_name(self) -> pulumi.Output[str]:
        """
        namespace name.
        """
        return pulumi.get(self, "namespace_name")

    @property
    @pulumi.getter(name="registryId")
    def registry_id(self) -> pulumi.Output[str]:
        """
        instance id.
        """
        return pulumi.get(self, "registry_id")

    @property
    @pulumi.getter(name="repositoryName")
    def repository_name(self) -> pulumi.Output[str]:
        """
        repository name.
        """
        return pulumi.get(self, "repository_name")
